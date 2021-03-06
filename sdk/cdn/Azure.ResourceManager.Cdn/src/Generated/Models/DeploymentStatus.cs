// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The DeploymentStatus. </summary>
    public readonly partial struct DeploymentStatus : IEquatable<DeploymentStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeploymentStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> NotStarted. </summary>
        public static DeploymentStatus NotStarted { get; } = new DeploymentStatus(NotStartedValue);
        /// <summary> InProgress. </summary>
        public static DeploymentStatus InProgress { get; } = new DeploymentStatus(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static DeploymentStatus Succeeded { get; } = new DeploymentStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static DeploymentStatus Failed { get; } = new DeploymentStatus(FailedValue);
        /// <summary> Determines if two <see cref="DeploymentStatus"/> values are the same. </summary>
        public static bool operator ==(DeploymentStatus left, DeploymentStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentStatus"/> values are not the same. </summary>
        public static bool operator !=(DeploymentStatus left, DeploymentStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeploymentStatus"/>. </summary>
        public static implicit operator DeploymentStatus(string value) => new DeploymentStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
