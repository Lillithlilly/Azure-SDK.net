// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Search
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest.Azure;
    using Models;

    internal partial class DataSourcesOperations
    {
        /// <summary>
        /// Creates a new datasource or updates a datasource if it already
        /// exists.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Update-Data-Source" />
        /// </summary>
        /// <param name='dataSource'>
        /// The definition of the datasource to create or update.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation.
        /// </param>
        /// <param name='accessCondition'>
        /// Additional parameters for the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null.
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null.
        /// </exception>
        /// <returns>
        /// A response object containing the response body and response headers.
        /// </returns>
        public Task<AzureOperationResponse<DataSource>> CreateOrUpdateWithHttpMessagesAsync(DataSource dataSource, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateOrUpdateWithHttpMessagesAsync(dataSource?.Name, dataSource, searchRequestOptions, accessCondition, customHeaders, cancellationToken);
        }

        /// <summary>
        /// Determines whether or not the given data source exists in the search service.
        /// </summary>
        /// <param name="dataSourceName">
        /// The name of the data source.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null.
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null.
        /// </exception>
        /// <returns>
        /// A response with the value <c>true</c> if the data source exists; <c>false</c> otherwise.
        /// </returns>
        public Task<AzureOperationResponse<bool>> ExistsWithHttpMessagesAsync(
            string dataSourceName,
            SearchRequestOptions searchRequestOptions = default(SearchRequestOptions),
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExistsHelper.ExistsFromGetResponse(() =>
                this.GetWithHttpMessagesAsync(dataSourceName, searchRequestOptions, customHeaders, cancellationToken));
        }
    }
}
