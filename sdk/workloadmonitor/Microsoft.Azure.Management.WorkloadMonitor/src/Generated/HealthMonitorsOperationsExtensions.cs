// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WorkloadMonitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HealthMonitorsOperations.
    /// </summary>
    public static partial class HealthMonitorsOperationsExtensions
    {
            /// <summary>
            /// Get the current health status of all monitors of a virtual machine.
            /// Optional parameters: $expand (retrieve the monitor's evidence and
            /// configuration) and $filter (filter by monitor name).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscription Id of the virtual machine.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group of the virtual machine.
            /// </param>
            /// <param name='providerName'>
            /// The provider name (ex: Microsoft.Compute for virtual machines).
            /// </param>
            /// <param name='resourceCollectionName'>
            /// The resource collection name (ex: virtualMachines for virtual machines).
            /// </param>
            /// <param name='resourceName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='filter'>
            /// Optionally filter by monitor name. Example: $filter=monitorName eq
            /// 'logical-disks|C:|disk-free-space-mb.'
            /// </param>
            /// <param name='expand'>
            /// Optionally expand the monitor???s evidence and/or configuration. Example:
            /// $expand=evidence,configuration.
            /// </param>
            public static IPage<HealthMonitor> List(this IHealthMonitorsOperations operations, string subscriptionId, string resourceGroupName, string providerName, string resourceCollectionName, string resourceName, string filter = default(string), string expand = default(string))
            {
                return operations.ListAsync(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, filter, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the current health status of all monitors of a virtual machine.
            /// Optional parameters: $expand (retrieve the monitor's evidence and
            /// configuration) and $filter (filter by monitor name).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscription Id of the virtual machine.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group of the virtual machine.
            /// </param>
            /// <param name='providerName'>
            /// The provider name (ex: Microsoft.Compute for virtual machines).
            /// </param>
            /// <param name='resourceCollectionName'>
            /// The resource collection name (ex: virtualMachines for virtual machines).
            /// </param>
            /// <param name='resourceName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='filter'>
            /// Optionally filter by monitor name. Example: $filter=monitorName eq
            /// 'logical-disks|C:|disk-free-space-mb.'
            /// </param>
            /// <param name='expand'>
            /// Optionally expand the monitor???s evidence and/or configuration. Example:
            /// $expand=evidence,configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HealthMonitor>> ListAsync(this IHealthMonitorsOperations operations, string subscriptionId, string resourceGroupName, string providerName, string resourceCollectionName, string resourceName, string filter = default(string), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, filter, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the current health status of a monitor of a virtual machine. Optional
            /// parameter: $expand (retrieve the monitor's evidence and configuration).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscription Id of the virtual machine.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group of the virtual machine.
            /// </param>
            /// <param name='providerName'>
            /// The provider name (ex: Microsoft.Compute for virtual machines).
            /// </param>
            /// <param name='resourceCollectionName'>
            /// The resource collection name (ex: virtualMachines for virtual machines).
            /// </param>
            /// <param name='resourceName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='monitorId'>
            /// The monitor Id of the virtual machine.
            /// </param>
            /// <param name='expand'>
            /// Optionally expand the monitor???s evidence and/or configuration. Example:
            /// $expand=evidence,configuration.
            /// </param>
            public static HealthMonitor Get(this IHealthMonitorsOperations operations, string subscriptionId, string resourceGroupName, string providerName, string resourceCollectionName, string resourceName, string monitorId, string expand = default(string))
            {
                return operations.GetAsync(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the current health status of a monitor of a virtual machine. Optional
            /// parameter: $expand (retrieve the monitor's evidence and configuration).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscription Id of the virtual machine.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group of the virtual machine.
            /// </param>
            /// <param name='providerName'>
            /// The provider name (ex: Microsoft.Compute for virtual machines).
            /// </param>
            /// <param name='resourceCollectionName'>
            /// The resource collection name (ex: virtualMachines for virtual machines).
            /// </param>
            /// <param name='resourceName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='monitorId'>
            /// The monitor Id of the virtual machine.
            /// </param>
            /// <param name='expand'>
            /// Optionally expand the monitor???s evidence and/or configuration. Example:
            /// $expand=evidence,configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HealthMonitor> GetAsync(this IHealthMonitorsOperations operations, string subscriptionId, string resourceGroupName, string providerName, string resourceCollectionName, string resourceName, string monitorId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the health state changes of a monitor of a virtual machine within the
            /// provided time window (default is the last 24 hours). Optional parameters:
            /// $expand (retrieve the monitor's evidence and configuration) and $filter
            /// (filter by heartbeat condition).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscription Id of the virtual machine.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group of the virtual machine.
            /// </param>
            /// <param name='providerName'>
            /// The provider name (ex: Microsoft.Compute for virtual machines).
            /// </param>
            /// <param name='resourceCollectionName'>
            /// The resource collection name (ex: virtualMachines for virtual machines).
            /// </param>
            /// <param name='resourceName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='monitorId'>
            /// The monitor Id of the virtual machine.
            /// </param>
            /// <param name='filter'>
            /// Optionally filter by heartbeat condition. Example: $filter=isHeartbeat eq
            /// false.
            /// </param>
            /// <param name='expand'>
            /// Optionally expand the monitor???s evidence and/or configuration. Example:
            /// $expand=evidence,configuration.
            /// </param>
            /// <param name='startTimestampUtc'>
            /// The start of the time window.
            /// </param>
            /// <param name='endTimestampUtc'>
            /// The end of the time window.
            /// </param>
            public static IPage<HealthMonitorStateChange> ListStateChanges(this IHealthMonitorsOperations operations, string subscriptionId, string resourceGroupName, string providerName, string resourceCollectionName, string resourceName, string monitorId, string filter = default(string), string expand = default(string), System.DateTime? startTimestampUtc = default(System.DateTime?), System.DateTime? endTimestampUtc = default(System.DateTime?))
            {
                return operations.ListStateChangesAsync(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId, filter, expand, startTimestampUtc, endTimestampUtc).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the health state changes of a monitor of a virtual machine within the
            /// provided time window (default is the last 24 hours). Optional parameters:
            /// $expand (retrieve the monitor's evidence and configuration) and $filter
            /// (filter by heartbeat condition).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscription Id of the virtual machine.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group of the virtual machine.
            /// </param>
            /// <param name='providerName'>
            /// The provider name (ex: Microsoft.Compute for virtual machines).
            /// </param>
            /// <param name='resourceCollectionName'>
            /// The resource collection name (ex: virtualMachines for virtual machines).
            /// </param>
            /// <param name='resourceName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='monitorId'>
            /// The monitor Id of the virtual machine.
            /// </param>
            /// <param name='filter'>
            /// Optionally filter by heartbeat condition. Example: $filter=isHeartbeat eq
            /// false.
            /// </param>
            /// <param name='expand'>
            /// Optionally expand the monitor???s evidence and/or configuration. Example:
            /// $expand=evidence,configuration.
            /// </param>
            /// <param name='startTimestampUtc'>
            /// The start of the time window.
            /// </param>
            /// <param name='endTimestampUtc'>
            /// The end of the time window.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HealthMonitorStateChange>> ListStateChangesAsync(this IHealthMonitorsOperations operations, string subscriptionId, string resourceGroupName, string providerName, string resourceCollectionName, string resourceName, string monitorId, string filter = default(string), string expand = default(string), System.DateTime? startTimestampUtc = default(System.DateTime?), System.DateTime? endTimestampUtc = default(System.DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStateChangesWithHttpMessagesAsync(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId, filter, expand, startTimestampUtc, endTimestampUtc, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the health state change of a monitor of a virtual machine at the
            /// provided timestamp. Optional parameter: $expand (retrieve the monitor's
            /// evidence and configuration).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscription Id of the virtual machine.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group of the virtual machine.
            /// </param>
            /// <param name='providerName'>
            /// The provider name (ex: Microsoft.Compute for virtual machines).
            /// </param>
            /// <param name='resourceCollectionName'>
            /// The resource collection name (ex: virtualMachines for virtual machines).
            /// </param>
            /// <param name='resourceName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='monitorId'>
            /// The monitor Id of the virtual machine.
            /// </param>
            /// <param name='timestampUnix'>
            /// The timestamp of the state change (unix format).
            /// </param>
            /// <param name='expand'>
            /// Optionally expand the monitor???s evidence and/or configuration. Example:
            /// $expand=evidence,configuration.
            /// </param>
            public static HealthMonitorStateChange GetStateChange(this IHealthMonitorsOperations operations, string subscriptionId, string resourceGroupName, string providerName, string resourceCollectionName, string resourceName, string monitorId, string timestampUnix, string expand = default(string))
            {
                return operations.GetStateChangeAsync(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId, timestampUnix, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the health state change of a monitor of a virtual machine at the
            /// provided timestamp. Optional parameter: $expand (retrieve the monitor's
            /// evidence and configuration).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscription Id of the virtual machine.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group of the virtual machine.
            /// </param>
            /// <param name='providerName'>
            /// The provider name (ex: Microsoft.Compute for virtual machines).
            /// </param>
            /// <param name='resourceCollectionName'>
            /// The resource collection name (ex: virtualMachines for virtual machines).
            /// </param>
            /// <param name='resourceName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='monitorId'>
            /// The monitor Id of the virtual machine.
            /// </param>
            /// <param name='timestampUnix'>
            /// The timestamp of the state change (unix format).
            /// </param>
            /// <param name='expand'>
            /// Optionally expand the monitor???s evidence and/or configuration. Example:
            /// $expand=evidence,configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HealthMonitorStateChange> GetStateChangeAsync(this IHealthMonitorsOperations operations, string subscriptionId, string resourceGroupName, string providerName, string resourceCollectionName, string resourceName, string monitorId, string timestampUnix, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStateChangeWithHttpMessagesAsync(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId, timestampUnix, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the current health status of all monitors of a virtual machine.
            /// Optional parameters: $expand (retrieve the monitor's evidence and
            /// configuration) and $filter (filter by monitor name).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<HealthMonitor> ListNext(this IHealthMonitorsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the current health status of all monitors of a virtual machine.
            /// Optional parameters: $expand (retrieve the monitor's evidence and
            /// configuration) and $filter (filter by monitor name).
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
            public static async Task<IPage<HealthMonitor>> ListNextAsync(this IHealthMonitorsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the health state changes of a monitor of a virtual machine within the
            /// provided time window (default is the last 24 hours). Optional parameters:
            /// $expand (retrieve the monitor's evidence and configuration) and $filter
            /// (filter by heartbeat condition).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<HealthMonitorStateChange> ListStateChangesNext(this IHealthMonitorsOperations operations, string nextPageLink)
            {
                return operations.ListStateChangesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the health state changes of a monitor of a virtual machine within the
            /// provided time window (default is the last 24 hours). Optional parameters:
            /// $expand (retrieve the monitor's evidence and configuration) and $filter
            /// (filter by heartbeat condition).
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
            public static async Task<IPage<HealthMonitorStateChange>> ListStateChangesNextAsync(this IHealthMonitorsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStateChangesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
