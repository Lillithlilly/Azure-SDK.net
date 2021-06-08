// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Action occurred on a resource. </summary>
    public readonly partial struct AgriFoodFarmingResourceActionType : IEquatable<AgriFoodFarmingResourceActionType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AgriFoodFarmingResourceActionType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgriFoodFarmingResourceActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatedValue = "Created";
        private const string UpdatedValue = "Updated";
        private const string DeletedValue = "Deleted";

        /// <summary> Created. </summary>
        public static AgriFoodFarmingResourceActionType Created { get; } = new AgriFoodFarmingResourceActionType(CreatedValue);
        /// <summary> Updated. </summary>
        public static AgriFoodFarmingResourceActionType Updated { get; } = new AgriFoodFarmingResourceActionType(UpdatedValue);
        /// <summary> Deleted. </summary>
        public static AgriFoodFarmingResourceActionType Deleted { get; } = new AgriFoodFarmingResourceActionType(DeletedValue);
        /// <summary> Determines if two <see cref="AgriFoodFarmingResourceActionType"/> values are the same. </summary>
        public static bool operator ==(AgriFoodFarmingResourceActionType left, AgriFoodFarmingResourceActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgriFoodFarmingResourceActionType"/> values are not the same. </summary>
        public static bool operator !=(AgriFoodFarmingResourceActionType left, AgriFoodFarmingResourceActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AgriFoodFarmingResourceActionType"/>. </summary>
        public static implicit operator AgriFoodFarmingResourceActionType(string value) => new AgriFoodFarmingResourceActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgriFoodFarmingResourceActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgriFoodFarmingResourceActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}