// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The State of the disco run. </summary>
    public readonly partial struct DiscoRunState : IEquatable<DiscoRunState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiscoRunState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiscoRunState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "pending";
        private const string RunningValue = "running";
        private const string CompletedValue = "completed";
        private const string FailedValue = "failed";

        /// <summary> pending. </summary>
        public static DiscoRunState Pending { get; } = new DiscoRunState(PendingValue);
        /// <summary> running. </summary>
        public static DiscoRunState Running { get; } = new DiscoRunState(RunningValue);
        /// <summary> completed. </summary>
        public static DiscoRunState Completed { get; } = new DiscoRunState(CompletedValue);
        /// <summary> failed. </summary>
        public static DiscoRunState Failed { get; } = new DiscoRunState(FailedValue);
        /// <summary> Determines if two <see cref="DiscoRunState"/> values are the same. </summary>
        public static bool operator ==(DiscoRunState left, DiscoRunState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiscoRunState"/> values are not the same. </summary>
        public static bool operator !=(DiscoRunState left, DiscoRunState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DiscoRunState"/>. </summary>
        public static implicit operator DiscoRunState(string value) => new DiscoRunState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiscoRunState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiscoRunState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
