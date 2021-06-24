﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Proto.Compute
{
    /// <summary> The status of the latest virtual machine scale set rolling upgrade. </summary>
    public partial class RollingUpgradeStatusInfo : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> 
        /// Initializes a new instance of the <see cref="rollingUpgradeStatusInfo"/> class. 
        /// </summary>
        public RollingUpgradeStatusInfo(Azure.ResourceManager.Compute.Models.RollingUpgradeStatusInfo rollingUpgradeStatusInfo) 
            : base(rollingUpgradeStatusInfo.Id, rollingUpgradeStatusInfo.Name, RollingUpgradeOperations.ResourceType)
        {
            Model = rollingUpgradeStatusInfo;
        }

        /// <summary>
        /// Gets or sets the Model this resource is based of. 
        ///</summary>
        public virtual Azure.ResourceManager.Compute.Models.RollingUpgradeStatusInfo Model { get; }

        /// <summary>
        /// Gets the subnet id. 
        ///</summary>
        public override string Name => Model.Name;

        /// <summary> The rolling upgrade policies applied for this upgrade. </summary>
        public RollingUpgradePolicy Policy => Model.Policy;

        /// <summary> Information about the current running state of the overall upgrade. </summary>
        public RollingUpgradeRunningStatus RunningStatus => Model.RunningStatus;

        /// <summary> Information about the number of virtual machine instances in each upgrade state. </summary>
        public RollingUpgradeProgressInfo Progress => Model.Progress;

        /// <summary> Error details for this upgrade, if there are any. </summary>
        public ApiError Error => Model.Error;
    }
}