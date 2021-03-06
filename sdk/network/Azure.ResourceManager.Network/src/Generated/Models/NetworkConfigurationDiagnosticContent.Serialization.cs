// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkConfigurationDiagnosticContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId");
            writer.WriteStringValue(TargetResourceId);
            if (Optional.IsDefined(VerbosityLevel))
            {
                writer.WritePropertyName("verbosityLevel");
                writer.WriteStringValue(VerbosityLevel.Value.ToString());
            }
            writer.WritePropertyName("profiles");
            writer.WriteStartArray();
            foreach (var item in Profiles)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
