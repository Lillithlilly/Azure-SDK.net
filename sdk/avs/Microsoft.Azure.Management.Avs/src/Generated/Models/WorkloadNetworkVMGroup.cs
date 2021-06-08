// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NSX VM Group
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkloadNetworkVMGroup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkloadNetworkVMGroup class.
        /// </summary>
        public WorkloadNetworkVMGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkloadNetworkVMGroup class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">Display name of the VM group.</param>
        /// <param name="members">Virtual machine members of this
        /// group.</param>
        /// <param name="status">VM Group status. Possible values include:
        /// 'SUCCESS, FAILURE'</param>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Succeeded', 'Failed', 'Building', 'Deleting',
        /// 'Updating'</param>
        /// <param name="revision">NSX revision number.</param>
        public WorkloadNetworkVMGroup(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), IList<string> members = default(IList<string>), string status = default(string), string provisioningState = default(string), long? revision = default(long?))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Members = members;
            Status = status;
            ProvisioningState = provisioningState;
            Revision = revision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of the VM group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets virtual machine members of this group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.members")]
        public IList<string> Members { get; set; }

        /// <summary>
        /// Gets VM Group status. Possible values include: 'SUCCESS, FAILURE'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the provisioning state. Possible values include: 'Succeeded',
        /// 'Failed', 'Building', 'Deleting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets NSX revision number.
        /// </summary>
        [JsonProperty(PropertyName = "properties.revision")]
        public long? Revision { get; set; }

    }
}