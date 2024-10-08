// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The StorageAccountFailoverType. </summary>
    public readonly partial struct StorageAccountFailoverType : IEquatable<StorageAccountFailoverType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageAccountFailoverType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageAccountFailoverType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PlannedValue = "Planned";

        /// <summary> Planned. </summary>
        public static StorageAccountFailoverType Planned { get; } = new StorageAccountFailoverType(PlannedValue);
        /// <summary> Determines if two <see cref="StorageAccountFailoverType"/> values are the same. </summary>
        public static bool operator ==(StorageAccountFailoverType left, StorageAccountFailoverType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageAccountFailoverType"/> values are not the same. </summary>
        public static bool operator !=(StorageAccountFailoverType left, StorageAccountFailoverType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageAccountFailoverType"/>. </summary>
        public static implicit operator StorageAccountFailoverType(string value) => new StorageAccountFailoverType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageAccountFailoverType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageAccountFailoverType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
