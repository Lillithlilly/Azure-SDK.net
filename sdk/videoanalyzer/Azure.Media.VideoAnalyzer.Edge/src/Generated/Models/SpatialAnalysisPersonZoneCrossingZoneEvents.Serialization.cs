// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonZoneCrossingZoneEvents : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("zone");
            writer.WriteObjectValue(Zone);
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events");
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonZoneCrossingZoneEvents DeserializeSpatialAnalysisPersonZoneCrossingZoneEvents(JsonElement element)
        {
            NamedPolygonBase zone = default;
            Optional<IList<SpatialAnalysisPersonZoneCrossingEvent>> events = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"))
                {
                    zone = NamedPolygonBase.DeserializeNamedPolygonBase(property.Value);
                    continue;
                }
                if (property.NameEquals("events"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SpatialAnalysisPersonZoneCrossingEvent> array = new List<SpatialAnalysisPersonZoneCrossingEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonZoneCrossingEvent.DeserializeSpatialAnalysisPersonZoneCrossingEvent(item));
                    }
                    events = array;
                    continue;
                }
            }
            return new SpatialAnalysisPersonZoneCrossingZoneEvents(zone, Optional.ToList(events));
        }
    }
}