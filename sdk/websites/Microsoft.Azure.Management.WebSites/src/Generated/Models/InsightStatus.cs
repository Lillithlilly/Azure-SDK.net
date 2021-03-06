// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for InsightStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InsightStatus
    {
        [EnumMember(Value = "Critical")]
        Critical,
        [EnumMember(Value = "Warning")]
        Warning,
        [EnumMember(Value = "Info")]
        Info,
        [EnumMember(Value = "Success")]
        Success,
        [EnumMember(Value = "None")]
        None
    }
    internal static class InsightStatusEnumExtension
    {
        internal static string ToSerializedValue(this InsightStatus? value)
        {
            return value == null ? null : ((InsightStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this InsightStatus value)
        {
            switch( value )
            {
                case InsightStatus.Critical:
                    return "Critical";
                case InsightStatus.Warning:
                    return "Warning";
                case InsightStatus.Info:
                    return "Info";
                case InsightStatus.Success:
                    return "Success";
                case InsightStatus.None:
                    return "None";
            }
            return null;
        }

        internal static InsightStatus? ParseInsightStatus(this string value)
        {
            switch( value )
            {
                case "Critical":
                    return InsightStatus.Critical;
                case "Warning":
                    return InsightStatus.Warning;
                case "Info":
                    return InsightStatus.Info;
                case "Success":
                    return InsightStatus.Success;
                case "None":
                    return InsightStatus.None;
            }
            return null;
        }
    }
}
