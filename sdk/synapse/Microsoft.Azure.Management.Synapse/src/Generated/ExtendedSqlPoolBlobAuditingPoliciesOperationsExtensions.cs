// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExtendedSqlPoolBlobAuditingPoliciesOperations.
    /// </summary>
    public static partial class ExtendedSqlPoolBlobAuditingPoliciesOperationsExtensions
    {
            /// <summary>
            /// Gets an extended Sql pool's blob auditing policy.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            public static ExtendedSqlPoolBlobAuditingPolicy Get(this IExtendedSqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an extended Sql pool's blob auditing policy.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedSqlPoolBlobAuditingPolicy> GetAsync(this IExtendedSqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an extended Sql pool's blob auditing policy.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='parameters'>
            /// The extended Sql pool blob auditing policy.
            /// </param>
            public static ExtendedSqlPoolBlobAuditingPolicy CreateOrUpdate(this IExtendedSqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, ExtendedSqlPoolBlobAuditingPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an extended Sql pool's blob auditing policy.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='parameters'>
            /// The extended Sql pool blob auditing policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedSqlPoolBlobAuditingPolicy> CreateOrUpdateAsync(this IExtendedSqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, ExtendedSqlPoolBlobAuditingPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists extended auditing settings of a Sql pool.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            public static IPage<ExtendedSqlPoolBlobAuditingPolicy> ListBySqlPool(this IExtendedSqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                return operations.ListBySqlPoolAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists extended auditing settings of a Sql pool.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExtendedSqlPoolBlobAuditingPolicy>> ListBySqlPoolAsync(this IExtendedSqlPoolBlobAuditingPoliciesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySqlPoolWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists extended auditing settings of a Sql pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExtendedSqlPoolBlobAuditingPolicy> ListBySqlPoolNext(this IExtendedSqlPoolBlobAuditingPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListBySqlPoolNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists extended auditing settings of a Sql pool.
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
            public static async Task<IPage<ExtendedSqlPoolBlobAuditingPolicy>> ListBySqlPoolNextAsync(this IExtendedSqlPoolBlobAuditingPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySqlPoolNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
