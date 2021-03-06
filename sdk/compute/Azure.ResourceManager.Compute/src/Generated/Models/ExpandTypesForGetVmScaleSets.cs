// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The ExpandTypesForGetVmScaleSets. </summary>
    public readonly partial struct ExpandTypesForGetVmScaleSets : IEquatable<ExpandTypesForGetVmScaleSets>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExpandTypesForGetVmScaleSets"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpandTypesForGetVmScaleSets(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserDataValue = "userData";

        /// <summary> userData. </summary>
        public static ExpandTypesForGetVmScaleSets UserData { get; } = new ExpandTypesForGetVmScaleSets(UserDataValue);
        /// <summary> Determines if two <see cref="ExpandTypesForGetVmScaleSets"/> values are the same. </summary>
        public static bool operator ==(ExpandTypesForGetVmScaleSets left, ExpandTypesForGetVmScaleSets right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpandTypesForGetVmScaleSets"/> values are not the same. </summary>
        public static bool operator !=(ExpandTypesForGetVmScaleSets left, ExpandTypesForGetVmScaleSets right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExpandTypesForGetVmScaleSets"/>. </summary>
        public static implicit operator ExpandTypesForGetVmScaleSets(string value) => new ExpandTypesForGetVmScaleSets(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpandTypesForGetVmScaleSets other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpandTypesForGetVmScaleSets other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
