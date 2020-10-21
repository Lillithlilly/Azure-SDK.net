// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// ComputePiOperationResponse
    /// </summary>
    public class ComputePiOperationResponse : Response<double>
    {
        /// <summary>
        /// Value
        /// </summary>
        public override double Value { get; }

        /// <summary>
        /// GetRawResponse
        /// </summary>
        /// <returns></returns>
        public override Response GetRawResponse()
        {
            throw new NotImplementedException();
        }
    }
}
