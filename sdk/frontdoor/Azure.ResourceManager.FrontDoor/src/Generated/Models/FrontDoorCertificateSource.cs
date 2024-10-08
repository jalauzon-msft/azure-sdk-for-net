// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the source of the SSL certificate. </summary>
    public readonly partial struct FrontDoorCertificateSource : IEquatable<FrontDoorCertificateSource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorCertificateSource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorCertificateSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureKeyVaultValue = "AzureKeyVault";
        private const string FrontDoorValue = "FrontDoor";

        /// <summary> AzureKeyVault. </summary>
        public static FrontDoorCertificateSource AzureKeyVault { get; } = new FrontDoorCertificateSource(AzureKeyVaultValue);
        /// <summary> FrontDoor. </summary>
        public static FrontDoorCertificateSource FrontDoor { get; } = new FrontDoorCertificateSource(FrontDoorValue);
        /// <summary> Determines if two <see cref="FrontDoorCertificateSource"/> values are the same. </summary>
        public static bool operator ==(FrontDoorCertificateSource left, FrontDoorCertificateSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorCertificateSource"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorCertificateSource left, FrontDoorCertificateSource right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FrontDoorCertificateSource"/>. </summary>
        public static implicit operator FrontDoorCertificateSource(string value) => new FrontDoorCertificateSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorCertificateSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorCertificateSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
