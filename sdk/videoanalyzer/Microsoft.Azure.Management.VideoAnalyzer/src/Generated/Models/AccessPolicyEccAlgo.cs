// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for AccessPolicyEccAlgo.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(AccessPolicyEccAlgoConverter))]
    public struct AccessPolicyEccAlgo : System.IEquatable<AccessPolicyEccAlgo>
    {
        private AccessPolicyEccAlgo(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// ES265
        /// </summary>
        public static readonly AccessPolicyEccAlgo ES256 = "ES256";

        /// <summary>
        /// ES384
        /// </summary>
        public static readonly AccessPolicyEccAlgo ES384 = "ES384";

        /// <summary>
        /// ES512
        /// </summary>
        public static readonly AccessPolicyEccAlgo ES512 = "ES512";


        /// <summary>
        /// Underlying value of enum AccessPolicyEccAlgo
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for AccessPolicyEccAlgo
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type AccessPolicyEccAlgo
        /// </summary>
        public bool Equals(AccessPolicyEccAlgo e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to AccessPolicyEccAlgo
        /// </summary>
        public static implicit operator AccessPolicyEccAlgo(string value)
        {
            return new AccessPolicyEccAlgo(value);
        }

        /// <summary>
        /// Implicit operator to convert AccessPolicyEccAlgo to string
        /// </summary>
        public static implicit operator string(AccessPolicyEccAlgo e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum AccessPolicyEccAlgo
        /// </summary>
        public static bool operator == (AccessPolicyEccAlgo e1, AccessPolicyEccAlgo e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum AccessPolicyEccAlgo
        /// </summary>
        public static bool operator != (AccessPolicyEccAlgo e1, AccessPolicyEccAlgo e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for AccessPolicyEccAlgo
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AccessPolicyEccAlgo && Equals((AccessPolicyEccAlgo)obj);
        }

        /// <summary>
        /// Returns for hashCode AccessPolicyEccAlgo
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}