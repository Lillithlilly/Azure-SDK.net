// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> An optional field, indicates how missed values will be filled with. Can not be set to NotFill, when alignMode is Outer.{Previous, Subsequent, Linear, Zero, Fix, NotFill}. </summary>
    public enum FillNAMethod
    {
        /// <summary> Previous. </summary>
        Previous,
        /// <summary> Subsequent. </summary>
        Subsequent,
        /// <summary> Linear. </summary>
        Linear,
        /// <summary> Zero. </summary>
        Zero,
        /// <summary> Pad. </summary>
        Pad,
        /// <summary> NotFill. </summary>
        NotFill
    }
}