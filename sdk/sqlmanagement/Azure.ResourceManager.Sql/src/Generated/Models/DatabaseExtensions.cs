// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An export managed database operation result resource. </summary>
    public partial class DatabaseExtensions : Resource
    {
        /// <summary> Initializes a new instance of DatabaseExtensions. </summary>
        public DatabaseExtensions()
        {
        }

        /// <summary> Initializes a new instance of DatabaseExtensions. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="operationMode"> Operation Mode. </param>
        /// <param name="storageKeyType"> Storage key type. </param>
        /// <param name="storageKey"> Storage key. </param>
        /// <param name="storageUri"> Storage Uri. </param>
        internal DatabaseExtensions(ResourceIdentifier id, string name, ResourceType type, OperationMode? operationMode, StorageKeyType? storageKeyType, string storageKey, string storageUri) : base(id, name, type)
        {
            OperationMode = operationMode;
            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
        }

        /// <summary> Operation Mode. </summary>
        public OperationMode? OperationMode { get; set; }
        /// <summary> Storage key type. </summary>
        public StorageKeyType? StorageKeyType { get; set; }
        /// <summary> Storage key. </summary>
        public string StorageKey { get; set; }
        /// <summary> Storage Uri. </summary>
        public string StorageUri { get; set; }
    }
}
