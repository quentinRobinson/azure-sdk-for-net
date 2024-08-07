// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A database connection configuration file. </summary>
    public partial class StaticSiteDatabaseConnectionConfigurationFileOverview
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

        /// <summary> Initializes a new instance of <see cref="StaticSiteDatabaseConnectionConfigurationFileOverview"/>. </summary>
        internal StaticSiteDatabaseConnectionConfigurationFileOverview()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteDatabaseConnectionConfigurationFileOverview"/>. </summary>
        /// <param name="fileName"> The name of the configuration file. </param>
        /// <param name="contents"> The Base64 encoding of the file contents. </param>
        /// <param name="staticSiteDatabaseConnectionConfigurationFileOverviewType"> The type of configuration file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticSiteDatabaseConnectionConfigurationFileOverview(string fileName, string contents, string staticSiteDatabaseConnectionConfigurationFileOverviewType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileName = fileName;
            Contents = contents;
            StaticSiteDatabaseConnectionConfigurationFileOverviewType = staticSiteDatabaseConnectionConfigurationFileOverviewType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the configuration file. </summary>
        [WirePath("fileName")]
        public string FileName { get; }
        /// <summary> The Base64 encoding of the file contents. </summary>
        [WirePath("contents")]
        public string Contents { get; }
        /// <summary> The type of configuration file. </summary>
        [WirePath("type")]
        public string StaticSiteDatabaseConnectionConfigurationFileOverviewType { get; }
    }
}
