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
    internal class LedgerDigestUploadsOperationSource : IOperationSource<LedgerDigestUploadsResource>
    {
        private readonly ArmClient _client;

        internal LedgerDigestUploadsOperationSource(ArmClient client)
        {
            _client = client;
        }

        LedgerDigestUploadsResource IOperationSource<LedgerDigestUploadsResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LedgerDigestUploadsData.DeserializeLedgerDigestUploadsData(document.RootElement);
            return new LedgerDigestUploadsResource(_client, data);
        }

        async ValueTask<LedgerDigestUploadsResource> IOperationSource<LedgerDigestUploadsResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LedgerDigestUploadsData.DeserializeLedgerDigestUploadsData(document.RootElement);
            return new LedgerDigestUploadsResource(_client, data);
        }
    }
}
