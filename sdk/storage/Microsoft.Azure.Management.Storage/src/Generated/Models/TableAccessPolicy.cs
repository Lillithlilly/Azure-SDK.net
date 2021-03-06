// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Table Access Policy Properties Object.
    /// </summary>
    public partial class TableAccessPolicy
    {
        /// <summary>
        /// Initializes a new instance of the TableAccessPolicy class.
        /// </summary>
        public TableAccessPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TableAccessPolicy class.
        /// </summary>
        /// <param name="permission">Required. List of abbreviated permissions.
        /// Supported permission values include 'r','a','u','d'</param>
        /// <param name="startTime">Start time of the access policy</param>
        /// <param name="expiryTime">Expiry time of the access policy</param>
        public TableAccessPolicy(string permission, System.DateTime? startTime = default(System.DateTime?), System.DateTime? expiryTime = default(System.DateTime?))
        {
            StartTime = startTime;
            ExpiryTime = expiryTime;
            Permission = permission;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start time of the access policy
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets expiry time of the access policy
        /// </summary>
        [JsonProperty(PropertyName = "expiryTime")]
        public System.DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets required. List of abbreviated permissions. Supported
        /// permission values include 'r','a','u','d'
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Permission == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Permission");
            }
        }
    }
}
