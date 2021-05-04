// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> The AnomalyValue. </summary>
    public partial class AnomalyValue
    {
        /// <summary> Initializes a new instance of AnomalyValue. </summary>
        /// <param name="isAnomaly"> To indicate whether current timestamp is anomaly or not. </param>
        /// <param name="severity"> anomaly score of the current timestamp, the more significant an anomaly is, the higher the score will be. </param>
        internal AnomalyValue(bool isAnomaly, float severity)
        {
            Contributors = new ChangeTrackingList<AnomalyContributor>();
            IsAnomaly = isAnomaly;
            Severity = severity;
        }

        /// <summary> Initializes a new instance of AnomalyValue. </summary>
        /// <param name="contributors"> If current timestamp is an anomaly, contributors will show potential root cause for thus anomaly. Contributors can help us understand why current timestamp has been detected as an anomaly. </param>
        /// <param name="isAnomaly"> To indicate whether current timestamp is anomaly or not. </param>
        /// <param name="severity"> anomaly score of the current timestamp, the more significant an anomaly is, the higher the score will be. </param>
        /// <param name="score"> anomaly score of the current timestamp, the more significant an anomaly is, the higher the score will be, score measures global significance. </param>
        internal AnomalyValue(IReadOnlyList<AnomalyContributor> contributors, bool isAnomaly, float severity, float? score)
        {
            Contributors = contributors;
            IsAnomaly = isAnomaly;
            Severity = severity;
            Score = score;
        }

        /// <summary> If current timestamp is an anomaly, contributors will show potential root cause for thus anomaly. Contributors can help us understand why current timestamp has been detected as an anomaly. </summary>
        public IReadOnlyList<AnomalyContributor> Contributors { get; }
        /// <summary> To indicate whether current timestamp is anomaly or not. </summary>
        public bool IsAnomaly { get; }
        /// <summary> anomaly score of the current timestamp, the more significant an anomaly is, the higher the score will be. </summary>
        public float Severity { get; }
        /// <summary> anomaly score of the current timestamp, the more significant an anomaly is, the higher the score will be, score measures global significance. </summary>
        public float? Score { get; }
    }
}