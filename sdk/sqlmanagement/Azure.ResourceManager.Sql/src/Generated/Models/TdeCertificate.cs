// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A TDE certificate that can be uploaded into a server. </summary>
    public partial class TdeCertificate : Resource
    {
        /// <summary> Initializes a new instance of TdeCertificate. </summary>
        public TdeCertificate()
        {
        }

        /// <summary> Initializes a new instance of TdeCertificate. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="privateBlob"> The base64 encoded certificate private blob. </param>
        /// <param name="certPassword"> The certificate password. </param>
        internal TdeCertificate(ResourceIdentifier id, string name, ResourceType type, string privateBlob, string certPassword) : base(id, name, type)
        {
            PrivateBlob = privateBlob;
            CertPassword = certPassword;
        }

        /// <summary> The base64 encoded certificate private blob. </summary>
        public string PrivateBlob { get; set; }
        /// <summary> The certificate password. </summary>
        public string CertPassword { get; set; }
    }
}
