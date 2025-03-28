// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing the ContainerRegistryCacheRule data model.
    /// An object that represents a cache rule for a container registry.
    /// </summary>
    public partial class ContainerRegistryCacheRuleData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCacheRuleData"/>. </summary>
        public ContainerRegistryCacheRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCacheRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="credentialSetResourceId"> The ARM resource ID of the credential store which is associated with the cache rule. </param>
        /// <param name="sourceRepository"> Source repository pulled from upstream. </param>
        /// <param name="targetRepository">
        /// Target repository specified in docker pull command.
        /// Eg: docker pull myregistry.azurecr.io/{targetRepository}:{tag}
        /// </param>
        /// <param name="createdOn"> The creation date of the cache rule. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryCacheRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier credentialSetResourceId, string sourceRepository, string targetRepository, DateTimeOffset? createdOn, ContainerRegistryProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CredentialSetResourceId = credentialSetResourceId;
            SourceRepository = sourceRepository;
            TargetRepository = targetRepository;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ARM resource ID of the credential store which is associated with the cache rule. </summary>
        [WirePath("properties.credentialSetResourceId")]
        public ResourceIdentifier CredentialSetResourceId { get; set; }
        /// <summary> Source repository pulled from upstream. </summary>
        [WirePath("properties.sourceRepository")]
        public string SourceRepository { get; set; }
        /// <summary>
        /// Target repository specified in docker pull command.
        /// Eg: docker pull myregistry.azurecr.io/{targetRepository}:{tag}
        /// </summary>
        [WirePath("properties.targetRepository")]
        public string TargetRepository { get; set; }
        /// <summary> The creation date of the cache rule. </summary>
        [WirePath("properties.creationDate")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Provisioning state of the resource. </summary>
        [WirePath("properties.provisioningState")]
        public ContainerRegistryProvisioningState? ProvisioningState { get; }
    }
}
