// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Contains the tables, columns &amp; rows resulting from a query. </summary>
    public partial class LogsQueryResult
    {
        /// <summary> Initializes a new instance of LogsQueryResult. </summary>
        internal LogsQueryResult()
        {
            Tables = new ChangeTrackingList<LogsQueryResultTable>();
        }

        /// <summary> Initializes a new instance of LogsQueryResult. </summary>
        /// <param name="tables"> The list of tables, columns and rows. </param>
        /// <param name="statistics"> Any object. </param>
        /// <param name="error"> . </param>
        internal LogsQueryResult(IReadOnlyList<LogsQueryResultTable> tables, JsonElement statistics, ErrorDetails error)
        {
            Tables = tables;
            Statistics = statistics;
            Error = error;
        }

        /// <summary> The list of tables, columns and rows. </summary>
        public IReadOnlyList<LogsQueryResultTable> Tables { get; }
    }
}