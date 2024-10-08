// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Detailed transfer status. </summary>
    public partial class DetailedTransferStatus
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

        /// <summary> Initializes a new instance of <see cref="DetailedTransferStatus"/>. </summary>
        internal DetailedTransferStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DetailedTransferStatus"/>. </summary>
        /// <param name="productType"> Type of product that is transferred. </param>
        /// <param name="productId"> The ID of the product that is transferred. </param>
        /// <param name="productName"> The name of the product that is transferred. </param>
        /// <param name="skuDescription"> The SKU of the product that is transferred. </param>
        /// <param name="transferStatus"> Transfer status. </param>
        /// <param name="errorDetails"> Error details for transfer execution. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetailedTransferStatus(BillingProductType? productType, string productId, string productName, string skuDescription, BillingProductTransferStatus? transferStatus, BillingTransferError errorDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProductType = productType;
            ProductId = productId;
            ProductName = productName;
            SkuDescription = skuDescription;
            TransferStatus = transferStatus;
            ErrorDetails = errorDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of product that is transferred. </summary>
        [WirePath("productType")]
        public BillingProductType? ProductType { get; }
        /// <summary> The ID of the product that is transferred. </summary>
        [WirePath("productId")]
        public string ProductId { get; }
        /// <summary> The name of the product that is transferred. </summary>
        [WirePath("productName")]
        public string ProductName { get; }
        /// <summary> The SKU of the product that is transferred. </summary>
        [WirePath("skuDescription")]
        public string SkuDescription { get; }
        /// <summary> Transfer status. </summary>
        [WirePath("transferStatus")]
        public BillingProductTransferStatus? TransferStatus { get; }
        /// <summary> Error details for transfer execution. </summary>
        [WirePath("errorDetails")]
        public BillingTransferError ErrorDetails { get; }
    }
}
