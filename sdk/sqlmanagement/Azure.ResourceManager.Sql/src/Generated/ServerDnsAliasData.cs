// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ServerDnsAlias data model. </summary>
    public partial class ServerDnsAliasData : Resource
    {
        /// <summary> Initializes a new instance of ServerDnsAliasData. </summary>
        public ServerDnsAliasData()
        {
        }

        /// <summary> Initializes a new instance of ServerDnsAliasData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="azureDnsRecord"> The fully qualified DNS record for alias. </param>
        internal ServerDnsAliasData(ResourceIdentifier id, string name, ResourceType type, string azureDnsRecord) : base(id, name, type)
        {
            AzureDnsRecord = azureDnsRecord;
        }

        /// <summary> The fully qualified DNS record for alias. </summary>
        public string AzureDnsRecord { get; }
    }
}
