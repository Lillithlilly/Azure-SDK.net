// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class InvoiceListResult
    {
        internal static InvoiceListResult DeserializeInvoiceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Invoice>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Invoice> array = new List<Invoice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Invoice.DeserializeInvoice(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new InvoiceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}