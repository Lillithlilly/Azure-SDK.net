// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host.Config;

namespace Microsoft.Azure.WebJobs.Extensions.Storage.Blobs.Listeners
{
    internal interface IHttpRequestProcessor
    {
        void RegisterHttpEnpoint(ExtensionConfigContext context);

        Task<HttpResponseMessage> ProcessHttpRequestAsync(HttpRequestMessage req, CancellationToken cancellationToken);
    }
}
