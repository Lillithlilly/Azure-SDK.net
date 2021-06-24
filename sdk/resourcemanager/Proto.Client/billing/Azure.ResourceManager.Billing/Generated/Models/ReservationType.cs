// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The type of transaction. </summary>
    public readonly partial struct ReservationType : IEquatable<ReservationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ReservationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PurchaseValue = "Purchase";
        private const string UsageChargeValue = "Usage Charge";

        /// <summary> Purchase. </summary>
        public static ReservationType Purchase { get; } = new ReservationType(PurchaseValue);
        /// <summary> Usage Charge. </summary>
        public static ReservationType UsageCharge { get; } = new ReservationType(UsageChargeValue);
        /// <summary> Determines if two <see cref="ReservationType"/> values are the same. </summary>
        public static bool operator ==(ReservationType left, ReservationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationType"/> values are not the same. </summary>
        public static bool operator !=(ReservationType left, ReservationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservationType"/>. </summary>
        public static implicit operator ReservationType(string value) => new ReservationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}