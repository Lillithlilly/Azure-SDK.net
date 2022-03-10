// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class TagResource
    {
        /// <summary>
        /// Deletes the entire set of tags on a resource or subscription.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_DeleteAtScope
        /// </summary>
        /// <param name="waitUntil"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.Delete");
            scope.Start();
            try
            {
                var response = await _tagResourceTagsRestClient.DeleteAtScopeAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation(response);
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
        /// Deletes the entire set of tags on a resource or subscription.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_DeleteAtScope
        /// </summary>
        /// <param name="waitUntil"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.Delete");
            scope.Start();
            try
            {
                var response = _tagResourceTagsRestClient.DeleteAtScope(Id.Parent, cancellationToken);
                var operation = new ResourcesArmOperation(response);
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
        /// This operation allows adding or replacing the entire set of tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_CreateOrUpdateAtScope
        /// </summary>
        /// <param name="waitUntil"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The TagResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<TagResource>> CreateOrUpdateAsync(WaitUntil waitUntil, TagResourceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tagResourceTagsRestClient.CreateOrUpdateAtScopeAsync(Id.Parent, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<TagResource>(Response.FromValue(new TagResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation allows adding or replacing the entire set of tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_CreateOrUpdateAtScope
        /// </summary>
        /// <param name="waitUntil"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The TagResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<TagResource> CreateOrUpdate(WaitUntil waitUntil, TagResourceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tagResourceTagsRestClient.CreateOrUpdateAtScope(Id.Parent, parameters, cancellationToken);
                var operation = new ResourcesArmOperation<TagResource>(Response.FromValue(new TagResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
