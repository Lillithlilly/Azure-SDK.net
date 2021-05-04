// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Trigger that runs every time a custom event is received. </summary>
    public partial class CustomEventsTrigger : MultiplePipelineTrigger
    {
        /// <summary> Initializes a new instance of CustomEventsTrigger. </summary>
        /// <param name="events"> The list of event types that cause this trigger to fire. </param>
        /// <param name="scope"> The ARM resource ID of the Azure Event Grid Topic. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="events"/> or <paramref name="scope"/> is null. </exception>
        public CustomEventsTrigger(IEnumerable<object> events, string scope)
        {
            if (events == null)
            {
                throw new ArgumentNullException(nameof(events));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            Events = events.ToList();
            Scope = scope;
            Type = "CustomEventsTrigger";
        }

        /// <summary> Initializes a new instance of CustomEventsTrigger. </summary>
        /// <param name="type"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="pipelines"> Pipelines that need to be started. </param>
        /// <param name="subjectBeginsWith"> The event subject must begin with the pattern provided for trigger to fire. At least one of these must be provided: subjectBeginsWith, subjectEndsWith. </param>
        /// <param name="subjectEndsWith"> The event subject must end with the pattern provided for trigger to fire. At least one of these must be provided: subjectBeginsWith, subjectEndsWith. </param>
        /// <param name="events"> The list of event types that cause this trigger to fire. </param>
        /// <param name="scope"> The ARM resource ID of the Azure Event Grid Topic. </param>
        internal CustomEventsTrigger(string type, string description, TriggerRuntimeState? runtimeState, IList<object> annotations, IDictionary<string, object> additionalProperties, IList<TriggerPipelineReference> pipelines, string subjectBeginsWith, string subjectEndsWith, IList<object> events, string scope) : base(type, description, runtimeState, annotations, additionalProperties, pipelines)
        {
            SubjectBeginsWith = subjectBeginsWith;
            SubjectEndsWith = subjectEndsWith;
            Events = events;
            Scope = scope;
            Type = type ?? "CustomEventsTrigger";
        }

        /// <summary> The event subject must begin with the pattern provided for trigger to fire. At least one of these must be provided: subjectBeginsWith, subjectEndsWith. </summary>
        public string SubjectBeginsWith { get; set; }
        /// <summary> The event subject must end with the pattern provided for trigger to fire. At least one of these must be provided: subjectBeginsWith, subjectEndsWith. </summary>
        public string SubjectEndsWith { get; set; }
        /// <summary> The list of event types that cause this trigger to fire. </summary>
        public IList<object> Events { get; }
        /// <summary> The ARM resource ID of the Azure Event Grid Topic. </summary>
        public string Scope { get; set; }
    }
}