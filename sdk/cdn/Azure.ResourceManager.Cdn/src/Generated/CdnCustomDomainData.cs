// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the CdnCustomDomain data model.
    /// Friendly domain name mapping to the endpoint hostname that the customer provides for branding purposes, e.g. www.contoso.com.
    /// Serialized Name: CustomDomain
    /// </summary>
    public partial class CdnCustomDomainData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="CdnCustomDomainData"/>. </summary>
        public CdnCustomDomainData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CdnCustomDomainData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="hostName">
        /// The host name of the custom domain. Must be a domain name.
        /// Serialized Name: CustomDomain.properties.hostName
        /// </param>
        /// <param name="resourceState">
        /// Resource status of the custom domain.
        /// Serialized Name: CustomDomain.properties.resourceState
        /// </param>
        /// <param name="customHttpsProvisioningState">
        /// Provisioning status of the custom domain.
        /// Serialized Name: CustomDomain.properties.customHttpsProvisioningState
        /// </param>
        /// <param name="customHttpsAvailabilityState">
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.
        /// Serialized Name: CustomDomain.properties.customHttpsProvisioningSubstate
        /// </param>
        /// <param name="customDomainHttpsContent">
        /// Certificate parameters for securing custom HTTPS
        /// Serialized Name: CustomDomain.properties.customHttpsParameters
        /// Please note <see cref="Models.CustomDomainHttpsContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="UserManagedHttpsContent"/> and <see cref="CdnManagedHttpsContent"/>.
        /// </param>
        /// <param name="validationData">
        /// Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China.
        /// Serialized Name: CustomDomain.properties.validationData
        /// </param>
        /// <param name="provisioningState">
        /// Provisioning status of Custom Https of the custom domain.
        /// Serialized Name: CustomDomain.properties.provisioningState
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnCustomDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string hostName, CustomDomainResourceState? resourceState, CustomHttpsProvisioningState? customHttpsProvisioningState, CustomHttpsAvailabilityState? customHttpsAvailabilityState, CustomDomainHttpsContent customDomainHttpsContent, string validationData, CustomHttpsProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            HostName = hostName;
            ResourceState = resourceState;
            CustomHttpsProvisioningState = customHttpsProvisioningState;
            CustomHttpsAvailabilityState = customHttpsAvailabilityState;
            CustomDomainHttpsContent = customDomainHttpsContent;
            ValidationData = validationData;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The host name of the custom domain. Must be a domain name.
        /// Serialized Name: CustomDomain.properties.hostName
        /// </summary>
        public string HostName { get; set; }
        /// <summary>
        /// Resource status of the custom domain.
        /// Serialized Name: CustomDomain.properties.resourceState
        /// </summary>
        public CustomDomainResourceState? ResourceState { get; }
        /// <summary>
        /// Provisioning status of the custom domain.
        /// Serialized Name: CustomDomain.properties.customHttpsProvisioningState
        /// </summary>
        public CustomHttpsProvisioningState? CustomHttpsProvisioningState { get; }
        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.
        /// Serialized Name: CustomDomain.properties.customHttpsProvisioningSubstate
        /// </summary>
        public CustomHttpsAvailabilityState? CustomHttpsAvailabilityState { get; }
        /// <summary>
        /// Certificate parameters for securing custom HTTPS
        /// Serialized Name: CustomDomain.properties.customHttpsParameters
        /// Please note <see cref="Models.CustomDomainHttpsContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="UserManagedHttpsContent"/> and <see cref="CdnManagedHttpsContent"/>.
        /// </summary>
        public CustomDomainHttpsContent CustomDomainHttpsContent { get; set; }
        /// <summary>
        /// Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China.
        /// Serialized Name: CustomDomain.properties.validationData
        /// </summary>
        public string ValidationData { get; set; }
        /// <summary>
        /// Provisioning status of Custom Https of the custom domain.
        /// Serialized Name: CustomDomain.properties.provisioningState
        /// </summary>
        public CustomHttpsProvisioningState? ProvisioningState { get; }
    }
}
