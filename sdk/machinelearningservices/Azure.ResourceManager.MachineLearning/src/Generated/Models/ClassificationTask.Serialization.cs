// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ClassificationTask : IUtf8JsonSerializable, IJsonModel<ClassificationTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClassificationTask>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClassificationTask>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationTask>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassificationTask)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(TrainingSettings))
            {
                if (TrainingSettings != null)
                {
                    writer.WritePropertyName("trainingSettings"u8);
                    writer.WriteObjectValue(TrainingSettings, options);
                }
                else
                {
                    writer.WriteNull("trainingSettings");
                }
            }
            if (Optional.IsDefined(PositiveLabel))
            {
                if (PositiveLabel != null)
                {
                    writer.WritePropertyName("positiveLabel"u8);
                    writer.WriteStringValue(PositiveLabel);
                }
                else
                {
                    writer.WriteNull("positiveLabel");
                }
            }
            if (Optional.IsDefined(LimitSettings))
            {
                if (LimitSettings != null)
                {
                    writer.WritePropertyName("limitSettings"u8);
                    writer.WriteObjectValue(LimitSettings, options);
                }
                else
                {
                    writer.WriteNull("limitSettings");
                }
            }
            if (Optional.IsDefined(NCrossValidations))
            {
                if (NCrossValidations != null)
                {
                    writer.WritePropertyName("nCrossValidations"u8);
                    writer.WriteObjectValue(NCrossValidations, options);
                }
                else
                {
                    writer.WriteNull("nCrossValidations");
                }
            }
            if (Optional.IsCollectionDefined(CvSplitColumnNames))
            {
                if (CvSplitColumnNames != null)
                {
                    writer.WritePropertyName("cvSplitColumnNames"u8);
                    writer.WriteStartArray();
                    foreach (var item in CvSplitColumnNames)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("cvSplitColumnNames");
                }
            }
            if (Optional.IsDefined(WeightColumnName))
            {
                if (WeightColumnName != null)
                {
                    writer.WritePropertyName("weightColumnName"u8);
                    writer.WriteStringValue(WeightColumnName);
                }
                else
                {
                    writer.WriteNull("weightColumnName");
                }
            }
            if (Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    writer.WriteObjectValue(ValidationData, options);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            if (Optional.IsDefined(TestData))
            {
                if (TestData != null)
                {
                    writer.WritePropertyName("testData"u8);
                    writer.WriteObjectValue(TestData, options);
                }
                else
                {
                    writer.WriteNull("testData");
                }
            }
            if (Optional.IsDefined(ValidationDataSize))
            {
                if (ValidationDataSize != null)
                {
                    writer.WritePropertyName("validationDataSize"u8);
                    writer.WriteNumberValue(ValidationDataSize.Value);
                }
                else
                {
                    writer.WriteNull("validationDataSize");
                }
            }
            if (Optional.IsDefined(TestDataSize))
            {
                if (TestDataSize != null)
                {
                    writer.WritePropertyName("testDataSize"u8);
                    writer.WriteNumberValue(TestDataSize.Value);
                }
                else
                {
                    writer.WriteNull("testDataSize");
                }
            }
            if (Optional.IsDefined(FeaturizationSettings))
            {
                if (FeaturizationSettings != null)
                {
                    writer.WritePropertyName("featurizationSettings"u8);
                    writer.WriteObjectValue(FeaturizationSettings, options);
                }
                else
                {
                    writer.WriteNull("featurizationSettings");
                }
            }
        }

        ClassificationTask IJsonModel<ClassificationTask>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationTask>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassificationTask)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClassificationTask(document.RootElement, options);
        }

        internal static ClassificationTask DeserializeClassificationTask(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClassificationPrimaryMetric? primaryMetric = default;
            ClassificationTrainingSettings trainingSettings = default;
            string positiveLabel = default;
            TableVerticalLimitSettings limitSettings = default;
            NCrossValidations nCrossValidations = default;
            IList<string> cvSplitColumnNames = default;
            string weightColumnName = default;
            MachineLearningTableJobInput validationData = default;
            MachineLearningTableJobInput testData = default;
            double? validationDataSize = default;
            double? testDataSize = default;
            TableVerticalFeaturizationSettings featurizationSettings = default;
            TaskType taskType = default;
            MachineLearningLogVerbosity? logVerbosity = default;
            MachineLearningTableJobInput trainingData = default;
            string targetColumnName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new ClassificationPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingSettings = null;
                        continue;
                    }
                    trainingSettings = ClassificationTrainingSettings.DeserializeClassificationTrainingSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("positiveLabel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        positiveLabel = null;
                        continue;
                    }
                    positiveLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limitSettings = null;
                        continue;
                    }
                    limitSettings = TableVerticalLimitSettings.DeserializeTableVerticalLimitSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nCrossValidations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nCrossValidations = null;
                        continue;
                    }
                    nCrossValidations = NCrossValidations.DeserializeNCrossValidations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cvSplitColumnNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvSplitColumnNames = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    cvSplitColumnNames = array;
                    continue;
                }
                if (property.NameEquals("weightColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightColumnName = null;
                        continue;
                    }
                    weightColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("testData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testData = null;
                        continue;
                    }
                    testData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationDataSize = null;
                        continue;
                    }
                    validationDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("testDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testDataSize = null;
                        continue;
                    }
                    testDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("featurizationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featurizationSettings = null;
                        continue;
                    }
                    featurizationSettings = TableVerticalFeaturizationSettings.DeserializeTableVerticalFeaturizationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClassificationTask(
                taskType,
                logVerbosity,
                trainingData,
                targetColumnName,
                serializedAdditionalRawData,
                primaryMetric,
                trainingSettings,
                positiveLabel,
                limitSettings,
                nCrossValidations,
                cvSplitColumnNames ?? new ChangeTrackingList<string>(),
                weightColumnName,
                validationData,
                testData,
                validationDataSize,
                testDataSize,
                featurizationSettings);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryMetric), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primaryMetric: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimaryMetric))
                {
                    builder.Append("  primaryMetric: ");
                    builder.AppendLine($"'{PrimaryMetric.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TrainingSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trainingSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TrainingSettings))
                {
                    builder.Append("  trainingSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TrainingSettings, options, 2, false, "  trainingSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PositiveLabel), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  positiveLabel: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PositiveLabel))
                {
                    builder.Append("  positiveLabel: ");
                    if (PositiveLabel.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PositiveLabel}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PositiveLabel}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LimitSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  limitSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LimitSettings))
                {
                    builder.Append("  limitSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LimitSettings, options, 2, false, "  limitSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NCrossValidations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nCrossValidations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NCrossValidations))
                {
                    builder.Append("  nCrossValidations: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NCrossValidations, options, 2, false, "  nCrossValidations: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CvSplitColumnNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cvSplitColumnNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(CvSplitColumnNames))
                {
                    if (CvSplitColumnNames.Any())
                    {
                        builder.Append("  cvSplitColumnNames: ");
                        builder.AppendLine("[");
                        foreach (var item in CvSplitColumnNames)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WeightColumnName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  weightColumnName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WeightColumnName))
                {
                    builder.Append("  weightColumnName: ");
                    if (WeightColumnName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WeightColumnName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WeightColumnName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidationData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validationData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValidationData))
                {
                    builder.Append("  validationData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ValidationData, options, 2, false, "  validationData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TestData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  testData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TestData))
                {
                    builder.Append("  testData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TestData, options, 2, false, "  testData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidationDataSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validationDataSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValidationDataSize))
                {
                    builder.Append("  validationDataSize: ");
                    builder.AppendLine($"'{ValidationDataSize.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TestDataSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  testDataSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TestDataSize))
                {
                    builder.Append("  testDataSize: ");
                    builder.AppendLine($"'{TestDataSize.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FeaturizationSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  featurizationSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FeaturizationSettings))
                {
                    builder.Append("  featurizationSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, FeaturizationSettings, options, 2, false, "  featurizationSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TaskType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  taskType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  taskType: ");
                builder.AppendLine($"'{TaskType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogVerbosity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logVerbosity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogVerbosity))
                {
                    builder.Append("  logVerbosity: ");
                    builder.AppendLine($"'{LogVerbosity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TrainingData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trainingData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TrainingData))
                {
                    builder.Append("  trainingData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TrainingData, options, 2, false, "  trainingData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetColumnName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetColumnName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetColumnName))
                {
                    builder.Append("  targetColumnName: ");
                    if (TargetColumnName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TargetColumnName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TargetColumnName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClassificationTask>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationTask>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClassificationTask)} does not support writing '{options.Format}' format.");
            }
        }

        ClassificationTask IPersistableModel<ClassificationTask>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationTask>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClassificationTask(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClassificationTask)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClassificationTask>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
