// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RecordingFileStatusUpdated event. </summary>
    public partial class AcsRecordingFileStatusUpdatedEventData
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

        /// <summary> Initializes a new instance of <see cref="AcsRecordingFileStatusUpdatedEventData"/>. </summary>
        /// <param name="recordingStorageInfo"> The details of recording storage information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingStorageInfo"/> is null. </exception>
        internal AcsRecordingFileStatusUpdatedEventData(AcsRecordingStorageInfoProperties recordingStorageInfo)
        {
            Argument.AssertNotNull(recordingStorageInfo, nameof(recordingStorageInfo));

            RecordingStorageInfo = recordingStorageInfo;
        }

        /// <summary> Initializes a new instance of <see cref="AcsRecordingFileStatusUpdatedEventData"/>. </summary>
        /// <param name="recordingStorageInfo"> The details of recording storage information. </param>
        /// <param name="recordingStartTime"> The time at which the recording started. </param>
        /// <param name="recordingDurationMs"> The recording duration in milliseconds. </param>
        /// <param name="recordingContentType"> The recording content type- AudioVideo, or Audio. </param>
        /// <param name="recordingChannelKind"> The recording  channel type - Mixed, Unmixed. </param>
        /// <param name="recordingFormatType"> The recording format type - Mp4, Mp3, Wav. </param>
        /// <param name="sessionEndReason"> The reason for ending recording session. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsRecordingFileStatusUpdatedEventData(AcsRecordingStorageInfoProperties recordingStorageInfo, DateTimeOffset? recordingStartTime, long? recordingDurationMs, RecordingContentType? recordingContentType, RecordingChannelType? recordingChannelKind, RecordingFormatType? recordingFormatType, string sessionEndReason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RecordingStorageInfo = recordingStorageInfo;
            RecordingStartTime = recordingStartTime;
            RecordingDurationMs = recordingDurationMs;
            RecordingContentType = recordingContentType;
            RecordingChannelKind = recordingChannelKind;
            RecordingFormatType = recordingFormatType;
            SessionEndReason = sessionEndReason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcsRecordingFileStatusUpdatedEventData"/> for deserialization. </summary>
        internal AcsRecordingFileStatusUpdatedEventData()
        {
        }

        /// <summary> The details of recording storage information. </summary>
        public AcsRecordingStorageInfoProperties RecordingStorageInfo { get; }
        /// <summary> The time at which the recording started. </summary>
        public DateTimeOffset? RecordingStartTime { get; }
        /// <summary> The recording duration in milliseconds. </summary>
        public long? RecordingDurationMs { get; }
        /// <summary> The recording content type- AudioVideo, or Audio. </summary>
        public RecordingContentType? RecordingContentType { get; }
        /// <summary> The recording  channel type - Mixed, Unmixed. </summary>
        public RecordingChannelType? RecordingChannelKind { get; }
        /// <summary> The recording format type - Mp4, Mp3, Wav. </summary>
        public RecordingFormatType? RecordingFormatType { get; }
        /// <summary> The reason for ending recording session. </summary>
        public string SessionEndReason { get; }
    }
}
