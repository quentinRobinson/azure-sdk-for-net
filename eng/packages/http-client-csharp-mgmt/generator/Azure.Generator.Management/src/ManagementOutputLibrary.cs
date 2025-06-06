﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.Management.Providers;
using Microsoft.TypeSpec.Generator.Providers;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Generator.Management
{
    /// <inheritdoc/>
    public class ManagementOutputLibrary : AzureOutputLibrary
    {
        private ManagementLongRunningOperationProvider? _armOperation;
        internal ManagementLongRunningOperationProvider ArmOperation => _armOperation ??= new ManagementLongRunningOperationProvider(false);

        private ManagementLongRunningOperationProvider? _genericArmOperation;
        internal ManagementLongRunningOperationProvider GenericArmOperation => _genericArmOperation ??= new ManagementLongRunningOperationProvider(true);

        private (IReadOnlyList<ResourceClientProvider> Resources, IReadOnlyList<ResourceCollectionClientProvider> Collection) BuildResources()
        {
            var resources = new List<ResourceClientProvider>();
            var collections = new List<ResourceCollectionClientProvider>();
            foreach (var client in ManagementClientGenerator.Instance.InputLibrary.AllClients)
            {
                BuildResourceCore(resources, collections, client);
            }
            return (resources, collections);
        }

        private static void BuildResourceCore(List<ResourceClientProvider> resources, List<ResourceCollectionClientProvider> collections, Microsoft.TypeSpec.Generator.Input.InputClient client)
        {
            // A resource client should contain the decorator "Azure.ResourceManager.@resourceMetadata"
            var resourceMetadata = ManagementClientGenerator.Instance.InputLibrary.GetResourceMetadata(client);
            if (resourceMetadata is not null)
            {
                var resource = new ResourceClientProvider(client, resourceMetadata);
                ManagementClientGenerator.Instance.AddTypeToKeep(resource.Name);
                resources.Add(resource);
                if (!resource.IsSingleton)
                {
                    var collection = new ResourceCollectionClientProvider(client, resourceMetadata, resource);
                    ManagementClientGenerator.Instance.AddTypeToKeep(collection.Name);
                    collections.Add(collection);
                }
            }
        }

        /// <inheritdoc/>
        protected override TypeProvider[] BuildTypeProviders()
        {
            var (resources, collections) = BuildResources();
            return [
                .. base.BuildTypeProviders().Where(t => t is not InheritableSystemObjectModelProvider),
                ArmOperation,
                GenericArmOperation,
                .. resources,
                .. collections,
                .. resources.Select(r => r.Source),
                .. resources.SelectMany(r => r.SerializationProviders)];
        }
    }
}
