// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementGlobalSchemaResource"/> and their operations.
    /// Each <see cref="ApiManagementGlobalSchemaResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="ApiManagementGlobalSchemaCollection"/> instance call the GetApiManagementGlobalSchemas method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ApiManagementGlobalSchemaCollection : ArmCollection, IEnumerable<ApiManagementGlobalSchemaResource>, IAsyncEnumerable<ApiManagementGlobalSchemaResource>
    {
        private readonly ClientDiagnostics _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics;
        private readonly GlobalSchemaRestOperations _apiManagementGlobalSchemaGlobalSchemaRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGlobalSchemaCollection"/> class for mocking. </summary>
        protected ApiManagementGlobalSchemaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGlobalSchemaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementGlobalSchemaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementGlobalSchemaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementGlobalSchemaResource.ResourceType, out string apiManagementGlobalSchemaGlobalSchemaApiVersion);
            _apiManagementGlobalSchemaGlobalSchemaRestClient = new GlobalSchemaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementGlobalSchemaGlobalSchemaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates new or updates existing specified Schema of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementGlobalSchemaResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string schemaId, ApiManagementGlobalSchemaData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics.CreateScope("ApiManagementGlobalSchemaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementGlobalSchemaGlobalSchemaRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementGlobalSchemaResource>(new ApiManagementGlobalSchemaOperationSource(Client), _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics, Pipeline, _apiManagementGlobalSchemaGlobalSchemaRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, data, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates new or updates existing specified Schema of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementGlobalSchemaResource> CreateOrUpdate(WaitUntil waitUntil, string schemaId, ApiManagementGlobalSchemaData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics.CreateScope("ApiManagementGlobalSchemaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementGlobalSchemaGlobalSchemaRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementGlobalSchemaResource>(new ApiManagementGlobalSchemaOperationSource(Client), _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics, Pipeline, _apiManagementGlobalSchemaGlobalSchemaRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, data, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Schema specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementGlobalSchemaResource>> GetAsync(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics.CreateScope("ApiManagementGlobalSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementGlobalSchemaGlobalSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGlobalSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Schema specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual Response<ApiManagementGlobalSchemaResource> Get(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics.CreateScope("ApiManagementGlobalSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementGlobalSchemaGlobalSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGlobalSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of schemas registered with service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementGlobalSchemaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementGlobalSchemaResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementGlobalSchemaGlobalSchemaRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementGlobalSchemaGlobalSchemaRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementGlobalSchemaResource(Client, ApiManagementGlobalSchemaData.DeserializeApiManagementGlobalSchemaData(e)), _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics, Pipeline, "ApiManagementGlobalSchemaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of schemas registered with service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementGlobalSchemaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementGlobalSchemaResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementGlobalSchemaGlobalSchemaRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementGlobalSchemaGlobalSchemaRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementGlobalSchemaResource(Client, ApiManagementGlobalSchemaData.DeserializeApiManagementGlobalSchemaData(e)), _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics, Pipeline, "ApiManagementGlobalSchemaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics.CreateScope("ApiManagementGlobalSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementGlobalSchemaGlobalSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics.CreateScope("ApiManagementGlobalSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementGlobalSchemaGlobalSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementGlobalSchemaResource>> GetIfExistsAsync(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics.CreateScope("ApiManagementGlobalSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementGlobalSchemaGlobalSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementGlobalSchemaResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGlobalSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGlobalSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual NullableResponse<ApiManagementGlobalSchemaResource> GetIfExists(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiManagementGlobalSchemaGlobalSchemaClientDiagnostics.CreateScope("ApiManagementGlobalSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementGlobalSchemaGlobalSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementGlobalSchemaResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGlobalSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementGlobalSchemaResource> IEnumerable<ApiManagementGlobalSchemaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementGlobalSchemaResource> IAsyncEnumerable<ApiManagementGlobalSchemaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
