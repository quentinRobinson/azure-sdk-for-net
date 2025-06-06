﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using ClientModel.Tests.ClientShared;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

#if SOURCE_GENERATOR
namespace System.ClientModel.SourceGeneration.Tests
#else
namespace System.ClientModel.Tests.Client.ModelReaderWriterTests.Models
#endif
{
    internal class UnknownBaseModel : BaseModel, IJsonModel<BaseModel>
    {
        public UnknownBaseModel()
            : base(null)
        {
            Kind = "Unknown";
        }

        internal UnknownBaseModel(string? kind, string? name, Dictionary<string, BinaryData> rawData)
            : base(rawData)
        {
            Kind = kind;
            Name = name;
        }

        void IJsonModel<BaseModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            Serialize(writer, options);
        }

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (OptionalProperty.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                SerializeRawData(writer);
            }
            writer.WriteEndObject();
        }

        internal static BaseModel DeserializeUnknownBaseModel(JsonElement element, ModelReaderWriterOptions? options = default) => DeserializeBaseModel(element, options);

        BaseModel IPersistableModel<BaseModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return DeserializeUnknownBaseModel(JsonDocument.Parse(data.ToString()).RootElement, options);
        }

        BaseModel IJsonModel<BaseModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownBaseModel(doc.RootElement, options);
        }

        BinaryData IPersistableModel<BaseModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
# if SOURCE_GENERATOR
                    return ModelReaderWriter.Write(this, options, BasicContext.Default);
#else
                    return ModelReaderWriter.Write(this, options);
#endif
                default:
                    throw new FormatException($"The model {nameof(BaseModel)} does not support writing '{options.Format}' format.");
            }
        }
    }
}
