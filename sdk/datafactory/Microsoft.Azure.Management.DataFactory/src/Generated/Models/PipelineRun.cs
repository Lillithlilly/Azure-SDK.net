// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about a pipeline run.
    /// </summary>
    public partial class PipelineRun
    {
        /// <summary>
        /// Initializes a new instance of the PipelineRun class.
        /// </summary>
        public PipelineRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineRun class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="runId">Identifier of a run.</param>
        /// <param name="runGroupId">Identifier that correlates all the
        /// recovery runs of a pipeline run.</param>
        /// <param name="isLatest">Indicates if the recovered pipeline run is
        /// the latest in its group.</param>
        /// <param name="pipelineName">The pipeline name.</param>
        /// <param name="parameters">The full or partial list of parameter
        /// name, value pair used in the pipeline run.</param>
        /// <param name="runDimensions">Run dimensions emitted by Pipeline
        /// run.</param>
        /// <param name="invokedBy">Entity that started the pipeline
        /// run.</param>
        /// <param name="lastUpdated">The last updated timestamp for the
        /// pipeline run event in ISO8601 format.</param>
        /// <param name="runStart">The start time of a pipeline run in ISO8601
        /// format.</param>
        /// <param name="runEnd">The end time of a pipeline run in ISO8601
        /// format.</param>
        /// <param name="durationInMs">The duration of a pipeline run.</param>
        /// <param name="status">The status of a pipeline run. Possible values:
        /// Queued, InProgress, Succeeded, Failed, Canceling, Cancelled</param>
        /// <param name="message">The message from a pipeline run.</param>
        public PipelineRun(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string runId = default(string), string runGroupId = default(string), bool? isLatest = default(bool?), string pipelineName = default(string), IDictionary<string, string> parameters = default(IDictionary<string, string>), IDictionary<string, string> runDimensions = default(IDictionary<string, string>), PipelineRunInvokedBy invokedBy = default(PipelineRunInvokedBy), System.DateTime? lastUpdated = default(System.DateTime?), System.DateTime? runStart = default(System.DateTime?), System.DateTime? runEnd = default(System.DateTime?), int? durationInMs = default(int?), string status = default(string), string message = default(string))
        {
            AdditionalProperties = additionalProperties;
            RunId = runId;
            RunGroupId = runGroupId;
            IsLatest = isLatest;
            PipelineName = pipelineName;
            Parameters = parameters;
            RunDimensions = runDimensions;
            InvokedBy = invokedBy;
            LastUpdated = lastUpdated;
            RunStart = runStart;
            RunEnd = runEnd;
            DurationInMs = durationInMs;
            Status = status;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets identifier of a run.
        /// </summary>
        [JsonProperty(PropertyName = "runId")]
        public string RunId { get; private set; }

        /// <summary>
        /// Gets identifier that correlates all the recovery runs of a pipeline
        /// run.
        /// </summary>
        [JsonProperty(PropertyName = "runGroupId")]
        public string RunGroupId { get; private set; }

        /// <summary>
        /// Gets indicates if the recovered pipeline run is the latest in its
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "isLatest")]
        public bool? IsLatest { get; private set; }

        /// <summary>
        /// Gets the pipeline name.
        /// </summary>
        [JsonProperty(PropertyName = "pipelineName")]
        public string PipelineName { get; private set; }

        /// <summary>
        /// Gets the full or partial list of parameter name, value pair used in
        /// the pipeline run.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, string> Parameters { get; private set; }

        /// <summary>
        /// Gets run dimensions emitted by Pipeline run.
        /// </summary>
        [JsonProperty(PropertyName = "runDimensions")]
        public IDictionary<string, string> RunDimensions { get; private set; }

        /// <summary>
        /// Gets entity that started the pipeline run.
        /// </summary>
        [JsonProperty(PropertyName = "invokedBy")]
        public PipelineRunInvokedBy InvokedBy { get; private set; }

        /// <summary>
        /// Gets the last updated timestamp for the pipeline run event in
        /// ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.DateTime? LastUpdated { get; private set; }

        /// <summary>
        /// Gets the start time of a pipeline run in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "runStart")]
        public System.DateTime? RunStart { get; private set; }

        /// <summary>
        /// Gets the end time of a pipeline run in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "runEnd")]
        public System.DateTime? RunEnd { get; private set; }

        /// <summary>
        /// Gets the duration of a pipeline run.
        /// </summary>
        [JsonProperty(PropertyName = "durationInMs")]
        public int? DurationInMs { get; private set; }

        /// <summary>
        /// Gets the status of a pipeline run. Possible values: Queued,
        /// InProgress, Succeeded, Failed, Canceling, Cancelled
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the message from a pipeline run.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}
