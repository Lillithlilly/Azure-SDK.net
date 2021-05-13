// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// OperationExtendedInfo
    /// </summary>
    /// <remarks>
    /// Operation Extended Info
    /// </remarks>
    public partial class OperationExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the OperationExtendedInfo class.
        /// </summary>
        public OperationExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationExtendedInfo class.
        /// </summary>
        /// <param name="objectType">This property will be used as the
        /// discriminator for deciding the specific types in the polymorphic
        /// chain of types.</param>
        public OperationExtendedInfo(string objectType = default(string))
        {
            ObjectType = objectType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this property will be used as the discriminator for
        /// deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

    }
}