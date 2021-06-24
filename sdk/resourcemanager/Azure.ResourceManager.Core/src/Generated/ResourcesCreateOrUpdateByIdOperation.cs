// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Core
{
    /// <summary> Create a resource by ID. </summary>
    public partial class ResourcesCreateOrUpdateByIdOperation : Operation<GenericResource>, IOperationSource<GenericResource>
    {
        private readonly OperationOrResponseInternals<GenericResource> _operation;
        private readonly OperationsBase _parentOperation;

        /// <summary> Initializes a new instance of ResourcesCreateOrUpdateByIdOperation for mocking. </summary>
        protected ResourcesCreateOrUpdateByIdOperation()
        {
        }

        internal ResourcesCreateOrUpdateByIdOperation(OperationsBase parentOperation, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationOrResponseInternals<GenericResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ResourcesCreateOrUpdateByIdOperation");
            _parentOperation = parentOperation;
        }
        /// <inheritdoc />
        public override string Id => "";

        /// <inheritdoc />
        public override GenericResource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GenericResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GenericResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        GenericResource IOperationSource<GenericResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new GenericResource(_parentOperation, GenericResourceData.DeserializeGenericResource(document.RootElement));
        }

        async ValueTask<GenericResource> IOperationSource<GenericResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new GenericResource(_parentOperation, GenericResourceData.DeserializeGenericResource(document.RootElement));
        }
    }
}