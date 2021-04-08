// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary>
    /// Optional parameters to use when getting Time Series Insights event schema.
    /// </summary>
    public abstract class EventSchemaRequestOptions
    {
        /// <summary>
        /// For the environments with warm store enabled, the query can be executed either on the 'WarmStore' or 'ColdStore'.
        /// This parameter in the query defines which store the query should be executed on. If not defined, the query
        /// will be executed on the cold store.
        /// </summary>
        public StoreType StoreType { get; set; }
    }
}
