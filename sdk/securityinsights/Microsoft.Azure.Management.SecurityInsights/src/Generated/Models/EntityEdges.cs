// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The edge that connects the entity to the other entity.
    /// </summary>
    public partial class EntityEdges
    {
        /// <summary>
        /// Initializes a new instance of the EntityEdges class.
        /// </summary>
        public EntityEdges()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityEdges class.
        /// </summary>
        /// <param name="targetEntityId">The target entity Id.</param>
        /// <param name="additionalData">A bag of custom fields that should be
        /// part of the entity and will be presented to the user.</param>
        public EntityEdges(string targetEntityId = default(string), IDictionary<string, object> additionalData = default(IDictionary<string, object>))
        {
            TargetEntityId = targetEntityId;
            AdditionalData = additionalData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target entity Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetEntityId")]
        public string TargetEntityId { get; set; }

        /// <summary>
        /// Gets or sets a bag of custom fields that should be part of the
        /// entity and will be presented to the user.
        /// </summary>
        [JsonProperty(PropertyName = "additionalData")]
        public IDictionary<string, object> AdditionalData { get; set; }

    }
}
