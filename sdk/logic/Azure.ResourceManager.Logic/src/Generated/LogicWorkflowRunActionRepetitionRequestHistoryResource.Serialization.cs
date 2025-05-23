// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Logic
{
    public partial class LogicWorkflowRunActionRepetitionRequestHistoryResource : IJsonModel<LogicWorkflowRequestHistoryData>
    {
        void IJsonModel<LogicWorkflowRequestHistoryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LogicWorkflowRequestHistoryData>)Data).Write(writer, options);

        LogicWorkflowRequestHistoryData IJsonModel<LogicWorkflowRequestHistoryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LogicWorkflowRequestHistoryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<LogicWorkflowRequestHistoryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<LogicWorkflowRequestHistoryData>(Data, options, AzureResourceManagerLogicContext.Default);

        LogicWorkflowRequestHistoryData IPersistableModel<LogicWorkflowRequestHistoryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LogicWorkflowRequestHistoryData>(data, options, AzureResourceManagerLogicContext.Default);

        string IPersistableModel<LogicWorkflowRequestHistoryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LogicWorkflowRequestHistoryData>)Data).GetFormatFromOptions(options);
    }
}
