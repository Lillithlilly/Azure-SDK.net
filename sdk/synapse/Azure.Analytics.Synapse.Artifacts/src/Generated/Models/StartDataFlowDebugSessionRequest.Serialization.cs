// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(StartDataFlowDebugSessionRequestConverter))]
    public partial class StartDataFlowDebugSessionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId");
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlow))
            {
                writer.WritePropertyName("dataFlow");
                writer.WriteObjectValue(DataFlow);
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets");
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LinkedServices))
            {
                writer.WritePropertyName("linkedServices");
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Staging))
            {
                writer.WritePropertyName("staging");
                writer.WriteObjectValue(Staging);
            }
            if (Optional.IsDefined(DebugSettings))
            {
                writer.WritePropertyName("debugSettings");
                writer.WriteObjectValue(DebugSettings);
            }
            if (Optional.IsDefined(IncrementalDebug))
            {
                writer.WritePropertyName("incrementalDebug");
                writer.WriteBooleanValue(IncrementalDebug.Value);
            }
            writer.WriteEndObject();
        }

        internal static StartDataFlowDebugSessionRequest DeserializeStartDataFlowDebugSessionRequest(JsonElement element)
        {
            Optional<string> sessionId = default;
            Optional<DataFlowResource> dataFlow = default;
            Optional<IList<DatasetResource>> datasets = default;
            Optional<IList<LinkedServiceResource>> linkedServices = default;
            Optional<object> staging = default;
            Optional<object> debugSettings = default;
            Optional<bool> incrementalDebug = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlow"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataFlow = DataFlowResource.DeserializeDataFlowResource(property.Value);
                    continue;
                }
                if (property.NameEquals("datasets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DatasetResource> array = new List<DatasetResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetResource.DeserializeDatasetResource(item));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("linkedServices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LinkedServiceResource> array = new List<LinkedServiceResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedServiceResource.DeserializeLinkedServiceResource(item));
                    }
                    linkedServices = array;
                    continue;
                }
                if (property.NameEquals("staging"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    staging = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("debugSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    debugSettings = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("incrementalDebug"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    incrementalDebug = property.Value.GetBoolean();
                    continue;
                }
            }
            return new StartDataFlowDebugSessionRequest(sessionId.Value, dataFlow.Value, Optional.ToList(datasets), Optional.ToList(linkedServices), staging.Value, debugSettings.Value, Optional.ToNullable(incrementalDebug));
        }

        internal partial class StartDataFlowDebugSessionRequestConverter : JsonConverter<StartDataFlowDebugSessionRequest>
        {
            public override void Write(Utf8JsonWriter writer, StartDataFlowDebugSessionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StartDataFlowDebugSessionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStartDataFlowDebugSessionRequest(document.RootElement);
            }
        }
    }
}