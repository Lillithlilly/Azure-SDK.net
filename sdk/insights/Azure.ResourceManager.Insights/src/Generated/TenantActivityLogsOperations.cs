// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    /// <summary> The TenantActivityLogs service client. </summary>
    public partial class TenantActivityLogsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TenantActivityLogsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of TenantActivityLogsOperations for mocking. </summary>
        protected TenantActivityLogsOperations()
        {
        }

        /// <summary> Initializes a new instance of TenantActivityLogsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal TenantActivityLogsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new TenantActivityLogsRestOperations(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the Activity Logs for the Tenant.&lt;br&gt;Everything that is applicable to the API to get the Activity Logs for the subscription is applicable to this API (the parameters, $filter, etc.).&lt;br&gt;One thing to point out here is that this API does *not* retrieve the logs at the individual subscription of the tenant but only surfaces the logs that were generated at the tenant level. </summary>
        /// <param name="filter"> Reduces the set of data collected. &lt;br&gt;The **$filter** is very restricted and allows only the following patterns.&lt;br&gt;- List events for a resource group: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceGroupName eq &apos;&lt;ResourceGroupName&gt;&apos;.&lt;br&gt;- List events for resource: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceUri eq &apos;&lt;ResourceURI&gt;&apos;.&lt;br&gt;- List events for a subscription: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos;.&lt;br&gt;- List events for a resource provider: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceProvider eq &apos;&lt;ResourceProviderName&gt;&apos;.&lt;br&gt;- List events for a correlation Id: api-version=2014-04-01&amp;$filter=eventTimestamp ge &apos;2014-07-16T04:36:37.6407898Z&apos; and eventTimestamp le &apos;2014-07-20T04:36:37.6407898Z&apos; and eventChannels eq &apos;Admin, Operation&apos; and correlationId eq &apos;&lt;CorrelationID&gt;&apos;.&lt;br&gt;**NOTE**: No other syntax is allowed. </param>
        /// <param name="select"> Used to fetch events with only the given properties.&lt;br&gt;The **$select** argument is a comma separated list of property names to be returned. Possible values are: *authorization*, *claims*, *correlationId*, *description*, *eventDataId*, *eventName*, *eventTimestamp*, *httpRequest*, *level*, *operationId*, *operationName*, *properties*, *resourceGroupName*, *resourceProviderName*, *resourceId*, *status*, *submissionTimestamp*, *subStatus*, *subscriptionId*. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<EventData> ListAsync(string filter = null, string select = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<EventData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantActivityLogsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(filter, select, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantActivityLogsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, filter, select, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the Activity Logs for the Tenant.&lt;br&gt;Everything that is applicable to the API to get the Activity Logs for the subscription is applicable to this API (the parameters, $filter, etc.).&lt;br&gt;One thing to point out here is that this API does *not* retrieve the logs at the individual subscription of the tenant but only surfaces the logs that were generated at the tenant level. </summary>
        /// <param name="filter"> Reduces the set of data collected. &lt;br&gt;The **$filter** is very restricted and allows only the following patterns.&lt;br&gt;- List events for a resource group: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceGroupName eq &apos;&lt;ResourceGroupName&gt;&apos;.&lt;br&gt;- List events for resource: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceUri eq &apos;&lt;ResourceURI&gt;&apos;.&lt;br&gt;- List events for a subscription: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos;.&lt;br&gt;- List events for a resource provider: $filter=eventTimestamp ge &apos;&lt;Start Time&gt;&apos; and eventTimestamp le &apos;&lt;End Time&gt;&apos; and eventChannels eq &apos;Admin, Operation&apos; and resourceProvider eq &apos;&lt;ResourceProviderName&gt;&apos;.&lt;br&gt;- List events for a correlation Id: api-version=2014-04-01&amp;$filter=eventTimestamp ge &apos;2014-07-16T04:36:37.6407898Z&apos; and eventTimestamp le &apos;2014-07-20T04:36:37.6407898Z&apos; and eventChannels eq &apos;Admin, Operation&apos; and correlationId eq &apos;&lt;CorrelationID&gt;&apos;.&lt;br&gt;**NOTE**: No other syntax is allowed. </param>
        /// <param name="select"> Used to fetch events with only the given properties.&lt;br&gt;The **$select** argument is a comma separated list of property names to be returned. Possible values are: *authorization*, *claims*, *correlationId*, *description*, *eventDataId*, *eventName*, *eventTimestamp*, *httpRequest*, *level*, *operationId*, *operationName*, *properties*, *resourceGroupName*, *resourceProviderName*, *resourceId*, *status*, *submissionTimestamp*, *subStatus*, *subscriptionId*. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<EventData> List(string filter = null, string select = null, CancellationToken cancellationToken = default)
        {
            Page<EventData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantActivityLogsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(filter, select, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantActivityLogsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, filter, select, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
