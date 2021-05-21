// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisCustomOperation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("extensionConfiguration");
            writer.WriteStringValue(ExtensionConfiguration);
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisCustomOperation DeserializeSpatialAnalysisCustomOperation(JsonElement element)
        {
            string extensionConfiguration = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extensionConfiguration"))
                {
                    extensionConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new SpatialAnalysisCustomOperation(type, extensionConfiguration);
        }
    }
}