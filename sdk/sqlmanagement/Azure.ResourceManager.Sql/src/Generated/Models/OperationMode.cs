// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Operation Mode. </summary>
    public readonly partial struct OperationMode : IEquatable<OperationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PolybaseImportValue = "PolybaseImport";

        /// <summary> PolybaseImport. </summary>
        public static OperationMode PolybaseImport { get; } = new OperationMode(PolybaseImportValue);
        /// <summary> Determines if two <see cref="OperationMode"/> values are the same. </summary>
        public static bool operator ==(OperationMode left, OperationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationMode"/> values are not the same. </summary>
        public static bool operator !=(OperationMode left, OperationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationMode"/>. </summary>
        public static implicit operator OperationMode(string value) => new OperationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
