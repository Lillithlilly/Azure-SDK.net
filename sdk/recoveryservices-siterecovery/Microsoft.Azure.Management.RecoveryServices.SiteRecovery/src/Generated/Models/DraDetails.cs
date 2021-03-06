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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DRA details.
    /// </summary>
    public partial class DraDetails
    {
        /// <summary>
        /// Initializes a new instance of the DraDetails class.
        /// </summary>
        public DraDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DraDetails class.
        /// </summary>
        /// <param name="id">The DRA Id.</param>
        /// <param name="name">The DRA name.</param>
        /// <param name="biosId">The DRA Bios Id.</param>
        /// <param name="version">The version.</param>
        /// <param name="lastHeartbeatUtc">The last heartbeat received from the
        /// DRA.</param>
        /// <param name="health">The health. Possible values include: 'None',
        /// 'Normal', 'Warning', 'Critical'</param>
        /// <param name="healthErrors">The health errors.</param>
        /// <param name="forwardProtectedItemCount">The count of protected
        /// items which are protected in forward direction.</param>
        /// <param name="reverseProtectedItemCount">The count of protected
        /// items which are protected in reverse direction.</param>
        public DraDetails(string id = default(string), string name = default(string), string biosId = default(string), string version = default(string), System.DateTime? lastHeartbeatUtc = default(System.DateTime?), string health = default(string), IList<HealthError> healthErrors = default(IList<HealthError>), int? forwardProtectedItemCount = default(int?), int? reverseProtectedItemCount = default(int?))
        {
            Id = id;
            Name = name;
            BiosId = biosId;
            Version = version;
            LastHeartbeatUtc = lastHeartbeatUtc;
            Health = health;
            HealthErrors = healthErrors;
            ForwardProtectedItemCount = forwardProtectedItemCount;
            ReverseProtectedItemCount = reverseProtectedItemCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the DRA Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the DRA name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the DRA Bios Id.
        /// </summary>
        [JsonProperty(PropertyName = "biosId")]
        public string BiosId { get; private set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the last heartbeat received from the DRA.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeatUtc")]
        public System.DateTime? LastHeartbeatUtc { get; private set; }

        /// <summary>
        /// Gets the health. Possible values include: 'None', 'Normal',
        /// 'Warning', 'Critical'
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public string Health { get; private set; }

        /// <summary>
        /// Gets the health errors.
        /// </summary>
        [JsonProperty(PropertyName = "healthErrors")]
        public IList<HealthError> HealthErrors { get; private set; }

        /// <summary>
        /// Gets the count of protected items which are protected in forward
        /// direction.
        /// </summary>
        [JsonProperty(PropertyName = "forwardProtectedItemCount")]
        public int? ForwardProtectedItemCount { get; private set; }

        /// <summary>
        /// Gets the count of protected items which are protected in reverse
        /// direction.
        /// </summary>
        [JsonProperty(PropertyName = "reverseProtectedItemCount")]
        public int? ReverseProtectedItemCount { get; private set; }

    }
}
