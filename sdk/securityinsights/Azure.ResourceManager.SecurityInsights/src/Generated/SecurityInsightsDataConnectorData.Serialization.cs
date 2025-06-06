// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsDataConnectorData : IUtf8JsonSerializable, IJsonModel<SecurityInsightsDataConnectorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsDataConnectorData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityInsightsDataConnectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsDataConnectorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsDataConnectorData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
        }

        SecurityInsightsDataConnectorData IJsonModel<SecurityInsightsDataConnectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsDataConnectorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsDataConnectorData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsDataConnectorData(document.RootElement, options);
        }

        internal static SecurityInsightsDataConnectorData DeserializeSecurityInsightsDataConnectorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonWebServicesCloudTrail": return SecurityInsightsAwsCloudTrailDataConnector.DeserializeSecurityInsightsAwsCloudTrailDataConnector(element, options);
                    case "AmazonWebServicesS3": return AwsS3DataConnector.DeserializeAwsS3DataConnector(element, options);
                    case "APIPolling": return CodelessApiPollingDataConnector.DeserializeCodelessApiPollingDataConnector(element, options);
                    case "AzureActiveDirectory": return SecurityInsightsAadDataConnector.DeserializeSecurityInsightsAadDataConnector(element, options);
                    case "AzureAdvancedThreatProtection": return SecurityInsightsAatpDataConnector.DeserializeSecurityInsightsAatpDataConnector(element, options);
                    case "AzureSecurityCenter": return SecurityInsightsAscDataConnector.DeserializeSecurityInsightsAscDataConnector(element, options);
                    case "Dynamics365": return Dynamics365DataConnector.DeserializeDynamics365DataConnector(element, options);
                    case "GCP": return GcpDataConnector.DeserializeGcpDataConnector(element, options);
                    case "GenericUI": return CodelessUiDataConnector.DeserializeCodelessUiDataConnector(element, options);
                    case "IOT": return IotDataConnector.DeserializeIotDataConnector(element, options);
                    case "MicrosoftCloudAppSecurity": return McasDataConnector.DeserializeMcasDataConnector(element, options);
                    case "MicrosoftDefenderAdvancedThreatProtection": return MdatpDataConnector.DeserializeMdatpDataConnector(element, options);
                    case "MicrosoftPurviewInformationProtection": return MicrosoftPurviewInformationProtectionDataConnector.DeserializeMicrosoftPurviewInformationProtectionDataConnector(element, options);
                    case "MicrosoftThreatIntelligence": return MstiDataConnector.DeserializeMstiDataConnector(element, options);
                    case "MicrosoftThreatProtection": return MtpDataConnector.DeserializeMtpDataConnector(element, options);
                    case "Office365": return SecurityInsightsOfficeDataConnector.DeserializeSecurityInsightsOfficeDataConnector(element, options);
                    case "Office365Project": return Office365ProjectDataConnector.DeserializeOffice365ProjectDataConnector(element, options);
                    case "OfficeATP": return OfficeAtpDataConnector.DeserializeOfficeAtpDataConnector(element, options);
                    case "OfficeIRM": return OfficeIrmDataConnector.DeserializeOfficeIrmDataConnector(element, options);
                    case "OfficePowerBI": return OfficePowerBIDataConnector.DeserializeOfficePowerBIDataConnector(element, options);
                    case "RestApiPoller": return RestApiPollerDataConnector.DeserializeRestApiPollerDataConnector(element, options);
                    case "ThreatIntelligence": return SecurityInsightsTIDataConnector.DeserializeSecurityInsightsTIDataConnector(element, options);
                    case "ThreatIntelligenceTaxii": return ThreatIntelligenceTaxiiDataConnector.DeserializeThreatIntelligenceTaxiiDataConnector(element, options);
                }
            }
            return UnknownDataConnector.DeserializeUnknownDataConnector(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  kind: ");
                builder.AppendLine($"'{Kind.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ETag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  etag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ETag))
                {
                    builder.Append("  etag: ");
                    builder.AppendLine($"'{ETag.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityInsightsDataConnectorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsDataConnectorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsDataConnectorData)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsDataConnectorData IPersistableModel<SecurityInsightsDataConnectorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsDataConnectorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecurityInsightsDataConnectorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsDataConnectorData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsDataConnectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
