// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    internal class ServerTrustGroupOperationSource : IOperationSource<ServerTrustGroupResource>
    {
        private readonly ArmClient _client;

        internal ServerTrustGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServerTrustGroupResource IOperationSource<ServerTrustGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerTrustGroupData.DeserializeServerTrustGroupData(document.RootElement);
            return new ServerTrustGroupResource(_client, data);
        }

        async ValueTask<ServerTrustGroupResource> IOperationSource<ServerTrustGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerTrustGroupData.DeserializeServerTrustGroupData(document.RootElement);
            return new ServerTrustGroupResource(_client, data);
        }
    }
}
