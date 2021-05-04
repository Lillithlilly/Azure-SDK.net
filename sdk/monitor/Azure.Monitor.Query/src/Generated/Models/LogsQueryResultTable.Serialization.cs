// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class LogsQueryResultTable
    {
        internal static LogsQueryResultTable DeserializeLogsQueryResultTable(JsonElement element)
        {
            string name = default;
            IReadOnlyList<LogsQueryResultColumn> columns = default;
            JsonElement rows = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("columns"))
                {
                    List<LogsQueryResultColumn> array = new List<LogsQueryResultColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogsQueryResultColumn.DeserializeLogsQueryResultColumn(item));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("rows"))
                {
                    rows = property.Value.Clone();
                    continue;
                }
            }
            return new LogsQueryResultTable(name, columns, rows);
        }
    }
}