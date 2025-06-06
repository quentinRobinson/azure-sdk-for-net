// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// The JSON object that represents the range for http status codes
    /// Serialized Name: HttpErrorRangeParameters
    /// </summary>
    public partial class HttpErrorRange
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

        /// <summary> Initializes a new instance of <see cref="HttpErrorRange"/>. </summary>
        public HttpErrorRange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HttpErrorRange"/>. </summary>
        /// <param name="begin">
        /// The inclusive start of the http status code range.
        /// Serialized Name: HttpErrorRangeParameters.begin
        /// </param>
        /// <param name="end">
        /// The inclusive end of the http status code range.
        /// Serialized Name: HttpErrorRangeParameters.end
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HttpErrorRange(int? begin, int? end, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Begin = begin;
            End = end;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The inclusive start of the http status code range.
        /// Serialized Name: HttpErrorRangeParameters.begin
        /// </summary>
        public int? Begin { get; set; }
        /// <summary>
        /// The inclusive end of the http status code range.
        /// Serialized Name: HttpErrorRangeParameters.end
        /// </summary>
        public int? End { get; set; }
    }
}
