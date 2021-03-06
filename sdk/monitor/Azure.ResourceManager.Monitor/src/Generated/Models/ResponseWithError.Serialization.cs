// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class ResponseWithError
    {
        internal static ResponseWithError DeserializeResponseWithError(JsonElement element)
        {
            Error error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    error = Error.DeserializeError(property.Value);
                    continue;
                }
            }
            return new ResponseWithError(error);
        }
    }
}
