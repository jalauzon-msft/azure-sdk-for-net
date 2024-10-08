// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The partition mechanism that will be used for Netezza read in parallel. </summary>
    public readonly partial struct NetezzaPartitionOption : IEquatable<NetezzaPartitionOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetezzaPartitionOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetezzaPartitionOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string DataSliceValue = "DataSlice";
        private const string DynamicRangeValue = "DynamicRange";

        /// <summary> None. </summary>
        public static NetezzaPartitionOption None { get; } = new NetezzaPartitionOption(NoneValue);
        /// <summary> DataSlice. </summary>
        public static NetezzaPartitionOption DataSlice { get; } = new NetezzaPartitionOption(DataSliceValue);
        /// <summary> DynamicRange. </summary>
        public static NetezzaPartitionOption DynamicRange { get; } = new NetezzaPartitionOption(DynamicRangeValue);
        /// <summary> Determines if two <see cref="NetezzaPartitionOption"/> values are the same. </summary>
        public static bool operator ==(NetezzaPartitionOption left, NetezzaPartitionOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetezzaPartitionOption"/> values are not the same. </summary>
        public static bool operator !=(NetezzaPartitionOption left, NetezzaPartitionOption right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetezzaPartitionOption"/>. </summary>
        public static implicit operator NetezzaPartitionOption(string value) => new NetezzaPartitionOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetezzaPartitionOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetezzaPartitionOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
