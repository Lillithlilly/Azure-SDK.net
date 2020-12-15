// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Azure.WebJobs
{
    /// <summary>
    /// Provides blob trigger kinds to detect changes.
    /// </summary>
    public enum BlobTriggerKind
    {
        /// <summary>
        /// Changes detection is relied on Storage Analytics logs.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/storage-analytics-log-format">Storage Analytics logs</see>
        /// </summary>
        AnalyticsScan,
        /// <summary>
        /// Changes detection is relied on EventGrid.
        /// <see href="https://docs.microsoft.com/en-us/azure/event-grid/event-schema-blob-storage">Azure Blob Storage as an Event Grid source</see>
        /// </summary>
        EventGrid
    }
}
