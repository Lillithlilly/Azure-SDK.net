// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a VirtualHub along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="VirtualHubResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetVirtualHubResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetVirtualHub method.
    /// </summary>
    public partial class VirtualHubResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualHubResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualHubName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _virtualHubClientDiagnostics;
        private readonly VirtualHubsRestOperations _virtualHubRestClient;
        private readonly VirtualHubData _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualHubResource"/> class for mocking. </summary>
        protected VirtualHubResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualHubResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VirtualHubResource(ArmClient client, VirtualHubData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualHubResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualHubResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualHubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string virtualHubApiVersion);
            _virtualHubRestClient = new VirtualHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualHubApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualHubs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualHubData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of HubVirtualNetworkConnectionResources in the VirtualHub. </summary>
        /// <returns> An object representing collection of HubVirtualNetworkConnectionResources and their operations over a HubVirtualNetworkConnectionResource. </returns>
        public virtual HubVirtualNetworkConnectionCollection GetHubVirtualNetworkConnections()
        {
            return GetCachedClient(Client => new HubVirtualNetworkConnectionCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves the details of a HubVirtualNetworkConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{connectionName}
        /// Operation Id: HubVirtualNetworkConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HubVirtualNetworkConnectionResource>> GetHubVirtualNetworkConnectionAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            return await GetHubVirtualNetworkConnections().GetAsync(connectionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the details of a HubVirtualNetworkConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{connectionName}
        /// Operation Id: HubVirtualNetworkConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<HubVirtualNetworkConnectionResource> GetHubVirtualNetworkConnection(string connectionName, CancellationToken cancellationToken = default)
        {
            return GetHubVirtualNetworkConnections().Get(connectionName, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualHubRouteTableV2Resources in the VirtualHub. </summary>
        /// <returns> An object representing collection of VirtualHubRouteTableV2Resources and their operations over a VirtualHubRouteTableV2Resource. </returns>
        public virtual VirtualHubRouteTableV2Collection GetVirtualHubRouteTableV2s()
        {
            return GetCachedClient(Client => new VirtualHubRouteTableV2Collection(Client, Id));
        }

        /// <summary>
        /// Retrieves the details of a VirtualHubRouteTableV2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeTables/{routeTableName}
        /// Operation Id: VirtualHubRouteTableV2s_Get
        /// </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VirtualHubRouteTableV2Resource>> GetVirtualHubRouteTableV2Async(string routeTableName, CancellationToken cancellationToken = default)
        {
            return await GetVirtualHubRouteTableV2s().GetAsync(routeTableName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the details of a VirtualHubRouteTableV2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeTables/{routeTableName}
        /// Operation Id: VirtualHubRouteTableV2s_Get
        /// </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<VirtualHubRouteTableV2Resource> GetVirtualHubRouteTableV2(string routeTableName, CancellationToken cancellationToken = default)
        {
            return GetVirtualHubRouteTableV2s().Get(routeTableName, cancellationToken);
        }

        /// <summary> Gets a collection of BgpConnectionResources in the VirtualHub. </summary>
        /// <returns> An object representing collection of BgpConnectionResources and their operations over a BgpConnectionResource. </returns>
        public virtual BgpConnectionCollection GetBgpConnections()
        {
            return GetCachedClient(Client => new BgpConnectionCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Bgp Connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_Get
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BgpConnectionResource>> GetBgpConnectionAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            return await GetBgpConnections().GetAsync(connectionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Bgp Connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}
        /// Operation Id: VirtualHubBgpConnection_Get
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<BgpConnectionResource> GetBgpConnection(string connectionName, CancellationToken cancellationToken = default)
        {
            return GetBgpConnections().Get(connectionName, cancellationToken);
        }

        /// <summary> Gets a collection of HubIPConfigurationResources in the VirtualHub. </summary>
        /// <returns> An object representing collection of HubIPConfigurationResources and their operations over a HubIPConfigurationResource. </returns>
        public virtual HubIPConfigurationCollection GetHubIPConfigurations()
        {
            return GetCachedClient(Client => new HubIPConfigurationCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Ip configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HubIPConfigurationResource>> GetHubIPConfigurationAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            return await GetHubIPConfigurations().GetAsync(ipConfigName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Ip configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<HubIPConfigurationResource> GetHubIPConfiguration(string ipConfigName, CancellationToken cancellationToken = default)
        {
            return GetHubIPConfigurations().Get(ipConfigName, cancellationToken);
        }

        /// <summary> Gets a collection of HubRouteTableResources in the VirtualHub. </summary>
        /// <returns> An object representing collection of HubRouteTableResources and their operations over a HubRouteTableResource. </returns>
        public virtual HubRouteTableCollection GetHubRouteTables()
        {
            return GetCachedClient(Client => new HubRouteTableCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves the details of a RouteTable.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables/{routeTableName}
        /// Operation Id: HubRouteTables_Get
        /// </summary>
        /// <param name="routeTableName"> The name of the RouteTable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HubRouteTableResource>> GetHubRouteTableAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            return await GetHubRouteTables().GetAsync(routeTableName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the details of a RouteTable.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables/{routeTableName}
        /// Operation Id: HubRouteTables_Get
        /// </summary>
        /// <param name="routeTableName"> The name of the RouteTable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<HubRouteTableResource> GetHubRouteTable(string routeTableName, CancellationToken cancellationToken = default)
        {
            return GetHubRouteTables().Get(routeTableName, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of a VirtualHub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualHubResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.Get");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a VirtualHub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualHubResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.Get");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a VirtualHub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.Delete");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a VirtualHub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.Delete");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the effective routes configured for the Virtual Hub resource or the specified resource .
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/effectiveRoutes
        /// Operation Id: VirtualHubs_GetEffectiveVirtualHubRoutes
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="effectiveRoutesParameters"> Parameters supplied to get the effective routes for a specific resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> GetEffectiveVirtualHubRoutesAsync(WaitUntil waitUntil, EffectiveRoutesParameters effectiveRoutesParameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.GetEffectiveVirtualHubRoutes");
            scope.Start();
            try
            {
                var response = await _virtualHubRestClient.GetEffectiveVirtualHubRoutesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, effectiveRoutesParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateGetEffectiveVirtualHubRoutesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, effectiveRoutesParameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the effective routes configured for the Virtual Hub resource or the specified resource .
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/effectiveRoutes
        /// Operation Id: VirtualHubs_GetEffectiveVirtualHubRoutes
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="effectiveRoutesParameters"> Parameters supplied to get the effective routes for a specific resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation GetEffectiveVirtualHubRoutes(WaitUntil waitUntil, EffectiveRoutesParameters effectiveRoutesParameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.GetEffectiveVirtualHubRoutes");
            scope.Start();
            try
            {
                var response = _virtualHubRestClient.GetEffectiveVirtualHubRoutes(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, effectiveRoutesParameters, cancellationToken);
                var operation = new NetworkArmOperation(_virtualHubClientDiagnostics, Pipeline, _virtualHubRestClient.CreateGetEffectiveVirtualHubRoutesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, effectiveRoutesParameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<VirtualHubResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _virtualHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualHubResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<VirtualHubResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _virtualHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new VirtualHubResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<VirtualHubResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _virtualHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualHubResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<VirtualHubResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _virtualHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new VirtualHubResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<VirtualHubResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _virtualHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualHubResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}
        /// Operation Id: VirtualHubs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<VirtualHubResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _virtualHubClientDiagnostics.CreateScope("VirtualHubResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _virtualHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new VirtualHubResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
