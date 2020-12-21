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

namespace Azure.Batch.Tasks
{
    public class BatchTaskClient : BatchClient
    {
        private readonly TaskRestClient _restClient;

        protected BatchTaskClient()
        {
        }

        public BatchTaskClient(Uri batchServiceUri, HttpPipeline pipeline) : this(batchServiceUri, pipeline, new BatchClientOptions())
        {
        }

        public BatchTaskClient(Uri batchServiceUri, HttpPipeline pipeline, BatchClientOptions options) : base(batchServiceUri, options)
        {
            _restClient = new TaskRestClient(ClientDiagnostics, pipeline, batchServiceUri.ToString());
        }

        public virtual Response<IReadOnlyList<CloudTask>> GetAllTasks(CancellationToken cancellationToken = default)
        {
            ResponseWithHeaders<CloudTaskListResult, TaskListHeaders> result = _restClient.List("", cancellationToken: cancellationToken);
            return Response.FromValue(result.Value.Value, result.GetRawResponse());
        }

        public async virtual Task<Response<IReadOnlyList<CloudTask>>> GetAllTasksAsync(CancellationToken cancellationToken = default)
        {
            ResponseWithHeaders<CloudTaskListResult, TaskListHeaders> result = await _restClient.ListAsync("", cancellationToken: cancellationToken).ConfigureAwait(false);
            return Response.FromValue(result.Value.Value, result.GetRawResponse());
        }
    }
}
