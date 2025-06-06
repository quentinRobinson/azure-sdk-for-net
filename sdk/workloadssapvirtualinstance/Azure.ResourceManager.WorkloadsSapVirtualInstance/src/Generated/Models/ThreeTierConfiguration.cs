// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    /// <summary> Gets or sets the three tier SAP configuration. For prerequisites for creating the infrastructure, please see [here](https://go.microsoft.com/fwlink/?linkid=2212611&amp;clcid=0x409). </summary>
    public partial class ThreeTierConfiguration : InfrastructureConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ThreeTierConfiguration"/>. </summary>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        /// <param name="centralServer"> The central server configuration. </param>
        /// <param name="applicationServer"> The application server configuration. </param>
        /// <param name="databaseServer"> The database configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appResourceGroup"/>, <paramref name="centralServer"/>, <paramref name="applicationServer"/> or <paramref name="databaseServer"/> is null. </exception>
        public ThreeTierConfiguration(string appResourceGroup, CentralServerConfiguration centralServer, ApplicationServerConfiguration applicationServer, DatabaseConfiguration databaseServer) : base(appResourceGroup)
        {
            Argument.AssertNotNull(appResourceGroup, nameof(appResourceGroup));
            Argument.AssertNotNull(centralServer, nameof(centralServer));
            Argument.AssertNotNull(applicationServer, nameof(applicationServer));
            Argument.AssertNotNull(databaseServer, nameof(databaseServer));

            CentralServer = centralServer;
            ApplicationServer = applicationServer;
            DatabaseServer = databaseServer;
            DeploymentType = SapDeploymentType.ThreeTier;
        }

        /// <summary> Initializes a new instance of <see cref="ThreeTierConfiguration"/>. </summary>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        /// <param name="deploymentType"> The SAP deployment type. Eg: SingleServer/ThreeTier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="networkConfiguration"> Network configuration common to all servers. </param>
        /// <param name="centralServer"> The central server configuration. </param>
        /// <param name="applicationServer"> The application server configuration. </param>
        /// <param name="databaseServer"> The database configuration. </param>
        /// <param name="highAvailabilityConfig"> The high availability configuration. </param>
        /// <param name="storageConfiguration"> The storage configuration. </param>
        /// <param name="customResourceNames">
        /// The set of custom names to be used for underlying azure resources that are part of the SAP system.
        /// Please note <see cref="ThreeTierCustomResourceNames"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ThreeTierFullResourceNames"/>.
        /// </param>
        internal ThreeTierConfiguration(string appResourceGroup, SapDeploymentType deploymentType, IDictionary<string, BinaryData> serializedAdditionalRawData, NetworkConfiguration networkConfiguration, CentralServerConfiguration centralServer, ApplicationServerConfiguration applicationServer, DatabaseConfiguration databaseServer, HighAvailabilityConfiguration highAvailabilityConfig, SapStorageConfiguration storageConfiguration, ThreeTierCustomResourceNames customResourceNames) : base(appResourceGroup, deploymentType, serializedAdditionalRawData)
        {
            NetworkConfiguration = networkConfiguration;
            CentralServer = centralServer;
            ApplicationServer = applicationServer;
            DatabaseServer = databaseServer;
            HighAvailabilityConfig = highAvailabilityConfig;
            StorageConfiguration = storageConfiguration;
            CustomResourceNames = customResourceNames;
            DeploymentType = deploymentType;
        }

        /// <summary> Initializes a new instance of <see cref="ThreeTierConfiguration"/> for deserialization. </summary>
        internal ThreeTierConfiguration()
        {
        }

        /// <summary> Network configuration common to all servers. </summary>
        internal NetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary> Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed. </summary>
        public bool? IsSecondaryIPEnabled
        {
            get => NetworkConfiguration is null ? default : NetworkConfiguration.IsSecondaryIPEnabled;
            set
            {
                if (NetworkConfiguration is null)
                    NetworkConfiguration = new NetworkConfiguration();
                NetworkConfiguration.IsSecondaryIPEnabled = value;
            }
        }

        /// <summary> The central server configuration. </summary>
        public CentralServerConfiguration CentralServer { get; set; }
        /// <summary> The application server configuration. </summary>
        public ApplicationServerConfiguration ApplicationServer { get; set; }
        /// <summary> The database configuration. </summary>
        public DatabaseConfiguration DatabaseServer { get; set; }
        /// <summary> The high availability configuration. </summary>
        internal HighAvailabilityConfiguration HighAvailabilityConfig { get; set; }
        /// <summary> The high availability type. </summary>
        public SapHighAvailabilityType? HighAvailabilityType
        {
            get => HighAvailabilityConfig is null ? default(SapHighAvailabilityType?) : HighAvailabilityConfig.HighAvailabilityType;
            set
            {
                HighAvailabilityConfig = value.HasValue ? new HighAvailabilityConfiguration(value.Value) : null;
            }
        }

        /// <summary> The storage configuration. </summary>
        internal SapStorageConfiguration StorageConfiguration { get; set; }
        /// <summary>
        /// The properties of the transport directory attached to the VIS. The default for transportFileShareConfiguration is the createAndMount flow if storage configuration is missing.
        /// Please note <see cref="FileShareConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CreateAndMountFileShareConfiguration"/>, <see cref="MountFileShareConfiguration"/> and <see cref="SkipFileShareConfiguration"/>.
        /// </summary>
        public FileShareConfiguration StorageTransportFileShareConfiguration
        {
            get => StorageConfiguration is null ? default : StorageConfiguration.TransportFileShareConfiguration;
            set
            {
                if (StorageConfiguration is null)
                    StorageConfiguration = new SapStorageConfiguration();
                StorageConfiguration.TransportFileShareConfiguration = value;
            }
        }

        /// <summary>
        /// The set of custom names to be used for underlying azure resources that are part of the SAP system.
        /// Please note <see cref="ThreeTierCustomResourceNames"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ThreeTierFullResourceNames"/>.
        /// </summary>
        public ThreeTierCustomResourceNames CustomResourceNames { get; set; }
    }
}
