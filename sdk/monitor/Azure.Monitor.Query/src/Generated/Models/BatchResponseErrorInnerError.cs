// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The BatchResponseErrorInnerError. </summary>
    internal partial class BatchResponseErrorInnerError
    {
        /// <summary> Initializes a new instance of BatchResponseErrorInnerError. </summary>
        internal BatchResponseErrorInnerError()
        {
            Details = new ChangeTrackingList<ErrorDetails>();
        }

        /// <summary> Initializes a new instance of BatchResponseErrorInnerError. </summary>
        /// <param name="code"> . </param>
        /// <param name="message"> . </param>
        /// <param name="details"> . </param>
        internal BatchResponseErrorInnerError(string code, string message, IReadOnlyList<ErrorDetails> details)
        {
            Code = code;
            Message = message;
            Details = details;
        }

        public string Code { get; }
        public string Message { get; }
        public IReadOnlyList<ErrorDetails> Details { get; }
    }
}