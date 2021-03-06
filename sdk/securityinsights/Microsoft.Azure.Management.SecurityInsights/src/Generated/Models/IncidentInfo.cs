// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes related incident information for the bookmark
    /// </summary>
    public partial class IncidentInfo
    {
        /// <summary>
        /// Initializes a new instance of the IncidentInfo class.
        /// </summary>
        public IncidentInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IncidentInfo class.
        /// </summary>
        /// <param name="incidentId">Incident Id</param>
        /// <param name="severity">The severity of the incident. Possible
        /// values include: 'High', 'Medium', 'Low', 'Informational'</param>
        /// <param name="title">The title of the incident</param>
        /// <param name="relationName">Relation Name</param>
        public IncidentInfo(string incidentId = default(string), string severity = default(string), string title = default(string), string relationName = default(string))
        {
            IncidentId = incidentId;
            Severity = severity;
            Title = title;
            RelationName = relationName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets incident Id
        /// </summary>
        [JsonProperty(PropertyName = "incidentId")]
        public string IncidentId { get; set; }

        /// <summary>
        /// Gets or sets the severity of the incident. Possible values include:
        /// 'High', 'Medium', 'Low', 'Informational'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the title of the incident
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets relation Name
        /// </summary>
        [JsonProperty(PropertyName = "relationName")]
        public string RelationName { get; set; }

    }
}
