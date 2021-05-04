// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesDefaultCategory : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("label");
            writer.WriteStringValue(Label);
            writer.WriteEndObject();
        }

        internal static TimeSeriesDefaultCategory DeserializeTimeSeriesDefaultCategory(JsonElement element)
        {
            string label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new TimeSeriesDefaultCategory(label);
        }
    }
}