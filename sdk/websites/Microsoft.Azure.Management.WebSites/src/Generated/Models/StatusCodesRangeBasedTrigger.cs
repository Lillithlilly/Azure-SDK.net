// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Trigger based on range of status codes.
    /// </summary>
    public partial class StatusCodesRangeBasedTrigger
    {
        /// <summary>
        /// Initializes a new instance of the StatusCodesRangeBasedTrigger
        /// class.
        /// </summary>
        public StatusCodesRangeBasedTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatusCodesRangeBasedTrigger
        /// class.
        /// </summary>
        /// <param name="statusCodes">HTTP status code.</param>
        /// <param name="count">Request Count.</param>
        /// <param name="timeInterval">Time interval.</param>
        public StatusCodesRangeBasedTrigger(string statusCodes = default(string), string path = default(string), int? count = default(int?), string timeInterval = default(string))
        {
            StatusCodes = statusCodes;
            Path = path;
            Count = count;
            TimeInterval = timeInterval;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets HTTP status code.
        /// </summary>
        [JsonProperty(PropertyName = "statusCodes")]
        public string StatusCodes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets request Count.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets time interval.
        /// </summary>
        [JsonProperty(PropertyName = "timeInterval")]
        public string TimeInterval { get; set; }

    }
}