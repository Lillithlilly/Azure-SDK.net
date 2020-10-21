// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// ComputePiOperationStatus
    /// </summary>
    public class ComputePiOperation : Operation<ComputePiOperationResponse>
    {
        /// <summary>
        /// ComputePiOperation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="client"></param>
        public ComputePiOperation(string id, ComputePiOperationClient client)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// HasCompleted
        /// </summary>
        public override bool HasCompleted { get; }

        /// <summary>
        /// HasValue
        /// </summary>
        public override bool HasValue { get; }

        /// <summary>
        /// Id
        /// </summary>
        public override string Id { get; }

        /// <summary>
        /// Value
        /// </summary>
        public override ComputePiOperationResponse Value { get; }

        /// <summary>
        /// Raw response
        /// </summary>
        /// <returns></returns>
        public override Response GetRawResponse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// UpdateStatus
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Response UpdateStatus(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// UpdateStatusAsync
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// WaitForCompletionAsync
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override ValueTask<Response<ComputePiOperationResponse>> WaitForCompletionAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// WaitForCompletionAsync
        /// </summary>
        /// <param name="pollingInterval"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override ValueTask<Response<ComputePiOperationResponse>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
