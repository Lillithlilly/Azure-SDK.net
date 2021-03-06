// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for H264RateControlMode.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(H264RateControlModeConverter))]
    public struct H264RateControlMode : System.IEquatable<H264RateControlMode>
    {
        private H264RateControlMode(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Average Bitrate (ABR) mode that hits the target bitrate: Default
        /// mode.
        /// </summary>
        public static readonly H264RateControlMode ABR = "ABR";

        /// <summary>
        /// Constant Bitrate (CBR) mode that tightens bitrate variations around
        /// target bitrate.
        /// </summary>
        public static readonly H264RateControlMode CBR = "CBR";

        /// <summary>
        /// Constant Rate Factor (CRF) mode that targets at constant subjective
        /// quality.
        /// </summary>
        public static readonly H264RateControlMode CRF = "CRF";


        /// <summary>
        /// Underlying value of enum H264RateControlMode
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for H264RateControlMode
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type H264RateControlMode
        /// </summary>
        public bool Equals(H264RateControlMode e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to H264RateControlMode
        /// </summary>
        public static implicit operator H264RateControlMode(string value)
        {
            return new H264RateControlMode(value);
        }

        /// <summary>
        /// Implicit operator to convert H264RateControlMode to string
        /// </summary>
        public static implicit operator string(H264RateControlMode e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum H264RateControlMode
        /// </summary>
        public static bool operator == (H264RateControlMode e1, H264RateControlMode e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum H264RateControlMode
        /// </summary>
        public static bool operator != (H264RateControlMode e1, H264RateControlMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for H264RateControlMode
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is H264RateControlMode && Equals((H264RateControlMode)obj);
        }

        /// <summary>
        /// Returns for hashCode H264RateControlMode
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
