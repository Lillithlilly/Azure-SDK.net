// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The type of single sign on Secret Type. </summary>
    public readonly partial struct SsoSecretType : IEquatable<SsoSecretType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SsoSecretType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SsoSecretType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SharedKeyValue = "SharedKey";
        private const string CertificateValue = "Certificate";
        private const string SharedKeyInKeyVaultValue = "SharedKeyInKeyVault";
        private const string CertificateInKeyVaultValue = "CertificateInKeyVault";

        /// <summary> SharedKey. </summary>
        public static SsoSecretType SharedKey { get; } = new SsoSecretType(SharedKeyValue);
        /// <summary> Certificate. </summary>
        public static SsoSecretType Certificate { get; } = new SsoSecretType(CertificateValue);
        /// <summary> SharedKeyInKeyVault. </summary>
        public static SsoSecretType SharedKeyInKeyVault { get; } = new SsoSecretType(SharedKeyInKeyVaultValue);
        /// <summary> CertificateInKeyVault. </summary>
        public static SsoSecretType CertificateInKeyVault { get; } = new SsoSecretType(CertificateInKeyVaultValue);
        /// <summary> Determines if two <see cref="SsoSecretType"/> values are the same. </summary>
        public static bool operator ==(SsoSecretType left, SsoSecretType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SsoSecretType"/> values are not the same. </summary>
        public static bool operator !=(SsoSecretType left, SsoSecretType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SsoSecretType"/>. </summary>
        public static implicit operator SsoSecretType(string value) => new SsoSecretType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SsoSecretType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SsoSecretType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
