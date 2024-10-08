// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents Codeless API Polling data connector. </summary>
    public partial class DataConnectorConnectContent
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

        /// <summary> Initializes a new instance of <see cref="DataConnectorConnectContent"/>. </summary>
        public DataConnectorConnectContent()
        {
            RequestConfigUserInputValues = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataConnectorConnectContent"/>. </summary>
        /// <param name="kind"> The authentication kind used to poll the data. </param>
        /// <param name="apiKey"> The API key of the audit server. </param>
        /// <param name="dataCollectionEndpoint"> Used in v2 logs connector. Represents the data collection ingestion endpoint in log analytics. </param>
        /// <param name="dataCollectionRuleImmutableId"> Used in v2 logs connector. The data collection rule immutable id, the rule defines the transformation and data destination. </param>
        /// <param name="outputStream"> Used in v2 logs connector. The stream we are sending the data to, this is the name of the streamDeclarations defined in the DCR. </param>
        /// <param name="clientSecret"> The client secret of the OAuth 2.0 application. </param>
        /// <param name="clientId"> The client id of the OAuth 2.0 application. </param>
        /// <param name="authorizationCode"> The authorization code used in OAuth 2.0 code flow to issue a token. </param>
        /// <param name="userName"> The user name in the audit log server. </param>
        /// <param name="password"> The user password in the audit log server. </param>
        /// <param name="requestConfigUserInputValues"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataConnectorConnectContent(ConnectAuthKind? kind, string apiKey, string dataCollectionEndpoint, string dataCollectionRuleImmutableId, string outputStream, string clientSecret, string clientId, string authorizationCode, string userName, string password, IList<BinaryData> requestConfigUserInputValues, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            ApiKey = apiKey;
            DataCollectionEndpoint = dataCollectionEndpoint;
            DataCollectionRuleImmutableId = dataCollectionRuleImmutableId;
            OutputStream = outputStream;
            ClientSecret = clientSecret;
            ClientId = clientId;
            AuthorizationCode = authorizationCode;
            UserName = userName;
            Password = password;
            RequestConfigUserInputValues = requestConfigUserInputValues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The authentication kind used to poll the data. </summary>
        [WirePath("kind")]
        public ConnectAuthKind? Kind { get; set; }
        /// <summary> The API key of the audit server. </summary>
        [WirePath("apiKey")]
        public string ApiKey { get; set; }
        /// <summary> Used in v2 logs connector. Represents the data collection ingestion endpoint in log analytics. </summary>
        [WirePath("dataCollectionEndpoint")]
        public string DataCollectionEndpoint { get; set; }
        /// <summary> Used in v2 logs connector. The data collection rule immutable id, the rule defines the transformation and data destination. </summary>
        [WirePath("dataCollectionRuleImmutableId")]
        public string DataCollectionRuleImmutableId { get; set; }
        /// <summary> Used in v2 logs connector. The stream we are sending the data to, this is the name of the streamDeclarations defined in the DCR. </summary>
        [WirePath("outputStream")]
        public string OutputStream { get; set; }
        /// <summary> The client secret of the OAuth 2.0 application. </summary>
        [WirePath("clientSecret")]
        public string ClientSecret { get; set; }
        /// <summary> The client id of the OAuth 2.0 application. </summary>
        [WirePath("clientId")]
        public string ClientId { get; set; }
        /// <summary> The authorization code used in OAuth 2.0 code flow to issue a token. </summary>
        [WirePath("authorizationCode")]
        public string AuthorizationCode { get; set; }
        /// <summary> The user name in the audit log server. </summary>
        [WirePath("userName")]
        public string UserName { get; set; }
        /// <summary> The user password in the audit log server. </summary>
        [WirePath("password")]
        public string Password { get; set; }
        /// <summary>
        /// Gets the request config user input values
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("requestConfigUserInputValues")]
        public IList<BinaryData> RequestConfigUserInputValues { get; }
    }
}
