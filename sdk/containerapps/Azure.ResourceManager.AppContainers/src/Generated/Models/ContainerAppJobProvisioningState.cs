// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Provisioning state of the Container Apps Job. </summary>
    public readonly partial struct ContainerAppJobProvisioningState : IEquatable<ContainerAppJobProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppJobProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";

        /// <summary> InProgress. </summary>
        public static ContainerAppJobProvisioningState InProgress { get; } = new ContainerAppJobProvisioningState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static ContainerAppJobProvisioningState Succeeded { get; } = new ContainerAppJobProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ContainerAppJobProvisioningState Failed { get; } = new ContainerAppJobProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ContainerAppJobProvisioningState Canceled { get; } = new ContainerAppJobProvisioningState(CanceledValue);
        /// <summary> Deleting. </summary>
        public static ContainerAppJobProvisioningState Deleting { get; } = new ContainerAppJobProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="ContainerAppJobProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ContainerAppJobProvisioningState left, ContainerAppJobProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppJobProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppJobProvisioningState left, ContainerAppJobProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerAppJobProvisioningState"/>. </summary>
        public static implicit operator ContainerAppJobProvisioningState(string value) => new ContainerAppJobProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppJobProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppJobProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
