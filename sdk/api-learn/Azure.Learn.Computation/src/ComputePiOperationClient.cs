// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Learn.Computation.Models;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// ComputationOperationsClient
    /// </summary>
    public class ComputePiOperationClient
    {
        /// <summary>
        /// ComputationOperationsClient mocking
        /// </summary>
        protected ComputePiOperationClient()
        {
        }

        /// <summary>
        /// StartComputePi
        /// </summary>
        /// <param name="precision"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ComputePiOperation StartComputePi(int? precision = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// StartComputePiAsync
        /// </summary>
        /// <param name="precision"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Task<ComputePiOperation> StartComputePiAsync(int? precision = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
