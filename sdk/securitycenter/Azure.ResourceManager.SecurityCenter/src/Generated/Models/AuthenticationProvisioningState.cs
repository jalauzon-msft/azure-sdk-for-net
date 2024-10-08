// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> State of the multi-cloud connector. </summary>
    public readonly partial struct AuthenticationProvisioningState : IEquatable<AuthenticationProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AuthenticationProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AuthenticationProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidValue = "Valid";
        private const string InvalidValue = "Invalid";
        private const string ExpiredValue = "Expired";
        private const string IncorrectPolicyValue = "IncorrectPolicy";

        /// <summary> Valid connector. </summary>
        public static AuthenticationProvisioningState Valid { get; } = new AuthenticationProvisioningState(ValidValue);
        /// <summary> Invalid connector. </summary>
        public static AuthenticationProvisioningState Invalid { get; } = new AuthenticationProvisioningState(InvalidValue);
        /// <summary> the connection has expired. </summary>
        public static AuthenticationProvisioningState Expired { get; } = new AuthenticationProvisioningState(ExpiredValue);
        /// <summary> Incorrect policy of the connector. </summary>
        public static AuthenticationProvisioningState IncorrectPolicy { get; } = new AuthenticationProvisioningState(IncorrectPolicyValue);
        /// <summary> Determines if two <see cref="AuthenticationProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AuthenticationProvisioningState left, AuthenticationProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuthenticationProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AuthenticationProvisioningState left, AuthenticationProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AuthenticationProvisioningState"/>. </summary>
        public static implicit operator AuthenticationProvisioningState(string value) => new AuthenticationProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuthenticationProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuthenticationProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
