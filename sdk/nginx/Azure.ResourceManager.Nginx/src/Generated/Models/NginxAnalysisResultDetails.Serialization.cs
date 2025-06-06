// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxAnalysisResultDetails : IUtf8JsonSerializable, IJsonModel<NginxAnalysisResultDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxAnalysisResultDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NginxAnalysisResultDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxAnalysisResultDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxAnalysisResultDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteStartArray();
                foreach (var item in Diagnostics)
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

        NginxAnalysisResultDetails IJsonModel<NginxAnalysisResultDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxAnalysisResultDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxAnalysisResultDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxAnalysisResultDetails(document.RootElement, options);
        }

        internal static NginxAnalysisResultDetails DeserializeNginxAnalysisResultDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<NginxAnalysisDiagnostic> errors = default;
            IReadOnlyList<NginxDiagnosticItem> diagnostics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxAnalysisDiagnostic> array = new List<NginxAnalysisDiagnostic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxAnalysisDiagnostic.DeserializeNginxAnalysisDiagnostic(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxDiagnosticItem> array = new List<NginxDiagnosticItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxDiagnosticItem.DeserializeNginxDiagnosticItem(item, options));
                    }
                    diagnostics = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NginxAnalysisResultDetails(errors ?? new ChangeTrackingList<NginxAnalysisDiagnostic>(), diagnostics ?? new ChangeTrackingList<NginxDiagnosticItem>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxAnalysisResultDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxAnalysisResultDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNginxContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NginxAnalysisResultDetails)} does not support writing '{options.Format}' format.");
            }
        }

        NginxAnalysisResultDetails IPersistableModel<NginxAnalysisResultDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxAnalysisResultDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNginxAnalysisResultDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxAnalysisResultDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxAnalysisResultDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
