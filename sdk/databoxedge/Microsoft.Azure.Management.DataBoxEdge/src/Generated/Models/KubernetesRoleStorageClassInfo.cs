// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Kubernetes storage class info.
    /// </summary>
    public partial class KubernetesRoleStorageClassInfo
    {
        /// <summary>
        /// Initializes a new instance of the KubernetesRoleStorageClassInfo
        /// class.
        /// </summary>
        public KubernetesRoleStorageClassInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KubernetesRoleStorageClassInfo
        /// class.
        /// </summary>
        /// <param name="name">Storage class name.</param>
        /// <param name="type">Storage class type.</param>
        /// <param name="posixCompliant">If provisioned storage is posix
        /// compliant. Possible values include: 'Invalid', 'Enabled',
        /// 'Disabled'</param>
        public KubernetesRoleStorageClassInfo(string name = default(string), string type = default(string), string posixCompliant = default(string))
        {
            Name = name;
            Type = type;
            PosixCompliant = posixCompliant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets storage class name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets storage class type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets if provisioned storage is posix compliant. Possible values
        /// include: 'Invalid', 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "posixCompliant")]
        public string PosixCompliant { get; private set; }

    }
}
