// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary>
    /// A representation of configuration data for a single Azure OpenAI chat data source.
    /// This will be used by a chat completions request that should use Azure OpenAI chat extensions to augment the
    /// response behavior.
    /// The use of this configuration is compatible only with Azure OpenAI.
    /// Please note <see cref="ChatDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CosmosChatDataSource"/>, <see cref="AzureSearchChatDataSource"/>, <see cref="ElasticsearchChatDataSource"/>, <see cref="MongoDBChatDataSource"/> and <see cref="PineconeChatDataSource"/>.
    /// </summary>
    public abstract partial class ChatDataSource
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
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        /// <summary> Initializes a new instance of <see cref="ChatDataSource"/>. </summary>
        protected ChatDataSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChatDataSource"/>. </summary>
        /// <param name="type"> The differentiating type identifier for the data source. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatDataSource(string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The differentiating type identifier for the data source. </summary>
        internal string Type { get; set; }
    }
}
