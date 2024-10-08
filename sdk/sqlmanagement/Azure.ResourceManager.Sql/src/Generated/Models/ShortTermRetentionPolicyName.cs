// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ShortTermRetentionPolicyName. </summary>
    public readonly partial struct ShortTermRetentionPolicyName : IEquatable<ShortTermRetentionPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ShortTermRetentionPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ShortTermRetentionPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static ShortTermRetentionPolicyName Default { get; } = new ShortTermRetentionPolicyName(DefaultValue);
        /// <summary> Determines if two <see cref="ShortTermRetentionPolicyName"/> values are the same. </summary>
        public static bool operator ==(ShortTermRetentionPolicyName left, ShortTermRetentionPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ShortTermRetentionPolicyName"/> values are not the same. </summary>
        public static bool operator !=(ShortTermRetentionPolicyName left, ShortTermRetentionPolicyName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ShortTermRetentionPolicyName"/>. </summary>
        public static implicit operator ShortTermRetentionPolicyName(string value) => new ShortTermRetentionPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ShortTermRetentionPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ShortTermRetentionPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
