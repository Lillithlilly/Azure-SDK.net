// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class Document
    {
        internal static Document DeserializeDocument(JsonElement element)
        {
            Optional<DocumentType> kind = default;
            Optional<string> url = default;
            Optional<DocumentSource> source = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new DocumentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    source = new DocumentSource(property.Value.GetString());
                    continue;
                }
            }
            return new Document(Optional.ToNullable(kind), url.Value, Optional.ToNullable(source));
        }
    }
}