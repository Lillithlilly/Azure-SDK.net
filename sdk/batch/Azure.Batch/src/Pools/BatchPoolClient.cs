// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Batch.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Batch.Pools
{
    public class BatchPoolClient : BatchClient
    {
        private readonly PoolClient _restClient;

        protected BatchPoolClient()
        {
        }

        public BatchPoolClient(Uri batchServiceUri, HttpPipeline pipeline) : this(batchServiceUri, pipeline, new BatchClientOptions())
        {
        }

        public BatchPoolClient(Uri batchServiceUri, HttpPipeline pipeline, BatchClientOptions options) : base(batchServiceUri, options)
        {
            _restClient = new PoolClient(ClientDiagnostics, pipeline, batchServiceUri.ToString());
        }

        public virtual Response<IReadOnlyList<CloudPool>> GetAllPools(CancellationToken cancellationToken = default)
        {
            ResponseWithHeaders<CloudPoolListResult, PoolListHeaders> result = _restClient.List(cancellationToken: cancellationToken);
            return Response.FromValue(result.Value.Value, result.GetRawResponse());
        }

        public async virtual Task<Response<IReadOnlyList<CloudPool>>> GetAllPoolsAsync(CancellationToken cancellationToken = default)
        {
            ResponseWithHeaders<CloudPoolListResult, PoolListHeaders> result = await _restClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            return Response.FromValue(result.Value.Value, result.GetRawResponse());
        }
    }
}
