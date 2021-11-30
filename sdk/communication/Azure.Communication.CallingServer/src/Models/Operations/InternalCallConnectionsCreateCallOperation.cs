// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallingServer
{
    [CodeGenModel("CallConnectionsCreateCallOperation")]
    internal partial class InternalCallConnectionsCreateCallOperation
    {
        internal InternalCallConnectionsCreateCallOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CreateCallResultInternal>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CreateCallOperation");

            if (response.Headers.TryGetValue<string>("callConnectionId", out var id))
            {
                CallConnectionId = id;
            }
        }

        /// <summary>
        /// The call connection id.
        /// </summary>
        public string CallConnectionId { get; }
    }
}
