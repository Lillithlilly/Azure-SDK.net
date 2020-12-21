// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Identity;

namespace Azure.Batch
{
    public class BatchServiceClient : BatchClient
    {
        private readonly BatchServiceRestClient _restClient;

        protected BatchServiceClient()
        {
        }

        public BatchServiceClient(Uri batchServiceUri, string batchAcountName, string batchAccountKey) : this(batchServiceUri, batchAcountName, batchAccountKey, new BatchClientOptions())
        {
        }

        public BatchServiceClient(Uri batchServiceUri, string batchAcountName, string batchAccountKey, BatchClientOptions options) : base(batchServiceUri, options)
        {
            Argument.AssertNotNull(batchAcountName, nameof(batchAcountName));
            Argument.AssertNotNull(batchAccountKey, nameof(batchAccountKey));

            throw new NotImplementedException();
        }

        public BatchServiceClient(Uri batchServiceUri) : this(batchServiceUri, new DefaultAzureCredential(true), new BatchClientOptions())
        {
        }

        public BatchServiceClient(Uri batchServiceUri, BatchClientOptions options) : this(batchServiceUri, new DefaultAzureCredential(true), options)
        {
        }

        public BatchServiceClient(Uri batchServiceUri, TokenCredential credential) : this(batchServiceUri, credential, new BatchClientOptions())
        {
        }

        public BatchServiceClient(Uri batchServiceUri, TokenCredential credential, BatchClientOptions options) : base(batchServiceUri, options)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            Pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, "https://batch.core.windows.net//.default"));

            _restClient = new BatchServiceRestClient(ClientDiagnostics, Pipeline, options.Version);
        }
    }
}
