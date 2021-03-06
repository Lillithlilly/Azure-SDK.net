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

namespace Azure.ResourceManager.CosmosDB
{
    internal class ClusterResourceOperationSource : IOperationSource<ClusterResource>
    {
        private readonly ArmClient _client;

        internal ClusterResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ClusterResource IOperationSource<ClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ClusterResourceData.DeserializeClusterResourceData(document.RootElement);
            return new ClusterResource(_client, data);
        }

        async ValueTask<ClusterResource> IOperationSource<ClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ClusterResourceData.DeserializeClusterResourceData(document.RootElement);
            return new ClusterResource(_client, data);
        }
    }
}
