// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Peering
{
    public partial class PeeringServiceResource : IJsonModel<PeeringServiceData>
    {
        private static PeeringServiceData s_dataDeserializationInstance;
        private static PeeringServiceData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<PeeringServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PeeringServiceData>)Data).Write(writer, options);

        PeeringServiceData IJsonModel<PeeringServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PeeringServiceData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<PeeringServiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PeeringServiceData>(Data, options, AzureResourceManagerPeeringContext.Default);

        PeeringServiceData IPersistableModel<PeeringServiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PeeringServiceData>(data, options, AzureResourceManagerPeeringContext.Default);

        string IPersistableModel<PeeringServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PeeringServiceData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
