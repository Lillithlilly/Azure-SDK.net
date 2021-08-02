// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventHubs.Producer
{
    /// <summary>
    /// This class allows the producer to pass contextual information to the application
    /// when a set of events fails to publish to the Event Hub.
    /// </summary>
    public class SendFailedEventArgs : EventArgs
    {
        /// <summary>
        /// The set of events that were in the batch that failed to publish.
        /// </summary>
        public IEnumerable<EventData> Events { get; set; }

        /// <summary>
        /// The exception that occurred when trying to publish the batch.
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// The identifier of the partition to which the batch was being published.
        /// </summary>
        public string PartitionId { get; set; }
    }
}
