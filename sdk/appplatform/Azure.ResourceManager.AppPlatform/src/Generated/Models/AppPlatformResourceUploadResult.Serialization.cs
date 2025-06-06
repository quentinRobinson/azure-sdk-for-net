// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformResourceUploadResult : IUtf8JsonSerializable, IJsonModel<AppPlatformResourceUploadResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformResourceUploadResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformResourceUploadResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformResourceUploadResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformResourceUploadResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
            if (Optional.IsDefined(UploadUri))
            {
                writer.WritePropertyName("uploadUrl"u8);
                writer.WriteStringValue(UploadUri.AbsoluteUri);
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

        AppPlatformResourceUploadResult IJsonModel<AppPlatformResourceUploadResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformResourceUploadResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformResourceUploadResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformResourceUploadResult(document.RootElement, options);
        }

        internal static AppPlatformResourceUploadResult DeserializeAppPlatformResourceUploadResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string relativePath = default;
            Uri uploadUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformResourceUploadResult(relativePath, uploadUri, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformResourceUploadResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformResourceUploadResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppPlatformContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformResourceUploadResult)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformResourceUploadResult IPersistableModel<AppPlatformResourceUploadResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformResourceUploadResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppPlatformResourceUploadResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformResourceUploadResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformResourceUploadResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
