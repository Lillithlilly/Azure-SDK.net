// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A rule governing the accessibility of a vault from a specific virtual
    /// network.
    /// </summary>
    public partial class VirtualNetworkRule
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkRule class.
        /// </summary>
        public VirtualNetworkRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkRule class.
        /// </summary>
        /// <param name="id">Full resource id of a vnet subnet, such as
        /// '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'.</param>
        /// <param name="ignoreMissingVnetServiceEndpoint">Property to specify
        /// whether NRP will ignore the check if parent subnet has
        /// serviceEndpoints configured.</param>
        public VirtualNetworkRule(string id, bool? ignoreMissingVnetServiceEndpoint = default(bool?))
        {
            Id = id;
            IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets full resource id of a vnet subnet, such as
        /// '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether NRP will ignore the check
        /// if parent subnet has serviceEndpoints configured.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreMissingVnetServiceEndpoint")]
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
