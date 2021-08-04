// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Messaging.EventHubs.Producer
{
    /// <summary>
    /// This class allows the application to customize the creation of the streaming producer.
    /// It extends <see cref="EventHubProducerClientOptions"/>.
    /// </summary>
    public class StreamingProducerOptions : EventHubProducerClientOptions
    {
        private int _maxConcurrentSends;

        /// <summary>
        ///  The amount of time to wait for new events to be queued before sending a partially
        /// full batch.
        /// </summary>
        ///
        ///<value>
        /// The default wait time is 250 milliseconds.
        ///</value>
        public TimeSpan? MaximumWaitTime { get; set; }

        /// <summary>
        /// The total number of events that can be queued across all partitions.
        /// </summary>
        ///
        /// <value>
        /// The default limit is 2500 queued events. Once this limit is reached more events can be added to the queue but
        /// the producer must wait until there is room, which is made by batches being published in the background.
        /// </value>
        public int MaximumQueuedEventLimit { get; set; }

        /// <summary>
        /// Indicates whether events should be published using idempotent semantics. This means that we will attempt to avoid duplication when
        /// sending events. Duplicates are still possible but the chance of them occuring is much lower when idempotent retries are enabled.
        /// Idempotent retries do have a minor impact on throughput and restrict the number of concurrent publishing operations that
        /// can be performed for each partition, meaning that Idempotent retries may not be enabled when the value of
        /// <see cref="MaximumConcurrentSendsPerPartition"/> is larger than 1.
        ///</summary>
        /// <value>
        /// By default, idempotent retries are disabled.
        ///</value>
        /// <remarks>
        /// It is important to note that enabling idempotent retries does not impact guarantee exactly-once semantics.  The existing
        /// Event Hubs at-least-once delivery contract still applies and event duplication is possible.
        /// </remarks>
        public Boolean EnableIdempotentRetries { get; set; }

        /// <summary>
        /// The number of batches that may be sent concurrently to each partition. This value cannot be larger than 1 if <see cref="EnableIdempotentRetries"/>
        /// are enabled.
        /// </summary>
        /// <value>
        /// By default, each partition will have only one publishing operation active.
        ///</value>
        /// <remarks>
        ///  When batches are published concurrently, the ordering of events is not guaranteed.  If the order events are published
        ///  must be maintained, <see cref="MaximumConcurrentSendsPerPartition" /> should not exceed 1.
        /// </remarks>
        public int MaximumConcurrentSendsPerPartition
        {
            get => _maxConcurrentSends;
            set
            {
                if (value < 1 || value > 100 || (EnableIdempotentRetries && value > 1))
                {
                    throw new Exception("MaximumConcurrentSendsPerPartition must be between 1 and 100, and cannot be larger than 1 if Idempotent Retries are enabled");
                }
                _maxConcurrentSends = value;
            }
        }

        /// <summary>
        /// This method creates a new <see cref="StreamingProducerOptions"/> with the default values.
        /// </summary>
        /// <returns>A new <see cref="StreamingProducerOptions"/> instance holding default values</returns>
        public StreamingProducerOptions()
        {
            MaximumWaitTime = TimeSpan.FromMilliseconds(250);
            MaximumQueuedEventLimit = 2500;
            EnableIdempotentRetries = false;
            MaximumConcurrentSendsPerPartition = 1;
        }

        internal new StreamingProducerOptions Clone()
        {
            throw new NotImplementedException();
        }
    }
}
