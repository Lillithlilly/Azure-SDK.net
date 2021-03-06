// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specifies the criteria for converting log to metric. </summary>
    public partial class MonitorCriteria
    {
        /// <summary> Initializes a new instance of MonitorCriteria. </summary>
        /// <param name="metricName"> Name of the metric. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricName"/> is null. </exception>
        public MonitorCriteria(string metricName)
        {
            if (metricName == null)
            {
                throw new ArgumentNullException(nameof(metricName));
            }

            MetricName = metricName;
            Dimensions = new ChangeTrackingList<MonitorDimension>();
        }

        /// <summary> Initializes a new instance of MonitorCriteria. </summary>
        /// <param name="metricName"> Name of the metric. </param>
        /// <param name="dimensions"> List of Dimensions for creating metric. </param>
        internal MonitorCriteria(string metricName, IList<MonitorDimension> dimensions)
        {
            MetricName = metricName;
            Dimensions = dimensions;
        }

        /// <summary> Name of the metric. </summary>
        public string MetricName { get; set; }
        /// <summary> List of Dimensions for creating metric. </summary>
        public IList<MonitorDimension> Dimensions { get; }
    }
}
