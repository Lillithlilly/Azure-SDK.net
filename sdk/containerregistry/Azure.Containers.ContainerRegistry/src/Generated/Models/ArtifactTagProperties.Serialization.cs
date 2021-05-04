// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class ArtifactTagProperties
    {
        internal static ArtifactTagProperties DeserializeArtifactTagProperties(JsonElement element)
        {
            string imageName = default;
            string name = default;
            string digest = default;
            DateTimeOffset createdTime = default;
            DateTimeOffset lastUpdateTime = default;
            ContentProperties changeableAttributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("name"))
                        {
                            name = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("digest"))
                        {
                            digest = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"))
                        {
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changeableAttributes"))
                        {
                            changeableAttributes = ContentProperties.DeserializeContentProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArtifactTagProperties(imageName, name, digest, createdTime, lastUpdateTime, changeableAttributes);
        }
    }
}