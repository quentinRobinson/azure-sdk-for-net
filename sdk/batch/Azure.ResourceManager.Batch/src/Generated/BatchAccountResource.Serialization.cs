// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Batch
{
    public partial class BatchAccountResource : IJsonModel<BatchAccountData>
    {
        private static BatchAccountData s_dataDeserializationInstance;
        private static BatchAccountData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<BatchAccountData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BatchAccountData>)Data).Write(writer, options);

        BatchAccountData IJsonModel<BatchAccountData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BatchAccountData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<BatchAccountData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<BatchAccountData>(Data, options, AzureResourceManagerBatchContext.Default);

        BatchAccountData IPersistableModel<BatchAccountData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BatchAccountData>(data, options, AzureResourceManagerBatchContext.Default);

        string IPersistableModel<BatchAccountData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BatchAccountData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
