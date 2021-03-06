// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A path element of a management group ancestors.
    /// </summary>
    public partial class ManagementGroupPathElement
    {
        /// <summary>
        /// Initializes a new instance of the ManagementGroupPathElement class.
        /// </summary>
        public ManagementGroupPathElement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementGroupPathElement class.
        /// </summary>
        /// <param name="name">The name of the group.</param>
        /// <param name="displayName">The friendly name of the group.</param>
        public ManagementGroupPathElement(string name = default(string), string displayName = default(string))
        {
            Name = name;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the group.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
