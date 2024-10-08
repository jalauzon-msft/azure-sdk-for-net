// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See aka.ms/AzureManagedPrometheus for an overview. </summary>
    public partial class ManagedClusterMonitorProfileMetrics
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterMonitorProfileMetrics"/>. </summary>
        /// <param name="isEnabled"> Whether to enable or disable the Azure Managed Prometheus addon for Prometheus monitoring. See aka.ms/AzureManagedPrometheus-aks-enable for details on enabling and disabling. </param>
        public ManagedClusterMonitorProfileMetrics(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterMonitorProfileMetrics"/>. </summary>
        /// <param name="isEnabled"> Whether to enable or disable the Azure Managed Prometheus addon for Prometheus monitoring. See aka.ms/AzureManagedPrometheus-aks-enable for details on enabling and disabling. </param>
        /// <param name="kubeStateMetrics"> Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterMonitorProfileMetrics(bool isEnabled, ManagedClusterMonitorProfileKubeStateMetrics kubeStateMetrics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            KubeStateMetrics = kubeStateMetrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterMonitorProfileMetrics"/> for deserialization. </summary>
        internal ManagedClusterMonitorProfileMetrics()
        {
        }

        /// <summary> Whether to enable or disable the Azure Managed Prometheus addon for Prometheus monitoring. See aka.ms/AzureManagedPrometheus-aks-enable for details on enabling and disabling. </summary>
        [WirePath("enabled")]
        public bool IsEnabled { get; set; }
        /// <summary> Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details. </summary>
        [WirePath("kubeStateMetrics")]
        public ManagedClusterMonitorProfileKubeStateMetrics KubeStateMetrics { get; set; }
    }
}
