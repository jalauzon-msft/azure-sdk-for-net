// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Support status of feature. </summary>
    public readonly partial struct VmResourceFeatureSupportStatus : IEquatable<VmResourceFeatureSupportStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmResourceFeatureSupportStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmResourceFeatureSupportStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string SupportedValue = "Supported";
        private const string DefaultOffValue = "DefaultOFF";
        private const string DefaultOnValue = "DefaultON";
        private const string NotSupportedValue = "NotSupported";

        /// <summary> Invalid. </summary>
        public static VmResourceFeatureSupportStatus Invalid { get; } = new VmResourceFeatureSupportStatus(InvalidValue);
        /// <summary> Supported. </summary>
        public static VmResourceFeatureSupportStatus Supported { get; } = new VmResourceFeatureSupportStatus(SupportedValue);
        /// <summary> DefaultOFF. </summary>
        public static VmResourceFeatureSupportStatus DefaultOff { get; } = new VmResourceFeatureSupportStatus(DefaultOffValue);
        /// <summary> DefaultON. </summary>
        public static VmResourceFeatureSupportStatus DefaultOn { get; } = new VmResourceFeatureSupportStatus(DefaultOnValue);
        /// <summary> NotSupported. </summary>
        public static VmResourceFeatureSupportStatus NotSupported { get; } = new VmResourceFeatureSupportStatus(NotSupportedValue);
        /// <summary> Determines if two <see cref="VmResourceFeatureSupportStatus"/> values are the same. </summary>
        public static bool operator ==(VmResourceFeatureSupportStatus left, VmResourceFeatureSupportStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmResourceFeatureSupportStatus"/> values are not the same. </summary>
        public static bool operator !=(VmResourceFeatureSupportStatus left, VmResourceFeatureSupportStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VmResourceFeatureSupportStatus"/>. </summary>
        public static implicit operator VmResourceFeatureSupportStatus(string value) => new VmResourceFeatureSupportStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmResourceFeatureSupportStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmResourceFeatureSupportStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
