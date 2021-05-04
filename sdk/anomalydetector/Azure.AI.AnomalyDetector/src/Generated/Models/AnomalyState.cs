// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> The AnomalyState. </summary>
    public partial class AnomalyState
    {
        /// <summary> Initializes a new instance of AnomalyState. </summary>
        /// <param name="timestamp"> timestamp. </param>
        internal AnomalyState(DateTimeOffset timestamp)
        {
            Timestamp = timestamp;
            Errors = new ChangeTrackingList<ErrorResponse>();
        }

        /// <summary> Initializes a new instance of AnomalyState. </summary>
        /// <param name="timestamp"> timestamp. </param>
        /// <param name="value"> . </param>
        /// <param name="errors"> Error message when inference this timestamp. </param>
        internal AnomalyState(DateTimeOffset timestamp, AnomalyValue value, IReadOnlyList<ErrorResponse> errors)
        {
            Timestamp = timestamp;
            Value = value;
            Errors = errors;
        }

        /// <summary> timestamp. </summary>
        public DateTimeOffset Timestamp { get; }
        public AnomalyValue Value { get; }
        /// <summary> Error message when inference this timestamp. </summary>
        public IReadOnlyList<ErrorResponse> Errors { get; }
    }
}