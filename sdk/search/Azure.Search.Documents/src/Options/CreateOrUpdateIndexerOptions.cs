// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Search.Documents.Indexes;

namespace Azure.Search.Documents
{
    /// <summary>
    /// Options for <see cref="SearchIndexerClient.CreateOrUpdateIndexer"/>.
    /// </summary>
    public sealed class CreateOrUpdateIndexerOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public bool OnlyIfUnchanged { get; set; }


        /*
         * SearchIndexer indexer,
            bool onlyIfUnchanged = false,
            bool? disableCacheReprocessingChangeDetection = null,
            bool? ignoreCacheResetRequirements = null,
            CancellationToken cancellationToken = default
         * 
         */
    }
}
