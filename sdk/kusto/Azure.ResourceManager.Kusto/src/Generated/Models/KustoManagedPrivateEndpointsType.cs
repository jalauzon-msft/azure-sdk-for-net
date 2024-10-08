// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The type of resource, for instance Microsoft.Kusto/clusters/managedPrivateEndpoints. </summary>
    public readonly partial struct KustoManagedPrivateEndpointsType : IEquatable<KustoManagedPrivateEndpointsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoManagedPrivateEndpointsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoManagedPrivateEndpointsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftKustoClustersManagedPrivateEndpointsValue = "Microsoft.Kusto/clusters/managedPrivateEndpoints";

        /// <summary> Microsoft.Kusto/clusters/managedPrivateEndpoints. </summary>
        public static KustoManagedPrivateEndpointsType MicrosoftKustoClustersManagedPrivateEndpoints { get; } = new KustoManagedPrivateEndpointsType(MicrosoftKustoClustersManagedPrivateEndpointsValue);
        /// <summary> Determines if two <see cref="KustoManagedPrivateEndpointsType"/> values are the same. </summary>
        public static bool operator ==(KustoManagedPrivateEndpointsType left, KustoManagedPrivateEndpointsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoManagedPrivateEndpointsType"/> values are not the same. </summary>
        public static bool operator !=(KustoManagedPrivateEndpointsType left, KustoManagedPrivateEndpointsType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KustoManagedPrivateEndpointsType"/>. </summary>
        public static implicit operator KustoManagedPrivateEndpointsType(string value) => new KustoManagedPrivateEndpointsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoManagedPrivateEndpointsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoManagedPrivateEndpointsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
