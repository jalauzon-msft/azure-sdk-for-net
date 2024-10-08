// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Indicates whether or not the HPC Cache has performed the username download successfully. </summary>
    public readonly partial struct StorageCacheUsernameDownloadedType : IEquatable<StorageCacheUsernameDownloadedType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageCacheUsernameDownloadedType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageCacheUsernameDownloadedType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string YesValue = "Yes";
        private const string NoValue = "No";
        private const string ErrorValue = "Error";

        /// <summary> Yes. </summary>
        public static StorageCacheUsernameDownloadedType Yes { get; } = new StorageCacheUsernameDownloadedType(YesValue);
        /// <summary> No. </summary>
        public static StorageCacheUsernameDownloadedType No { get; } = new StorageCacheUsernameDownloadedType(NoValue);
        /// <summary> Error. </summary>
        public static StorageCacheUsernameDownloadedType Error { get; } = new StorageCacheUsernameDownloadedType(ErrorValue);
        /// <summary> Determines if two <see cref="StorageCacheUsernameDownloadedType"/> values are the same. </summary>
        public static bool operator ==(StorageCacheUsernameDownloadedType left, StorageCacheUsernameDownloadedType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageCacheUsernameDownloadedType"/> values are not the same. </summary>
        public static bool operator !=(StorageCacheUsernameDownloadedType left, StorageCacheUsernameDownloadedType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageCacheUsernameDownloadedType"/>. </summary>
        public static implicit operator StorageCacheUsernameDownloadedType(string value) => new StorageCacheUsernameDownloadedType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageCacheUsernameDownloadedType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageCacheUsernameDownloadedType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
