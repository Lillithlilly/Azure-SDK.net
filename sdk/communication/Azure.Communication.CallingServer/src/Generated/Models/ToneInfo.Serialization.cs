// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class ToneInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SequenceId))
            {
                writer.WritePropertyName("sequenceId");
                writer.WriteNumberValue(SequenceId.Value);
            }
            if (Optional.IsDefined(Tone))
            {
                writer.WritePropertyName("tone");
                writer.WriteStringValue(Tone.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ToneInfo DeserializeToneInfo(JsonElement element)
        {
            Optional<int> sequenceId = default;
            Optional<ToneValue> tone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sequenceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sequenceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tone"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tone = new ToneValue(property.Value.GetString());
                    continue;
                }
            }
            return new ToneInfo(Optional.ToNullable(sequenceId), Optional.ToNullable(tone));
        }
    }
}