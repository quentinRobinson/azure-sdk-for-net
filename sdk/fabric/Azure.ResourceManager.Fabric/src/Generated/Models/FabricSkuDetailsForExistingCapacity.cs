// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Fabric.Models
{
    /// <summary> An object that represents SKU details for existing resources. </summary>
    public partial class FabricSkuDetailsForExistingCapacity
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FabricSkuDetailsForExistingCapacity"/>. </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="sku"> The SKU details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> or <paramref name="sku"/> is null. </exception>
        internal FabricSkuDetailsForExistingCapacity(string resourceType, FabricSku sku)
        {
            Argument.AssertNotNull(resourceType, nameof(resourceType));
            Argument.AssertNotNull(sku, nameof(sku));

            ResourceType = resourceType;
            Sku = sku;
        }

        /// <summary> Initializes a new instance of <see cref="FabricSkuDetailsForExistingCapacity"/>. </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="sku"> The SKU details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FabricSkuDetailsForExistingCapacity(string resourceType, FabricSku sku, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FabricSkuDetailsForExistingCapacity"/> for deserialization. </summary>
        internal FabricSkuDetailsForExistingCapacity()
        {
        }

        /// <summary> The resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The SKU details. </summary>
        public FabricSku Sku { get; }
    }
}
