// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The CloudServiceVaultAndSecretReference. </summary>
    public partial class CloudServiceVaultAndSecretReference
    {
        /// <summary> Initializes a new instance of CloudServiceVaultAndSecretReference. </summary>
        public CloudServiceVaultAndSecretReference()
        {
        }

        /// <summary> Initializes a new instance of CloudServiceVaultAndSecretReference. </summary>
        /// <param name="sourceVault"></param>
        /// <param name="secretUri"></param>
        internal CloudServiceVaultAndSecretReference(WritableSubResource sourceVault, Uri secretUri)
        {
            SourceVault = sourceVault;
            SecretUri = secretUri;
        }

        /// <summary> Gets or sets the source vault. </summary>
        internal WritableSubResource SourceVault { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SourceVaultId
        {
            get => SourceVault is null ? default : SourceVault.Id;
            set
            {
                if (SourceVault is null)
                    SourceVault = new WritableSubResource();
                SourceVault.Id = value;
            }
        }

        /// <summary> Gets or sets the secret uri. </summary>
        public Uri SecretUri { get; set; }
    }
}
