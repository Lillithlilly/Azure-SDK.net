// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> Deployment filter. </summary>
    internal partial class DeploymentFilter
    {
        /// <summary> Initializes a new instance of DeploymentFilter. </summary>
        internal DeploymentFilter()
        {
        }

        /// <summary> Update provider. </summary>
        public string Provider { get; }
        /// <summary> Update name. </summary>
        public string Name { get; }
        /// <summary> Update version. </summary>
        public string Version { get; }
    }
}