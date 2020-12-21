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

namespace Azure.Batch.Jobs
{
    public class BatchJobClient : BatchClient
    {
        private readonly JobRestClient _restClient;

        protected BatchJobClient()
        {
        }

        public BatchJobClient(Uri batchServiceUri, HttpPipeline pipeline) : this(batchServiceUri, pipeline, new BatchClientOptions())
        {
        }

        public BatchJobClient(Uri batchServiceUri, HttpPipeline pipeline, BatchClientOptions options) : base(batchServiceUri, options)
        {
            _restClient = new JobRestClient(ClientDiagnostics, pipeline, batchServiceUri.ToString());
        }

        public virtual Response<IReadOnlyList<CloudJob>> GetAllJobs(CancellationToken cancellationToken = default)
        {
            ResponseWithHeaders<CloudJobListResult, JobListHeaders> result = _restClient.List(cancellationToken: cancellationToken);
            return Response.FromValue(result.Value.Value, result.GetRawResponse());
        }

        public async virtual Task<Response<IReadOnlyList<CloudJob>>> GetAllJobsAsync(CancellationToken cancellationToken = default)
        {
            ResponseWithHeaders<CloudJobListResult, JobListHeaders> result = await _restClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            return Response.FromValue(result.Value.Value, result.GetRawResponse());
        }
    }
}
