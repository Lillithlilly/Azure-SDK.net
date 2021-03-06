// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    /// <summary> The Metrics service client. </summary>
    public partial class MetricsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal MetricsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of MetricsOperations for mocking. </summary>
        protected MetricsOperations()
        {
        }

        /// <summary> Initializes a new instance of MetricsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal MetricsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new MetricsRestOperations(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> **Lists the metric values for a resource**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="timespan"> The timespan of the query. It is a string with the following format &apos;startDateTime_ISO/endDateTime_ISO&apos;. </param>
        /// <param name="interval"> The interval (i.e. timegrain) of the query. </param>
        /// <param name="metricnames"> The names of the metrics (comma separated) to retrieve. </param>
        /// <param name="aggregation"> The list of aggregation types (comma separated) to retrieve. </param>
        /// <param name="top">
        /// The maximum number of records to retrieve.
        /// Valid only if $filter is specified.
        /// Defaults to 10.
        /// </param>
        /// <param name="orderby">
        /// The aggregation to use for sorting results and the direction of the sort.
        /// Only one order can be specified.
        /// Examples: sum asc.
        /// </param>
        /// <param name="filter"> The **$filter** is used to reduce the set of metric data returned.&lt;br&gt;Example:&lt;br&gt;Metric contains metadata A, B and C.&lt;br&gt;- Return all time series of C where A = a1 and B = b1 or b2&lt;br&gt;**$filter=A eq ???a1??? and B eq ???b1??? or B eq ???b2??? and C eq ???*???**&lt;br&gt;- Invalid variant:&lt;br&gt;**$filter=A eq ???a1??? and B eq ???b1??? and C eq ???*??? or B = ???b2???**&lt;br&gt;This is invalid because the logical or operator cannot separate two different metadata names.&lt;br&gt;- Return all time series where A = a1, B = b1 and C = c1:&lt;br&gt;**$filter=A eq ???a1??? and B eq ???b1??? and C eq ???c1???**&lt;br&gt;- Return all time series where A = a1&lt;br&gt;**$filter=A eq ???a1??? and B eq ???*??? and C eq ???*???**. </param>
        /// <param name="resultType"> Reduces the set of data collected. The syntax allowed depends on the operation. See the operation&apos;s description for details. </param>
        /// <param name="metricnamespace"> Metric namespace to query metric definitions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Models.Response>> ListAsync(string resourceUri, string timespan = null, TimeSpan? interval = null, string metricnames = null, string aggregation = null, int? top = null, string orderby = null, string filter = null, ResultType? resultType = null, string metricnamespace = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricsOperations.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(resourceUri, timespan, interval, metricnames, aggregation, top, orderby, filter, resultType, metricnamespace, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> **Lists the metric values for a resource**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="timespan"> The timespan of the query. It is a string with the following format &apos;startDateTime_ISO/endDateTime_ISO&apos;. </param>
        /// <param name="interval"> The interval (i.e. timegrain) of the query. </param>
        /// <param name="metricnames"> The names of the metrics (comma separated) to retrieve. </param>
        /// <param name="aggregation"> The list of aggregation types (comma separated) to retrieve. </param>
        /// <param name="top">
        /// The maximum number of records to retrieve.
        /// Valid only if $filter is specified.
        /// Defaults to 10.
        /// </param>
        /// <param name="orderby">
        /// The aggregation to use for sorting results and the direction of the sort.
        /// Only one order can be specified.
        /// Examples: sum asc.
        /// </param>
        /// <param name="filter"> The **$filter** is used to reduce the set of metric data returned.&lt;br&gt;Example:&lt;br&gt;Metric contains metadata A, B and C.&lt;br&gt;- Return all time series of C where A = a1 and B = b1 or b2&lt;br&gt;**$filter=A eq ???a1??? and B eq ???b1??? or B eq ???b2??? and C eq ???*???**&lt;br&gt;- Invalid variant:&lt;br&gt;**$filter=A eq ???a1??? and B eq ???b1??? and C eq ???*??? or B = ???b2???**&lt;br&gt;This is invalid because the logical or operator cannot separate two different metadata names.&lt;br&gt;- Return all time series where A = a1, B = b1 and C = c1:&lt;br&gt;**$filter=A eq ???a1??? and B eq ???b1??? and C eq ???c1???**&lt;br&gt;- Return all time series where A = a1&lt;br&gt;**$filter=A eq ???a1??? and B eq ???*??? and C eq ???*???**. </param>
        /// <param name="resultType"> Reduces the set of data collected. The syntax allowed depends on the operation. See the operation&apos;s description for details. </param>
        /// <param name="metricnamespace"> Metric namespace to query metric definitions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Models.Response> List(string resourceUri, string timespan = null, TimeSpan? interval = null, string metricnames = null, string aggregation = null, int? top = null, string orderby = null, string filter = null, ResultType? resultType = null, string metricnamespace = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricsOperations.List");
            scope.Start();
            try
            {
                return RestClient.List(resourceUri, timespan, interval, metricnames, aggregation, top, orderby, filter, resultType, metricnamespace, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
