// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// Definition of which Windows Event Log events will be collected and how they will be collected.
    /// Only collected from Windows machines.
    /// </summary>
    internal partial class WindowsEventLogDataSource
    {
        /// <summary> Initializes a new instance of WindowsEventLogDataSource. </summary>
        internal WindowsEventLogDataSource()
        {
            Streams = new ChangeTrackingList<KnownWindowsEventLogDataSourceStreams>();
            XPathQueries = new ChangeTrackingList<string>();
        }

        /// <summary>
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </summary>
        public IReadOnlyList<KnownWindowsEventLogDataSourceStreams> Streams { get; }
        /// <summary> A list of Windows Event Log queries in XPATH format. </summary>
        public IReadOnlyList<string> XPathQueries { get; }
        /// <summary>
        /// A friendly name for the data source. 
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; }
    }
}
