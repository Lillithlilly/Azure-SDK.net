// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Learn.Computation.Models;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// ComputeNodes
    /// </summary>
    [CodeGenModel("PageOfComputeNodes")]
    internal partial class ComputeNodes
    {
        /// <summary>
        /// Node
        /// </summary>
        [CodeGenMember("Value")]
        public IReadOnlyList<ComputeNode> Node { get; }
    }
}
