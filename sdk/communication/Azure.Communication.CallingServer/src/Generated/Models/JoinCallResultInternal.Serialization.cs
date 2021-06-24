// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class JoinCallResultInternal
    {
        internal static JoinCallResultInternal DeserializeJoinCallResultInternal(JsonElement element)
        {
            Optional<string> callConnectionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
            }
            return new JoinCallResultInternal(callConnectionId.Value);
        }
    }
}