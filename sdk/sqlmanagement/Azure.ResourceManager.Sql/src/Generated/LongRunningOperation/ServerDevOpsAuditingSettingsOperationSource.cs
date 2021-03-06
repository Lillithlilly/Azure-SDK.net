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
    internal class ServerDevOpsAuditingSettingsOperationSource : IOperationSource<ServerDevOpsAuditingSettingsResource>
    {
        private readonly ArmClient _client;

        internal ServerDevOpsAuditingSettingsOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServerDevOpsAuditingSettingsResource IOperationSource<ServerDevOpsAuditingSettingsResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerDevOpsAuditingSettingsData.DeserializeServerDevOpsAuditingSettingsData(document.RootElement);
            return new ServerDevOpsAuditingSettingsResource(_client, data);
        }

        async ValueTask<ServerDevOpsAuditingSettingsResource> IOperationSource<ServerDevOpsAuditingSettingsResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerDevOpsAuditingSettingsData.DeserializeServerDevOpsAuditingSettingsData(document.RootElement);
            return new ServerDevOpsAuditingSettingsResource(_client, data);
        }
    }
}
