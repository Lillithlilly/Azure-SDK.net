// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SyncGroup data model. </summary>
    public partial class SyncGroupData : Resource
    {
        /// <summary> Initializes a new instance of SyncGroupData. </summary>
        public SyncGroupData()
        {
        }

        /// <summary> Initializes a new instance of SyncGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="sku"> The name and capacity of the SKU. </param>
        /// <param name="interval"> Sync interval of the sync group. </param>
        /// <param name="lastSyncTime"> Last sync time of the sync group. </param>
        /// <param name="conflictResolutionPolicy"> Conflict resolution policy of the sync group. </param>
        /// <param name="syncDatabaseId"> ARM resource id of the sync database in the sync group. </param>
        /// <param name="hubDatabaseUserName"> User name for the sync group hub database credential. </param>
        /// <param name="hubDatabasePassword"> Password for the sync group hub database credential. </param>
        /// <param name="syncState"> Sync state of the sync group. </param>
        /// <param name="schema"> Sync schema of the sync group. </param>
        /// <param name="enableConflictLogging"> If conflict logging is enabled. </param>
        /// <param name="conflictLoggingRetentionInDays"> Conflict logging retention period. </param>
        /// <param name="usePrivateLinkConnection"> If use private link connection is enabled. </param>
        /// <param name="privateEndpointName"> Private endpoint name of the sync group if use private link connection is enabled. </param>
        internal SyncGroupData(ResourceIdentifier id, string name, ResourceType type, Models.Sku sku, int? interval, DateTimeOffset? lastSyncTime, SyncConflictResolutionPolicy? conflictResolutionPolicy, string syncDatabaseId, string hubDatabaseUserName, string hubDatabasePassword, SyncGroupState? syncState, SyncGroupSchema schema, bool? enableConflictLogging, int? conflictLoggingRetentionInDays, bool? usePrivateLinkConnection, string privateEndpointName) : base(id, name, type)
        {
            Sku = sku;
            Interval = interval;
            LastSyncTime = lastSyncTime;
            ConflictResolutionPolicy = conflictResolutionPolicy;
            SyncDatabaseId = syncDatabaseId;
            HubDatabaseUserName = hubDatabaseUserName;
            HubDatabasePassword = hubDatabasePassword;
            SyncState = syncState;
            Schema = schema;
            EnableConflictLogging = enableConflictLogging;
            ConflictLoggingRetentionInDays = conflictLoggingRetentionInDays;
            UsePrivateLinkConnection = usePrivateLinkConnection;
            PrivateEndpointName = privateEndpointName;
        }

        /// <summary> The name and capacity of the SKU. </summary>
        public Models.Sku Sku { get; set; }
        /// <summary> Sync interval of the sync group. </summary>
        public int? Interval { get; set; }
        /// <summary> Last sync time of the sync group. </summary>
        public DateTimeOffset? LastSyncTime { get; }
        /// <summary> Conflict resolution policy of the sync group. </summary>
        public SyncConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }
        /// <summary> ARM resource id of the sync database in the sync group. </summary>
        public string SyncDatabaseId { get; set; }
        /// <summary> User name for the sync group hub database credential. </summary>
        public string HubDatabaseUserName { get; set; }
        /// <summary> Password for the sync group hub database credential. </summary>
        public string HubDatabasePassword { get; set; }
        /// <summary> Sync state of the sync group. </summary>
        public SyncGroupState? SyncState { get; }
        /// <summary> Sync schema of the sync group. </summary>
        public SyncGroupSchema Schema { get; set; }
        /// <summary> If conflict logging is enabled. </summary>
        public bool? EnableConflictLogging { get; set; }
        /// <summary> Conflict logging retention period. </summary>
        public int? ConflictLoggingRetentionInDays { get; set; }
        /// <summary> If use private link connection is enabled. </summary>
        public bool? UsePrivateLinkConnection { get; set; }
        /// <summary> Private endpoint name of the sync group if use private link connection is enabled. </summary>
        public string PrivateEndpointName { get; }
    }
}
