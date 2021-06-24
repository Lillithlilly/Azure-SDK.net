// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class Customer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(EnabledAzurePlans))
            {
                writer.WritePropertyName("enabledAzurePlans");
                writer.WriteStartArray();
                foreach (var item in EnabledAzurePlans)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Resellers))
            {
                writer.WritePropertyName("resellers");
                writer.WriteStartArray();
                foreach (var item in Resellers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Customer DeserializeCustomer(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> billingProfileId = default;
            Optional<string> billingProfileDisplayName = default;
            Optional<string> displayName = default;
            Optional<IList<AzurePlan>> enabledAzurePlans = default;
            Optional<IList<Reseller>> resellers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("billingProfileId"))
                        {
                            billingProfileId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileDisplayName"))
                        {
                            billingProfileDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabledAzurePlans"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AzurePlan> array = new List<AzurePlan>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzurePlan.DeserializeAzurePlan(item));
                            }
                            enabledAzurePlans = array;
                            continue;
                        }
                        if (property0.NameEquals("resellers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Reseller> array = new List<Reseller>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Reseller.DeserializeReseller(item));
                            }
                            resellers = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Customer(id.Value, name.Value, type.Value, billingProfileId.Value, billingProfileDisplayName.Value, displayName.Value, Optional.ToList(enabledAzurePlans), Optional.ToList(resellers));
        }
    }
}