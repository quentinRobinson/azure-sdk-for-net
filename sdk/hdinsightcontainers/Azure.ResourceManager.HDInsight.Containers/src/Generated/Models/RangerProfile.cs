// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The ranger cluster profile. </summary>
    public partial class RangerProfile
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

        /// <summary> Initializes a new instance of <see cref="RangerProfile"/>. </summary>
        /// <param name="rangerAdmin"> Specification for the Ranger Admin service. </param>
        /// <param name="rangerUsersync"> Specification for the Ranger Usersync service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rangerAdmin"/> or <paramref name="rangerUsersync"/> is null. </exception>
        public RangerProfile(RangerAdminSpec rangerAdmin, RangerUsersyncSpec rangerUsersync)
        {
            Argument.AssertNotNull(rangerAdmin, nameof(rangerAdmin));
            Argument.AssertNotNull(rangerUsersync, nameof(rangerUsersync));

            RangerAdmin = rangerAdmin;
            RangerUsersync = rangerUsersync;
        }

        /// <summary> Initializes a new instance of <see cref="RangerProfile"/>. </summary>
        /// <param name="rangerAdmin"> Specification for the Ranger Admin service. </param>
        /// <param name="rangerAudit"> Properties required to describe audit log storage. </param>
        /// <param name="rangerUsersync"> Specification for the Ranger Usersync service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RangerProfile(RangerAdminSpec rangerAdmin, RangerAuditSpec rangerAudit, RangerUsersyncSpec rangerUsersync, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RangerAdmin = rangerAdmin;
            RangerAudit = rangerAudit;
            RangerUsersync = rangerUsersync;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RangerProfile"/> for deserialization. </summary>
        internal RangerProfile()
        {
        }

        /// <summary> Specification for the Ranger Admin service. </summary>
        [WirePath("rangerAdmin")]
        public RangerAdminSpec RangerAdmin { get; set; }
        /// <summary> Properties required to describe audit log storage. </summary>
        internal RangerAuditSpec RangerAudit { get; set; }
        /// <summary> Azure storage location of the blobs. MSI should have read/write access to this Storage account. </summary>
        [WirePath("rangerAudit.storageAccount")]
        public string RangerAuditStorageAccount
        {
            get => RangerAudit is null ? default : RangerAudit.StorageAccount;
            set
            {
                if (RangerAudit is null)
                    RangerAudit = new RangerAuditSpec();
                RangerAudit.StorageAccount = value;
            }
        }

        /// <summary> Specification for the Ranger Usersync service. </summary>
        [WirePath("rangerUsersync")]
        public RangerUsersyncSpec RangerUsersync { get; set; }
    }
}
