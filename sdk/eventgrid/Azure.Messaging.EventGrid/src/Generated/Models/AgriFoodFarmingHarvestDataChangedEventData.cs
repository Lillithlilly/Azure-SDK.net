// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AgFoodPlatform.HarvestDataChanged event. </summary>
    public partial class AgriFoodFarmingHarvestDataChangedEventData
    {
        /// <summary> Initializes a new instance of AgriFoodFarmingHarvestDataChangedEventData. </summary>
        internal AgriFoodFarmingHarvestDataChangedEventData()
        {
            Properties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of AgriFoodFarmingHarvestDataChangedEventData. </summary>
        /// <param name="actionType"> Action occurred on a resource. </param>
        /// <param name="farmerId"> Id of the farmer it belongs to. </param>
        /// <param name="status"> Status of the resource. </param>
        /// <param name="source"> Source of the farm operation data. </param>
        /// <param name="modifiedDateTime"> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="eTag"> The ETag value to implement optimistic concurrency. </param>
        /// <param name="id"> Unique id of resource. </param>
        /// <param name="name"> Name to identify resource. </param>
        /// <param name="description"> Textual description of resource. </param>
        /// <param name="createdDateTime"> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </param>
        /// <param name="properties">
        /// A list of key value pairs that describe the resource.
        /// 
        /// Only string and numeral values are supported.
        /// </param>
        internal AgriFoodFarmingHarvestDataChangedEventData(AgriFoodFarmingResourceActionType? actionType, string farmerId, string status, string source, DateTimeOffset? modifiedDateTime, string eTag, string id, string name, string description, DateTimeOffset? createdDateTime, IReadOnlyDictionary<string, object> properties)
        {
            ActionType = actionType;
            FarmerId = farmerId;
            Status = status;
            Source = source;
            ModifiedDateTime = modifiedDateTime;
            ETag = eTag;
            Id = id;
            Name = name;
            Description = description;
            CreatedDateTime = createdDateTime;
            Properties = properties;
        }

        /// <summary> Action occurred on a resource. </summary>
        public AgriFoodFarmingResourceActionType? ActionType { get; }
        /// <summary> Id of the farmer it belongs to. </summary>
        public string FarmerId { get; }
        /// <summary> Status of the resource. </summary>
        public string Status { get; }
        /// <summary> Source of the farm operation data. </summary>
        public string Source { get; }
        /// <summary> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? ModifiedDateTime { get; }
        /// <summary> The ETag value to implement optimistic concurrency. </summary>
        public string ETag { get; }
        /// <summary> Unique id of resource. </summary>
        public string Id { get; }
        /// <summary> Name to identify resource. </summary>
        public string Name { get; }
        /// <summary> Textual description of resource. </summary>
        public string Description { get; }
        /// <summary> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary>
        /// A list of key value pairs that describe the resource.
        /// 
        /// Only string and numeral values are supported.
        /// </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
    }
}