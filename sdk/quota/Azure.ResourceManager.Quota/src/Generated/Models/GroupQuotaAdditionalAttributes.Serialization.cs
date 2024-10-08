// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class GroupQuotaAdditionalAttributes : IUtf8JsonSerializable, IJsonModel<GroupQuotaAdditionalAttributes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GroupQuotaAdditionalAttributes>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GroupQuotaAdditionalAttributes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupQuotaAdditionalAttributes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GroupQuotaAdditionalAttributes)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("groupId"u8);
            writer.WriteObjectValue(GroupId, options);
            if (Optional.IsDefined(Environment))
            {
                writer.WritePropertyName("environment"u8);
                writer.WriteStringValue(Environment.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        GroupQuotaAdditionalAttributes IJsonModel<GroupQuotaAdditionalAttributes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupQuotaAdditionalAttributes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GroupQuotaAdditionalAttributes)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGroupQuotaAdditionalAttributes(document.RootElement, options);
        }

        internal static GroupQuotaAdditionalAttributes DeserializeGroupQuotaAdditionalAttributes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GroupQuotaGroupingId groupId = default;
            GroupQuotaEnvironmentType? environment = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = GroupQuotaGroupingId.DeserializeGroupQuotaGroupingId(property.Value, options);
                    continue;
                }
                if (property.NameEquals("environment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    environment = new GroupQuotaEnvironmentType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GroupQuotaAdditionalAttributes(groupId, environment, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GroupId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  groupId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GroupId))
                {
                    builder.Append("  groupId: ");
                    BicepSerializationHelpers.AppendChildObject(builder, GroupId, options, 2, false, "  groupId: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Environment), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  environment: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Environment))
                {
                    builder.Append("  environment: ");
                    builder.AppendLine($"'{Environment.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<GroupQuotaAdditionalAttributes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupQuotaAdditionalAttributes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GroupQuotaAdditionalAttributes)} does not support writing '{options.Format}' format.");
            }
        }

        GroupQuotaAdditionalAttributes IPersistableModel<GroupQuotaAdditionalAttributes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupQuotaAdditionalAttributes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGroupQuotaAdditionalAttributes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GroupQuotaAdditionalAttributes)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GroupQuotaAdditionalAttributes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
