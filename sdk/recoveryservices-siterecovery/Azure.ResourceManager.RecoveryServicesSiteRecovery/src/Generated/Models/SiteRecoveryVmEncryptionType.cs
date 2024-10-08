// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The encryption type of the VM. </summary>
    public readonly partial struct SiteRecoveryVmEncryptionType : IEquatable<SiteRecoveryVmEncryptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVmEncryptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SiteRecoveryVmEncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotEncryptedValue = "NotEncrypted";
        private const string OnePassEncryptedValue = "OnePassEncrypted";
        private const string TwoPassEncryptedValue = "TwoPassEncrypted";

        /// <summary> NotEncrypted. </summary>
        public static SiteRecoveryVmEncryptionType NotEncrypted { get; } = new SiteRecoveryVmEncryptionType(NotEncryptedValue);
        /// <summary> OnePassEncrypted. </summary>
        public static SiteRecoveryVmEncryptionType OnePassEncrypted { get; } = new SiteRecoveryVmEncryptionType(OnePassEncryptedValue);
        /// <summary> TwoPassEncrypted. </summary>
        public static SiteRecoveryVmEncryptionType TwoPassEncrypted { get; } = new SiteRecoveryVmEncryptionType(TwoPassEncryptedValue);
        /// <summary> Determines if two <see cref="SiteRecoveryVmEncryptionType"/> values are the same. </summary>
        public static bool operator ==(SiteRecoveryVmEncryptionType left, SiteRecoveryVmEncryptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SiteRecoveryVmEncryptionType"/> values are not the same. </summary>
        public static bool operator !=(SiteRecoveryVmEncryptionType left, SiteRecoveryVmEncryptionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SiteRecoveryVmEncryptionType"/>. </summary>
        public static implicit operator SiteRecoveryVmEncryptionType(string value) => new SiteRecoveryVmEncryptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SiteRecoveryVmEncryptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SiteRecoveryVmEncryptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
