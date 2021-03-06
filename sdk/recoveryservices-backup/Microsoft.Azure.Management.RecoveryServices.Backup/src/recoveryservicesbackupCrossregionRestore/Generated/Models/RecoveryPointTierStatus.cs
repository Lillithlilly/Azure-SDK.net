// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RecoveryPointTierStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecoveryPointTierStatus
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "Valid")]
        Valid,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "Rehydrated")]
        Rehydrated
    }
    internal static class RecoveryPointTierStatusEnumExtension
    {
        internal static string ToSerializedValue(this RecoveryPointTierStatus? value)
        {
            return value == null ? null : ((RecoveryPointTierStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RecoveryPointTierStatus value)
        {
            switch( value )
            {
                case RecoveryPointTierStatus.Invalid:
                    return "Invalid";
                case RecoveryPointTierStatus.Valid:
                    return "Valid";
                case RecoveryPointTierStatus.Disabled:
                    return "Disabled";
                case RecoveryPointTierStatus.Deleted:
                    return "Deleted";
                case RecoveryPointTierStatus.Rehydrated:
                    return "Rehydrated";
            }
            return null;
        }

        internal static RecoveryPointTierStatus? ParseRecoveryPointTierStatus(this string value)
        {
            switch( value )
            {
                case "Invalid":
                    return RecoveryPointTierStatus.Invalid;
                case "Valid":
                    return RecoveryPointTierStatus.Valid;
                case "Disabled":
                    return RecoveryPointTierStatus.Disabled;
                case "Deleted":
                    return RecoveryPointTierStatus.Deleted;
                case "Rehydrated":
                    return RecoveryPointTierStatus.Rehydrated;
            }
            return null;
        }
    }
}
