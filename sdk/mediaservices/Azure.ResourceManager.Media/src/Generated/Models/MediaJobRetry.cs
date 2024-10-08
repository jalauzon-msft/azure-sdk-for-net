// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Indicates that it may be possible to retry the Job. If retry is unsuccessful, please contact Azure support via Azure Portal. </summary>
    public readonly partial struct MediaJobRetry : IEquatable<MediaJobRetry>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaJobRetry"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaJobRetry(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DoNotRetryValue = "DoNotRetry";
        private const string MayRetryValue = "MayRetry";

        /// <summary> Issue needs to be investigated and then the job resubmitted with corrections or retried once the underlying issue has been corrected. </summary>
        public static MediaJobRetry DoNotRetry { get; } = new MediaJobRetry(DoNotRetryValue);
        /// <summary> Issue may be resolved after waiting for a period of time and resubmitting the same Job. </summary>
        public static MediaJobRetry MayRetry { get; } = new MediaJobRetry(MayRetryValue);
        /// <summary> Determines if two <see cref="MediaJobRetry"/> values are the same. </summary>
        public static bool operator ==(MediaJobRetry left, MediaJobRetry right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaJobRetry"/> values are not the same. </summary>
        public static bool operator !=(MediaJobRetry left, MediaJobRetry right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MediaJobRetry"/>. </summary>
        public static implicit operator MediaJobRetry(string value) => new MediaJobRetry(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaJobRetry other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaJobRetry other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
