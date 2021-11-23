// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallingServer
{
    [CodeGenModel("InternalCallingCreateCallOperation")]
    public partial class CreateCallOperation
    {
        internal CreateCallOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CreateCallResultInternal>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CreateCallOperation");

            if (response.Headers.TryGetValue<string>("operation-id", out var id))
            {
                Id = id;
            }
        }

        /// <inheritdoc />
        public override string Id { get; }
    }
}
