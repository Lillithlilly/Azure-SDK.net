// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Azure.WebJobs.Extensions.Storage.Common;
using Microsoft.Azure.WebJobs.Extensions.Storage.Common.Listeners;
using Microsoft.Azure.WebJobs.Host.Config;
using Microsoft.Azure.WebJobs.Host.Executors;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.WebJobs.Extensions.Storage.Blobs.Listeners
{
    internal class HttpRequestProcessor : IHttpRequestProcessor
    {
        private readonly SharedQueueWatcher _sharedQueueWatcher;
        private readonly IHostIdProvider _hostIdProvider;
        private readonly QueueServiceClientProvider _queueServiceClientProvider;
        private readonly ILogger _logger;
        private BlobTriggerQueueWriter _blobTriggerQueueWriter;

        public HttpRequestProcessor(
            SharedQueueWatcher sharedQueueWatcher,
            IHostIdProvider hostIdProvider,
            QueueServiceClientProvider queueServiceClientProvider,
            ILoggerFactory loggerFactory)
        {
            _sharedQueueWatcher = sharedQueueWatcher;
            _hostIdProvider = hostIdProvider;
            _queueServiceClientProvider = queueServiceClientProvider;
            _logger = loggerFactory.CreateLogger<HttpRequestProcessor>();
        }

        public void RegisterHttpEnpoint(ExtensionConfigContext context)
        {
            //Debugger.Break();
#pragma warning disable CS0618 // Type or member is obsolete
            Uri url = context.GetWebhookHandler();
#pragma warning restore CS0618 // Type or member is obsolete
            _logger.LogInformation($"registered http endpoint = {url?.GetLeftPart(UriPartial.Path)}");
        }

        public async Task<HttpResponseMessage> ProcessHttpRequestAsync(HttpRequestMessage req, CancellationToken cancellationToken)
        {
            //Debugger.Break();
            var functionName = HttpUtility.ParseQueryString(req.RequestUri.Query)["functionName"];

            IEnumerable<string> eventTypeHeaders = null;
            string eventTypeHeader = null;
            if (req.Headers.TryGetValues("aeg-event-type", out eventTypeHeaders))
            {
                eventTypeHeader = eventTypeHeaders.First();
            }

            return await EventGrid.HttpRequestProcessor.ProcessAsync(req, functionName, _logger, ProcessEventsAsync, CancellationToken.None).ConfigureAwait(false);
        }

        private async Task<HttpResponseMessage> ProcessEventsAsync(JArray events, string functionName, CancellationToken cancellationToken)
        {
            if (_blobTriggerQueueWriter == null)
            {
                await InitializeWriterAsync(cancellationToken).ConfigureAwait(false);
            }

            foreach (JObject jo in events)
            {
                BlobTriggerMessage blobTriggerMessage = GetBlobTriggerMessage(jo, functionName);
                await _blobTriggerQueueWriter.EnqueueAsync(blobTriggerMessage, cancellationToken).ConfigureAwait(false);
            }

            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }


        private async Task InitializeWriterAsync(CancellationToken cancellationToken)
        {
            string hostId = await _hostIdProvider.GetHostIdAsync(cancellationToken).ConfigureAwait(false);
            string hostBlobTriggerQueueName = HostQueueNames.GetHostBlobTriggerQueueName(hostId);
            var hostBlobTriggerQueue = _queueServiceClientProvider.GetHost().GetQueueClient(hostBlobTriggerQueueName);

            _blobTriggerQueueWriter = new BlobTriggerQueueWriter(hostBlobTriggerQueue, _sharedQueueWatcher);
        }

        private BlobTriggerMessage GetBlobTriggerMessage(JObject jo, string functionId)
        {
            JObject data = jo["data"] as JObject;

            BlobUriBuilder blobUriBuilder = new BlobUriBuilder(new Uri(data["url"].ToString()));

            return new BlobTriggerMessage()
            {
                ETag = $"\"{data["eTag"]}\"",
                BlobType = (BlobType)Enum.Parse(typeof(BlobType), data["blobType"].ToString().Replace("Blob", "")),
                ContainerName = blobUriBuilder.BlobContainerName,
                BlobName = blobUriBuilder.BlobName,
                FunctionId = functionId
            };
        }
    }
}