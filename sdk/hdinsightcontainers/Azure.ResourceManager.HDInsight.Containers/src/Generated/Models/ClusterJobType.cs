// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Type of cluster job. </summary>
    internal readonly partial struct ClusterJobType : IEquatable<ClusterJobType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterJobType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterJobType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FlinkJobValue = "FlinkJob";

        /// <summary> FlinkJob. </summary>
        public static ClusterJobType FlinkJob { get; } = new ClusterJobType(FlinkJobValue);
        /// <summary> Determines if two <see cref="ClusterJobType"/> values are the same. </summary>
        public static bool operator ==(ClusterJobType left, ClusterJobType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterJobType"/> values are not the same. </summary>
        public static bool operator !=(ClusterJobType left, ClusterJobType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterJobType"/>. </summary>
        public static implicit operator ClusterJobType(string value) => new ClusterJobType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterJobType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterJobType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
