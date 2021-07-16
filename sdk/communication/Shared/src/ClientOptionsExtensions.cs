// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;
using System;

namespace Azure.Communication.Pipeline
{
    internal static class ClientOptionsExtensions
    {
        public static HttpPipeline BuildHttpPipeline(this ClientOptions options, ConnectionString connectionString, string authority = null)
        {
            var authPolicy = new HMACAuthenticationPolicy(new AzureKeyCredential(connectionString.GetRequired("accesskey")), authority);

            return HttpPipelineBuilder.Build(options, authPolicy);
        }

        public static HttpPipeline BuildHttpPipeline(this ClientOptions options, AzureKeyCredential keyCredential)
        {
            var authPolicy = new HMACAuthenticationPolicy(keyCredential);
            return HttpPipelineBuilder.Build(options, authPolicy);
        }

        public static HttpPipeline BuildHttpPipeline(this ClientOptions options, TokenCredential tokenCredential)
        {
            var authPolicy = new BearerTokenAuthenticationPolicy(tokenCredential, "https://communication.azure.com//.default");
            return HttpPipelineBuilder.Build(options, authPolicy);
        }
    }
}