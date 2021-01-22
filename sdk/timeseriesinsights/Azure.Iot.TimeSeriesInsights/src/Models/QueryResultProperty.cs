// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary>
    /// Q
    /// </summary>
    public class QueryResultProperty
    {
        /// <summary>
        /// EP
        /// </summary>
        public EventProperty EventProperty { get; set; }

        /// <summary>
        /// PV
        /// </summary>
        public object PropertyValue { get; set; }
    }
}
