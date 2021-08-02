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
        /// The default limit is 2500 queued events.
        /// </value>
        public int MaximumQueuedEventCount { get; set; }

        /// <summary>
        /// Indicates whether events should be published using idempotent semantics.  This allows Event Hubs to
        /// detect publishing attempts during retries that would result in duplication and is likely to reduce the occurrence of duplicate events.
        ///
        /// Idempotent retries do have a minor impact on throughput and restrict the number of concurrent publishing operations that
        /// can be performed for each partition.
        ///
        /// Idempotent retries may not be enabled when the value of <see cref="MaximumConcurrentSendsPerPartition"/> is larger than 1.
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
            MaximumQueuedEventCount = 200;
            EnableIdempotentRetries = false;
            MaximumConcurrentSendsPerPartition = 1;
        }

        internal new StreamingProducerOptions Clone()
        {
            var baseOptions = base.Clone();
            var copiedOptions = new StreamingProducerOptions
            {
                MaximumWaitTime = MaximumWaitTime,
                MaximumQueuedEventCount = MaximumQueuedEventCount,
                EnableIdempotentRetries = EnableIdempotentRetries,
                MaximumConcurrentSendsPerPartition = MaximumConcurrentSendsPerPartition,
                EnableIdempotentPartitions = EnableIdempotentPartitions,
            };

            foreach (var pair in PartitionOptions)
            {
                copiedOptions.PartitionOptions.Add(pair.Key, pair.Value.Clone());
            }

            return copiedOptions;
        }
    }
}
