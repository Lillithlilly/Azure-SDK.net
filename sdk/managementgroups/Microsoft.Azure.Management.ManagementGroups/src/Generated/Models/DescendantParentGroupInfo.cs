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
    /// The ID of the parent management group.
    /// </summary>
    public partial class DescendantParentGroupInfo
    {
        /// <summary>
        /// Initializes a new instance of the DescendantParentGroupInfo class.
        /// </summary>
        public DescendantParentGroupInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DescendantParentGroupInfo class.
        /// </summary>
        /// <param name="id">The fully qualified ID for the parent management
        /// group.  For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000</param>
        public DescendantParentGroupInfo(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified ID for the parent management
        /// group.  For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
