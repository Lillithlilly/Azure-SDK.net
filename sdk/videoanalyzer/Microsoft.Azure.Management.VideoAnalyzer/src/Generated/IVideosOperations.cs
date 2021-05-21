// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// VideosOperations operations.
    /// </summary>
    public partial interface IVideosOperations
    {
        /// <summary>
        /// List all existing video resources.
        /// </summary>
        /// <remarks>
        /// List all existing video resources in the specified account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The Azure Video Analyzer account name.
        /// </param>
        /// <param name='top'>
        /// Specifies a non-negative integer n that limits the number of items
        /// returned from a collection. The service returns the number of
        /// available items up to but not greater than the specified value n.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<VideoEntity>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves a video resource.
        /// </summary>
        /// <remarks>
        /// Retrieves an existing video resource within an account with a given
        /// name.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The Azure Video Analyzer account name.
        /// </param>
        /// <param name='videoName'>
        /// The name of the video to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VideoEntity>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string videoName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or updates a video resource.
        /// </summary>
        /// <remarks>
        /// Creates a new video resource or updates an existing one in an
        /// account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The Azure Video Analyzer account name.
        /// </param>
        /// <param name='videoName'>
        /// The name of the video to create or update.
        /// </param>
        /// <param name='title'>
        /// Optional video title provided by the user. Value can be up to 256
        /// characters long.
        /// </param>
        /// <param name='description'>
        /// Optional video description provided by the user. Value can be up to
        /// 2048 characters long.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VideoEntity>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string videoName, string title = default(string), string description = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a video resource.
        /// </summary>
        /// <remarks>
        /// Deletes an existing video resource and its underlying data. This
        /// operation is irreversible.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The Azure Video Analyzer account name.
        /// </param>
        /// <param name='videoName'>
        /// The name of the video to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string videoName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the properties of a video resource.
        /// </summary>
        /// <remarks>
        /// Updates individual properties of an existing video resource.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The Azure Video Analyzer account name.
        /// </param>
        /// <param name='videoName'>
        /// The name of the video to update.
        /// </param>
        /// <param name='title'>
        /// Optional video title provided by the user. Value can be up to 256
        /// characters long.
        /// </param>
        /// <param name='description'>
        /// Optional video description provided by the user. Value can be up to
        /// 2048 characters long.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VideoEntity>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string videoName, string title = default(string), string description = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generates a streaming token for video playback.
        /// </summary>
        /// <remarks>
        /// Generates a streaming token used for authenticating video playback.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The Azure Video Analyzer account name.
        /// </param>
        /// <param name='videoName'>
        /// The name of the video to generate a token for playback.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VideoStreamingToken>> ListStreamingTokenWithHttpMessagesAsync(string resourceGroupName, string accountName, string videoName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all existing video resources.
        /// </summary>
        /// <remarks>
        /// List all existing video resources in the specified account.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<VideoEntity>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}