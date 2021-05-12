// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SecurityAlertsPolicyState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SecurityAlertsPolicyState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class SecurityAlertsPolicyStateEnumExtension
    {
        internal static string ToSerializedValue(this SecurityAlertsPolicyState? value)
        {
            return value == null ? null : ((SecurityAlertsPolicyState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SecurityAlertsPolicyState value)
        {
            switch( value )
            {
                case SecurityAlertsPolicyState.Enabled:
                    return "Enabled";
                case SecurityAlertsPolicyState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static SecurityAlertsPolicyState? ParseSecurityAlertsPolicyState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return SecurityAlertsPolicyState.Enabled;
                case "Disabled":
                    return SecurityAlertsPolicyState.Disabled;
            }
            return null;
        }
    }
}