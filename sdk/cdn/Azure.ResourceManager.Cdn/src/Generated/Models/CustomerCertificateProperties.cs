// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Customer Certificate used for https
    /// Serialized Name: CustomerCertificateParameters
    /// </summary>
    public partial class CustomerCertificateProperties : FrontDoorSecretProperties
    {
        /// <summary> Initializes a new instance of <see cref="CustomerCertificateProperties"/>. </summary>
        /// <param name="secretSource">
        /// Resource reference to the Azure Key Vault certificate. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{certificateName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​
        /// Serialized Name: CustomerCertificateParameters.secretSource
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretSource"/> is null. </exception>
        public CustomerCertificateProperties(WritableSubResource secretSource)
        {
            Argument.AssertNotNull(secretSource, nameof(secretSource));

            SecretSource = secretSource;
            SubjectAlternativeNames = new ChangeTrackingList<string>();
            SecretType = SecretType.CustomerCertificate;
        }

        /// <summary> Initializes a new instance of <see cref="CustomerCertificateProperties"/>. </summary>
        /// <param name="secretType">
        /// The type of the secret resource.
        /// Serialized Name: SecretParameters.type
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="secretSource">
        /// Resource reference to the Azure Key Vault certificate. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{certificateName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​
        /// Serialized Name: CustomerCertificateParameters.secretSource
        /// </param>
        /// <param name="secretVersion">
        /// Version of the secret to be used
        /// Serialized Name: CustomerCertificateParameters.secretVersion
        /// </param>
        /// <param name="useLatestVersion">
        /// Whether to use the latest version for the certificate
        /// Serialized Name: CustomerCertificateParameters.useLatestVersion
        /// </param>
        /// <param name="subject">
        /// Subject name in the certificate.
        /// Serialized Name: CustomerCertificateParameters.subject
        /// </param>
        /// <param name="expiresOn">
        /// Certificate expiration date.
        /// Serialized Name: CustomerCertificateParameters.expirationDate
        /// </param>
        /// <param name="certificateAuthority">
        /// Certificate issuing authority.
        /// Serialized Name: CustomerCertificateParameters.certificateAuthority
        /// </param>
        /// <param name="subjectAlternativeNames">
        /// The list of SANs.
        /// Serialized Name: CustomerCertificateParameters.subjectAlternativeNames
        /// </param>
        /// <param name="thumbprint">
        /// Certificate thumbprint.
        /// Serialized Name: CustomerCertificateParameters.thumbprint
        /// </param>
        internal CustomerCertificateProperties(SecretType secretType, IDictionary<string, BinaryData> serializedAdditionalRawData, WritableSubResource secretSource, string secretVersion, bool? useLatestVersion, string subject, DateTimeOffset? expiresOn, string certificateAuthority, IList<string> subjectAlternativeNames, string thumbprint) : base(secretType, serializedAdditionalRawData)
        {
            SecretSource = secretSource;
            SecretVersion = secretVersion;
            UseLatestVersion = useLatestVersion;
            Subject = subject;
            ExpiresOn = expiresOn;
            CertificateAuthority = certificateAuthority;
            SubjectAlternativeNames = subjectAlternativeNames;
            Thumbprint = thumbprint;
            SecretType = secretType;
        }

        /// <summary> Initializes a new instance of <see cref="CustomerCertificateProperties"/> for deserialization. </summary>
        internal CustomerCertificateProperties()
        {
        }

        /// <summary>
        /// Resource reference to the Azure Key Vault certificate. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{certificateName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​
        /// Serialized Name: CustomerCertificateParameters.secretSource
        /// </summary>
        internal WritableSubResource SecretSource { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SecretSourceId
        {
            get => SecretSource is null ? default : SecretSource.Id;
            set
            {
                if (SecretSource is null)
                    SecretSource = new WritableSubResource();
                SecretSource.Id = value;
            }
        }

        /// <summary>
        /// Version of the secret to be used
        /// Serialized Name: CustomerCertificateParameters.secretVersion
        /// </summary>
        public string SecretVersion { get; set; }
        /// <summary>
        /// Whether to use the latest version for the certificate
        /// Serialized Name: CustomerCertificateParameters.useLatestVersion
        /// </summary>
        public bool? UseLatestVersion { get; set; }
        /// <summary>
        /// Subject name in the certificate.
        /// Serialized Name: CustomerCertificateParameters.subject
        /// </summary>
        public string Subject { get; }
        /// <summary>
        /// Certificate expiration date.
        /// Serialized Name: CustomerCertificateParameters.expirationDate
        /// </summary>
        public DateTimeOffset? ExpiresOn { get; }
        /// <summary>
        /// Certificate issuing authority.
        /// Serialized Name: CustomerCertificateParameters.certificateAuthority
        /// </summary>
        public string CertificateAuthority { get; }
        /// <summary>
        /// The list of SANs.
        /// Serialized Name: CustomerCertificateParameters.subjectAlternativeNames
        /// </summary>
        public IList<string> SubjectAlternativeNames { get; }
        /// <summary>
        /// Certificate thumbprint.
        /// Serialized Name: CustomerCertificateParameters.thumbprint
        /// </summary>
        public string Thumbprint { get; }
    }
}
