// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class ComplianceResultResource : IJsonModel<ComplianceResultData>
    {
        private static ComplianceResultData s_dataDeserializationInstance;
        private static ComplianceResultData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ComplianceResultData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ComplianceResultData>)Data).Write(writer, options);

        ComplianceResultData IJsonModel<ComplianceResultData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ComplianceResultData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ComplianceResultData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ComplianceResultData>(Data, options, AzureResourceManagerSecurityCenterContext.Default);

        ComplianceResultData IPersistableModel<ComplianceResultData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ComplianceResultData>(data, options, AzureResourceManagerSecurityCenterContext.Default);

        string IPersistableModel<ComplianceResultData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ComplianceResultData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
