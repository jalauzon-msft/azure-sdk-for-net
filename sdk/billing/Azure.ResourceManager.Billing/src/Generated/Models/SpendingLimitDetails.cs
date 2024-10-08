// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The billing profile spending limit. </summary>
    public partial class SpendingLimitDetails
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

        /// <summary> Initializes a new instance of <see cref="SpendingLimitDetails"/>. </summary>
        internal SpendingLimitDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SpendingLimitDetails"/>. </summary>
        /// <param name="amount"> The initial amount for the billing profile. </param>
        /// <param name="currency"> The currency in which the charges for the billing profile are billed. </param>
        /// <param name="startOn"> The date when this spending limit goes into effect. </param>
        /// <param name="endOn"> The date when this spending limit is no longer in effect. </param>
        /// <param name="limitType"> The type of spending limit. </param>
        /// <param name="status"> The status of current spending limit. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SpendingLimitDetails(float? amount, string currency, DateTimeOffset? startOn, DateTimeOffset? endOn, SpendingLimitType? limitType, SpendingLimitStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Amount = amount;
            Currency = currency;
            StartOn = startOn;
            EndOn = endOn;
            LimitType = limitType;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The initial amount for the billing profile. </summary>
        [WirePath("amount")]
        public float? Amount { get; }
        /// <summary> The currency in which the charges for the billing profile are billed. </summary>
        [WirePath("currency")]
        public string Currency { get; }
        /// <summary> The date when this spending limit goes into effect. </summary>
        [WirePath("startDate")]
        public DateTimeOffset? StartOn { get; }
        /// <summary> The date when this spending limit is no longer in effect. </summary>
        [WirePath("endDate")]
        public DateTimeOffset? EndOn { get; }
        /// <summary> The type of spending limit. </summary>
        [WirePath("type")]
        public SpendingLimitType? LimitType { get; }
        /// <summary> The status of current spending limit. </summary>
        [WirePath("status")]
        public SpendingLimitStatus? Status { get; }
    }
}
