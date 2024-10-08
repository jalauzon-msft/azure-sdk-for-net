// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The tracking record type. </summary>
    public readonly partial struct IntegrationAccountTrackingRecordType : IEquatable<IntegrationAccountTrackingRecordType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountTrackingRecordType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationAccountTrackingRecordType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string CustomValue = "Custom";
        private const string AS2MessageValue = "AS2Message";
        private const string AS2MdnValue = "AS2MDN";
        private const string X12InterchangeValue = "X12Interchange";
        private const string X12FunctionalGroupValue = "X12FunctionalGroup";
        private const string X12TransactionSetValue = "X12TransactionSet";
        private const string X12InterchangeAcknowledgmentValue = "X12InterchangeAcknowledgment";
        private const string X12FunctionalGroupAcknowledgmentValue = "X12FunctionalGroupAcknowledgment";
        private const string X12TransactionSetAcknowledgmentValue = "X12TransactionSetAcknowledgment";
        private const string EdifactInterchangeValue = "EdifactInterchange";
        private const string EdifactFunctionalGroupValue = "EdifactFunctionalGroup";
        private const string EdifactTransactionSetValue = "EdifactTransactionSet";
        private const string EdifactInterchangeAcknowledgmentValue = "EdifactInterchangeAcknowledgment";
        private const string EdifactFunctionalGroupAcknowledgmentValue = "EdifactFunctionalGroupAcknowledgment";
        private const string EdifactTransactionSetAcknowledgmentValue = "EdifactTransactionSetAcknowledgment";

        /// <summary> NotSpecified. </summary>
        public static IntegrationAccountTrackingRecordType NotSpecified { get; } = new IntegrationAccountTrackingRecordType(NotSpecifiedValue);
        /// <summary> Custom. </summary>
        public static IntegrationAccountTrackingRecordType Custom { get; } = new IntegrationAccountTrackingRecordType(CustomValue);
        /// <summary> AS2Message. </summary>
        public static IntegrationAccountTrackingRecordType AS2Message { get; } = new IntegrationAccountTrackingRecordType(AS2MessageValue);
        /// <summary> AS2MDN. </summary>
        public static IntegrationAccountTrackingRecordType AS2Mdn { get; } = new IntegrationAccountTrackingRecordType(AS2MdnValue);
        /// <summary> X12Interchange. </summary>
        public static IntegrationAccountTrackingRecordType X12Interchange { get; } = new IntegrationAccountTrackingRecordType(X12InterchangeValue);
        /// <summary> X12FunctionalGroup. </summary>
        public static IntegrationAccountTrackingRecordType X12FunctionalGroup { get; } = new IntegrationAccountTrackingRecordType(X12FunctionalGroupValue);
        /// <summary> X12TransactionSet. </summary>
        public static IntegrationAccountTrackingRecordType X12TransactionSet { get; } = new IntegrationAccountTrackingRecordType(X12TransactionSetValue);
        /// <summary> X12InterchangeAcknowledgment. </summary>
        public static IntegrationAccountTrackingRecordType X12InterchangeAcknowledgment { get; } = new IntegrationAccountTrackingRecordType(X12InterchangeAcknowledgmentValue);
        /// <summary> X12FunctionalGroupAcknowledgment. </summary>
        public static IntegrationAccountTrackingRecordType X12FunctionalGroupAcknowledgment { get; } = new IntegrationAccountTrackingRecordType(X12FunctionalGroupAcknowledgmentValue);
        /// <summary> X12TransactionSetAcknowledgment. </summary>
        public static IntegrationAccountTrackingRecordType X12TransactionSetAcknowledgment { get; } = new IntegrationAccountTrackingRecordType(X12TransactionSetAcknowledgmentValue);
        /// <summary> EdifactInterchange. </summary>
        public static IntegrationAccountTrackingRecordType EdifactInterchange { get; } = new IntegrationAccountTrackingRecordType(EdifactInterchangeValue);
        /// <summary> EdifactFunctionalGroup. </summary>
        public static IntegrationAccountTrackingRecordType EdifactFunctionalGroup { get; } = new IntegrationAccountTrackingRecordType(EdifactFunctionalGroupValue);
        /// <summary> EdifactTransactionSet. </summary>
        public static IntegrationAccountTrackingRecordType EdifactTransactionSet { get; } = new IntegrationAccountTrackingRecordType(EdifactTransactionSetValue);
        /// <summary> EdifactInterchangeAcknowledgment. </summary>
        public static IntegrationAccountTrackingRecordType EdifactInterchangeAcknowledgment { get; } = new IntegrationAccountTrackingRecordType(EdifactInterchangeAcknowledgmentValue);
        /// <summary> EdifactFunctionalGroupAcknowledgment. </summary>
        public static IntegrationAccountTrackingRecordType EdifactFunctionalGroupAcknowledgment { get; } = new IntegrationAccountTrackingRecordType(EdifactFunctionalGroupAcknowledgmentValue);
        /// <summary> EdifactTransactionSetAcknowledgment. </summary>
        public static IntegrationAccountTrackingRecordType EdifactTransactionSetAcknowledgment { get; } = new IntegrationAccountTrackingRecordType(EdifactTransactionSetAcknowledgmentValue);
        /// <summary> Determines if two <see cref="IntegrationAccountTrackingRecordType"/> values are the same. </summary>
        public static bool operator ==(IntegrationAccountTrackingRecordType left, IntegrationAccountTrackingRecordType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationAccountTrackingRecordType"/> values are not the same. </summary>
        public static bool operator !=(IntegrationAccountTrackingRecordType left, IntegrationAccountTrackingRecordType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IntegrationAccountTrackingRecordType"/>. </summary>
        public static implicit operator IntegrationAccountTrackingRecordType(string value) => new IntegrationAccountTrackingRecordType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationAccountTrackingRecordType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationAccountTrackingRecordType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
