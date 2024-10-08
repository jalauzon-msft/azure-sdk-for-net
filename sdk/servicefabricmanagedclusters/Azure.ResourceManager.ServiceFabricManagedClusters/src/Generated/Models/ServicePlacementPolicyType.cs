// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The type of placement policy for a service fabric service. Following are the possible values. </summary>
    internal readonly partial struct ServicePlacementPolicyType : IEquatable<ServicePlacementPolicyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServicePlacementPolicyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServicePlacementPolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidDomainValue = "InvalidDomain";
        private const string RequiredDomainValue = "RequiredDomain";
        private const string PreferredPrimaryDomainValue = "PreferredPrimaryDomain";
        private const string RequiredDomainDistributionValue = "RequiredDomainDistribution";
        private const string NonPartiallyPlaceServiceValue = "NonPartiallyPlaceService";

        /// <summary> Indicates that the ServicePlacementPolicyDescription is of type ServicePlacementInvalidDomainPolicyDescription, which indicates that a particular fault or upgrade domain cannot be used for placement of this service. The value is 0. </summary>
        public static ServicePlacementPolicyType InvalidDomain { get; } = new ServicePlacementPolicyType(InvalidDomainValue);
        /// <summary> Indicates that the ServicePlacementPolicyDescription is of type ServicePlacementRequireDomainDistributionPolicyDescription indicating that the replicas of the service must be placed in a specific domain. The value is 1. </summary>
        public static ServicePlacementPolicyType RequiredDomain { get; } = new ServicePlacementPolicyType(RequiredDomainValue);
        /// <summary> Indicates that the ServicePlacementPolicyDescription is of type ServicePlacementPreferPrimaryDomainPolicyDescription, which indicates that if possible the Primary replica for the partitions of the service should be located in a particular domain as an optimization. The value is 2. </summary>
        public static ServicePlacementPolicyType PreferredPrimaryDomain { get; } = new ServicePlacementPolicyType(PreferredPrimaryDomainValue);
        /// <summary> Indicates that the ServicePlacementPolicyDescription is of type ServicePlacementRequireDomainDistributionPolicyDescription, indicating that the system will disallow placement of any two replicas from the same partition in the same domain at any time. The value is 3. </summary>
        public static ServicePlacementPolicyType RequiredDomainDistribution { get; } = new ServicePlacementPolicyType(RequiredDomainDistributionValue);
        /// <summary> Indicates that the ServicePlacementPolicyDescription is of type ServicePlacementNonPartiallyPlaceServicePolicyDescription, which indicates that if possible all replicas of a particular partition of the service should be placed atomically. The value is 4. </summary>
        public static ServicePlacementPolicyType NonPartiallyPlaceService { get; } = new ServicePlacementPolicyType(NonPartiallyPlaceServiceValue);
        /// <summary> Determines if two <see cref="ServicePlacementPolicyType"/> values are the same. </summary>
        public static bool operator ==(ServicePlacementPolicyType left, ServicePlacementPolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServicePlacementPolicyType"/> values are not the same. </summary>
        public static bool operator !=(ServicePlacementPolicyType left, ServicePlacementPolicyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ServicePlacementPolicyType"/>. </summary>
        public static implicit operator ServicePlacementPolicyType(string value) => new ServicePlacementPolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServicePlacementPolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServicePlacementPolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
