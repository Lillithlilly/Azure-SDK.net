// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// ComputeOperation
    /// </summary>
    [CodeGenModel("Operation")]
#pragma warning disable CS0282 // There is no defined ordering between fields in multiple declarations of partial struct
    public partial struct ComputeOperation
#pragma warning restore CS0282 // There is no defined ordering between fields in multiple declarations of partial struct
    {
        /// <summary>
        /// computed value
        /// </summary>
        [CodeGenMember("Value")]
        public float? ComputedValue { get; }
    }
}
