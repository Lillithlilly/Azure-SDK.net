// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class QuantityResolution
    {
        internal static QuantityResolution DeserializeQuantityResolution(JsonElement element)
        {
            double value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetDouble();
                    continue;
                }
            }
            return new QuantityResolution(value);
        }
    }
}
