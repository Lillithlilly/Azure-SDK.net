// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing a Traffic Manager HeatMap.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HeatMapModel : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the HeatMapModel class.
        /// </summary>
        public HeatMapModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HeatMapModel class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Network/trafficManagerProfiles.</param>
        /// <param name="startTime">The beginning of the time window for this
        /// HeatMap, inclusive.</param>
        /// <param name="endTime">The ending of the time window for this
        /// HeatMap, exclusive.</param>
        /// <param name="endpoints">The endpoints used in this HeatMap
        /// calculation.</param>
        /// <param name="trafficFlows">The traffic flows produced in this
        /// HeatMap calculation.</param>
        public HeatMapModel(string id = default(string), string name = default(string), string type = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), IList<HeatMapEndpoint> endpoints = default(IList<HeatMapEndpoint>), IList<TrafficFlow> trafficFlows = default(IList<TrafficFlow>))
            : base(id, name, type)
        {
            StartTime = startTime;
            EndTime = endTime;
            Endpoints = endpoints;
            TrafficFlows = trafficFlows;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the beginning of the time window for this HeatMap,
        /// inclusive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the ending of the time window for this HeatMap,
        /// exclusive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the endpoints used in this HeatMap calculation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoints")]
        public IList<HeatMapEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Gets or sets the traffic flows produced in this HeatMap
        /// calculation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trafficFlows")]
        public IList<TrafficFlow> TrafficFlows { get; set; }

    }
}
