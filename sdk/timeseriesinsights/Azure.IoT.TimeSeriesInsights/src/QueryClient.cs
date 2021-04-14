// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary>
    /// Query client that can be used to query for events, series and aggregate series on Time Series Insights.
    /// </summary>
    public class QueryClient
    {
        private readonly QueryRestClient _queryRestClient;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary>
        /// Initializes a new instance of QueryClient. This constructor should only be used for mocking purposes.
        /// </summary>
        protected QueryClient()
        {
        }

        internal QueryClient(QueryRestClient queryRestClient, ClientDiagnostics clientDiagnostics)
        {
            Argument.AssertNotNull(queryRestClient, nameof(queryRestClient));
            Argument.AssertNotNull(clientDiagnostics, nameof(clientDiagnostics));

            _queryRestClient = queryRestClient;
            _clientDiagnostics = clientDiagnostics;
        }

        /// <summary>
        /// Retrieve raw events for a given Time Series Id asynchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve raw events for.</param>
        /// <param name="startTime">Start timestamp of the time range. Events that have this timestamp are included.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded.</param>
        /// <param name="options">Optional parameters to use when querying for events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="AsyncPageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual AsyncPageable<TimeSeriesPoint> GetEventsAsync(
            TimeSeriesId timeSeriesId,
            DateTimeOffset startTime,
            DateTimeOffset endTime,
            QueryEventsRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetEvents)}");
            scope.Start();

            try
            {
                var searchSpan = new DateTimeRange(startTime, endTime);
                var queryRequest = new QueryRequest
                {
                    GetEvents = new GetEvents(timeSeriesId, searchSpan)
                };

                BuildEventsRequestOptions(options, queryRequest);

                return QueryInternalAsync(queryRequest, nameof(GetEvents), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve raw events for a given Time Series Id synchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve raw events for.</param>
        /// <param name="startTime">Start timestamp of the time range. Events that have this timestamp are included.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded.</param>
        /// <param name="options">Optional parameters to use when querying for events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="Pageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual Pageable<TimeSeriesPoint> GetEvents(
            TimeSeriesId timeSeriesId,
            DateTimeOffset startTime,
            DateTimeOffset endTime,
            QueryEventsRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetEvents)}");
            scope.Start();

            try
            {
                var searchSpan = new DateTimeRange(startTime, endTime);
                var queryRequest = new QueryRequest
                {
                    GetEvents = new GetEvents(timeSeriesId, searchSpan)
                };

                BuildEventsRequestOptions(options, queryRequest);

                return QueryInternal(queryRequest, nameof(GetEvents), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve raw events for a given Time Series Id over a specified time interval asynchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve raw events for.</param>
        /// <param name="timeSpan">The time interval over which to query data.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded. If null is provided, <c>DateTimeOffset.UtcNow</c> is used.</param>
        /// <param name="options">Optional parameters to use when querying for events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="AsyncPageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual AsyncPageable<TimeSeriesPoint> GetEventsAsync(
            TimeSeriesId timeSeriesId,
            TimeSpan timeSpan,
            DateTimeOffset? endTime = null,
            QueryEventsRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetEvents)}");
            scope.Start();

            try
            {
                DateTimeOffset rangeEndTime = endTime ?? DateTimeOffset.UtcNow;
                DateTimeOffset rangeStartTime = rangeEndTime - timeSpan;
                var searchSpan = new DateTimeRange(rangeStartTime, rangeEndTime);
                var queryRequest = new QueryRequest
                {
                    GetEvents = new GetEvents(timeSeriesId, searchSpan)
                };

                BuildEventsRequestOptions(options, queryRequest);

                return QueryInternalAsync(queryRequest, nameof(GetEvents), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve raw events for a given Time Series Id over a certain time interval synchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve raw events for.</param>
        /// <param name="timeSpan">The time interval over which to query data.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded. If null is provided, <c>DateTimeOffset.UtcNow</c> is used.</param>
        /// <param name="options">Optional parameters to use when querying for events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="Pageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual Pageable<TimeSeriesPoint> GetEvents(
            TimeSeriesId timeSeriesId,
            TimeSpan timeSpan,
            DateTimeOffset? endTime = null,
            QueryEventsRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetEvents)}");
            scope.Start();

            try
            {
                DateTimeOffset rangeEndTime = endTime ?? DateTimeOffset.UtcNow;
                DateTimeOffset rangeStartTime = rangeEndTime - timeSpan;
                var searchSpan = new DateTimeRange(rangeStartTime, rangeEndTime);
                var queryRequest = new QueryRequest
                {
                    GetEvents = new GetEvents(timeSeriesId, searchSpan)
                };

                BuildEventsRequestOptions(options, queryRequest);

                return QueryInternal(queryRequest, nameof(GetEvents), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve series events for a given Time Series Id asynchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve series events for.</param>
        /// <param name="startTime">Start timestamp of the time range. Events that have this timestamp are included.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded.</param>
        /// <param name="options">Optional parameters to use when querying for series events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="AsyncPageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual AsyncPageable<TimeSeriesPoint> GetSeriesAsync(
            TimeSeriesId timeSeriesId,
            DateTimeOffset startTime,
            DateTimeOffset endTime,
            QuerySeriesRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetSeries)}");
            scope.Start();

            try
            {
                var searchSpan = new DateTimeRange(startTime, endTime);
                var queryRequest = new QueryRequest
                {
                    GetSeries = new GetSeries(timeSeriesId, searchSpan)
                };

                BuildSeriesRequestOptions(options, queryRequest);

                return QueryInternalAsync(queryRequest, nameof(GetSeries), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve series events for a given Time Series Id synchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve series events for.</param>
        /// <param name="startTime">Start timestamp of the time range. Events that have this timestamp are included.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded.</param>
        /// <param name="options">Optional parameters to use when querying for series events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="Pageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual Pageable<TimeSeriesPoint> GetSeries(
            TimeSeriesId timeSeriesId,
            DateTimeOffset startTime,
            DateTimeOffset endTime,
            QuerySeriesRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetSeries)}");
            scope.Start();

            try
            {
                var searchSpan = new DateTimeRange(startTime, endTime);
                var queryRequest = new QueryRequest
                {
                    GetSeries = new GetSeries(timeSeriesId, searchSpan)
                };

                BuildSeriesRequestOptions(options, queryRequest);

                return QueryInternal(queryRequest, nameof(GetSeries), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve series events for a given Time Series Id over a specified time interval asynchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve series events for.</param>
        /// <param name="timeSpan">The time interval over which to query data.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded. If null is provided, <c>DateTimeOffset.UtcNow</c> is used.</param>
        /// <param name="options">Optional parameters to use when querying for series events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="AsyncPageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual AsyncPageable<TimeSeriesPoint> GetSeriesAsync(
            TimeSeriesId timeSeriesId,
            TimeSpan timeSpan,
            DateTimeOffset? endTime = null,
            QuerySeriesRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetSeries)}");
            scope.Start();

            try
            {
                DateTimeOffset rangeEndTime = endTime ?? DateTimeOffset.UtcNow;
                DateTimeOffset rangeStartTime = rangeEndTime - timeSpan;
                var searchSpan = new DateTimeRange(rangeStartTime, rangeEndTime);
                var queryRequest = new QueryRequest
                {
                    GetSeries = new GetSeries(timeSeriesId, searchSpan)
                };

                BuildSeriesRequestOptions(options, queryRequest);

                return QueryInternalAsync(queryRequest, nameof(GetSeries), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve series events for a given Time Series Id over a certain time interval synchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve series events for.</param>
        /// <param name="timeSpan">The time interval over which to query data.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded. If null is provided, <c>DateTimeOffset.UtcNow</c> is used.</param>
        /// <param name="options">Optional parameters to use when querying for series events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="Pageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual Pageable<TimeSeriesPoint> GetSeries(
            TimeSeriesId timeSeriesId,
            TimeSpan timeSpan,
            DateTimeOffset? endTime = null,
            QuerySeriesRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetSeries)}");
            scope.Start();

            try
            {
                DateTimeOffset rangeEndTime = endTime ?? DateTimeOffset.UtcNow;
                DateTimeOffset rangeStartTime = rangeEndTime - timeSpan;
                var searchSpan = new DateTimeRange(rangeStartTime, rangeEndTime);
                var queryRequest = new QueryRequest
                {
                    GetSeries = new GetSeries(timeSeriesId, searchSpan)
                };

                BuildSeriesRequestOptions(options, queryRequest);

                return QueryInternal(queryRequest, nameof(GetSeries), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve aggregated time series from events for a given Time Series Id asynchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve series events for.</param>
        /// <param name="startTime">Start timestamp of the time range. Events that have this timestamp are included.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded.</param>
        /// <param name="interval">Interval size used to group events by.</param>
        /// <param name="options">Optional parameters to use when querying for aggregated series events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="Pageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual AsyncPageable<TimeSeriesPoint> QueryAggregateSeriesAsync(
            TimeSeriesId timeSeriesId,
            DateTimeOffset startTime,
            DateTimeOffset endTime,
            TimeSpan interval,
            QueryAggregateSeriesRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(QueryAggregateSeries)}");
            scope.Start();

            try
            {
                var searchSpan = new DateTimeRange(startTime, endTime);
                var queryRequest = new QueryRequest
                {
                    AggregateSeries = new AggregateSeries(timeSeriesId, searchSpan, interval)
                };

                BuildAggregateSeriesRequestOptions(options, queryRequest);

                return QueryInternalAsync(queryRequest,nameof(QueryAggregateSeries), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve aggregated time series from events for a given Time Series Id synchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve series events for.</param>
        /// <param name="startTime">Start timestamp of the time range. Events that have this timestamp are included.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded.</param>
        /// <param name="interval">Interval size used to group events by.</param>
        /// <param name="options">Optional parameters to use when querying for aggregated series events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="Pageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual Pageable<TimeSeriesPoint> QueryAggregateSeries(
            TimeSeriesId timeSeriesId,
            DateTimeOffset startTime,
            DateTimeOffset endTime,
            TimeSpan interval,
            QueryAggregateSeriesRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(QueryAggregateSeries)}");
            scope.Start();

            try
            {
                var searchSpan = new DateTimeRange(startTime, endTime);
                var queryRequest = new QueryRequest
                {
                    AggregateSeries = new AggregateSeries(timeSeriesId, searchSpan, interval)
                };

                BuildAggregateSeriesRequestOptions(options, queryRequest);

                return QueryInternal(queryRequest, nameof(QueryAggregateSeries), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve aggregated time series from events for a given Time Series Id over a specified time interval asynchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve series events for.</param>
        /// <param name="interval">Interval size used to group events by.</param>
        /// <param name="timeSpan">The time interval over which to query data.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded. If null is provided, <c>DateTimeOffset.UtcNow</c> is used.</param>
        /// <param name="options">Optional parameters to use when querying for aggregated series events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="Pageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual AsyncPageable<TimeSeriesPoint> QueryAggregateSeriesAsync(
            TimeSeriesId timeSeriesId,
            TimeSpan interval,
            TimeSpan timeSpan,
            DateTimeOffset? endTime = null,
            QueryAggregateSeriesRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(QueryAggregateSeries)}");
            scope.Start();

            try
            {
                DateTimeOffset rangeEndTime = endTime ?? DateTimeOffset.UtcNow;
                DateTimeOffset rangeStartTime = rangeEndTime - timeSpan;
                var searchSpan = new DateTimeRange(rangeStartTime, rangeEndTime);
                var queryRequest = new QueryRequest
                {
                    AggregateSeries = new AggregateSeries(timeSeriesId, searchSpan, interval)
                };

                BuildAggregateSeriesRequestOptions(options, queryRequest);

                return QueryInternalAsync(queryRequest, nameof(QueryAggregateSeries), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve aggregated time series from events for a given Time Series Id over a specified time interval synchronously.
        /// </summary>
        /// <param name="timeSeriesId">The Time Series Id to retrieve series events for.</param>
        /// <param name="interval">Interval size used to group events by.</param>
        /// <param name="timeSpan">The time interval over which to query data.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded. If null is provided, <c>DateTimeOffset.UtcNow</c> is used.</param>
        /// <param name="options">Optional parameters to use when querying for aggregated series events.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The pageable list <see cref="Pageable{TimeSeriesPoint}"/> of Time Series points.</returns>
        public virtual Pageable<TimeSeriesPoint> QueryAggregateSeries(
            TimeSeriesId timeSeriesId,
            TimeSpan interval,
            TimeSpan timeSpan,
            DateTimeOffset? endTime = null,
            QueryAggregateSeriesRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(QueryAggregateSeries)}");
            scope.Start();

            try
            {
                DateTimeOffset rangeEndTime = endTime ?? DateTimeOffset.UtcNow;
                DateTimeOffset rangeStartTime = rangeEndTime - timeSpan;
                var searchSpan = new DateTimeRange(rangeStartTime, rangeEndTime);
                var queryRequest = new QueryRequest
                {
                    AggregateSeries = new AggregateSeries(timeSeriesId, searchSpan, interval)
                };

                BuildAggregateSeriesRequestOptions(options, queryRequest);

                return QueryInternal(queryRequest, nameof(QueryAggregateSeries), options?.StoreType?.ToString(), cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve Time Series Insights environment event schema for a given search span asynchronously.
        /// </summary>
        /// <param name="startTime">Start timestamp of the time range. Events that have this timestamp are included.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded.</param>
        /// <param name="options">Optional parameters to use when retrieving the environment event schema.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>List of event properties for the Time Series Insights environment.</returns>
        /// <remarks>
        /// Event schema is a set of property definitions. Event schema may not contain all persisted properties when there are too many properties.
        /// </remarks>
        public virtual async Task<Response<EventProperty[]>> GetEventSchemaAsync(
            DateTimeOffset startTime,
            DateTimeOffset endTime,
            EventSchemaRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetEventSchema)}");
            scope.Start();

            try
            {
                var searchSpan = new DateTimeRange(startTime, endTime);
                var eventSchemaRequest = new GetEventSchemaRequest(searchSpan);
                Response<EventSchema> getEventSchemaResponse = await _queryRestClient
                    .GetEventSchemaAsync(eventSchemaRequest, options?.StoreType?.ToString(), null, cancellationToken)
                    .ConfigureAwait(false);

                return Response.FromValue(getEventSchemaResponse.Value.Properties.ToArray(), getEventSchemaResponse.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieve Time Series Insights environment event schema for a given search span synchronously.
        /// </summary>
        /// <param name="startTime">Start timestamp of the time range. Events that have this timestamp are included.</param>
        /// <param name="endTime">End timestamp of the time range. Events that match this timestamp are excluded.</param>
        /// <param name="options">Optional parameters to use when retrieving the environment event schema.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>List of event properties for the Time Series Insights environment.</returns>
        /// <remarks>
        /// Event schema is a set of property definitions. Event schema may not contain all persisted properties when there are too many properties.
        /// </remarks>
        public virtual Response<EventProperty[]> GetEventSchema(
            DateTimeOffset startTime,
            DateTimeOffset endTime,
            EventSchemaRequestOptions options = null,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetEventSchema)}");
            scope.Start();

            try
            {
                var searchSpan = new DateTimeRange(startTime, endTime);
                var eventSchemaRequest = new GetEventSchemaRequest(searchSpan);
                Response<EventSchema> getEventSchemaResponse = _queryRestClient
                    .GetEventSchema(eventSchemaRequest, options?.StoreType?.ToString(), null, cancellationToken);

                return Response.FromValue(getEventSchemaResponse.Value.Properties.ToArray(), getEventSchemaResponse.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        private AsyncPageable<TimeSeriesPoint> QueryInternalAsync(
                    QueryRequest queryRequest,
                    string diagnosticScopeName,
                    string storeType,
                    CancellationToken cancellationToken)
        {
            async Task<Page<TimeSeriesPoint>> FirstPageFunc(int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{diagnosticScopeName}");
                scope.Start();
                try
                {
                    Response<QueryResultPage> response = await _queryRestClient
                        .ExecuteAsync(queryRequest, storeType, null, null, cancellationToken)
                        .ConfigureAwait(false);

                    TimeSeriesPoint[] points = createQueryResponse(response.Value);

                    return Page.FromValues(points, response.Value.ContinuationToken, response.GetRawResponse());
                }
                catch (Exception ex)
                {
                    scope.Failed(ex);
                    throw;
                }
            }

            async Task<Page<TimeSeriesPoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{diagnosticScopeName}");
                scope.Start();
                try
                {
                    Response<QueryResultPage> response = await _queryRestClient
                        .ExecuteAsync(queryRequest, storeType, nextLink, null, cancellationToken)
                        .ConfigureAwait(false);

                    TimeSeriesPoint[] points = createQueryResponse(response.Value);

                    return Page.FromValues(points, response.Value.ContinuationToken, response.GetRawResponse());
                }
                catch (Exception ex)
                {
                    scope.Failed(ex);
                    throw;
                }
            }

            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        private Pageable<TimeSeriesPoint> QueryInternal(
            QueryRequest queryRequest,
            string diagnosticScopeName,
            string storeType,
            CancellationToken cancellationToken)
        {
            Page<TimeSeriesPoint> FirstPageFunc(int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{diagnosticScopeName}");
                scope.Start();
                try
                {
                    Response<QueryResultPage> response = _queryRestClient
                        .Execute(queryRequest, storeType, null, null, cancellationToken);

                    TimeSeriesPoint[] points = createQueryResponse(response.Value);

                    return Page.FromValues(points, response.Value.ContinuationToken, response.GetRawResponse());
                }
                catch (Exception ex)
                {
                    scope.Failed(ex);
                    throw;
                }
            }

            Page<TimeSeriesPoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{diagnosticScopeName}");
                scope.Start();
                try
                {
                    Response<QueryResultPage> response = _queryRestClient
                        .Execute(queryRequest, storeType, nextLink, null, cancellationToken);

                    TimeSeriesPoint[] points = createQueryResponse(response.Value);

                    return Page.FromValues(points, response.Value.ContinuationToken, response.GetRawResponse());
                }
                catch (Exception ex)
                {
                    scope.Failed(ex);
                    throw;
                }
            }

            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        private static void BuildEventsRequestOptions(QueryEventsRequestOptions options, QueryRequest queryRequest)
        {
            if (options != null)
            {
                if (options.Filter != null)
                {
                    queryRequest.GetEvents.Filter = new TimeSeriesExpression(options.Filter);
                }

                if (options.ProjectedProperties != null)
                {
                    foreach (EventProperty projectedProperty in options.ProjectedProperties)
                    {
                        queryRequest.GetEvents.ProjectedProperties.Add(projectedProperty);
                    }
                }

                queryRequest.GetEvents.Take = options.MaximumNumberOfEvents;
            }
        }

        private static void BuildSeriesRequestOptions(QuerySeriesRequestOptions options, QueryRequest queryRequest)
        {
            if (options != null)
            {
                if (options.Filter != null)
                {
                    queryRequest.GetSeries.Filter = new TimeSeriesExpression(options.Filter);
                }

                if (options.ProjectedVariables != null)
                {
                    foreach (string projectedVariable in options.ProjectedVariables)
                    {
                        queryRequest.GetSeries.ProjectedVariables.Add(projectedVariable);
                    }
                }

                if (options.InlineVariables != null)
                {
                    foreach (string inlineVariableKey in options.InlineVariables.Keys)
                    {
                        queryRequest.GetSeries.InlineVariables[inlineVariableKey] = options.InlineVariables[inlineVariableKey];
                    }
                }

                queryRequest.GetSeries.Take = options.MaximumNumberOfEvents;
            }
        }

        private static TimeSeriesPoint[] createQueryResponse(QueryResultPage value)
        {
            var result = new List<TimeSeriesPoint>();

            for (int i = 0; i < value.Timestamps.Count; i++)
            {
                DateTimeOffset timestamp = value.Timestamps[i];
                var point = new TimeSeriesPoint(timestamp);

                foreach (PropertyValues property in value.Properties)
                {
                    var eventProperty = new EventProperty(property.Name, property.Type);
                    point.Values[eventProperty] = property.Values[i];
                }

                result.Add(point);
            }

            return result.ToArray();
        }

        private static void BuildAggregateSeriesRequestOptions(QueryAggregateSeriesRequestOptions options, QueryRequest queryRequest)
        {
            if (options != null)
            {
                if (options.Filter != null)
                {
                    queryRequest.AggregateSeries.Filter = new TimeSeriesExpression(options.Filter);
                }

                if (options.ProjectedVariables != null)
                {
                    foreach (string projectedVariable in options.ProjectedVariables)
                    {
                        queryRequest.AggregateSeries.ProjectedVariables.Add(projectedVariable);
                    }
                }

                if (options.InlineVariables != null)
                {
                    foreach (string inlineVariableKey in options.InlineVariables.Keys)
                    {
                        queryRequest.AggregateSeries.InlineVariables[inlineVariableKey] = options.InlineVariables[inlineVariableKey];
                    }
                }
            }
        }
    }
}
