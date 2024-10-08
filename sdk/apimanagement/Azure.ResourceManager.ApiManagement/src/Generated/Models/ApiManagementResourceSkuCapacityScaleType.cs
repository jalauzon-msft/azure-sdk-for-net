// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The scale type applicable to the sku. </summary>
    public readonly partial struct ApiManagementResourceSkuCapacityScaleType : IEquatable<ApiManagementResourceSkuCapacityScaleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiManagementResourceSkuCapacityScaleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiManagementResourceSkuCapacityScaleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutomaticValue = "automatic";
        private const string ManualValue = "manual";
        private const string NoneValue = "none";

        /// <summary> Supported scale type automatic. </summary>
        public static ApiManagementResourceSkuCapacityScaleType Automatic { get; } = new ApiManagementResourceSkuCapacityScaleType(AutomaticValue);
        /// <summary> Supported scale type manual. </summary>
        public static ApiManagementResourceSkuCapacityScaleType Manual { get; } = new ApiManagementResourceSkuCapacityScaleType(ManualValue);
        /// <summary> Scaling not supported. </summary>
        public static ApiManagementResourceSkuCapacityScaleType None { get; } = new ApiManagementResourceSkuCapacityScaleType(NoneValue);
        /// <summary> Determines if two <see cref="ApiManagementResourceSkuCapacityScaleType"/> values are the same. </summary>
        public static bool operator ==(ApiManagementResourceSkuCapacityScaleType left, ApiManagementResourceSkuCapacityScaleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiManagementResourceSkuCapacityScaleType"/> values are not the same. </summary>
        public static bool operator !=(ApiManagementResourceSkuCapacityScaleType left, ApiManagementResourceSkuCapacityScaleType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApiManagementResourceSkuCapacityScaleType"/>. </summary>
        public static implicit operator ApiManagementResourceSkuCapacityScaleType(string value) => new ApiManagementResourceSkuCapacityScaleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiManagementResourceSkuCapacityScaleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiManagementResourceSkuCapacityScaleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
