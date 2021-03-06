// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for updating a task run.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TaskRunUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the TaskRunUpdateParameters class.
        /// </summary>
        public TaskRunUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskRunUpdateParameters class.
        /// </summary>
        /// <param name="identity">Identity for the resource.</param>
        /// <param name="runRequest">The request (parameters) for the new
        /// run</param>
        /// <param name="forceUpdateTag">How the run should be forced to rerun
        /// even if the run request configuration has not changed</param>
        /// <param name="location">The location of the resource</param>
        /// <param name="tags">The ARM resource tags.</param>
        public TaskRunUpdateParameters(IdentityProperties identity = default(IdentityProperties), RunRequest runRequest = default(RunRequest), string forceUpdateTag = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Identity = identity;
            RunRequest = runRequest;
            ForceUpdateTag = forceUpdateTag;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identity for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public IdentityProperties Identity { get; set; }

        /// <summary>
        /// Gets or sets the request (parameters) for the new run
        /// </summary>
        [JsonProperty(PropertyName = "properties.runRequest")]
        public RunRequest RunRequest { get; set; }

        /// <summary>
        /// Gets or sets how the run should be forced to rerun even if the run
        /// request configuration has not changed
        /// </summary>
        [JsonProperty(PropertyName = "properties.forceUpdateTag")]
        public string ForceUpdateTag { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
