// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary>
    /// QueryResultItem
    /// </summary>
    public class QueryResultItem
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="properties"></param>
        public QueryResultItem(string timestamp, IList<QueryResultProperty> properties)
        {
            Timestamp = timestamp;
            Properties = properties;
        }

        /// <summary>
        /// Timestamp
        /// </summary>
        public string Timestamp { get; }

        /// <summary>
        /// Properties
        /// </summary>
        public IList<QueryResultProperty> Properties { get; }
    }
}
