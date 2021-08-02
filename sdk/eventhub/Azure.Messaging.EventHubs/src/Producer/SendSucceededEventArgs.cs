// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Messaging.EventHubs;

namespace Azure.Messaging.EventHubs.Producer
{
    /// <summary>
    /// This class allows the producer to pass contextual information to the application
    /// when a set of events is published to the Event Hub.
    /// </summary>
    public class SendSucceededEventArgs : EventArgs
    {
        /// <summary>
        /// The set of events in the batch that was published.
        /// </summary>
        public IEnumerable<EventData> Events { get; set; }

        /// <summary>
        /// The identifier of the partition that the batch was published to.
        /// </summary>
        public string PartitionId { get; set; }
    }
}
