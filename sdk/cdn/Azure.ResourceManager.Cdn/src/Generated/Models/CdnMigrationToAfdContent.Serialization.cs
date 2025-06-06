// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnMigrationToAfdContent : IUtf8JsonSerializable, IJsonModel<CdnMigrationToAfdContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnMigrationToAfdContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CdnMigrationToAfdContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnMigrationToAfdContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnMigrationToAfdContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku, options);
            if (Optional.IsCollectionDefined(MigrationEndpointMappings))
            {
                writer.WritePropertyName("migrationEndpointMappings"u8);
                writer.WriteStartArray();
                foreach (var item in MigrationEndpointMappings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        CdnMigrationToAfdContent IJsonModel<CdnMigrationToAfdContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnMigrationToAfdContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnMigrationToAfdContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnMigrationToAfdContent(document.RootElement, options);
        }

        internal static CdnMigrationToAfdContent DeserializeCdnMigrationToAfdContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CdnSku sku = default;
            IList<MigrationEndpointMapping> migrationEndpointMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = CdnSku.DeserializeCdnSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("migrationEndpointMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MigrationEndpointMapping> array = new List<MigrationEndpointMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrationEndpointMapping.DeserializeMigrationEndpointMapping(item, options));
                    }
                    migrationEndpointMappings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CdnMigrationToAfdContent(sku, migrationEndpointMappings ?? new ChangeTrackingList<MigrationEndpointMapping>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CdnMigrationToAfdContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnMigrationToAfdContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCdnContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CdnMigrationToAfdContent)} does not support writing '{options.Format}' format.");
            }
        }

        CdnMigrationToAfdContent IPersistableModel<CdnMigrationToAfdContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnMigrationToAfdContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCdnMigrationToAfdContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnMigrationToAfdContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnMigrationToAfdContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
