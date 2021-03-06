// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ClustersOperations.
    /// </summary>
    public static partial class ClustersOperationsExtensions
    {
            /// <summary>
            /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed
            /// by Azure region.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static AvailableClustersList ListAvailableClusterRegion(this IClustersOperations operations)
            {
                return operations.ListAvailableClusterRegionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed
            /// by Azure region.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailableClustersList> ListAvailableClusterRegionAsync(this IClustersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAvailableClusterRegionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Cluster> ListBySubscription(this IClustersOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Cluster>> ListBySubscriptionAsync(this IClustersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            public static IPage<Cluster> ListByResourceGroup(this IClustersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Cluster>> ListByResourceGroupAsync(this IClustersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the resource description of the specified Event Hubs Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            public static Cluster Get(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.GetAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the resource description of the specified Event Hubs Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> GetAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an instance of an Event Hubs Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for creating a eventhub cluster resource.
            /// </param>
            public static Cluster CreateOrUpdate(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an instance of an Event Hubs Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for creating a eventhub cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> CreateOrUpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies mutable properties on the Event Hubs Cluster. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the Event Hubs Cluster which should be updated.
            /// </param>
            public static Cluster Update(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.UpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies mutable properties on the Event Hubs Cluster. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the Event Hubs Cluster which should be updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> UpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Event Hubs Cluster. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            public static void Delete(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Event Hubs Cluster. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all Event Hubs Namespace IDs in an Event Hubs Dedicated Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            public static EHNamespaceIdListResult ListNamespaces(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListNamespacesAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all Event Hubs Namespace IDs in an Event Hubs Dedicated Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EHNamespaceIdListResult> ListNamespacesAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNamespacesWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an instance of an Event Hubs Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for creating a eventhub cluster resource.
            /// </param>
            public static Cluster BeginCreateOrUpdate(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an instance of an Event Hubs Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for creating a eventhub cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> BeginCreateOrUpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Modifies mutable properties on the Event Hubs Cluster. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the Event Hubs Cluster which should be updated.
            /// </param>
            public static Cluster BeginUpdate(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies mutable properties on the Event Hubs Cluster. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the Event Hubs Cluster which should be updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> BeginUpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Event Hubs Cluster. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            public static void BeginDelete(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Event Hubs Cluster. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Event Hubs Cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Cluster> ListBySubscriptionNext(this IClustersOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group
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
            public static async Task<IPage<Cluster>> ListBySubscriptionNextAsync(this IClustersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Cluster> ListByResourceGroupNext(this IClustersOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available Event Hubs Clusters within an ARM resource group
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
            public static async Task<IPage<Cluster>> ListByResourceGroupNextAsync(this IClustersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
