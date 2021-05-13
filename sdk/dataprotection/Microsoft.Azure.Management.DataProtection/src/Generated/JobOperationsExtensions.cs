// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobOperations.
    /// </summary>
    public static partial class JobOperationsExtensions
    {
            /// <summary>
            /// Gets a job with id in a backup vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='jobId'>
            /// The Job ID. This is a GUID-formatted string (e.g.
            /// 00000000-0000-0000-0000-000000000000).
            /// </param>
            public static AzureBackupJobResource Get(this IJobOperations operations, string resourceGroupName, string vaultName, string jobId)
            {
                return operations.GetAsync(resourceGroupName, vaultName, jobId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a job with id in a backup vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='jobId'>
            /// The Job ID. This is a GUID-formatted string (e.g.
            /// 00000000-0000-0000-0000-000000000000).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AzureBackupJobResource> GetAsync(this IJobOperations operations, string resourceGroupName, string vaultName, string jobId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vaultName, jobId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}