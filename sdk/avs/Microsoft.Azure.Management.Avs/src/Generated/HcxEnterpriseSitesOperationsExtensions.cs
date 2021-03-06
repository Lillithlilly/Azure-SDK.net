// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HcxEnterpriseSitesOperations.
    /// </summary>
    public static partial class HcxEnterpriseSitesOperationsExtensions
    {
            /// <summary>
            /// List HCX Enterprise Sites in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            public static IPage<HcxEnterpriseSite> List(this IHcxEnterpriseSitesOperations operations, string resourceGroupName, string privateCloudName)
            {
                return operations.ListAsync(resourceGroupName, privateCloudName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List HCX Enterprise Sites in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HcxEnterpriseSite>> ListAsync(this IHcxEnterpriseSitesOperations operations, string resourceGroupName, string privateCloudName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, privateCloudName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an HCX Enterprise Site by name in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='hcxEnterpriseSiteName'>
            /// Name of the HCX Enterprise Site in the private cloud
            /// </param>
            public static HcxEnterpriseSite Get(this IHcxEnterpriseSitesOperations operations, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName)
            {
                return operations.GetAsync(resourceGroupName, privateCloudName, hcxEnterpriseSiteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an HCX Enterprise Site by name in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='hcxEnterpriseSiteName'>
            /// Name of the HCX Enterprise Site in the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HcxEnterpriseSite> GetAsync(this IHcxEnterpriseSitesOperations operations, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateCloudName, hcxEnterpriseSiteName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an HCX Enterprise Site in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// The name of the private cloud.
            /// </param>
            /// <param name='hcxEnterpriseSiteName'>
            /// Name of the HCX Enterprise Site in the private cloud
            /// </param>
            public static HcxEnterpriseSite CreateOrUpdate(this IHcxEnterpriseSitesOperations operations, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, privateCloudName, hcxEnterpriseSiteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an HCX Enterprise Site in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// The name of the private cloud.
            /// </param>
            /// <param name='hcxEnterpriseSiteName'>
            /// Name of the HCX Enterprise Site in the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HcxEnterpriseSite> CreateOrUpdateAsync(this IHcxEnterpriseSitesOperations operations, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, hcxEnterpriseSiteName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an HCX Enterprise Site in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='hcxEnterpriseSiteName'>
            /// Name of the HCX Enterprise Site in the private cloud
            /// </param>
            public static void Delete(this IHcxEnterpriseSitesOperations operations, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName)
            {
                operations.DeleteAsync(resourceGroupName, privateCloudName, hcxEnterpriseSiteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an HCX Enterprise Site in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='hcxEnterpriseSiteName'>
            /// Name of the HCX Enterprise Site in the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IHcxEnterpriseSitesOperations operations, string resourceGroupName, string privateCloudName, string hcxEnterpriseSiteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, privateCloudName, hcxEnterpriseSiteName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List HCX Enterprise Sites in a private cloud
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<HcxEnterpriseSite> ListNext(this IHcxEnterpriseSitesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List HCX Enterprise Sites in a private cloud
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
            public static async Task<IPage<HcxEnterpriseSite>> ListNextAsync(this IHcxEnterpriseSitesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
