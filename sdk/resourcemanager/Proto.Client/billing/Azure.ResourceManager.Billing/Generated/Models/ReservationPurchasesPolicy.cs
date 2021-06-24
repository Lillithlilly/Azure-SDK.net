// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The policy that controls whether Azure reservation purchases are allowed for a billing profile. </summary>
    public readonly partial struct ReservationPurchasesPolicy : IEquatable<ReservationPurchasesPolicy>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ReservationPurchasesPolicy"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationPurchasesPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowedValue = "Allowed";
        private const string NotAllowedValue = "NotAllowed";

        /// <summary> Allowed. </summary>
        public static ReservationPurchasesPolicy Allowed { get; } = new ReservationPurchasesPolicy(AllowedValue);
        /// <summary> NotAllowed. </summary>
        public static ReservationPurchasesPolicy NotAllowed { get; } = new ReservationPurchasesPolicy(NotAllowedValue);
        /// <summary> Determines if two <see cref="ReservationPurchasesPolicy"/> values are the same. </summary>
        public static bool operator ==(ReservationPurchasesPolicy left, ReservationPurchasesPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationPurchasesPolicy"/> values are not the same. </summary>
        public static bool operator !=(ReservationPurchasesPolicy left, ReservationPurchasesPolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservationPurchasesPolicy"/>. </summary>
        public static implicit operator ReservationPurchasesPolicy(string value) => new ReservationPurchasesPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationPurchasesPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationPurchasesPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}