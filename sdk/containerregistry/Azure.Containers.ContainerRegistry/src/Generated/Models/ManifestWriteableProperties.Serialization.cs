// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class ManifestWriteableProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CanDelete))
            {
                writer.WritePropertyName("deleteEnabled");
                writer.WriteBooleanValue(CanDelete.Value);
            }
            if (Optional.IsDefined(CanWrite))
            {
                writer.WritePropertyName("writeEnabled");
                writer.WriteBooleanValue(CanWrite.Value);
            }
            if (Optional.IsDefined(CanList))
            {
                writer.WritePropertyName("listEnabled");
                writer.WriteBooleanValue(CanList.Value);
            }
            if (Optional.IsDefined(CanRead))
            {
                writer.WritePropertyName("readEnabled");
                writer.WriteBooleanValue(CanRead.Value);
            }
            if (Optional.IsDefined(QuarantineState))
            {
                writer.WritePropertyName("quarantineState");
                writer.WriteStringValue(QuarantineState);
            }
            if (Optional.IsDefined(QuarantineDetails))
            {
                writer.WritePropertyName("quarantineDetails");
                writer.WriteStringValue(QuarantineDetails);
            }
            writer.WriteEndObject();
        }

        internal static ManifestWriteableProperties DeserializeManifestWriteableProperties(JsonElement element)
        {
            Optional<bool> deleteEnabled = default;
            Optional<bool> writeEnabled = default;
            Optional<bool> listEnabled = default;
            Optional<bool> readEnabled = default;
            Optional<string> quarantineState = default;
            Optional<string> quarantineDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deleteEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deleteEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("writeEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("listEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    listEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("quarantineState"))
                {
                    quarantineState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quarantineDetails"))
                {
                    quarantineDetails = property.Value.GetString();
                    continue;
                }
            }
            return new ManifestWriteableProperties(Optional.ToNullable(deleteEnabled), Optional.ToNullable(writeEnabled), Optional.ToNullable(listEnabled), Optional.ToNullable(readEnabled), quarantineState.Value, quarantineDetails.Value);
        }
    }
}