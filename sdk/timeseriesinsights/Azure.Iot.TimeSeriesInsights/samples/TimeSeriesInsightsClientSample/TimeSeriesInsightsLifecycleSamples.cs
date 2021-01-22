// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Iot.TimeSeriesInsights.Models;
using static Azure.Iot.TimeSeriesInsights.Samples.SampleLogger;

namespace Azure.Iot.TimeSeriesInsights.Samples
{
    internal class TimeSeriesInsightsLifecycleSamples
    {
        private readonly string tsiEndpointName;
        private readonly TimeSeriesInsightsClient client;

        public TimeSeriesInsightsLifecycleSamples(TimeSeriesInsightsClient tsiClient, string tsiEndpointName)
        {
            this.tsiEndpointName = tsiEndpointName;
            client = tsiClient;
        }

        /// <summary>
        /// This sample is a placeholder to demo the snippet generation.
        /// </summary>
        public async Task RunSamplesAsync()
        {
            await GetRawEvents_VCurrent().ConfigureAwait(false);
        }

        private async Task GetRawEvents_VCurrent()
        {
            try
            {
                var tsId = new List<string>() { "18", "2", "1" };
                DateTimeRange range = CreateDateTimeRange();

                QueryRequest requestParameters = new QueryRequest
                {
                    GetEvents = new GetEvents(tsId, range)
                };

                AsyncPageable<QueryResultItem> rawEvents = client.ExecuteQuery(requestParameters);
                await foreach (QueryResultItem item in rawEvents)
                {
                    // process the raw event
                }
            }
            catch (Exception ex)
            {
            }
        }

        private async Task GetRawEvents_VNext()
        {
            try
            {
                var tsId = new List<string>() { "18", "2", "1" };
                DateTimeRange range = CreateDateTimeRange();

                var getRequestParameters = new GetEvents(tsId, range);
                AsyncPageable<QueryResultItem> rawEvents = client.QueryRawEventAsyncVNext(getRequestParameters);
            }
        }

        private async Task GetRawEvents_VOverload()
        {
            try
            {
                var tsId = new List<string>() { "18", "2", "1" };
                DateTimeRange range = CreateDateTimeRange();

                QueryGetEventsRequest parameters = new QueryGetEventsRequest()
                {
                    GetEvents = new GetEvents(tsId, range)
                };

                AsyncPageable<QueryResultItem> asyncPageable = client.GetRawEvents(parameters);
                await foreach (QueryResultItem item in asyncPageable)
                {
                    // process the raw event
                }
            }
            catch (Exception ex)
            {

            }
        }

        private static DateTimeRange CreateDateTimeRange()
        {
            DateTime fromDate = new DateTime(2020, 12, 29, 8, 30, 0, DateTimeKind.Utc);
            DateTimeOffset from = new DateTimeOffset(fromDate);

            DateTime toDate = new DateTime(2021, 1, 9, 8, 30, 0, DateTimeKind.Utc);
            DateTimeOffset to = new DateTimeOffset(toDate);

            DateTimeRange range = new DateTimeRange(from, to);
            return range;
        }

    }
}
