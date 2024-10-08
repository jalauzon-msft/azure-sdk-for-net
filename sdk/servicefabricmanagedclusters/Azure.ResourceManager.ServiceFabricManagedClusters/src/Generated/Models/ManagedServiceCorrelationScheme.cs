// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The service correlation scheme. </summary>
    public readonly partial struct ManagedServiceCorrelationScheme : IEquatable<ManagedServiceCorrelationScheme>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedServiceCorrelationScheme"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedServiceCorrelationScheme(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlignedAffinityValue = "AlignedAffinity";
        private const string NonAlignedAffinityValue = "NonAlignedAffinity";

        /// <summary> Aligned affinity ensures that the primaries of the partitions of the affinitized services are collocated on the same nodes. This is the default and is the same as selecting the Affinity scheme. The value is 0. </summary>
        public static ManagedServiceCorrelationScheme AlignedAffinity { get; } = new ManagedServiceCorrelationScheme(AlignedAffinityValue);
        /// <summary> Non-Aligned affinity guarantees that all replicas of each service will be placed on the same nodes. Unlike Aligned Affinity, this does not guarantee that replicas of particular role will be collocated. The value is 1. </summary>
        public static ManagedServiceCorrelationScheme NonAlignedAffinity { get; } = new ManagedServiceCorrelationScheme(NonAlignedAffinityValue);
        /// <summary> Determines if two <see cref="ManagedServiceCorrelationScheme"/> values are the same. </summary>
        public static bool operator ==(ManagedServiceCorrelationScheme left, ManagedServiceCorrelationScheme right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedServiceCorrelationScheme"/> values are not the same. </summary>
        public static bool operator !=(ManagedServiceCorrelationScheme left, ManagedServiceCorrelationScheme right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedServiceCorrelationScheme"/>. </summary>
        public static implicit operator ManagedServiceCorrelationScheme(string value) => new ManagedServiceCorrelationScheme(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedServiceCorrelationScheme other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedServiceCorrelationScheme other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
