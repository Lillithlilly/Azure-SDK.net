// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The deletion recovery level currently in effect for the object. If it contains &apos;Purgeable&apos;, then the object can be permanently deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval. </summary>
    public readonly partial struct DeletionRecoveryLevel : IEquatable<DeletionRecoveryLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeletionRecoveryLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeletionRecoveryLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PurgeableValue = "Purgeable";
        private const string RecoverablePurgeableValue = "Recoverable+Purgeable";
        private const string RecoverableValue = "Recoverable";
        private const string RecoverableProtectedSubscriptionValue = "Recoverable+ProtectedSubscription";

        /// <summary> Purgeable. </summary>
        public static DeletionRecoveryLevel Purgeable { get; } = new DeletionRecoveryLevel(PurgeableValue);
        /// <summary> Recoverable+Purgeable. </summary>
        public static DeletionRecoveryLevel RecoverablePurgeable { get; } = new DeletionRecoveryLevel(RecoverablePurgeableValue);
        /// <summary> Recoverable. </summary>
        public static DeletionRecoveryLevel Recoverable { get; } = new DeletionRecoveryLevel(RecoverableValue);
        /// <summary> Recoverable+ProtectedSubscription. </summary>
        public static DeletionRecoveryLevel RecoverableProtectedSubscription { get; } = new DeletionRecoveryLevel(RecoverableProtectedSubscriptionValue);
        /// <summary> Determines if two <see cref="DeletionRecoveryLevel"/> values are the same. </summary>
        public static bool operator ==(DeletionRecoveryLevel left, DeletionRecoveryLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeletionRecoveryLevel"/> values are not the same. </summary>
        public static bool operator !=(DeletionRecoveryLevel left, DeletionRecoveryLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeletionRecoveryLevel"/>. </summary>
        public static implicit operator DeletionRecoveryLevel(string value) => new DeletionRecoveryLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeletionRecoveryLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeletionRecoveryLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
