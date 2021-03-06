// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> the recurrence frequency. How often the schedule profile should take effect. This value must be Week, meaning each week will have the same set of profiles. For example, to set a daily schedule, set **schedule** to every day of the week. The frequency property specifies that the schedule is repeated weekly. </summary>
    public enum RecurrenceFrequency
    {
        /// <summary> None. </summary>
        None,
        /// <summary> Second. </summary>
        Second,
        /// <summary> Minute. </summary>
        Minute,
        /// <summary> Hour. </summary>
        Hour,
        /// <summary> Day. </summary>
        Day,
        /// <summary> Week. </summary>
        Week,
        /// <summary> Month. </summary>
        Month,
        /// <summary> Year. </summary>
        Year
    }
}
