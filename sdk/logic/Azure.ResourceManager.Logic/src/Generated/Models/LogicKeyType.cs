// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The key type. </summary>
    public readonly partial struct LogicKeyType : IEquatable<LogicKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string PrimaryValue = "Primary";
        private const string SecondaryValue = "Secondary";

        /// <summary> NotSpecified. </summary>
        public static LogicKeyType NotSpecified { get; } = new LogicKeyType(NotSpecifiedValue);
        /// <summary> Primary. </summary>
        public static LogicKeyType Primary { get; } = new LogicKeyType(PrimaryValue);
        /// <summary> Secondary. </summary>
        public static LogicKeyType Secondary { get; } = new LogicKeyType(SecondaryValue);
        /// <summary> Determines if two <see cref="LogicKeyType"/> values are the same. </summary>
        public static bool operator ==(LogicKeyType left, LogicKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicKeyType"/> values are not the same. </summary>
        public static bool operator !=(LogicKeyType left, LogicKeyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LogicKeyType"/>. </summary>
        public static implicit operator LogicKeyType(string value) => new LogicKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
