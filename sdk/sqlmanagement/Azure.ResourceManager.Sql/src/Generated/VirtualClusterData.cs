// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the VirtualCluster data model. </summary>
    public partial class VirtualClusterData : TrackedResource
    {
        /// <summary> Initializes a new instance of VirtualClusterData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualClusterData(AzureLocation location) : base(location)
        {
            ChildResources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="subnetId"> Subnet resource ID for the virtual cluster. </param>
        /// <param name="family"> If the service has different generations of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="childResources"> List of resources in this virtual cluster. </param>
        /// <param name="maintenanceConfigurationId"> Specifies maintenance configuration id to apply to this virtual cluster. </param>
        internal VirtualClusterData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, string subnetId, string family, IReadOnlyList<string> childResources, string maintenanceConfigurationId) : base(id, name, type, tags, location)
        {
            SubnetId = subnetId;
            Family = family;
            ChildResources = childResources;
            MaintenanceConfigurationId = maintenanceConfigurationId;
        }

        /// <summary> Subnet resource ID for the virtual cluster. </summary>
        public string SubnetId { get; }
        /// <summary> If the service has different generations of hardware, for the same SKU, then that can be captured here. </summary>
        public string Family { get; set; }
        /// <summary> List of resources in this virtual cluster. </summary>
        public IReadOnlyList<string> ChildResources { get; }
        /// <summary> Specifies maintenance configuration id to apply to this virtual cluster. </summary>
        public string MaintenanceConfigurationId { get; set; }
    }
}
