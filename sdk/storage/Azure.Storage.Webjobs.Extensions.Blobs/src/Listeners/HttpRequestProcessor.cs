// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.WebJobs.Extensions.Storage.Blobs;
using Microsoft.Azure.WebJobs.Extensions.Storage.Common;
using Microsoft.Azure.WebJobs.Host.Blobs.Listeners;
using Microsoft.Azure.WebJobs.Host.Config;
using Microsoft.Azure.WebJobs.Host.Executors;
using Microsoft.Azure.WebJobs.Host.Queues.Listeners;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.WebJobs.Host.Blobs
{
    internal class HttpRequestProcessor: IHttpRequestProcessor
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
#pragma warning disable CS0618 // Type or member is obsolete
            Uri url = context.GetWebhookHandler();
#pragma warning restore CS0618 // Type or member is obsolete
            _logger.LogInformation($"registered http endpoint = {url?.GetLeftPart(UriPartial.Path)}");
        }

        public async Task<HttpResponseMessage> ProcessHttpRequestAsync(HttpRequestMessage req, CancellationToken cancellationToken)
        {
            var functionId = HttpUtility.ParseQueryString(req.RequestUri.Query)["functionName"];

            IEnumerable<string> eventTypeHeaders = null;
            string eventTypeHeader = null;
            if (req.Headers.TryGetValues("aeg-event-type", out eventTypeHeaders))
            {
                eventTypeHeader = eventTypeHeaders.First();
            }

            if (String.Equals(eventTypeHeader, "SubscriptionValidation", StringComparison.OrdinalIgnoreCase))
            {
                string jsonArray = await req.Content.ReadAsStringAsync().ConfigureAwait(false);
                SubscriptionValidationEvent validationEvent = null;
                List<JObject> events = JsonConvert.DeserializeObject<List<JObject>>(jsonArray);
                // TODO remove unnecessary serialization
                validationEvent = ((JObject)events[0]["data"]).ToObject<SubscriptionValidationEvent>();
                SubscriptionValidationResponse validationResponse = new SubscriptionValidationResponse { ValidationResponse = validationEvent.ValidationCode };
                var returnMessage = new HttpResponseMessage(HttpStatusCode.OK);
                returnMessage.Content = new StringContent(JsonConvert.SerializeObject(validationResponse));
                _logger.LogInformation($"perform handshake with eventGrid for function: {functionId}");
                return returnMessage;
            }
            else if (String.Equals(eventTypeHeader, "Notification", StringComparison.OrdinalIgnoreCase))
            {
                JArray events = null;
                string requestContent = await req.Content.ReadAsStringAsync().ConfigureAwait(false);
                var token = JToken.Parse(requestContent);
                if (token.Type == JTokenType.Array)
                {
                    // eventgrid schema
                    events = (JArray)token;
                }
                else if (token.Type == JTokenType.Object)
                {
                    // cloudevent schema
                    events = new JArray
                    {
                        token
                    };
                }

                if (_blobTriggerQueueWriter == null)
                {
                    await InitializeWriterAsync(cancellationToken).ConfigureAwait(false);
                }

                foreach (JObject jo in events)
                {
                    BlobTriggerMessage blobTriggerMessage = GetBlobTriggerMessage(jo, functionId);
                    await _blobTriggerQueueWriter.EnqueueAsync(blobTriggerMessage, cancellationToken).ConfigureAwait(false);
                }

                return new HttpResponseMessage(HttpStatusCode.Accepted);
            }
            else if (String.Equals(eventTypeHeader, "Unsubscribe", StringComparison.OrdinalIgnoreCase))
            {
                // TODO disable function?
                return new HttpResponseMessage(HttpStatusCode.Accepted);
            }

            return new HttpResponseMessage(HttpStatusCode.BadRequest);
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
