// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    internal class BackupInformationOperationSource : IOperationSource<BackupInformation>
    {
        BackupInformation IOperationSource<BackupInformation>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return BackupInformation.DeserializeBackupInformation(document.RootElement);
        }

        async ValueTask<BackupInformation> IOperationSource<BackupInformation>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return BackupInformation.DeserializeBackupInformation(document.RootElement);
        }
    }
}
