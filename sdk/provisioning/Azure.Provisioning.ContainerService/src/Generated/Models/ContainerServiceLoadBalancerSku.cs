// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// The default is &apos;standard&apos;. See [Azure Load Balancer
/// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more
/// information about the differences between load balancer SKUs.
/// </summary>
public enum ContainerServiceLoadBalancerSku
{
    /// <summary>
    /// Use a a standard Load Balancer. This is the recommended Load Balancer
    /// SKU. For more information about on working with the load balancer in
    /// the managed cluster, see the [standard Load
    /// Balancer](https://docs.microsoft.com/azure/aks/load-balancer-standard)
    /// article.
    /// </summary>
    [DataMember(Name = "standard")]
    Standard,

    /// <summary>
    /// Use a basic Load Balancer with limited functionality.
    /// </summary>
    [DataMember(Name = "basic")]
    Basic,
}
