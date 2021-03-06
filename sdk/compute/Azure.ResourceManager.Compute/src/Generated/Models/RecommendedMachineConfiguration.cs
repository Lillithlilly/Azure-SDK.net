// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </summary>
    public partial class RecommendedMachineConfiguration
    {
        /// <summary> Initializes a new instance of RecommendedMachineConfiguration. </summary>
        public RecommendedMachineConfiguration()
        {
        }

        /// <summary> Initializes a new instance of RecommendedMachineConfiguration. </summary>
        /// <param name="vcpUs"> Describes the resource range. </param>
        /// <param name="memory"> Describes the resource range. </param>
        internal RecommendedMachineConfiguration(ResourceRange vcpUs, ResourceRange memory)
        {
            VCPUs = vcpUs;
            Memory = memory;
        }

        /// <summary> Describes the resource range. </summary>
        public ResourceRange VCPUs { get; set; }
        /// <summary> Describes the resource range. </summary>
        public ResourceRange Memory { get; set; }
    }
}
