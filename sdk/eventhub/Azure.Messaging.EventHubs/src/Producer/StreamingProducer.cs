// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using System.Threading.Channels;
using Azure.Core.Diagnostics;
using Azure.Core.Pipeline;

namespace Azure.Messaging.EventHubs.Producer
{
    /// <summary>
    /// The streaming producer is responsible for publishing instances of <see cref="EventData"/> to an
    /// Event Hub. A single <see cref="EventData"/> instance is enqueued by the application, which is
    /// then batched and published efficiently in the background, independent of the enqueue operation.
    /// </summary>
    ///
    /// <remarks>
    /// <para>
    /// The streaming producer batches events from a queue, and does not require the application to batch events
    /// before publishing to the Event Hub. The <see cref="StreamingProducer"/> utilizes timeouts on
    /// partially full batches if <see cref="StreamingProducerOptions.MaximumWaitTime"/> has passed since an
    /// event has been queued.
    /// </para>
    ///
    /// <para>
    /// The <see cref="StreamingProducer"/> is safe to cache and use as a singleton for the lifetime of an
    /// application. This is the recommended approach, since the client is responsible for efficient network,
    /// CPU, and memory use. Calling <see cref="CloseAsync(CancellationToken)"/> or <see cref="DisposeAsync"/>
    /// is required so that resources can be cleaned up after use.
    /// </para>
    /// </remarks>
    public class StreamingProducer : IAsyncDisposable
    {
        private EventHubProducerClient _producer;
        private StreamingProducerOptions _options;

        private bool _isStarted;
        private bool _isClosed;

        private event Func<SendSucceededEventArgs, Task> _sendSucceeded;
        private event Func<SendFailedEventArgs, Task> _sendFailed;

        /// <summary>
        /// A handler for event batches that have been published successfully. Control is passed to this method after events have successfully
        /// been published to the Event Hub, along with an instance of <see cref="SendSucceededEventArgs"/> containing the <see cref="EventData"/>
        /// instances that were published and the Id of which partition it was published to.
        /// </summary>
        public event Func<SendSucceededEventArgs, Task> SendSucceededAsync
        {
            add
            {
                Argument.AssertNotNull(value, nameof(SendSucceededAsync));

                if (_sendSucceeded != default)
                {
                    throw new NotSupportedException(Resources.HandlerHasAlreadyBeenAssigned);
                }
                _sendSucceeded = value;
            }

            remove
            {
                Argument.AssertNotNull(value, nameof(SendSucceededAsync));

                if (_isStarted)
                {
                    throw new ArgumentException("Handlers cannot be changed after the streaming producer has started publishing.");
                }

                if (_sendSucceeded != value)
                {
                    throw new ArgumentException(Resources.HandlerHasNotBeenAssigned);
                }
                _sendSucceeded = default;
            }
        }

        /// <summary>
        /// A handler for event batches that have failed to successfully publish. If a transient failure occured during publishing,
        /// this method will only be called after applying the retry policy. However, control is passed to this method on the event that a batch
        /// has failed to be published to the Event Hub for any reason, transient or permanent, along with an instance of
        /// <see cref="SendFailedEventArgs"/> containing the <see cref="EventData"/> instances that failed to publish as well as the Id of the partition
        /// that it could not be published to, and the exception that caused the failure.
        /// </summary>
        /// <remarks>
        /// Since applications have less deterministic control over failed batches and which events are contained in them, it is recommended that the
        /// application creates a more generous custom <see cref="RetryPolicy"/> to better deal with transient failures, especially when event ordering
        /// is important.
        /// </remarks>
        public event Func<SendFailedEventArgs, Task> SendFailedAsync
        {
            add
            {
                Argument.AssertNotNull(value, nameof(SendFailedAsync));

                if (_sendFailed != default)
                {
                    throw new NotSupportedException(Resources.HandlerHasAlreadyBeenAssigned);
                }
                _sendFailed = value;
            }

            remove
            {
                Argument.AssertNotNull(value, nameof(SendFailedAsync));

                if (_isStarted)
                {
                    throw new ArgumentException("Handlers cannot be changed after the streaming producer has started publishing.");
                }

                if (_sendFailed != value)
                {
                    throw new ArgumentException(Resources.HandlerHasNotBeenAssigned);
                }
                _sendFailed = default;
            }
        }

        /// <summary>
        /// The fully qualified Event Hubs namespace that this producer is currently associated with, which will likely be similar
        /// to <c>{yournamespace}.servicebus.windows.net</c>.
        /// </summary>
        public string FullyQualifiedNamespace => _producer.FullyQualifiedNamespace;

        /// <summary>
        /// The name of the Event Hub that this producer is connected to, specific to the Event Hubs namespace that contains it.
        /// </summary>
        public string EventHubName => _producer.EventHubName;

        /// <summary>
        /// A unique name to identify the streaming producer.
        /// </summary>
        public string Identifier => _producer.Identifier;

        /// <summary>
        /// The total number of events that are currently in the queue waiting to be published, across all partitions.
        /// </summary>
        public virtual int TotalPendingEventCount { get; protected set; }

        /// <summary>
        /// <c>true</c> if the streaming producer has been closed <c>false</c> otherwise.
        /// </summary>
        public bool IsClosed => _isClosed;

        /// <summary>
        /// Returns the number of events present in the queue waiting to be sent for a given partition.
        /// </summary>
        /// <param name="partition">The id of the partition.</param>
        public int GetPartitionQueuedEventCount(string partition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingProducer" /> class.
        /// </summary>
        /// <param name="connectionString">The connection string to use for connecting to the Event Hubs namespace;
        /// it is expected that the Event Hub name and the shared key properties are contained in this connection string.</param>
        /// <param name="eventHubName">The name of the specific Event Hub to associate the producer with.</param>
        /// <param name="clientOptions">A set of <see cref="StreamingProducerOptions"/> to apply when configuring the streaming producer.</param>
        public StreamingProducer(string connectionString, string eventHubName = default, StreamingProducerOptions clientOptions = default) : this(clientOptions)
        {
            _producer = new EventHubProducerClient(connectionString, eventHubName, clientOptions);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingProducer" /> class.
        /// </summary>
        /// <param name="fullyQualifiedNamespace">The fully qualified Event Hubs namespace to connect to.  This is likely to be similar to <c>{yournamespace}.servicebus.windows.net</c>.</param>
        /// <param name="eventHubName">The name of the specific Event Hub to associate the producer with.</param>
        /// <param name="credential">The shared access key credential to use for authorization.  Access controls may be specified by the Event Hubs namespace or the requested Event Hub, depending on Azure configuration.</param>
        /// <param name="clientOptions">A set of <see cref="StreamingProducerOptions"/> to apply when configuring the streaming producer.</param>
        public StreamingProducer(string fullyQualifiedNamespace, string eventHubName, AzureNamedKeyCredential credential, StreamingProducerOptions clientOptions = default) : this(clientOptions)
        {
            _producer = new EventHubProducerClient(fullyQualifiedNamespace, eventHubName, credential, clientOptions);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingProducer" /> class.
        /// </summary>
        /// <param name="fullyQualifiedNamespace">The fully qualified Event Hubs namespace to connect to.  This is likely to be similar to <c>{yournamespace}.servicebus.windows.net</c>.</param>
        /// <param name="eventHubName">The name of the specific Event Hub to associate the producer with.</param>
        /// <param name="credential">The shared access key credential to use for authorization.  Access controls may be specified by the Event Hubs namespace or the requested Event Hub, depending on Azure configuration.</param>
        /// <param name="clientOptions">A set of <see cref="StreamingProducerOptions"/> to apply when configuring the streaming producer.</param>
        public StreamingProducer(string fullyQualifiedNamespace, string eventHubName, AzureSasCredential credential, StreamingProducerOptions clientOptions = default) : this(clientOptions)
        {
            _producer = new EventHubProducerClient(fullyQualifiedNamespace, eventHubName, credential, clientOptions);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingProducer" /> class.
        /// </summary>
        /// <param name="fullyQualifiedNamespace">The fully qualified Event Hubs namespace to connect to.  This is likely to be similar to <c>{yournamespace}.servicebus.windows.net</c>.</param>
        /// <param name="eventHubName">The name of the specific Event Hub to associate the producer with.</param>
        /// <param name="credential">The shared access key credential to use for authorization.  Access controls may be specified by the Event Hubs namespace or the requested Event Hub, depending on Azure configuration.</param>
        /// <param name="clientOptions">A set of <see cref="StreamingProducerOptions"/> to apply when configuring the streaming producer.</param>
        public StreamingProducer(string fullyQualifiedNamespace, string eventHubName, TokenCredential credential, StreamingProducerOptions clientOptions = default) : this(clientOptions)
        {
            _producer = new EventHubProducerClient(fullyQualifiedNamespace, eventHubName, credential, clientOptions);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingProducer" /> class.
        /// </summary>
        /// <param name="connection">The <see cref="EventHubConnection" /> connection to use for communication with the Event Hubs service.</param>
        /// <param name="clientOptions">A set of <see cref="StreamingProducerOptions"/> to apply when configuring the streaming producer.</param>
        public StreamingProducer(EventHubConnection connection, StreamingProducerOptions clientOptions = default): this(clientOptions)
        {
            _producer = new EventHubProducerClient(connection, clientOptions);
        }

        /// <summary>
        /// An internal method to set up options and create data structures.
        /// </summary>
        /// <param name="options"></param>
        private StreamingProducer(StreamingProducerOptions options)
        {
            if (options != null)
            {
                _options = options.Clone();
            }
            else
            {
                _options = new StreamingProducerOptions();
            }
        }

        /// <summary>
        /// Enqueues an <see cref="EventData"/> instance to be published to the Event Hub. This method waits until the queue has
        /// space for the given event, it does not wait until the event is published.
        /// </summary>
        /// <param name="eventData">The event data to be published.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the
        /// operation.</param>
        /// <param name="options">An optional set of options to consider when publishing this event.</param>
        /// <remarks>
        /// <para>
        /// Upon the first call to queue, the send success and failures handlers cannot be changed.
        /// </para>
        ///
        /// <para>
        /// When this call returns, the event will have been added to the queue, but may not have been published yet. Publishing the event
        /// occurs in the background. After attempting to publish, the appropriate handler will be called, either <see cref="SendSucceededAsync"/>
        /// if the events are sent successfully, or <see cref="SendFailedAsync"/> if the events fail to send.
        /// </para>
        /// </remarks>
        public Task EnqueueEventAsync(EventData eventData, SendEventOptions options = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enqueues an <see cref="EventData"/> instance to be published to the Event Hub. This method does not wait until the queue has
        /// space for the given event and instead returns if there is not room. It does not wait until the event is published.
        /// </summary>
        /// <param name="eventData">The event data to be published.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken" /> instance to signal the request to cancel the operation.</param>
        /// <param name="options">An optional set of options to consider when publishing this event.</param>
        /// <remarks>
        /// <para>
        /// Upon the first call to queue, the send success and failures handlers cannot be changed.
        /// </para>
        ///
        /// <para>
        /// When this call returns, the event may have been added to the queue, but may not have been published yet. Publishing the event
        /// occurs in the background. After attempting to publish, the appropriate handler will be called, either <see cref="SendSucceededAsync"/>
        /// if the events are sent successfully, or <see cref="SendFailedAsync"/> if the events fail to send.
        /// </para>
        /// </remarks>
        /// <returns><c>true</c> if queuing the event was successful <c>false</c> if the queue was full and the event could not be enqueued.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "AZC0102:Do not use GetAwaiter().GetResult().", Justification = "<Pending>")]
        public virtual bool TryEnqueueEvent(EventData eventData, SendEventOptions options = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method flushes the queue by attempting to publish all events that are currently in the queue. Each attempt to publish applies the retry policy
        /// when necessary, and on successful or failed publishing, the appropriate <see cref="SendSucceededAsync"/> or <see cref="SendFailedAsync"/> handler
        /// will be called. Upon completion of this method, all events will have been removed from the queues and either published or dealt with according
        /// to the <see cref="SendFailedAsync"/> handler.
        /// </summary>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken" /> instance to signal the request to cancel the operation.</param>
        public virtual Task FlushAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs the tasks needed to clean up all the resources used by the <see cref="StreamingProducer"/>, including ensuring that
        /// the streaming producer itself has been closed.
        /// </summary>
        /// <remarks>
        /// Calling this method will also call <see cref="FlushAsync(CancellationToken)"/>, which will attempt to publish any events that are still pending,
        /// and finish any active sending.
        /// </remarks>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken" /> instance to signal the request to cancel the operation.</param>
        public virtual ValueTask CloseAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method cancels any active publishing and clears all events that are currently waiting to be published in the queue.
        /// </summary>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken" /> instance to signal the request to cancel the operation.</param>
        public virtual Task ClearAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs the tasks needed to clean up all the resources used by the <see cref="StreamingProducer"/>, including ensuring that
        /// the streaming producer itself has been closed.
        /// </summary>
        /// <remarks>
        /// Calling this method will also call <see cref="FlushAsync(CancellationToken)"/>, which will attempt to publish any events that are still pending,
        /// and finish any active sending.
        /// </remarks>
        public ValueTask DisposeAsync()
        {
            // TODO: only filled to satisfy the analyzers
            GC.SuppressFinalize(this);
            return _producer.DisposeAsync();
        }

        /// <summary>
        /// This method is called upon the successful publishing of a batch of events. It calls the <see cref="SendSucceededAsync"/> event handler.
        /// </summary>
        /// <param name="events">An <see cref="IEnumerable{EventData}"/> instance holding all of the <see cref="EventData"/> instances within the
        /// batch that was successfully published.</param>
        /// <param name="partitionId">The partition that the batch of events was published to.</param>
        protected virtual Task OnSendSucceededAsync(IEnumerable<EventData> events, string partitionId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is called upon the failed publishing of a batch of events, after applying the retry policy if there was a transient failure.
        /// It calls the <see cref="SendFailedAsync"/> event handler.
        /// </summary>
        /// <param name="events">An <see cref="IEnumerable{EventData}"/> instance holding all of the <see cref="EventData"/> instances within the
        /// batch that was successfully published.</param>
        /// <param name="ex">The <see cref="Exception"/> that was raised when the events failed to publish.</param>
        /// <param name="partitionId">The partition that the batch of events was published to.</param>
        protected virtual Task OnSendFailedAsync(IEnumerable<EventData> events, Exception ex, string partitionId = default)
        {
            throw new NotImplementedException();
        }
    }
}
