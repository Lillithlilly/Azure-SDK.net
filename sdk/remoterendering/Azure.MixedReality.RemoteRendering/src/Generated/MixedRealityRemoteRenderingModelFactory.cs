// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class MixedRealityRemoteRenderingModelFactory
    {
        /// <summary> Initializes new instance of AssetConversion class. </summary>
        /// <param name="conversionId"> The ID of the conversion supplied when the conversion was created. </param>
        /// <param name="options"> Conversion settings describe the origin of input files and destination of output files. </param>
        /// <param name="output"> Information about the output of a successful conversion. Only present when the status of the conversion is &apos;Succeeded&apos;. </param>
        /// <param name="error"> The error object containing details about the conversion failure. </param>
        /// <param name="status"> The status of the conversion. Terminal states are &apos;Cancelled&apos;, &apos;Failed&apos;, and &apos;Succeeded&apos;. </param>
        /// <param name="createdOn"> The time when the conversion was created. Date and time in ISO 8601 format. </param>
        /// <returns> A new <see cref="RemoteRendering.AssetConversion"/> instance for mocking. </returns>
        public static AssetConversion AssetConversion(string conversionId = default, AssetConversionOptions options = default, AssetConversionOutput output = default, RemoteRenderingServiceError error = default, AssetConversionStatus status = default, DateTimeOffset createdOn = default)
        {
            return new AssetConversion(conversionId, options, output, error, status, createdOn);
        }

        /// <summary> Initializes new instance of AssetConversionOutput class. </summary>
        /// <param name="outputAssetUri"> URI of the asset generated by the conversion process. </param>
        /// <returns> A new <see cref="RemoteRendering.AssetConversionOutput"/> instance for mocking. </returns>
        public static AssetConversionOutput AssetConversionOutput(string outputAssetUri = default)
        {
            return new AssetConversionOutput(outputAssetUri);
        }

        /// <summary> Initializes new instance of RemoteRenderingServiceError class. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="details"> An array of details about specific errors that led to this reported error. </param>
        /// <param name="target"> The target of the particular error (e.g., the name of the property in error). </param>
        /// <param name="innerError"> An object containing more specific information than the current object about the error. </param>
        /// <returns> A new <see cref="RemoteRendering.RemoteRenderingServiceError"/> instance for mocking. </returns>
        public static RemoteRenderingServiceError RemoteRenderingServiceError(string code = default, string message = default, IReadOnlyList<RemoteRenderingServiceError> details = default, string target = default, RemoteRenderingServiceError innerError = default)
        {
            details ??= new List<RemoteRenderingServiceError>();
            return new RemoteRenderingServiceError(code, message, details, target, innerError);
        }

        /// <summary> Initializes new instance of RenderingSession class. </summary>
        /// <param name="sessionId"> The ID of the session supplied when the session was created. </param>
        /// <param name="arrInspectorPort"> The TCP port at which the Azure Remote Rendering Inspector tool is hosted. </param>
        /// <param name="handshakePort"> The TCP port used for the handshake when establishing a connection. </param>
        /// <param name="elapsedTimeMinutes"> Amount of time in minutes the session is or was in the &apos;Ready&apos; state. Time is rounded down to a full minute. </param>
        /// <param name="host"> The hostname under which the rendering session is reachable. </param>
        /// <param name="maxLeaseTimeMinutes"> The time in minutes the session will run after reaching the &apos;Ready&apos; state. </param>
        /// <param name="size"> The size of the server used for the rendering session. The size impacts the number of polygons the server can render. Refer to https://docs.microsoft.com/azure/remote-rendering/reference/vm-sizes for details. </param>
        /// <param name="status"> The status of the rendering session. Terminal states are &apos;Error&apos;, &apos;Expired&apos;, and &apos;Stopped&apos;. </param>
        /// <param name="teraflops"> The computational power of the rendering session GPU measured in teraflops. </param>
        /// <param name="error"> The error object containing details about the rendering session startup failure. </param>
        /// <param name="createdOn"> The time when the rendering session was created. Date and time in ISO 8601 format. </param>
        /// <returns> A new <see cref="RemoteRendering.RenderingSession"/> instance for mocking. </returns>
        public static RenderingSession RenderingSession(string sessionId = default, int? arrInspectorPort = default, int? handshakePort = default, int? elapsedTimeMinutes = default, string host = default, int? maxLeaseTimeMinutes = default, RenderingServerSize size = default, RenderingSessionStatus status = default, float? teraflops = default, RemoteRenderingServiceError error = default, DateTimeOffset? createdOn = default)
        {
            return new RenderingSession(sessionId, arrInspectorPort, handshakePort, elapsedTimeMinutes, host, maxLeaseTimeMinutes, size, status, teraflops, error, createdOn);
        }
    }
}