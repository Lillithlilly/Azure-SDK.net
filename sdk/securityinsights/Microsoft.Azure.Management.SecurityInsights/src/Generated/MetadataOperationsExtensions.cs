// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MetadataOperations.
    /// </summary>
    public static partial class MetadataOperationsExtensions
    {
            /// <summary>
            /// List of all metadata
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition. Optional.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results. Optional.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results. Optional.
            /// </param>
            /// <param name='skip'>
            /// Used to skip n elements in the OData query (offset). Returns a nextLink to
            /// the next page of results if there are any left.
            /// </param>
            public static IPage<MetadataModel> List(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string filter = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, filter, orderby, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of all metadata
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition. Optional.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results. Optional.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results. Optional.
            /// </param>
            /// <param name='skip'>
            /// Used to skip n elements in the OData query (offset). Returns a nextLink to
            /// the next page of results if there are any left.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MetadataModel>> ListAsync(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string filter = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, filter, orderby, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a Metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='metadataName'>
            /// The Metadata name.
            /// </param>
            public static MetadataModel Get(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string metadataName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, metadataName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='metadataName'>
            /// The Metadata name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MetadataModel> GetAsync(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string metadataName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, metadataName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='metadataName'>
            /// The Metadata name.
            /// </param>
            public static void Delete(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string metadataName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, metadataName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='metadataName'>
            /// The Metadata name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string metadataName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, metadataName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create a Metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='metadataName'>
            /// The Metadata name.
            /// </param>
            /// <param name='metadata'>
            /// Metadata resource.
            /// </param>
            public static MetadataModel Create(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string metadataName, MetadataModel metadata)
            {
                return operations.CreateAsync(resourceGroupName, workspaceName, metadataName, metadata).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a Metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='metadataName'>
            /// The Metadata name.
            /// </param>
            /// <param name='metadata'>
            /// Metadata resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MetadataModel> CreateAsync(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string metadataName, MetadataModel metadata, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, workspaceName, metadataName, metadata, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing Metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='metadataName'>
            /// The Metadata name.
            /// </param>
            /// <param name='metadataPatch'>
            /// Partial metadata request.
            /// </param>
            public static MetadataModel Update(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string metadataName, MetadataPatch metadataPatch)
            {
                return operations.UpdateAsync(resourceGroupName, workspaceName, metadataName, metadataPatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing Metadata.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='metadataName'>
            /// The Metadata name.
            /// </param>
            /// <param name='metadataPatch'>
            /// Partial metadata request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MetadataModel> UpdateAsync(this IMetadataOperations operations, string resourceGroupName, string workspaceName, string metadataName, MetadataPatch metadataPatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, metadataName, metadataPatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List of all metadata
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<MetadataModel> ListNext(this IMetadataOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of all metadata
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MetadataModel>> ListNextAsync(this IMetadataOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
