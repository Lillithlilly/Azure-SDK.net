// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static partial class ProvisioningStateExtensions
    {
        public static string ToSerialString(this ProvisioningState value) => value switch
        {
            ProvisioningState.Creating => "Creating",
            ProvisioningState.ResolvingDns => "ResolvingDNS",
            ProvisioningState.Succeeded => "Succeeded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningState value.")
        };

        public static ProvisioningState ToProvisioningState(this string value)
        {
            if (string.Equals(value, "Creating", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Creating;
            if (string.Equals(value, "ResolvingDNS", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.ResolvingDns;
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return ProvisioningState.Succeeded;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProvisioningState value.");
        }
    }
}
