// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Response to a batch query. </summary>
    public partial class LogsBatchQueryResults
    {
        /// <summary> Initializes a new instance of LogsBatchQueryResults. </summary>
        internal LogsBatchQueryResults()
        {
            Responses = new ChangeTrackingList<BatchQueryResponse>();
        }

        /// <summary> Initializes a new instance of LogsBatchQueryResults. </summary>
        /// <param name="responses"> An array of responses corresponding to each individual request in a batch. </param>
        internal LogsBatchQueryResults(IReadOnlyList<BatchQueryResponse> responses)
        {
            Responses = responses;
        }
    }
}