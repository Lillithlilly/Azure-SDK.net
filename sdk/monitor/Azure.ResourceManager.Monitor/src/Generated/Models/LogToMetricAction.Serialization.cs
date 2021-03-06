// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class LogToMetricAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("criteria");
            writer.WriteStartArray();
            foreach (var item in Criteria)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static LogToMetricAction DeserializeLogToMetricAction(JsonElement element)
        {
            IList<MonitorCriteria> criteria = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("criteria"))
                {
                    List<MonitorCriteria> array = new List<MonitorCriteria>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorCriteria.DeserializeMonitorCriteria(item));
                    }
                    criteria = array;
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new LogToMetricAction(odataType, criteria);
        }
    }
}
