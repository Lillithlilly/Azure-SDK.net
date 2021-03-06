// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VirtualMachineType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VirtualMachineType
    {
        /// <summary>
        /// A user VM
        /// </summary>
        [EnumMember(Value = "User")]
        User,
        /// <summary>
        /// A template VM
        /// </summary>
        [EnumMember(Value = "Template")]
        Template
    }
    internal static class VirtualMachineTypeEnumExtension
    {
        internal static string ToSerializedValue(this VirtualMachineType? value)
        {
            return value == null ? null : ((VirtualMachineType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this VirtualMachineType value)
        {
            switch( value )
            {
                case VirtualMachineType.User:
                    return "User";
                case VirtualMachineType.Template:
                    return "Template";
            }
            return null;
        }

        internal static VirtualMachineType? ParseVirtualMachineType(this string value)
        {
            switch( value )
            {
                case "User":
                    return VirtualMachineType.User;
                case "Template":
                    return VirtualMachineType.Template;
            }
            return null;
        }
    }
}
