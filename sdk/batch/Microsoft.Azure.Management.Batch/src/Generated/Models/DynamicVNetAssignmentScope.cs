// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DynamicVNetAssignmentScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DynamicVNetAssignmentScope
    {
        /// <summary>
        /// No dynamic VNet assignment is enabled.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>
        /// Dynamic VNet assignment is done per-job. Don't use this option
        /// unless your batch account has been approved to use this feature.
        /// </summary>
        [EnumMember(Value = "job")]
        Job
    }
    internal static class DynamicVNetAssignmentScopeEnumExtension
    {
        internal static string ToSerializedValue(this DynamicVNetAssignmentScope? value)
        {
            return value == null ? null : ((DynamicVNetAssignmentScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DynamicVNetAssignmentScope value)
        {
            switch( value )
            {
                case DynamicVNetAssignmentScope.None:
                    return "none";
                case DynamicVNetAssignmentScope.Job:
                    return "job";
            }
            return null;
        }

        internal static DynamicVNetAssignmentScope? ParseDynamicVNetAssignmentScope(this string value)
        {
            switch( value )
            {
                case "none":
                    return DynamicVNetAssignmentScope.None;
                case "job":
                    return DynamicVNetAssignmentScope.Job;
            }
            return null;
        }
    }
}
