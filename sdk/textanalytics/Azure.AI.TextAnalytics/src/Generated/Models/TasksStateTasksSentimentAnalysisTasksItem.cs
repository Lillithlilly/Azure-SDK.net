// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasksSentimentAnalysisTasksItem. </summary>
    internal partial class TasksStateTasksSentimentAnalysisTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of TasksStateTasksSentimentAnalysisTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        internal TasksStateTasksSentimentAnalysisTasksItem(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of TasksStateTasksSentimentAnalysisTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <param name="results"> . </param>
        internal TasksStateTasksSentimentAnalysisTasksItem(DateTimeOffset lastUpdateDateTime, string name, TextAnalyticsOperationStatus status, SentimentResponse results) : base(lastUpdateDateTime, name, status)
        {
            Results = results;
        }

        public SentimentResponse Results { get; }
    }
}