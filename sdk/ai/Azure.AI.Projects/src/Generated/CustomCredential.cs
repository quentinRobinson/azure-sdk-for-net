// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Custom credential definition. </summary>
    public partial class CustomCredential : BaseCredentials
    {
        /// <summary> Initializes a new instance of <see cref="CustomCredential"/>. </summary>
        internal CustomCredential()
        {
            Type = CredentialType.Custom;
            Keys = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomCredential"/>. </summary>
        /// <param name="type"> The type of credential used by the connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="keys"> The credential type. </param>
        internal CustomCredential(CredentialType type, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, string> keys) : base(type, serializedAdditionalRawData)
        {
            Keys = keys;
        }

        /// <summary> The credential type. </summary>
        public IReadOnlyDictionary<string, string> Keys { get; }
    }
}
