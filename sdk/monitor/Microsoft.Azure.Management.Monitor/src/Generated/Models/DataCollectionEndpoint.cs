// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of data collection endpoint.
    /// </summary>
    public partial class DataCollectionEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the DataCollectionEndpoint class.
        /// </summary>
        public DataCollectionEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataCollectionEndpoint class.
        /// </summary>
        /// <param name="description">Description of the data collection
        /// endpoint.</param>
        /// <param name="immutableId">The immutable ID of this data collection
        /// endpoint resource. This property is READ-ONLY.</param>
        /// <param name="configurationAccess">The endpoint used by agents to
        /// access their configuration.</param>
        /// <param name="logsIngestion">The endpoint used by clients to ingest
        /// logs.</param>
        /// <param name="networkAcls">Network access control rules for the
        /// endpoints.</param>
        /// <param name="provisioningState">The resource provisioning state.
        /// This property is READ-ONLY. Possible values include: 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed'</param>
        public DataCollectionEndpoint(string description = default(string), string immutableId = default(string), DataCollectionEndpointConfigurationAccess configurationAccess = default(DataCollectionEndpointConfigurationAccess), DataCollectionEndpointLogsIngestion logsIngestion = default(DataCollectionEndpointLogsIngestion), DataCollectionEndpointNetworkAcls networkAcls = default(DataCollectionEndpointNetworkAcls), string provisioningState = default(string))
        {
            Description = description;
            ImmutableId = immutableId;
            ConfigurationAccess = configurationAccess;
            LogsIngestion = logsIngestion;
            NetworkAcls = networkAcls;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the data collection endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the immutable ID of this data collection endpoint
        /// resource. This property is READ-ONLY.
        /// </summary>
        [JsonProperty(PropertyName = "immutableId")]
        public string ImmutableId { get; set; }

        /// <summary>
        /// Gets or sets the endpoint used by agents to access their
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "configurationAccess")]
        public DataCollectionEndpointConfigurationAccess ConfigurationAccess { get; set; }

        /// <summary>
        /// Gets or sets the endpoint used by clients to ingest logs.
        /// </summary>
        [JsonProperty(PropertyName = "logsIngestion")]
        public DataCollectionEndpointLogsIngestion LogsIngestion { get; set; }

        /// <summary>
        /// Gets or sets network access control rules for the endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "networkAcls")]
        public DataCollectionEndpointNetworkAcls NetworkAcls { get; set; }

        /// <summary>
        /// Gets the resource provisioning state. This property is READ-ONLY.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}