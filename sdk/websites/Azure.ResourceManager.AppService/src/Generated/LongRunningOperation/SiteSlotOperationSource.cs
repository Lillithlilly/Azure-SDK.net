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

namespace Azure.ResourceManager.AppService
{
    internal class SiteSlotOperationSource : IOperationSource<SiteSlotResource>
    {
        private readonly ArmClient _client;

        internal SiteSlotOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteSlotResource IOperationSource<SiteSlotResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WebSiteData.DeserializeWebSiteData(document.RootElement);
            return new SiteSlotResource(_client, data);
        }

        async ValueTask<SiteSlotResource> IOperationSource<SiteSlotResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WebSiteData.DeserializeWebSiteData(document.RootElement);
            return new SiteSlotResource(_client, data);
        }
    }
}
