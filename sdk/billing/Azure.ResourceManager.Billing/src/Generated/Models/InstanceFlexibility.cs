// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type. </summary>
    public readonly partial struct InstanceFlexibility : IEquatable<InstanceFlexibility>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InstanceFlexibility"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InstanceFlexibility(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnValue = "On";
        private const string OffValue = "Off";

        /// <summary> On. </summary>
        public static InstanceFlexibility On { get; } = new InstanceFlexibility(OnValue);
        /// <summary> Off. </summary>
        public static InstanceFlexibility Off { get; } = new InstanceFlexibility(OffValue);
        /// <summary> Determines if two <see cref="InstanceFlexibility"/> values are the same. </summary>
        public static bool operator ==(InstanceFlexibility left, InstanceFlexibility right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InstanceFlexibility"/> values are not the same. </summary>
        public static bool operator !=(InstanceFlexibility left, InstanceFlexibility right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InstanceFlexibility"/>. </summary>
        public static implicit operator InstanceFlexibility(string value) => new InstanceFlexibility(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InstanceFlexibility other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InstanceFlexibility other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
