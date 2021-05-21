// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureApplicationInsightsParameterPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureCloud))
            {
                writer.WritePropertyName("azureCloud");
                writer.WriteStringValue(AzureCloud);
            }
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId");
                writer.WriteStringValue(ApplicationId);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey");
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query");
                writer.WriteStringValue(Query);
            }
            writer.WriteEndObject();
        }
    }
}