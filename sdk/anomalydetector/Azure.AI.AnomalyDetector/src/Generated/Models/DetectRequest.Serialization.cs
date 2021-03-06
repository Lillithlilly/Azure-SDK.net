// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    public partial class DetectRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("series");
            writer.WriteStartArray();
            foreach (var item in Series)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Granularity))
            {
                writer.WritePropertyName("granularity");
                writer.WriteStringValue(Granularity.Value.ToSerialString());
            }
            if (Optional.IsDefined(CustomInterval))
            {
                writer.WritePropertyName("customInterval");
                writer.WriteNumberValue(CustomInterval.Value);
            }
            if (Optional.IsDefined(Period))
            {
                writer.WritePropertyName("period");
                writer.WriteNumberValue(Period.Value);
            }
            if (Optional.IsDefined(MaxAnomalyRatio))
            {
                writer.WritePropertyName("maxAnomalyRatio");
                writer.WriteNumberValue(MaxAnomalyRatio.Value);
            }
            if (Optional.IsDefined(Sensitivity))
            {
                writer.WritePropertyName("sensitivity");
                writer.WriteNumberValue(Sensitivity.Value);
            }
            if (Optional.IsDefined(ImputeMode))
            {
                writer.WritePropertyName("imputeMode");
                writer.WriteStringValue(ImputeMode.Value.ToString());
            }
            if (Optional.IsDefined(ImputeFixedValue))
            {
                writer.WritePropertyName("imputeFixedValue");
                writer.WriteNumberValue(ImputeFixedValue.Value);
            }
            writer.WriteEndObject();
        }
    }
}
