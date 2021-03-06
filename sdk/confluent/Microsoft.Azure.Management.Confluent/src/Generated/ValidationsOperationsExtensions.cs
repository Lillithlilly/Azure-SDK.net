// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Confluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ValidationsOperations.
    /// </summary>
    public static partial class ValidationsOperationsExtensions
    {
            /// <summary>
            /// Organization Validate proxy resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name
            /// </param>
            /// <param name='organizationName'>
            /// Organization resource name
            /// </param>
            /// <param name='body'>
            /// Organization resource model
            /// </param>
            public static OrganizationResource ValidateOrganization(this IValidationsOperations operations, string resourceGroupName, string organizationName, OrganizationResource body)
            {
                return operations.ValidateOrganizationAsync(resourceGroupName, organizationName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Organization Validate proxy resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name
            /// </param>
            /// <param name='organizationName'>
            /// Organization resource name
            /// </param>
            /// <param name='body'>
            /// Organization resource model
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrganizationResource> ValidateOrganizationAsync(this IValidationsOperations operations, string resourceGroupName, string organizationName, OrganizationResource body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateOrganizationWithHttpMessagesAsync(resourceGroupName, organizationName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
