// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ManifestsCreateHeaders
    {
        private readonly Response _response;
        public ManifestsCreateHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Identifies the docker upload uuid for the current request. </summary>
        public string DockerContentDigest => _response.Headers.TryGetValue("Docker-Content-Digest", out string value) ? value : null;
        /// <summary> The canonical location url of the uploaded manifest. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        /// <summary> The length of the requested blob content. </summary>
        public long? ContentLength => _response.Headers.TryGetValue("Content-Length", out long? value) ? value : null;
    }
}