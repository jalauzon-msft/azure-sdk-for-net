// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Current status of the validation. </summary>
    public readonly partial struct ValidationStatus : IEquatable<ValidationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ValidationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ValidationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string NotStartedValue = "NotStarted";
        private const string InitializedValue = "Initialized";
        private const string InProgressValue = "InProgress";
        private const string CompletedValue = "Completed";
        private const string CompletedWithIssuesValue = "CompletedWithIssues";
        private const string StoppedValue = "Stopped";
        private const string FailedValue = "Failed";

        /// <summary> Default. </summary>
        public static ValidationStatus Default { get; } = new ValidationStatus(DefaultValue);
        /// <summary> NotStarted. </summary>
        public static ValidationStatus NotStarted { get; } = new ValidationStatus(NotStartedValue);
        /// <summary> Initialized. </summary>
        public static ValidationStatus Initialized { get; } = new ValidationStatus(InitializedValue);
        /// <summary> InProgress. </summary>
        public static ValidationStatus InProgress { get; } = new ValidationStatus(InProgressValue);
        /// <summary> Completed. </summary>
        public static ValidationStatus Completed { get; } = new ValidationStatus(CompletedValue);
        /// <summary> CompletedWithIssues. </summary>
        public static ValidationStatus CompletedWithIssues { get; } = new ValidationStatus(CompletedWithIssuesValue);
        /// <summary> Stopped. </summary>
        public static ValidationStatus Stopped { get; } = new ValidationStatus(StoppedValue);
        /// <summary> Failed. </summary>
        public static ValidationStatus Failed { get; } = new ValidationStatus(FailedValue);
        /// <summary> Determines if two <see cref="ValidationStatus"/> values are the same. </summary>
        public static bool operator ==(ValidationStatus left, ValidationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ValidationStatus"/> values are not the same. </summary>
        public static bool operator !=(ValidationStatus left, ValidationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ValidationStatus"/>. </summary>
        public static implicit operator ValidationStatus(string value) => new ValidationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ValidationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ValidationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
