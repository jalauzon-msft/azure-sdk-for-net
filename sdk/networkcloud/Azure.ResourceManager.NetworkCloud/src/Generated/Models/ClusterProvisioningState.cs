// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The provisioning state of the cluster. </summary>
    public readonly partial struct ClusterProvisioningState : IEquatable<ClusterProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string AcceptedValue = "Accepted";
        private const string ValidatingValue = "Validating";
        private const string UpdatingValue = "Updating";

        /// <summary> Succeeded. </summary>
        public static ClusterProvisioningState Succeeded { get; } = new ClusterProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ClusterProvisioningState Failed { get; } = new ClusterProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ClusterProvisioningState Canceled { get; } = new ClusterProvisioningState(CanceledValue);
        /// <summary> Accepted. </summary>
        public static ClusterProvisioningState Accepted { get; } = new ClusterProvisioningState(AcceptedValue);
        /// <summary> Validating. </summary>
        public static ClusterProvisioningState Validating { get; } = new ClusterProvisioningState(ValidatingValue);
        /// <summary> Updating. </summary>
        public static ClusterProvisioningState Updating { get; } = new ClusterProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="ClusterProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ClusterProvisioningState left, ClusterProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ClusterProvisioningState left, ClusterProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterProvisioningState"/>. </summary>
        public static implicit operator ClusterProvisioningState(string value) => new ClusterProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
