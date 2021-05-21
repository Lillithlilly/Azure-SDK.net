// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ExtensionProcessorBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpoint");
            writer.WriteObjectValue(Endpoint);
            writer.WritePropertyName("image");
            writer.WriteObjectValue(Image);
            if (Optional.IsDefined(SamplingOptions))
            {
                writer.WritePropertyName("samplingOptions");
                writer.WriteObjectValue(SamplingOptions);
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ExtensionProcessorBase DeserializeExtensionProcessorBase(JsonElement element)
        {
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.VideoAnalyzer.GrpcExtension": return GrpcExtension.DeserializeGrpcExtension(element);
                    case "#Microsoft.VideoAnalyzer.HttpExtension": return HttpExtension.DeserializeHttpExtension(element);
                }
            }
            EndpointBase endpoint = default;
            ImageProperties image = default;
            Optional<SamplingOptions> samplingOptions = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"))
                {
                    endpoint = EndpointBase.DeserializeEndpointBase(property.Value);
                    continue;
                }
                if (property.NameEquals("image"))
                {
                    image = ImageProperties.DeserializeImageProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("samplingOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    samplingOptions = SamplingOptions.DeserializeSamplingOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new ExtensionProcessorBase(type, name, inputs, endpoint, image, samplingOptions.Value);
        }
    }
}