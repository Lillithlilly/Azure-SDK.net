// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class AzurePlan : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SkuId))
            {
                writer.WritePropertyName("skuId");
                writer.WriteStringValue(SkuId);
            }
            writer.WriteEndObject();
        }

        internal static AzurePlan DeserializeAzurePlan(JsonElement element)
        {
            Optional<string> skuId = default;
            Optional<string> skuDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skuId"))
                {
                    skuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuDescription"))
                {
                    skuDescription = property.Value.GetString();
                    continue;
                }
            }
            return new AzurePlan(skuId.Value, skuDescription.Value);
        }
    }
}