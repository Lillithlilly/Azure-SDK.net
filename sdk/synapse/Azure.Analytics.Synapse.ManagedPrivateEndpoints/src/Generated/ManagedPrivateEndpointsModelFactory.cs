// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models;

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class ManagedPrivateEndpointsModelFactory
    {
        /// <summary> Initializes new instance of ManagedPrivateEndpoint class. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="properties"> Managed private endpoint properties. </param>
        /// <returns> A new <see cref="Models.ManagedPrivateEndpoint"/> instance for mocking. </returns>
        public static ManagedPrivateEndpoint ManagedPrivateEndpoint(string id = default, string name = default, string type = default, ManagedPrivateEndpointProperties properties = default)
        {
            return new ManagedPrivateEndpoint(id, name, type, properties);
        }

        /// <summary> Initializes new instance of ManagedPrivateEndpointProperties class. </summary>
        /// <param name="privateLinkResourceId"> The ARM resource ID of the resource to which the managed private endpoint is created. </param>
        /// <param name="groupId"> The groupId to which the managed private endpoint is created. </param>
        /// <param name="provisioningState"> The managed private endpoint provisioning state. </param>
        /// <param name="connectionState"> The managed private endpoint connection state. </param>
        /// <param name="isReserved"> Denotes whether the managed private endpoint is reserved. </param>
        /// <returns> A new <see cref="Models.ManagedPrivateEndpointProperties"/> instance for mocking. </returns>
        public static ManagedPrivateEndpointProperties ManagedPrivateEndpointProperties(string privateLinkResourceId = default, string groupId = default, string provisioningState = default, ManagedPrivateEndpointConnectionState connectionState = default, bool? isReserved = default)
        {
            return new ManagedPrivateEndpointProperties(privateLinkResourceId, groupId, provisioningState, connectionState, isReserved);
        }

        /// <summary> Initializes new instance of ManagedPrivateEndpointConnectionState class. </summary>
        /// <param name="status"> The approval status. </param>
        /// <param name="description"> The managed private endpoint description. </param>
        /// <param name="actionsRequired"> The actions required on the managed private endpoint. </param>
        /// <returns> A new <see cref="Models.ManagedPrivateEndpointConnectionState"/> instance for mocking. </returns>
        public static ManagedPrivateEndpointConnectionState ManagedPrivateEndpointConnectionState(string status = default, string description = default, string actionsRequired = default)
        {
            return new ManagedPrivateEndpointConnectionState(status, description, actionsRequired);
        }
    }
}