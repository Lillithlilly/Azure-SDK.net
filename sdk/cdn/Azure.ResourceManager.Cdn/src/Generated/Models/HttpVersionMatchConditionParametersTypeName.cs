// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The HttpVersionMatchConditionParametersTypeName. </summary>
    public readonly partial struct HttpVersionMatchConditionParametersTypeName : IEquatable<HttpVersionMatchConditionParametersTypeName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HttpVersionMatchConditionParametersTypeName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HttpVersionMatchConditionParametersTypeName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeliveryRuleHttpVersionConditionParametersValue = "DeliveryRuleHttpVersionConditionParameters";

        /// <summary> DeliveryRuleHttpVersionConditionParameters. </summary>
        public static HttpVersionMatchConditionParametersTypeName DeliveryRuleHttpVersionConditionParameters { get; } = new HttpVersionMatchConditionParametersTypeName(DeliveryRuleHttpVersionConditionParametersValue);
        /// <summary> Determines if two <see cref="HttpVersionMatchConditionParametersTypeName"/> values are the same. </summary>
        public static bool operator ==(HttpVersionMatchConditionParametersTypeName left, HttpVersionMatchConditionParametersTypeName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HttpVersionMatchConditionParametersTypeName"/> values are not the same. </summary>
        public static bool operator !=(HttpVersionMatchConditionParametersTypeName left, HttpVersionMatchConditionParametersTypeName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HttpVersionMatchConditionParametersTypeName"/>. </summary>
        public static implicit operator HttpVersionMatchConditionParametersTypeName(string value) => new HttpVersionMatchConditionParametersTypeName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HttpVersionMatchConditionParametersTypeName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HttpVersionMatchConditionParametersTypeName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
