// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of HybridConnection and their operations over its parent. </summary>
    public partial class SiteSlotHybridConnectionNamespaceRelayCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridConnectionNamespaceRelayCollection"/> class for mocking. </summary>
        protected SiteSlotHybridConnectionNamespaceRelayCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteSlotHybridConnectionNamespaceRelayCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotHybridConnectionNamespaceRelayCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SiteSlot.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateHybridConnectionSlot
        /// <summary> Description for Creates a new Hybrid Connection using a Service Bus relay. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="connectionEnvelope"> The details of the hybrid connection. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/>, <paramref name="relayName"/>, or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual WebAppCreateOrUpdateHybridConnectionSlotOperation CreateOrUpdate(string namespaceName, string relayName, HybridConnectionData connectionEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdateHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, connectionEnvelope, cancellationToken);
                var operation = new WebAppCreateOrUpdateHybridConnectionSlotOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateHybridConnectionSlot
        /// <summary> Description for Creates a new Hybrid Connection using a Service Bus relay. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="connectionEnvelope"> The details of the hybrid connection. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/>, <paramref name="relayName"/>, or <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<WebAppCreateOrUpdateHybridConnectionSlotOperation> CreateOrUpdateAsync(string namespaceName, string relayName, HybridConnectionData connectionEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdateHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new WebAppCreateOrUpdateHybridConnectionSlotOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetHybridConnectionSlot
        /// <summary> Description for Retrieves a specific Service Bus Hybrid Connection used by this Web App. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<SiteSlotHybridConnectionNamespaceRelay> Get(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetHybridConnectionSlot
        /// <summary> Description for Retrieves a specific Service Bus Hybrid Connection used by this Web App. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHybridConnectionNamespaceRelay>> GetAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<SiteSlotHybridConnectionNamespaceRelay> GetIfExists(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteSlotHybridConnectionNamespaceRelay>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHybridConnectionNamespaceRelay>> GetIfExistsAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteSlotHybridConnectionNamespaceRelay>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotHybridConnectionNamespaceRelay(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(namespaceName, relayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(namespaceName, relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteSlotHybridConnectionNamespaceRelay, HybridConnectionData> Construct() { }
    }
}
