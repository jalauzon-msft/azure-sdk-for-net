// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The prefix validation state. </summary>
    public readonly partial struct PeeringPrefixValidationState : IEquatable<PeeringPrefixValidationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PeeringPrefixValidationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PeeringPrefixValidationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string InvalidValue = "Invalid";
        private const string VerifiedValue = "Verified";
        private const string FailedValue = "Failed";
        private const string PendingValue = "Pending";
        private const string WarningValue = "Warning";
        private const string UnknownValue = "Unknown";

        /// <summary> None. </summary>
        public static PeeringPrefixValidationState None { get; } = new PeeringPrefixValidationState(NoneValue);
        /// <summary> Invalid. </summary>
        public static PeeringPrefixValidationState Invalid { get; } = new PeeringPrefixValidationState(InvalidValue);
        /// <summary> Verified. </summary>
        public static PeeringPrefixValidationState Verified { get; } = new PeeringPrefixValidationState(VerifiedValue);
        /// <summary> Failed. </summary>
        public static PeeringPrefixValidationState Failed { get; } = new PeeringPrefixValidationState(FailedValue);
        /// <summary> Pending. </summary>
        public static PeeringPrefixValidationState Pending { get; } = new PeeringPrefixValidationState(PendingValue);
        /// <summary> Warning. </summary>
        public static PeeringPrefixValidationState Warning { get; } = new PeeringPrefixValidationState(WarningValue);
        /// <summary> Unknown. </summary>
        public static PeeringPrefixValidationState Unknown { get; } = new PeeringPrefixValidationState(UnknownValue);
        /// <summary> Determines if two <see cref="PeeringPrefixValidationState"/> values are the same. </summary>
        public static bool operator ==(PeeringPrefixValidationState left, PeeringPrefixValidationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PeeringPrefixValidationState"/> values are not the same. </summary>
        public static bool operator !=(PeeringPrefixValidationState left, PeeringPrefixValidationState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PeeringPrefixValidationState"/>. </summary>
        public static implicit operator PeeringPrefixValidationState(string value) => new PeeringPrefixValidationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PeeringPrefixValidationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PeeringPrefixValidationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
