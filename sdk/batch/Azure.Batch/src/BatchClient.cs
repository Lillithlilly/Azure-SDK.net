// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Batch
{
    public class BatchClient
    {
        public Uri EndPoint { get; private set; }
        public HttpPipeline Pipeline { get; protected internal set; }
        private protected ClientDiagnostics ClientDiagnostics { get; private set; }

        protected BatchClient()
        {
        }

        protected BatchClient(Uri batchServiceUri, ClientOptions options)
        {
            Argument.AssertNotNull(batchServiceUri, nameof(batchServiceUri));
            Argument.AssertNotNull(options, nameof(options));

            EndPoint = batchServiceUri;
            ClientDiagnostics = new ClientDiagnostics(options);
        }
    }
}
