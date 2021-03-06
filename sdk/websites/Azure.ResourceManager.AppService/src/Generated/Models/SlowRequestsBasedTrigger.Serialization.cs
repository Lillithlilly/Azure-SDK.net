// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SlowRequestsBasedTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TimeTaken))
            {
                writer.WritePropertyName("timeTaken");
                writer.WriteStringValue(TimeTaken);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count");
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(TimeInterval))
            {
                writer.WritePropertyName("timeInterval");
                writer.WriteStringValue(TimeInterval);
            }
            writer.WriteEndObject();
        }

        internal static SlowRequestsBasedTrigger DeserializeSlowRequestsBasedTrigger(JsonElement element)
        {
            Optional<string> timeTaken = default;
            Optional<string> path = default;
            Optional<int> count = default;
            Optional<string> timeInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeTaken"))
                {
                    timeTaken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeInterval"))
                {
                    timeInterval = property.Value.GetString();
                    continue;
                }
            }
            return new SlowRequestsBasedTrigger(timeTaken.Value, path.Value, Optional.ToNullable(count), timeInterval.Value);
        }
    }
}
