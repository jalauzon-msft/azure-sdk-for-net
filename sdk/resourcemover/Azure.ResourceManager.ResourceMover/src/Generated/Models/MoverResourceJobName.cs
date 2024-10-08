// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the job name. </summary>
    public readonly partial struct MoverResourceJobName : IEquatable<MoverResourceJobName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MoverResourceJobName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MoverResourceJobName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitialSyncValue = "InitialSync";

        /// <summary> InitialSync. </summary>
        public static MoverResourceJobName InitialSync { get; } = new MoverResourceJobName(InitialSyncValue);
        /// <summary> Determines if two <see cref="MoverResourceJobName"/> values are the same. </summary>
        public static bool operator ==(MoverResourceJobName left, MoverResourceJobName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MoverResourceJobName"/> values are not the same. </summary>
        public static bool operator !=(MoverResourceJobName left, MoverResourceJobName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MoverResourceJobName"/>. </summary>
        public static implicit operator MoverResourceJobName(string value) => new MoverResourceJobName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MoverResourceJobName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MoverResourceJobName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
