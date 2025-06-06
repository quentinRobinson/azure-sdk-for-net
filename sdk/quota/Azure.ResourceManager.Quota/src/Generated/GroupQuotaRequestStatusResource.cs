// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A Class representing a GroupQuotaRequestStatus along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GroupQuotaRequestStatusResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGroupQuotaRequestStatusResource method.
    /// Otherwise you can get one from its parent resource <see cref="GroupQuotaEntityResource"/> using the GetGroupQuotaRequestStatus method.
    /// </summary>
    public partial class GroupQuotaRequestStatusResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GroupQuotaRequestStatusResource"/> instance. </summary>
        /// <param name="managementGroupId"> The managementGroupId. </param>
        /// <param name="groupQuotaName"> The groupQuotaName. </param>
        /// <param name="requestId"> The requestId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string groupQuotaName, string requestId)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/groupQuotaRequests/{requestId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _groupQuotaRequestStatusGroupQuotaLimitsRequestClientDiagnostics;
        private readonly GroupQuotaLimitsRequestRestOperations _groupQuotaRequestStatusGroupQuotaLimitsRequestRestClient;
        private readonly GroupQuotaRequestStatusData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Quota/groupQuotas/groupQuotaRequests";

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaRequestStatusResource"/> class for mocking. </summary>
        protected GroupQuotaRequestStatusResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaRequestStatusResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GroupQuotaRequestStatusResource(ArmClient client, GroupQuotaRequestStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaRequestStatusResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GroupQuotaRequestStatusResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _groupQuotaRequestStatusGroupQuotaLimitsRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string groupQuotaRequestStatusGroupQuotaLimitsRequestApiVersion);
            _groupQuotaRequestStatusGroupQuotaLimitsRequestRestClient = new GroupQuotaLimitsRequestRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, groupQuotaRequestStatusGroupQuotaLimitsRequestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GroupQuotaRequestStatusData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get API to check the status of a GroupQuota request by requestId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/groupQuotaRequests/{requestId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimitsRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GroupQuotaRequestStatusResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaRequestStatusGroupQuotaLimitsRequestClientDiagnostics.CreateScope("GroupQuotaRequestStatusResource.Get");
            scope.Start();
            try
            {
                var response = await _groupQuotaRequestStatusGroupQuotaLimitsRequestRestClient.GetAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get API to check the status of a GroupQuota request by requestId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/groupQuotaRequests/{requestId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimitsRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GroupQuotaRequestStatusResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaRequestStatusGroupQuotaLimitsRequestClientDiagnostics.CreateScope("GroupQuotaRequestStatusResource.Get");
            scope.Start();
            try
            {
                var response = _groupQuotaRequestStatusGroupQuotaLimitsRequestRestClient.Get(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
