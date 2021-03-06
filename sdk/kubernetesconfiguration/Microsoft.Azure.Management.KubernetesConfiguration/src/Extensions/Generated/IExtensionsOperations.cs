// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Extensions
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ExtensionsOperations operations.
    /// </summary>
    public partial interface IExtensionsOperations
    {
        /// <summary>
        /// Create a new Kubernetes Cluster Extension.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='extensionName'>
        /// Name of the Extension.
        /// </param>
        /// <param name='extension'>
        /// Properties necessary to Create an Extension.
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
        Task<AzureOperationResponse<Extension>> CreateWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, Extension extension, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets Kubernetes Cluster Extension.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='extensionName'>
        /// Name of the Extension.
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
        Task<AzureOperationResponse<Extension>> GetWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a Kubernetes Cluster Extension. This will cause the Agent to
        /// Uninstall the extension from the cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='extensionName'>
        /// Name of the Extension.
        /// </param>
        /// <param name='forceDelete'>
        /// Delete the extension resource in Azure - not the normal
        /// asynchronous delete.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, bool? forceDelete = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch an existing Kubernetes Cluster Extension.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='extensionName'>
        /// Name of the Extension.
        /// </param>
        /// <param name='patchExtension'>
        /// Properties to Patch in an existing Extension.
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
        Task<AzureOperationResponse<Extension>> UpdateWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, PatchExtension patchExtension, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all Extensions in the cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
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
        Task<AzureOperationResponse<IPage<Extension>>> ListWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a new Kubernetes Cluster Extension.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='extensionName'>
        /// Name of the Extension.
        /// </param>
        /// <param name='extension'>
        /// Properties necessary to Create an Extension.
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
        Task<AzureOperationResponse<Extension>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, Extension extension, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a Kubernetes Cluster Extension. This will cause the Agent to
        /// Uninstall the extension from the cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='extensionName'>
        /// Name of the Extension.
        /// </param>
        /// <param name='forceDelete'>
        /// Delete the extension resource in Azure - not the normal
        /// asynchronous delete.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, bool? forceDelete = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch an existing Kubernetes Cluster Extension.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='clusterRp'>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for
        /// AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// Possible values include: 'Microsoft.ContainerService',
        /// 'Microsoft.Kubernetes'
        /// </param>
        /// <param name='clusterResourceName'>
        /// The Kubernetes cluster resource name - either managedClusters (for
        /// AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// Possible values include: 'managedClusters', 'connectedClusters'
        /// </param>
        /// <param name='clusterName'>
        /// The name of the kubernetes cluster.
        /// </param>
        /// <param name='extensionName'>
        /// Name of the Extension.
        /// </param>
        /// <param name='patchExtension'>
        /// Properties to Patch in an existing Extension.
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
        Task<AzureOperationResponse<Extension>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string extensionName, PatchExtension patchExtension, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all Extensions in the cluster.
        /// </summary>
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
        Task<AzureOperationResponse<IPage<Extension>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
