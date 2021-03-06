// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of replication links. </summary>
    internal partial class ReplicationLinkListResult
    {
        /// <summary> Initializes a new instance of ReplicationLinkListResult. </summary>
        internal ReplicationLinkListResult()
        {
            Value = new ChangeTrackingList<ReplicationLinkData>();
        }

        /// <summary> Initializes a new instance of ReplicationLinkListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ReplicationLinkListResult(IReadOnlyList<ReplicationLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ReplicationLinkData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
