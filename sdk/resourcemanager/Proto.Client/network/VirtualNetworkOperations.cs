﻿using Azure;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Proto.Network
{
    /// <summary>
    /// A class representing the operations that can be performed over a specific virtual nerwork.
    /// </summary>
    public class VirtualNetworkOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, VirtualNetwork>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualNetworkOperations"/> class.
        /// </summary>
        /// <param name="genericOperations"> An instance of <see cref="GenericResourceOperations"/> that has an id for a virtual nerwork. </param>
        internal VirtualNetworkOperations(GenericResourceOperations genericOperations)
            : base(genericOperations, genericOperations.Id)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualNetworkOperations"/> class.
        /// </summary>
        /// <param name="resourceGroup"> The client parameters to use in these operations. </param>
        /// <param name="vnetName"> The name of the virtual network to use. </param>
        internal VirtualNetworkOperations(ResourceGroupOperations resourceGroup, string vnetName)
            : base(resourceGroup, resourceGroup.Id.AppendProviderResource(ResourceType.Namespace, ResourceType.Type, vnetName))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualNetworkOperations"/> class.
        /// </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected VirtualNetworkOperations(ResourceOperationsBase options, ResourceIdentifier id)
            : base(options, id)
        {
        }

        /// <summary>
        /// Gets the resource type definition for a virtual nerwork.
        /// </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualNetworks";

        /// <summary>
        /// Gets the valid resource type definition for a virtual nerwork.
        /// </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        private VirtualNetworksOperations Operations => new NetworkManagementClient(
            Id.SubscriptionId,
            BaseUri,
            Credential,
            ClientOptions.Convert<NetworkManagementClientOptions>()).VirtualNetworks;

        /// <inheritdoc/>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            return Operations.StartDelete(Id.ResourceGroupName, Id.Name, cancellationToken).WaitForCompletionAsync(cancellationToken).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <inheritdoc/>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            return (await Operations.StartDeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken)).WaitForCompletionAsync(cancellationToken).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <inheritdoc/>
        public Operation StartDelete(CancellationToken cancellationToken = default)
        {
            return new PhVoidArmOperation(Operations.StartDelete(Id.ResourceGroupName, Id.Name, cancellationToken));
        }

        /// <inheritdoc/>
        public async Task<Operation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            return new PhVoidArmOperation(await Operations.StartDeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken));
        }

        /// <inheritdoc/>
        public override Response<VirtualNetwork> Get(CancellationToken cancellationToken = default)
        {
            var response = Operations.Get(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
            return Response.FromValue(new VirtualNetwork(this, new VirtualNetworkData(response.Value)), response.GetRawResponse());
        }

        /// <inheritdoc/>
        public async override Task<Response<VirtualNetwork>> GetAsync(CancellationToken cancellationToken = default)
        {
            var response = await Operations.GetAsync(Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
            return Response.FromValue(new VirtualNetwork(this, new VirtualNetworkData(response.Value)), response.GetRawResponse());
        }

        /// <inheritdoc/>
        public Response<VirtualNetwork> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            var resource = GetResource();
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(resource.Data.Tags);
            patchable.Tags[key] = value;
            var response = Operations.UpdateTags(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
            return Response.FromValue(new VirtualNetwork(this, new VirtualNetworkData(response.Value)), response.GetRawResponse());
        }

        /// <inheritdoc/>
        public async Task<Response<VirtualNetwork>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            var resource = await GetResourceAsync(cancellationToken);
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(resource.Data.Tags);
            patchable.Tags[key] = value;
            var response = await Operations.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
            return Response.FromValue(new VirtualNetwork(this, new VirtualNetworkData(response.Value)), response.GetRawResponse());
        }

        /// <inheritdoc/>
        public Operation<VirtualNetwork> StartAddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            var resource = GetResource();
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(resource.Data.Tags);
            patchable.Tags[key] = value;
            return new PhArmOperation<VirtualNetwork, Azure.ResourceManager.Network.Models.VirtualNetwork>(
                Operations.UpdateTags(Id.ResourceGroupName, Id.Name, patchable, cancellationToken),
                n => new VirtualNetwork(this, new VirtualNetworkData(n)));
        }

        /// <inheritdoc/>
        public async Task<Operation<VirtualNetwork>> StartAddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            var resource = await GetResourceAsync(cancellationToken);
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(resource.Data.Tags);
            patchable.Tags[key] = value;
            return new PhArmOperation<VirtualNetwork, Azure.ResourceManager.Network.Models.VirtualNetwork>(
                await Operations.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken),
                n => new VirtualNetwork(this, new VirtualNetworkData(n)));
        }

        /// <summary>
        /// Gets a list of subnet in the virtual nerwork.
        /// </summary>
        /// <returns> An object representing collection of subnets and their operations over a virtual network. </returns>
        public SubnetContainer GetSubnets()
        {
            return new SubnetContainer(this);
        }

        /// <inheritdoc/>
        public Response<VirtualNetwork> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(tags);
            var response = Operations.UpdateTags(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
            return Response.FromValue(new VirtualNetwork(this, new VirtualNetworkData(response.Value)), response.GetRawResponse());
        }

        /// <inheritdoc/>
        public async Task<Response<VirtualNetwork>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(tags);
            var response = await Operations.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
            return Response.FromValue(new VirtualNetwork(this, new VirtualNetworkData(response.Value)), response.GetRawResponse());
        }

        /// <inheritdoc/>
        public Operation<VirtualNetwork> StartSetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(tags);
            return new PhArmOperation<VirtualNetwork, Azure.ResourceManager.Network.Models.VirtualNetwork>(
                Operations.UpdateTags(Id.ResourceGroupName, Id.Name, patchable, cancellationToken),
                n => new VirtualNetwork(this, new VirtualNetworkData(n)));
        }

        /// <inheritdoc/>
        public async Task<Operation<VirtualNetwork>> StartSetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(tags);
            return new PhArmOperation<VirtualNetwork, Azure.ResourceManager.Network.Models.VirtualNetwork>(
                await Operations.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken),
                n => new VirtualNetwork(this, new VirtualNetworkData(n)));
        }

        /// <inheritdoc/>
        public Response<VirtualNetwork> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            var resource = GetResource();
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(resource.Data.Tags);
            patchable.Tags.Remove(key);
            var response = Operations.UpdateTags(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
            return Response.FromValue(new VirtualNetwork(this, new VirtualNetworkData(response.Value)), response.GetRawResponse());
        }

        /// <inheritdoc/>
        public async Task<Response<VirtualNetwork>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            var resource = await GetResourceAsync(cancellationToken);
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(resource.Data.Tags);
            patchable.Tags.Remove(key);
            var response = await Operations.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
            return Response.FromValue(new VirtualNetwork(this, new VirtualNetworkData(response.Value)), response.GetRawResponse());
        }

        /// <inheritdoc/>
        public Operation<VirtualNetwork> StartRemoveTag(string key, CancellationToken cancellationToken = default)
        {
            var resource = GetResource();
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(resource.Data.Tags);
            patchable.Tags.Remove(key);
            return new PhArmOperation<VirtualNetwork, Azure.ResourceManager.Network.Models.VirtualNetwork>(
                Operations.UpdateTags(Id.ResourceGroupName, Id.Name, patchable, cancellationToken),
                n => new VirtualNetwork(this, new VirtualNetworkData(n)));
        }

        /// <inheritdoc/>
        public async Task<Operation<VirtualNetwork>> StartRemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            var resource = await GetResourceAsync(cancellationToken);
            var patchable = new Azure.ResourceManager.Network.Models.TagsObject();
            patchable.Tags.ReplaceWith(resource.Data.Tags);
            patchable.Tags.Remove(key);
            return new PhArmOperation<VirtualNetwork, Azure.ResourceManager.Network.Models.VirtualNetwork>(
                await Operations.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken),
                n => new VirtualNetwork(this, new VirtualNetworkData(n)));
        }

        /// <summary>
        /// Lists all available geo-locations.
        /// </summary>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType);
        }

        /// <summary>
        /// Lists all available geo-locations.
        /// </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of location that may take multiple service requests to iterate over. </returns>
        /// <exception cref="InvalidOperationException"> The default subscription id is null. </exception>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken);
        }
    }
}