// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The related metadata items for the category. </summary>
    internal partial class MetadataCategoryRelated
    {
        /// <summary> Initializes a new instance of MetadataCategoryRelated. </summary>
        internal MetadataCategoryRelated()
        {
            Tables = new ChangeTrackingList<string>();
            Functions = new ChangeTrackingList<string>();
            ResourceTypes = new ChangeTrackingList<string>();
            Queries = new ChangeTrackingList<string>();
            Solutions = new ChangeTrackingList<string>();
        }

        /// <summary> The tables related to the category. </summary>
        public IReadOnlyList<string> Tables { get; }
        /// <summary> The functions related to the category. </summary>
        public IReadOnlyList<string> Functions { get; }
        /// <summary> The resource types related to the category. </summary>
        public IReadOnlyList<string> ResourceTypes { get; }
        /// <summary> The saved queries related to the category. </summary>
        public IReadOnlyList<string> Queries { get; }
        /// <summary> The Log Analytics solutions related to the category. </summary>
        public IReadOnlyList<string> Solutions { get; }
    }
}