// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> Whether or not public endpoint access is allowed for this Mongo cluster.  Value is optional and default value is 'Enabled'. </summary>
    public readonly partial struct MongoClusterPublicNetworkAccess : IEquatable<MongoClusterPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoClusterPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoClusterPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> If set, mongo cluster can be accessed through private and public methods. </summary>
        public static MongoClusterPublicNetworkAccess Enabled { get; } = new MongoClusterPublicNetworkAccess(EnabledValue);
        /// <summary> If set, the private endpoints are the exclusive access method. </summary>
        public static MongoClusterPublicNetworkAccess Disabled { get; } = new MongoClusterPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="MongoClusterPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(MongoClusterPublicNetworkAccess left, MongoClusterPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoClusterPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(MongoClusterPublicNetworkAccess left, MongoClusterPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MongoClusterPublicNetworkAccess"/>. </summary>
        public static implicit operator MongoClusterPublicNetworkAccess(string value) => new MongoClusterPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoClusterPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoClusterPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
