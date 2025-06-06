// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class WebSiteSlotTriggeredWebJobHistoryResource : IJsonModel<TriggeredJobHistoryData>
    {
        private static TriggeredJobHistoryData s_dataDeserializationInstance;
        private static TriggeredJobHistoryData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<TriggeredJobHistoryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TriggeredJobHistoryData>)Data).Write(writer, options);

        TriggeredJobHistoryData IJsonModel<TriggeredJobHistoryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TriggeredJobHistoryData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<TriggeredJobHistoryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<TriggeredJobHistoryData>(Data, options, AzureResourceManagerAppServiceContext.Default);

        TriggeredJobHistoryData IPersistableModel<TriggeredJobHistoryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TriggeredJobHistoryData>(data, options, AzureResourceManagerAppServiceContext.Default);

        string IPersistableModel<TriggeredJobHistoryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TriggeredJobHistoryData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
