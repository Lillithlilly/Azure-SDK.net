// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Gender value: M, F, or X. </summary>
    public readonly partial struct FieldValueGender : IEquatable<FieldValueGender>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FieldValueGender"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FieldValueGender(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MValue = "M";
        private const string FValue = "F";
        private const string XValue = "X";

        /// <summary> M. </summary>
        public static FieldValueGender M { get; } = new FieldValueGender(MValue);
        /// <summary> F. </summary>
        public static FieldValueGender F { get; } = new FieldValueGender(FValue);
        /// <summary> X. </summary>
        public static FieldValueGender X { get; } = new FieldValueGender(XValue);
        /// <summary> Determines if two <see cref="FieldValueGender"/> values are the same. </summary>
        public static bool operator ==(FieldValueGender left, FieldValueGender right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FieldValueGender"/> values are not the same. </summary>
        public static bool operator !=(FieldValueGender left, FieldValueGender right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FieldValueGender"/>. </summary>
        public static implicit operator FieldValueGender(string value) => new FieldValueGender(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FieldValueGender other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FieldValueGender other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}