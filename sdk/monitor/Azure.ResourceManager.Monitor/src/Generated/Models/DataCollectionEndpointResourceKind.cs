// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The kind of the resource. </summary>
    public readonly partial struct DataCollectionEndpointResourceKind : IEquatable<DataCollectionEndpointResourceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataCollectionEndpointResourceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataCollectionEndpointResourceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinuxValue = "Linux";
        private const string WindowsValue = "Windows";

        /// <summary> Linux. </summary>
        public static DataCollectionEndpointResourceKind Linux { get; } = new DataCollectionEndpointResourceKind(LinuxValue);
        /// <summary> Windows. </summary>
        public static DataCollectionEndpointResourceKind Windows { get; } = new DataCollectionEndpointResourceKind(WindowsValue);
        /// <summary> Determines if two <see cref="DataCollectionEndpointResourceKind"/> values are the same. </summary>
        public static bool operator ==(DataCollectionEndpointResourceKind left, DataCollectionEndpointResourceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataCollectionEndpointResourceKind"/> values are not the same. </summary>
        public static bool operator !=(DataCollectionEndpointResourceKind left, DataCollectionEndpointResourceKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataCollectionEndpointResourceKind"/>. </summary>
        public static implicit operator DataCollectionEndpointResourceKind(string value) => new DataCollectionEndpointResourceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataCollectionEndpointResourceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataCollectionEndpointResourceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
