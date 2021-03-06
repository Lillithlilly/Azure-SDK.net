// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class SqlRoleDefinitionList
    {
        internal static SqlRoleDefinitionList DeserializeSqlRoleDefinitionList(JsonElement element)
        {
            Optional<IReadOnlyList<SqlRoleDefinitionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SqlRoleDefinitionData> array = new List<SqlRoleDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlRoleDefinitionData.DeserializeSqlRoleDefinitionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SqlRoleDefinitionList(Optional.ToList(value));
        }
    }
}
