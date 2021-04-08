// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary>
    /// Provide helper methods that can be used with Time Series Insights <see cref="QueryClient"/>.
    /// </summary>
    public static class QueryHelpers
    {
        /// <summary>
        /// Convert an AsyncPageable into a List.
        /// </summary>
        /// <typeparam name="T">Type of elements.</typeparam>
        /// <param name="pageable">The AsyncPageable.</param>
        /// <returns>A list of the elements.</returns>
        public static async Task<List<T>> ToListAsync<T>(this AsyncPageable<T> pageable)
        {
            var values = new List<T>();

            await foreach (T value in pageable.ConfigureAwait(false))
            {
                values.Add(value);
            }

            return values;
        }
    }
}
