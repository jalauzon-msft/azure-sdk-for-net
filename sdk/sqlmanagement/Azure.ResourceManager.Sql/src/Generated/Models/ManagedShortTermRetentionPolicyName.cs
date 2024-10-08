// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ManagedShortTermRetentionPolicyName. </summary>
    public readonly partial struct ManagedShortTermRetentionPolicyName : IEquatable<ManagedShortTermRetentionPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedShortTermRetentionPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedShortTermRetentionPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static ManagedShortTermRetentionPolicyName Default { get; } = new ManagedShortTermRetentionPolicyName(DefaultValue);
        /// <summary> Determines if two <see cref="ManagedShortTermRetentionPolicyName"/> values are the same. </summary>
        public static bool operator ==(ManagedShortTermRetentionPolicyName left, ManagedShortTermRetentionPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedShortTermRetentionPolicyName"/> values are not the same. </summary>
        public static bool operator !=(ManagedShortTermRetentionPolicyName left, ManagedShortTermRetentionPolicyName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedShortTermRetentionPolicyName"/>. </summary>
        public static implicit operator ManagedShortTermRetentionPolicyName(string value) => new ManagedShortTermRetentionPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedShortTermRetentionPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedShortTermRetentionPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
