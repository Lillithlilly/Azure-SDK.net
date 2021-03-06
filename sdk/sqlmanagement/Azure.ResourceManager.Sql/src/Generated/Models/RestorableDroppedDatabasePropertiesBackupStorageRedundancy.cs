// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The storage account type used to store backups for this database. </summary>
    public readonly partial struct RestorableDroppedDatabasePropertiesBackupStorageRedundancy : IEquatable<RestorableDroppedDatabasePropertiesBackupStorageRedundancy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RestorableDroppedDatabasePropertiesBackupStorageRedundancy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RestorableDroppedDatabasePropertiesBackupStorageRedundancy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeoValue = "Geo";
        private const string LocalValue = "Local";
        private const string ZoneValue = "Zone";

        /// <summary> Geo. </summary>
        public static RestorableDroppedDatabasePropertiesBackupStorageRedundancy Geo { get; } = new RestorableDroppedDatabasePropertiesBackupStorageRedundancy(GeoValue);
        /// <summary> Local. </summary>
        public static RestorableDroppedDatabasePropertiesBackupStorageRedundancy Local { get; } = new RestorableDroppedDatabasePropertiesBackupStorageRedundancy(LocalValue);
        /// <summary> Zone. </summary>
        public static RestorableDroppedDatabasePropertiesBackupStorageRedundancy Zone { get; } = new RestorableDroppedDatabasePropertiesBackupStorageRedundancy(ZoneValue);
        /// <summary> Determines if two <see cref="RestorableDroppedDatabasePropertiesBackupStorageRedundancy"/> values are the same. </summary>
        public static bool operator ==(RestorableDroppedDatabasePropertiesBackupStorageRedundancy left, RestorableDroppedDatabasePropertiesBackupStorageRedundancy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RestorableDroppedDatabasePropertiesBackupStorageRedundancy"/> values are not the same. </summary>
        public static bool operator !=(RestorableDroppedDatabasePropertiesBackupStorageRedundancy left, RestorableDroppedDatabasePropertiesBackupStorageRedundancy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RestorableDroppedDatabasePropertiesBackupStorageRedundancy"/>. </summary>
        public static implicit operator RestorableDroppedDatabasePropertiesBackupStorageRedundancy(string value) => new RestorableDroppedDatabasePropertiesBackupStorageRedundancy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RestorableDroppedDatabasePropertiesBackupStorageRedundancy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RestorableDroppedDatabasePropertiesBackupStorageRedundancy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
