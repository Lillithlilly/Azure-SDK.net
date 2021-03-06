// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The PostArgsMatchConditionParametersTypeName. </summary>
    public readonly partial struct PostArgsMatchConditionParametersTypeName : IEquatable<PostArgsMatchConditionParametersTypeName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostArgsMatchConditionParametersTypeName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostArgsMatchConditionParametersTypeName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeliveryRulePostArgsConditionParametersValue = "DeliveryRulePostArgsConditionParameters";

        /// <summary> DeliveryRulePostArgsConditionParameters. </summary>
        public static PostArgsMatchConditionParametersTypeName DeliveryRulePostArgsConditionParameters { get; } = new PostArgsMatchConditionParametersTypeName(DeliveryRulePostArgsConditionParametersValue);
        /// <summary> Determines if two <see cref="PostArgsMatchConditionParametersTypeName"/> values are the same. </summary>
        public static bool operator ==(PostArgsMatchConditionParametersTypeName left, PostArgsMatchConditionParametersTypeName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostArgsMatchConditionParametersTypeName"/> values are not the same. </summary>
        public static bool operator !=(PostArgsMatchConditionParametersTypeName left, PostArgsMatchConditionParametersTypeName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostArgsMatchConditionParametersTypeName"/>. </summary>
        public static implicit operator PostArgsMatchConditionParametersTypeName(string value) => new PostArgsMatchConditionParametersTypeName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostArgsMatchConditionParametersTypeName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostArgsMatchConditionParametersTypeName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
