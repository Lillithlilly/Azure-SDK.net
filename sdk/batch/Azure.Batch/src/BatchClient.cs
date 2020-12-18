// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Batch
{
    public class BatchClient
    {
        private readonly Uri _endpoint;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BatchServiceRestClient _restClient;

        protected BatchClient()
        {
        }

        private BatchClient(Uri batchServiceUri, BatchClientOptions options)
        {
            Argument.AssertNotNull(batchServiceUri, nameof(batchServiceUri));
            Argument.AssertNotNull(options, nameof(options));

            _endpoint = batchServiceUri;
            _clientDiagnostics = new ClientDiagnostics(options);
        }

        public BatchClient(Uri batchServiceUri, string batchAcountName, string batchAccountKey) : this(batchServiceUri, batchAcountName, batchAccountKey, new BatchClientOptions())
        {
        }

        public BatchClient(Uri batchServiceUri, string batchAcountName, string batchAccountKey, BatchClientOptions options) : this(batchServiceUri, options)
        {
            Argument.AssertNotNull(batchAcountName, nameof(batchAcountName));
            Argument.AssertNotNull(batchAccountKey, nameof(batchAccountKey));

            throw new NotImplementedException();
        }

        public BatchClient(Uri batchServiceUri, TokenCredential credential) : this(batchServiceUri, credential, new BatchClientOptions())
        {
        }

        public BatchClient(Uri batchServiceUri, TokenCredential credential, BatchClientOptions options) : this(batchServiceUri, options)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, "https://batch.core.windows.net//.default"));

            _restClient = new BatchServiceRestClient(_clientDiagnostics, _pipeline, options.Version);
        }
    }
}
