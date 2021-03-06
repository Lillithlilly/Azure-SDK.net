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
    internal class ServerCommunicationLinkOperationSource : IOperationSource<ServerCommunicationLinkResource>
    {
        private readonly ArmClient _client;

        internal ServerCommunicationLinkOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServerCommunicationLinkResource IOperationSource<ServerCommunicationLinkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerCommunicationLinkData.DeserializeServerCommunicationLinkData(document.RootElement);
            return new ServerCommunicationLinkResource(_client, data);
        }

        async ValueTask<ServerCommunicationLinkResource> IOperationSource<ServerCommunicationLinkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerCommunicationLinkData.DeserializeServerCommunicationLinkData(document.RootElement);
            return new ServerCommunicationLinkResource(_client, data);
        }
    }
}
