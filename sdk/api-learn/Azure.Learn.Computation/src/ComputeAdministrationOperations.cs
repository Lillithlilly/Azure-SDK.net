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
    /// ComputeAdministrationOperations
    /// </summary>
    public class ComputeAdministrationOperations
    {
        /// <summary>
        /// ComputeAdministrationOperations for mocking
        /// </summary>
        protected ComputeAdministrationOperations()
        {
        }


        /// <summary>
        /// ComputeAdministrationOperations
        /// </summary>
        /// <param name="computeNodeName"></param>
        public ComputeAdministrationOperations(string computeNodeName)
        {
        }

        /// <summary>
        /// CreateComputeNode
        /// </summary>
        /// <param name="ifMatch"></param>
        /// <param name="computeNode"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ComputeNode> CreateComputeNode(string ifMatch = null, ComputeNode computeNode = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// CreateComputeNodeAsync
        /// </summary>
        /// <param name="ifMatch"></param>
        /// <param name="computeNode"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Task<Response<ComputeNode>> CreateComputeNodeAsync(string ifMatch = null, ComputeNode computeNode = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GetComputeNode
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ComputeNode> GetComputeNode(CancellationToken cancellationToken = default)
        {
           throw new NotImplementedException();
        }

        /// <summary>
        /// GetComputeNodeAsync
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Task<Response<ComputeNode>> GetComputeNodeAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GetComputeNodes
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Pageable<ComputeNode> GetComputeNodes(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GetComputeNodesAsync
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual AsyncPageable<ComputeNode> GetComputeNodesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

    }
}
