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
    internal class SqlContainerOperationSource : IOperationSource<SqlContainerResource>
    {
        private readonly ArmClient _client;

        internal SqlContainerOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlContainerResource IOperationSource<SqlContainerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlContainerData.DeserializeSqlContainerData(document.RootElement);
            return new SqlContainerResource(_client, data);
        }

        async ValueTask<SqlContainerResource> IOperationSource<SqlContainerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlContainerData.DeserializeSqlContainerData(document.RootElement);
            return new SqlContainerResource(_client, data);
        }
    }
}
