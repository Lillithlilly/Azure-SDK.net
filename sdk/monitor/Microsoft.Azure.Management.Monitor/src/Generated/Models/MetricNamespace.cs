// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metric namespace class specifies the metadata for a metric namespace.
    /// </summary>
    public partial class MetricNamespace
    {
        /// <summary>
        /// Initializes a new instance of the MetricNamespace class.
        /// </summary>
        public MetricNamespace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricNamespace class.
        /// </summary>
        /// <param name="id">The ID of the metric namespace.</param>
        /// <param name="type">The type of the namespace.</param>
        /// <param name="name">The escaped name of the namespace.</param>
        /// <param name="classification">Kind of namespace. Possible values
        /// include: 'Platform', 'Custom', 'Qos'</param>
        /// <param name="properties">Properties which include the fully
        /// qualified namespace name.</param>
        public MetricNamespace(string id = default(string), string type = default(string), string name = default(string), string classification = default(string), MetricNamespaceName properties = default(MetricNamespaceName))
        {
            Id = id;
            Type = type;
            Name = name;
            Classification = classification;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the metric namespace.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the namespace.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the escaped name of the namespace.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets kind of namespace. Possible values include:
        /// 'Platform', 'Custom', 'Qos'
        /// </summary>
        [JsonProperty(PropertyName = "classification")]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets properties which include the fully qualified namespace
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public MetricNamespaceName Properties { get; set; }

    }
}
