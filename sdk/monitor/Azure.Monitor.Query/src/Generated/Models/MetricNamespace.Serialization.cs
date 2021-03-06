// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricNamespace
    {
        internal static MetricNamespace DeserializeMetricNamespace(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> type = default;
            Optional<string> name = default;
            Optional<MetricNamespaceClassification> classification = default;
            Optional<MetricNamespaceName> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classification"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    classification = new MetricNamespaceClassification(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = MetricNamespaceName.DeserializeMetricNamespaceName(property.Value);
                    continue;
                }
            }
            return new MetricNamespace(id.Value, type.Value, name.Value, Optional.ToNullable(classification), properties.Value);
        }
    }
}
