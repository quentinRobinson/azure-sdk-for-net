// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Authorization confirm consent code request contract. </summary>
    public partial class AuthorizationConfirmConsentCodeContent
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

        /// <summary> Initializes a new instance of <see cref="AuthorizationConfirmConsentCodeContent"/>. </summary>
        public AuthorizationConfirmConsentCodeContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationConfirmConsentCodeContent"/>. </summary>
        /// <param name="consentCode"> The consent code from the authorization server after authorizing and consenting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthorizationConfirmConsentCodeContent(string consentCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConsentCode = consentCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The consent code from the authorization server after authorizing and consenting. </summary>
        [WirePath("consentCode")]
        public string ConsentCode { get; set; }
    }
}
