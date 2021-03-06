// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties specific to client affine subscriptions.
    /// </summary>
    public partial class SBClientAffineProperties
    {
        /// <summary>
        /// Initializes a new instance of the SBClientAffineProperties class.
        /// </summary>
        public SBClientAffineProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SBClientAffineProperties class.
        /// </summary>
        /// <param name="clientId">Indicates the Client ID of the application
        /// that created the client-affine subscription.</param>
        /// <param name="isDurable">For client-affine subscriptions, this value
        /// indicates whether the subscription is durable or not.</param>
        /// <param name="isShared">For client-affine subscriptions, this value
        /// indicates whether the subscription is shared or not.</param>
        public SBClientAffineProperties(string clientId = default(string), bool? isDurable = default(bool?), bool? isShared = default(bool?))
        {
            ClientId = clientId;
            IsDurable = isDurable;
            IsShared = isShared;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the Client ID of the application that
        /// created the client-affine subscription.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets for client-affine subscriptions, this value indicates
        /// whether the subscription is durable or not.
        /// </summary>
        [JsonProperty(PropertyName = "isDurable")]
        public bool? IsDurable { get; set; }

        /// <summary>
        /// Gets or sets for client-affine subscriptions, this value indicates
        /// whether the subscription is shared or not.
        /// </summary>
        [JsonProperty(PropertyName = "isShared")]
        public bool? IsShared { get; set; }

    }
}
