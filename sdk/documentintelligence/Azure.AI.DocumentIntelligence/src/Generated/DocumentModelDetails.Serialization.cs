// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentModelDetails : IUtf8JsonSerializable, IJsonModel<DocumentModelDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentModelDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DocumentModelDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentModelDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("createdDateTime"u8);
                writer.WriteStringValue(CreatedOn, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiresOn))
            {
                writer.WritePropertyName("expirationDateTime"u8);
                writer.WriteStringValue(ExpiresOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ModifiedOn))
            {
                writer.WritePropertyName("modifiedDateTime"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(BuildMode))
            {
                writer.WritePropertyName("buildMode"u8);
                writer.WriteStringValue(BuildMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BlobSource))
            {
                writer.WritePropertyName("azureBlobSource"u8);
                writer.WriteObjectValue(BlobSource, options);
            }
            if (options.Format != "W" && Optional.IsDefined(BlobFileListSource))
            {
                writer.WritePropertyName("azureBlobFileListSource"u8);
                writer.WriteObjectValue(BlobFileListSource, options);
            }
            if (Optional.IsDefined(ClassifierId))
            {
                writer.WritePropertyName("classifierId"u8);
                writer.WriteStringValue(ClassifierId);
            }
            if (Optional.IsDefined(Split))
            {
                writer.WritePropertyName("split"u8);
                writer.WriteStringValue(Split.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DocumentTypes))
            {
                writer.WritePropertyName("docTypes"u8);
                writer.WriteStartObject();
                foreach (var item in DocumentTypes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Warnings))
            {
                writer.WritePropertyName("warnings"u8);
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TrainingHours))
            {
                writer.WritePropertyName("trainingHours"u8);
                writer.WriteNumberValue(TrainingHours.Value);
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

        DocumentModelDetails IJsonModel<DocumentModelDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentModelDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentModelDetails(document.RootElement, options);
        }

        internal static DocumentModelDetails DeserializeDocumentModelDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            string description = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset? expirationDateTime = default;
            DateTimeOffset? modifiedDateTime = default;
            string apiVersion = default;
            IReadOnlyDictionary<string, string> tags = default;
            DocumentBuildMode? buildMode = default;
            BlobContentSource azureBlobSource = default;
            BlobFileListContentSource azureBlobFileListSource = default;
            string classifierId = default;
            SplitMode? split = default;
            IReadOnlyDictionary<string, DocumentTypeDetails> docTypes = default;
            IReadOnlyList<DocumentIntelligenceWarning> warnings = default;
            float? trainingHours = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("buildMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    buildMode = new DocumentBuildMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureBlobSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobSource = BlobContentSource.DeserializeBlobContentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureBlobFileListSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobFileListSource = BlobFileListContentSource.DeserializeBlobFileListContentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("classifierId"u8))
                {
                    classifierId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("split"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    split = new SplitMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("docTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DocumentTypeDetails> dictionary = new Dictionary<string, DocumentTypeDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DocumentTypeDetails.DeserializeDocumentTypeDetails(property0.Value, options));
                    }
                    docTypes = dictionary;
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentIntelligenceWarning> array = new List<DocumentIntelligenceWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentIntelligenceWarning.DeserializeDocumentIntelligenceWarning(item, options));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("trainingHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trainingHours = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DocumentModelDetails(
                modelId,
                description,
                createdDateTime,
                expirationDateTime,
                modifiedDateTime,
                apiVersion,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                buildMode,
                azureBlobSource,
                azureBlobFileListSource,
                classifierId,
                split,
                docTypes ?? new ChangeTrackingDictionary<string, DocumentTypeDetails>(),
                warnings ?? new ChangeTrackingList<DocumentIntelligenceWarning>(),
                trainingHours,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentModelDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIDocumentIntelligenceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DocumentModelDetails)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentModelDetails IPersistableModel<DocumentModelDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDocumentModelDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentModelDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentModelDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentModelDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDocumentModelDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
