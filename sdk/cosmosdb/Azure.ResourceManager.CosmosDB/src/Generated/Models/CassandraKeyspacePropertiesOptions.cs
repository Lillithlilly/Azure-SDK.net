// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CassandraKeyspacePropertiesOptions. </summary>
    public partial class CassandraKeyspacePropertiesOptions : OptionsResource
    {
        /// <summary> Initializes a new instance of CassandraKeyspacePropertiesOptions. </summary>
        public CassandraKeyspacePropertiesOptions()
        {
        }

        /// <summary> Initializes a new instance of CassandraKeyspacePropertiesOptions. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        internal CassandraKeyspacePropertiesOptions(int? throughput, AutoscaleSettings autoscaleSettings) : base(throughput, autoscaleSettings)
        {
        }
    }
}
