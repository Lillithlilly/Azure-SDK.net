// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The current billing status of the subscription. </summary>
    public readonly partial struct BillingSubscriptionStatusType : IEquatable<BillingSubscriptionStatusType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="BillingSubscriptionStatusType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingSubscriptionStatusType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string InactiveValue = "Inactive";
        private const string AbandonedValue = "Abandoned";
        private const string DeletedValue = "Deleted";
        private const string WarningValue = "Warning";

        /// <summary> Active. </summary>
        public static BillingSubscriptionStatusType Active { get; } = new BillingSubscriptionStatusType(ActiveValue);
        /// <summary> Inactive. </summary>
        public static BillingSubscriptionStatusType Inactive { get; } = new BillingSubscriptionStatusType(InactiveValue);
        /// <summary> Abandoned. </summary>
        public static BillingSubscriptionStatusType Abandoned { get; } = new BillingSubscriptionStatusType(AbandonedValue);
        /// <summary> Deleted. </summary>
        public static BillingSubscriptionStatusType Deleted { get; } = new BillingSubscriptionStatusType(DeletedValue);
        /// <summary> Warning. </summary>
        public static BillingSubscriptionStatusType Warning { get; } = new BillingSubscriptionStatusType(WarningValue);
        /// <summary> Determines if two <see cref="BillingSubscriptionStatusType"/> values are the same. </summary>
        public static bool operator ==(BillingSubscriptionStatusType left, BillingSubscriptionStatusType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingSubscriptionStatusType"/> values are not the same. </summary>
        public static bool operator !=(BillingSubscriptionStatusType left, BillingSubscriptionStatusType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BillingSubscriptionStatusType"/>. </summary>
        public static implicit operator BillingSubscriptionStatusType(string value) => new BillingSubscriptionStatusType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingSubscriptionStatusType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingSubscriptionStatusType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}