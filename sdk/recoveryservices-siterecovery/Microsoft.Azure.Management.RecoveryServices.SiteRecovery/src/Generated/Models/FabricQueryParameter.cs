// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Query parameter to get fabric.
    /// </summary>
    public partial class FabricQueryParameter
    {
        /// <summary>
        /// Initializes a new instance of the FabricQueryParameter class.
        /// </summary>
        public FabricQueryParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FabricQueryParameter class.
        /// </summary>
        /// <param name="zoneToZoneMappings">A value indicating whether the
        /// zone to zone mappings are to be returned.</param>
        /// <param name="fetchAgentDetails">A value indicating whether the
        /// agent details are to be fetched.</param>
        /// <param name="biosId">The BIOS Id to be used for fetching agent
        /// details.</param>
        /// <param name="fqdn">The FQDN to be used for fetching agent
        /// details.</param>
        /// <param name="discoveryType">The type of the discovered machine to
        /// be used for fetching agent details.</param>
        /// <param name="osType">The OS type to be used for fetching agent
        /// details.</param>
        public FabricQueryParameter(string zoneToZoneMappings = default(string), string fetchAgentDetails = default(string), string biosId = default(string), string fqdn = default(string), string discoveryType = default(string), string osType = default(string))
        {
            ZoneToZoneMappings = zoneToZoneMappings;
            FetchAgentDetails = fetchAgentDetails;
            BiosId = biosId;
            Fqdn = fqdn;
            DiscoveryType = discoveryType;
            OsType = osType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether the zone to zone mappings
        /// are to be returned.
        /// </summary>
        [JsonProperty(PropertyName = "zoneToZoneMappings")]
        public string ZoneToZoneMappings { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the agent details are to be
        /// fetched.
        /// </summary>
        [JsonProperty(PropertyName = "fetchAgentDetails")]
        public string FetchAgentDetails { get; set; }

        /// <summary>
        /// Gets or sets the BIOS Id to be used for fetching agent details.
        /// </summary>
        [JsonProperty(PropertyName = "biosId")]
        public string BiosId { get; set; }

        /// <summary>
        /// Gets or sets the FQDN to be used for fetching agent details.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or sets the type of the discovered machine to be used for
        /// fetching agent details.
        /// </summary>
        [JsonProperty(PropertyName = "discoveryType")]
        public string DiscoveryType { get; set; }

        /// <summary>
        /// Gets or sets the OS type to be used for fetching agent details.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

    }
}