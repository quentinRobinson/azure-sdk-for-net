// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class FileShareProtectableItem : IUtf8JsonSerializable, IJsonModel<FileShareProtectableItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FileShareProtectableItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FileShareProtectableItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareProtectableItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileShareProtectableItem)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ParentContainerFabricId))
            {
                writer.WritePropertyName("parentContainerFabricId"u8);
                writer.WriteStringValue(ParentContainerFabricId);
            }
            if (Optional.IsDefined(ParentContainerFriendlyName))
            {
                writer.WritePropertyName("parentContainerFriendlyName"u8);
                writer.WriteStringValue(ParentContainerFriendlyName);
            }
            if (Optional.IsDefined(AzureFileShareType))
            {
                writer.WritePropertyName("azureFileShareType"u8);
                writer.WriteStringValue(AzureFileShareType.Value.ToString());
            }
        }

        FileShareProtectableItem IJsonModel<FileShareProtectableItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareProtectableItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileShareProtectableItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileShareProtectableItem(document.RootElement, options);
        }

        internal static FileShareProtectableItem DeserializeFileShareProtectableItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string parentContainerFabricId = default;
            string parentContainerFriendlyName = default;
            BackupFileShareType? azureFileShareType = default;
            string backupManagementType = default;
            string workloadType = default;
            string protectableItemType = default;
            string friendlyName = default;
            BackupProtectionStatus? protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentContainerFabricId"u8))
                {
                    parentContainerFabricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentContainerFriendlyName"u8))
                {
                    parentContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureFileShareType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFileShareType = new BackupFileShareType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemType"u8))
                {
                    protectableItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FileShareProtectableItem(
                backupManagementType,
                workloadType,
                protectableItemType,
                friendlyName,
                protectionState,
                serializedAdditionalRawData,
                parentContainerFabricId,
                parentContainerFriendlyName,
                azureFileShareType);
        }

        BinaryData IPersistableModel<FileShareProtectableItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareProtectableItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FileShareProtectableItem)} does not support writing '{options.Format}' format.");
            }
        }

        FileShareProtectableItem IPersistableModel<FileShareProtectableItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareProtectableItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFileShareProtectableItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileShareProtectableItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileShareProtectableItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
