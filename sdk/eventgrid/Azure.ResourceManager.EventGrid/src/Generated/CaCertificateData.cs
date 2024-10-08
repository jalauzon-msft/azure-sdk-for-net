// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the CaCertificate data model.
    /// The CA Certificate resource.
    /// </summary>
    public partial class CaCertificateData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="CaCertificateData"/>. </summary>
        public CaCertificateData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CaCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description for the CA Certificate resource. </param>
        /// <param name="encodedCertificate"> Base64 encoded PEM (Privacy Enhanced Mail) format certificate data. </param>
        /// <param name="issueTimeInUtc"> Certificate issue time in UTC. This is a read-only field. </param>
        /// <param name="expiryTimeInUtc"> Certificate expiry time in UTC. This is a read-only field. </param>
        /// <param name="provisioningState"> Provisioning state of the CA Certificate resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CaCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string encodedCertificate, DateTimeOffset? issueTimeInUtc, DateTimeOffset? expiryTimeInUtc, CaCertificateProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            EncodedCertificate = encodedCertificate;
            IssueTimeInUtc = issueTimeInUtc;
            ExpiryTimeInUtc = expiryTimeInUtc;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Description for the CA Certificate resource. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> Base64 encoded PEM (Privacy Enhanced Mail) format certificate data. </summary>
        [WirePath("properties.encodedCertificate")]
        public string EncodedCertificate { get; set; }
        /// <summary> Certificate issue time in UTC. This is a read-only field. </summary>
        [WirePath("properties.issueTimeInUtc")]
        public DateTimeOffset? IssueTimeInUtc { get; }
        /// <summary> Certificate expiry time in UTC. This is a read-only field. </summary>
        [WirePath("properties.expiryTimeInUtc")]
        public DateTimeOffset? ExpiryTimeInUtc { get; }
        /// <summary> Provisioning state of the CA Certificate resource. </summary>
        [WirePath("properties.provisioningState")]
        public CaCertificateProvisioningState? ProvisioningState { get; }
    }
}
