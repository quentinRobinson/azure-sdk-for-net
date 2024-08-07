// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Inference
{
    /// <summary> Client options for ChatCompletionsClient. </summary>
    public partial class ChatCompletionsClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2024_05_01_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2024-05-01-preview". </summary>
            V2024_05_01_Preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of ChatCompletionsClientOptions. </summary>
        public ChatCompletionsClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2024_05_01_Preview => "2024-05-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
