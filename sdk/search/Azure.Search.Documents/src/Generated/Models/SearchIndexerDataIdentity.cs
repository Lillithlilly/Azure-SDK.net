// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Abstract base type for data identities. </summary>
    public partial class SearchIndexerDataIdentity
    {
        /// <summary> Initializes a new instance of SearchIndexerDataIdentity. </summary>
        public SearchIndexerDataIdentity()
        {
        }

        /// <summary> Initializes a new instance of SearchIndexerDataIdentity. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the identity. </param>
        internal SearchIndexerDataIdentity(string oDataType)
        {
            ODataType = oDataType;
        }

        /// <summary> Identifies the concrete type of the identity. </summary>
        internal string ODataType { get; set; }
    }
}