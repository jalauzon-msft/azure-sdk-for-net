// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConnectedCache.Models
{
    /// <summary> Model representing customer for connectedCache resource. </summary>
    public partial class MccCustomerProperty
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

        /// <summary> Initializes a new instance of <see cref="MccCustomerProperty"/>. </summary>
        public MccCustomerProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MccCustomerProperty"/>. </summary>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="customer"> Mcc customer resource (customer entity). </param>
        /// <param name="additionalCustomerProperties"> Mcc customer resource additional properties. </param>
        /// <param name="statusCode"> Mcc response status code. </param>
        /// <param name="statusText"> Mcc response status text as string for retrieving status details. </param>
        /// <param name="statusDetails"> Mcc response status details for retrieving response inner details. </param>
        /// <param name="status"> HTTP error status code. </param>
        /// <param name="error"> Mcc response error details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MccCustomerProperty(ConnectedCacheProvisioningState? provisioningState, MccCustomerEntity customer, MccCustomerAdditionalProperties additionalCustomerProperties, string statusCode, string statusText, string statusDetails, string status, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Customer = customer;
            AdditionalCustomerProperties = additionalCustomerProperties;
            StatusCode = statusCode;
            StatusText = statusText;
            StatusDetails = statusDetails;
            Status = status;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioned state of the resource. </summary>
        public ConnectedCacheProvisioningState? ProvisioningState { get; }
        /// <summary> Mcc customer resource (customer entity). </summary>
        public MccCustomerEntity Customer { get; set; }
        /// <summary> Mcc customer resource additional properties. </summary>
        public MccCustomerAdditionalProperties AdditionalCustomerProperties { get; set; }
        /// <summary> Mcc response status code. </summary>
        public string StatusCode { get; }
        /// <summary> Mcc response status text as string for retrieving status details. </summary>
        public string StatusText { get; }
        /// <summary> Mcc response status details for retrieving response inner details. </summary>
        public string StatusDetails { get; }
        /// <summary> HTTP error status code. </summary>
        public string Status { get; }
        /// <summary> Mcc response error details. </summary>
        public ResponseError Error { get; }
    }
}
