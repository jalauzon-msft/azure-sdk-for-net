// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Type of data directory mapping. </summary>
    public readonly partial struct SqlDataDirectoryType : IEquatable<SqlDataDirectoryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlDataDirectoryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlDataDirectoryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string DataValue = "Data";
        private const string LogValue = "Log";

        /// <summary> Invalid. </summary>
        public static SqlDataDirectoryType Invalid { get; } = new SqlDataDirectoryType(InvalidValue);
        /// <summary> Data. </summary>
        public static SqlDataDirectoryType Data { get; } = new SqlDataDirectoryType(DataValue);
        /// <summary> Log. </summary>
        public static SqlDataDirectoryType Log { get; } = new SqlDataDirectoryType(LogValue);
        /// <summary> Determines if two <see cref="SqlDataDirectoryType"/> values are the same. </summary>
        public static bool operator ==(SqlDataDirectoryType left, SqlDataDirectoryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlDataDirectoryType"/> values are not the same. </summary>
        public static bool operator !=(SqlDataDirectoryType left, SqlDataDirectoryType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqlDataDirectoryType"/>. </summary>
        public static implicit operator SqlDataDirectoryType(string value) => new SqlDataDirectoryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlDataDirectoryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlDataDirectoryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
