// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class QosPortRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start");
                writer.WriteNumberValue(Start.Value);
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end");
                writer.WriteNumberValue(End.Value);
            }
            writer.WriteEndObject();
        }

        internal static QosPortRange DeserializeQosPortRange(JsonElement element)
        {
            Optional<int> start = default;
            Optional<int> end = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    start = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    end = property.Value.GetInt32();
                    continue;
                }
            }
            return new QosPortRange(Optional.ToNullable(start), Optional.ToNullable(end));
        }
    }
}
