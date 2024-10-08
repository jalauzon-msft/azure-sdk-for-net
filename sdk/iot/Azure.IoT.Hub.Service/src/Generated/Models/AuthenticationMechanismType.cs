// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The type of authentication used to connect to the service. </summary>
    public readonly partial struct AuthenticationMechanismType : IEquatable<AuthenticationMechanismType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AuthenticationMechanismType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AuthenticationMechanismType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SasValue = "sas";
        private const string SelfSignedValue = "selfSigned";
        private const string CertificateAuthorityValue = "certificateAuthority";
        private const string NoneValue = "none";

        /// <summary> sas. </summary>
        public static AuthenticationMechanismType Sas { get; } = new AuthenticationMechanismType(SasValue);
        /// <summary> selfSigned. </summary>
        public static AuthenticationMechanismType SelfSigned { get; } = new AuthenticationMechanismType(SelfSignedValue);
        /// <summary> certificateAuthority. </summary>
        public static AuthenticationMechanismType CertificateAuthority { get; } = new AuthenticationMechanismType(CertificateAuthorityValue);
        /// <summary> none. </summary>
        public static AuthenticationMechanismType None { get; } = new AuthenticationMechanismType(NoneValue);
        /// <summary> Determines if two <see cref="AuthenticationMechanismType"/> values are the same. </summary>
        public static bool operator ==(AuthenticationMechanismType left, AuthenticationMechanismType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuthenticationMechanismType"/> values are not the same. </summary>
        public static bool operator !=(AuthenticationMechanismType left, AuthenticationMechanismType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AuthenticationMechanismType"/>. </summary>
        public static implicit operator AuthenticationMechanismType(string value) => new AuthenticationMechanismType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuthenticationMechanismType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuthenticationMechanismType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
