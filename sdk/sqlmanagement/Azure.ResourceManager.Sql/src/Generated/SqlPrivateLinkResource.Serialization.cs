// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlPrivateLinkResource : IJsonModel<SqlPrivateLinkResourceData>
    {
        private static SqlPrivateLinkResourceData s_dataDeserializationInstance;
        private static SqlPrivateLinkResourceData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SqlPrivateLinkResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlPrivateLinkResourceData>)Data).Write(writer, options);

        SqlPrivateLinkResourceData IJsonModel<SqlPrivateLinkResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlPrivateLinkResourceData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SqlPrivateLinkResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SqlPrivateLinkResourceData>(Data, options, AzureResourceManagerSqlContext.Default);

        SqlPrivateLinkResourceData IPersistableModel<SqlPrivateLinkResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlPrivateLinkResourceData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<SqlPrivateLinkResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlPrivateLinkResourceData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
