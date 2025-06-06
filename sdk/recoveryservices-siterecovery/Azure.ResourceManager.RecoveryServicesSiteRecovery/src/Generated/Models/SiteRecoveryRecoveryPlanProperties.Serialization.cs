// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryRecoveryPlanProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryRecoveryPlanProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryRecoveryPlanProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryRecoveryPlanProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryRecoveryPlanProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryRecoveryPlanProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(PrimaryFabricId))
            {
                writer.WritePropertyName("primaryFabricId"u8);
                writer.WriteStringValue(PrimaryFabricId);
            }
            if (Optional.IsDefined(PrimaryFabricFriendlyName))
            {
                writer.WritePropertyName("primaryFabricFriendlyName"u8);
                writer.WriteStringValue(PrimaryFabricFriendlyName);
            }
            if (Optional.IsDefined(RecoveryFabricId))
            {
                writer.WritePropertyName("recoveryFabricId"u8);
                writer.WriteStringValue(RecoveryFabricId);
            }
            if (Optional.IsDefined(RecoveryFabricFriendlyName))
            {
                writer.WritePropertyName("recoveryFabricFriendlyName"u8);
                writer.WriteStringValue(RecoveryFabricFriendlyName);
            }
            if (Optional.IsDefined(FailoverDeploymentModel))
            {
                writer.WritePropertyName("failoverDeploymentModel"u8);
                writer.WriteStringValue(FailoverDeploymentModel);
            }
            if (Optional.IsCollectionDefined(ReplicationProviders))
            {
                writer.WritePropertyName("replicationProviders"u8);
                writer.WriteStartArray();
                foreach (var item in ReplicationProviders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedOperations))
            {
                writer.WritePropertyName("allowedOperations"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedOperations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastPlannedFailoverOn))
            {
                writer.WritePropertyName("lastPlannedFailoverTime"u8);
                writer.WriteStringValue(LastPlannedFailoverOn.Value, "O");
            }
            if (Optional.IsDefined(LastUnplannedFailoverOn))
            {
                writer.WritePropertyName("lastUnplannedFailoverTime"u8);
                writer.WriteStringValue(LastUnplannedFailoverOn.Value, "O");
            }
            if (Optional.IsDefined(LastTestFailoverOn))
            {
                writer.WritePropertyName("lastTestFailoverTime"u8);
                writer.WriteStringValue(LastTestFailoverOn.Value, "O");
            }
            if (Optional.IsDefined(CurrentScenario))
            {
                writer.WritePropertyName("currentScenario"u8);
                writer.WriteObjectValue(CurrentScenario, options);
            }
            if (Optional.IsDefined(CurrentScenarioStatus))
            {
                writer.WritePropertyName("currentScenarioStatus"u8);
                writer.WriteStringValue(CurrentScenarioStatus);
            }
            if (Optional.IsDefined(CurrentScenarioStatusDescription))
            {
                writer.WritePropertyName("currentScenarioStatusDescription"u8);
                writer.WriteStringValue(CurrentScenarioStatusDescription);
            }
            if (Optional.IsCollectionDefined(Groups))
            {
                writer.WritePropertyName("groups"u8);
                writer.WriteStartArray();
                foreach (var item in Groups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificDetails)
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

        SiteRecoveryRecoveryPlanProperties IJsonModel<SiteRecoveryRecoveryPlanProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryRecoveryPlanProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryRecoveryPlanProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryRecoveryPlanProperties(document.RootElement, options);
        }

        internal static SiteRecoveryRecoveryPlanProperties DeserializeSiteRecoveryRecoveryPlanProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            ResourceIdentifier primaryFabricId = default;
            string primaryFabricFriendlyName = default;
            ResourceIdentifier recoveryFabricId = default;
            string recoveryFabricFriendlyName = default;
            string failoverDeploymentModel = default;
            IReadOnlyList<string> replicationProviders = default;
            IReadOnlyList<string> allowedOperations = default;
            DateTimeOffset? lastPlannedFailoverTime = default;
            DateTimeOffset? lastUnplannedFailoverTime = default;
            DateTimeOffset? lastTestFailoverTime = default;
            CurrentScenarioDetails currentScenario = default;
            string currentScenarioStatus = default;
            string currentScenarioStatusDescription = default;
            IReadOnlyList<SiteRecoveryPlanGroup> groups = default;
            IReadOnlyList<RecoveryPlanProviderSpecificDetails> providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryFabricFriendlyName"u8))
                {
                    primaryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricFriendlyName"u8))
                {
                    recoveryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverDeploymentModel"u8))
                {
                    failoverDeploymentModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationProviders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    replicationProviders = array;
                    continue;
                }
                if (property.NameEquals("allowedOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOperations = array;
                    continue;
                }
                if (property.NameEquals("lastPlannedFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastPlannedFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUnplannedFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUnplannedFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTestFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTestFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentScenario"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentScenario = CurrentScenarioDetails.DeserializeCurrentScenarioDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("currentScenarioStatus"u8))
                {
                    currentScenarioStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentScenarioStatusDescription"u8))
                {
                    currentScenarioStatusDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryPlanGroup> array = new List<SiteRecoveryPlanGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryPlanGroup.DeserializeSiteRecoveryPlanGroup(item, options));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProviderSpecificDetails> array = new List<RecoveryPlanProviderSpecificDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProviderSpecificDetails.DeserializeRecoveryPlanProviderSpecificDetails(item, options));
                    }
                    providerSpecificDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryRecoveryPlanProperties(
                friendlyName,
                primaryFabricId,
                primaryFabricFriendlyName,
                recoveryFabricId,
                recoveryFabricFriendlyName,
                failoverDeploymentModel,
                replicationProviders ?? new ChangeTrackingList<string>(),
                allowedOperations ?? new ChangeTrackingList<string>(),
                lastPlannedFailoverTime,
                lastUnplannedFailoverTime,
                lastTestFailoverTime,
                currentScenario,
                currentScenarioStatus,
                currentScenarioStatusDescription,
                groups ?? new ChangeTrackingList<SiteRecoveryPlanGroup>(),
                providerSpecificDetails ?? new ChangeTrackingList<RecoveryPlanProviderSpecificDetails>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryRecoveryPlanProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryRecoveryPlanProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryRecoveryPlanProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryRecoveryPlanProperties IPersistableModel<SiteRecoveryRecoveryPlanProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryRecoveryPlanProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSiteRecoveryRecoveryPlanProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryRecoveryPlanProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryRecoveryPlanProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
