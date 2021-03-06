// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CrrOperationResultsOperations.
    /// </summary>
    public static partial class CrrOperationResultsOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='operationId'>
            /// </param>
            public static void Get(this ICrrOperationResultsOperations operations, string azureRegion, string operationId)
            {
                operations.GetAsync(azureRegion, operationId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetAsync(this ICrrOperationResultsOperations operations, string azureRegion, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetWithHttpMessagesAsync(azureRegion, operationId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
