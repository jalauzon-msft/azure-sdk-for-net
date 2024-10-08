// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> The text line style name, including handwriting and other. </summary>
    public readonly partial struct TextStyleName : IEquatable<TextStyleName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TextStyleName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TextStyleName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "other";
        private const string HandwritingValue = "handwriting";

        /// <summary> other. </summary>
        public static TextStyleName Other { get; } = new TextStyleName(OtherValue);
        /// <summary> handwriting. </summary>
        public static TextStyleName Handwriting { get; } = new TextStyleName(HandwritingValue);
        /// <summary> Determines if two <see cref="TextStyleName"/> values are the same. </summary>
        public static bool operator ==(TextStyleName left, TextStyleName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TextStyleName"/> values are not the same. </summary>
        public static bool operator !=(TextStyleName left, TextStyleName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TextStyleName"/>. </summary>
        public static implicit operator TextStyleName(string value) => new TextStyleName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TextStyleName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TextStyleName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
