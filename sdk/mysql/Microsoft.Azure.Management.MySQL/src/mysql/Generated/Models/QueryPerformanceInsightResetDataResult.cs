// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Result of Query Performance Insight data reset.
    /// </summary>
    public partial class QueryPerformanceInsightResetDataResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// QueryPerformanceInsightResetDataResult class.
        /// </summary>
        public QueryPerformanceInsightResetDataResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// QueryPerformanceInsightResetDataResult class.
        /// </summary>
        /// <param name="status">Indicates result of the operation. Possible
        /// values include: 'Succeeded', 'Failed'</param>
        /// <param name="message">operation message.</param>
        public QueryPerformanceInsightResetDataResult(string status = default(string), string message = default(string))
        {
            Status = status;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates result of the operation. Possible values
        /// include: 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets operation message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
