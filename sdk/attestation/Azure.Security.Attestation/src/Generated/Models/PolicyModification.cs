// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.Attestation
{
    /// <summary> The result of the operation. </summary>
    public readonly partial struct PolicyModification : IEquatable<PolicyModification>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyModification"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyModification(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UpdatedValue = "Updated";
        private const string RemovedValue = "Removed";

        /// <summary> The specified policy object was updated. </summary>
        public static PolicyModification Updated { get; } = new PolicyModification(UpdatedValue);
        /// <summary> The specified policy object was removed. </summary>
        public static PolicyModification Removed { get; } = new PolicyModification(RemovedValue);
        /// <summary> Determines if two <see cref="PolicyModification"/> values are the same. </summary>
        public static bool operator ==(PolicyModification left, PolicyModification right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyModification"/> values are not the same. </summary>
        public static bool operator !=(PolicyModification left, PolicyModification right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PolicyModification"/>. </summary>
        public static implicit operator PolicyModification(string value) => new PolicyModification(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyModification other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyModification other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
