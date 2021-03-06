// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureStackHCI
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ArcSettingsOperations.
    /// </summary>
    public static partial class ArcSettingsOperationsExtensions
    {
            /// <summary>
            /// Get ArcSetting resources of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            public static IPage<ArcSetting> ListByCluster(this IArcSettingsOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListByClusterAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get ArcSetting resources of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ArcSetting>> ListByClusterAsync(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByClusterWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get ArcSetting resource details of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='arcSettingName'>
            /// The name of the proxy resource holding details of HCI ArcSetting
            /// information.
            /// </param>
            public static ArcSetting Get(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, string arcSettingName)
            {
                return operations.GetAsync(resourceGroupName, clusterName, arcSettingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get ArcSetting resource details of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='arcSettingName'>
            /// The name of the proxy resource holding details of HCI ArcSetting
            /// information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArcSetting> GetAsync(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, string arcSettingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, arcSettingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create ArcSetting for HCI cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='arcSettingName'>
            /// The name of the proxy resource holding details of HCI ArcSetting
            /// information.
            /// </param>
            /// <param name='arcSetting'>
            /// Parameters supplied to the Create ArcSetting resource for this HCI cluster.
            /// </param>
            public static ArcSetting Create(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, string arcSettingName, ArcSetting arcSetting)
            {
                return operations.CreateAsync(resourceGroupName, clusterName, arcSettingName, arcSetting).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create ArcSetting for HCI cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='arcSettingName'>
            /// The name of the proxy resource holding details of HCI ArcSetting
            /// information.
            /// </param>
            /// <param name='arcSetting'>
            /// Parameters supplied to the Create ArcSetting resource for this HCI cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArcSetting> CreateAsync(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, string arcSettingName, ArcSetting arcSetting, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, clusterName, arcSettingName, arcSetting, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete ArcSetting resource details of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='arcSettingName'>
            /// The name of the proxy resource holding details of HCI ArcSetting
            /// information.
            /// </param>
            public static void Delete(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, string arcSettingName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName, arcSettingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete ArcSetting resource details of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='arcSettingName'>
            /// The name of the proxy resource holding details of HCI ArcSetting
            /// information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, string arcSettingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, arcSettingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete ArcSetting resource details of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='arcSettingName'>
            /// The name of the proxy resource holding details of HCI ArcSetting
            /// information.
            /// </param>
            public static void BeginDelete(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, string arcSettingName)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName, arcSettingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete ArcSetting resource details of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='arcSettingName'>
            /// The name of the proxy resource holding details of HCI ArcSetting
            /// information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IArcSettingsOperations operations, string resourceGroupName, string clusterName, string arcSettingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, arcSettingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get ArcSetting resources of HCI Cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ArcSetting> ListByClusterNext(this IArcSettingsOperations operations, string nextPageLink)
            {
                return operations.ListByClusterNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get ArcSetting resources of HCI Cluster.
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
            public static async Task<IPage<ArcSetting>> ListByClusterNextAsync(this IArcSettingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByClusterNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
