// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Error code of the transfer validation response. </summary>
    public readonly partial struct SubscriptionTransferValidationErrorCode : IEquatable<SubscriptionTransferValidationErrorCode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SubscriptionTransferValidationErrorCode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SubscriptionTransferValidationErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidSourceValue = "InvalidSource";
        private const string SubscriptionNotActiveValue = "SubscriptionNotActive";
        private const string InsufficientPermissionOnSourceValue = "InsufficientPermissionOnSource";
        private const string InsufficientPermissionOnDestinationValue = "InsufficientPermissionOnDestination";
        private const string DestinationBillingProfilePastDueValue = "DestinationBillingProfilePastDue";
        private const string SubscriptionTypeNotSupportedValue = "SubscriptionTypeNotSupported";
        private const string CrossBillingAccountNotAllowedValue = "CrossBillingAccountNotAllowed";
        private const string NotAvailableForDestinationMarketValue = "NotAvailableForDestinationMarket";

        /// <summary> InvalidSource. </summary>
        public static SubscriptionTransferValidationErrorCode InvalidSource { get; } = new SubscriptionTransferValidationErrorCode(InvalidSourceValue);
        /// <summary> SubscriptionNotActive. </summary>
        public static SubscriptionTransferValidationErrorCode SubscriptionNotActive { get; } = new SubscriptionTransferValidationErrorCode(SubscriptionNotActiveValue);
        /// <summary> InsufficientPermissionOnSource. </summary>
        public static SubscriptionTransferValidationErrorCode InsufficientPermissionOnSource { get; } = new SubscriptionTransferValidationErrorCode(InsufficientPermissionOnSourceValue);
        /// <summary> InsufficientPermissionOnDestination. </summary>
        public static SubscriptionTransferValidationErrorCode InsufficientPermissionOnDestination { get; } = new SubscriptionTransferValidationErrorCode(InsufficientPermissionOnDestinationValue);
        /// <summary> DestinationBillingProfilePastDue. </summary>
        public static SubscriptionTransferValidationErrorCode DestinationBillingProfilePastDue { get; } = new SubscriptionTransferValidationErrorCode(DestinationBillingProfilePastDueValue);
        /// <summary> SubscriptionTypeNotSupported. </summary>
        public static SubscriptionTransferValidationErrorCode SubscriptionTypeNotSupported { get; } = new SubscriptionTransferValidationErrorCode(SubscriptionTypeNotSupportedValue);
        /// <summary> CrossBillingAccountNotAllowed. </summary>
        public static SubscriptionTransferValidationErrorCode CrossBillingAccountNotAllowed { get; } = new SubscriptionTransferValidationErrorCode(CrossBillingAccountNotAllowedValue);
        /// <summary> NotAvailableForDestinationMarket. </summary>
        public static SubscriptionTransferValidationErrorCode NotAvailableForDestinationMarket { get; } = new SubscriptionTransferValidationErrorCode(NotAvailableForDestinationMarketValue);
        /// <summary> Determines if two <see cref="SubscriptionTransferValidationErrorCode"/> values are the same. </summary>
        public static bool operator ==(SubscriptionTransferValidationErrorCode left, SubscriptionTransferValidationErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SubscriptionTransferValidationErrorCode"/> values are not the same. </summary>
        public static bool operator !=(SubscriptionTransferValidationErrorCode left, SubscriptionTransferValidationErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SubscriptionTransferValidationErrorCode"/>. </summary>
        public static implicit operator SubscriptionTransferValidationErrorCode(string value) => new SubscriptionTransferValidationErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SubscriptionTransferValidationErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SubscriptionTransferValidationErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}