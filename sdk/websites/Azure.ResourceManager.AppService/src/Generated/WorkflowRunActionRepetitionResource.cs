// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WorkflowRunActionRepetition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WorkflowRunActionRepetitionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWorkflowRunActionRepetitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="WorkflowRunActionResource"/> using the GetWorkflowRunActionRepetition method.
    /// </summary>
    public partial class WorkflowRunActionRepetitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkflowRunActionRepetitionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="workflowName"> The workflowName. </param>
        /// <param name="runName"> The runName. </param>
        /// <param name="actionName"> The actionName. </param>
        /// <param name="repetitionName"> The repetitionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workflowRunActionRepetitionClientDiagnostics;
        private readonly WorkflowRunActionRepetitionsRestOperations _workflowRunActionRepetitionRestClient;
        private readonly WorkflowRunActionRepetitionDefinitionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/hostruntime/webhooks/api/workflows/runs/actions/repetitions";

        /// <summary> Initializes a new instance of the <see cref="WorkflowRunActionRepetitionResource"/> class for mocking. </summary>
        protected WorkflowRunActionRepetitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkflowRunActionRepetitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkflowRunActionRepetitionResource(ArmClient client, WorkflowRunActionRepetitionDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WorkflowRunActionRepetitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkflowRunActionRepetitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workflowRunActionRepetitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workflowRunActionRepetitionApiVersion);
            _workflowRunActionRepetitionRestClient = new WorkflowRunActionRepetitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workflowRunActionRepetitionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkflowRunActionRepetitionDefinitionData Data
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

        /// <summary> Gets a collection of WebAppRequestHistoryResources in the WorkflowRunActionRepetition. </summary>
        /// <returns> An object representing collection of WebAppRequestHistoryResources and their operations over a WebAppRequestHistoryResource. </returns>
        public virtual WebAppRequestHistoryCollection GetWebAppRequestHistories()
        {
            return GetCachedClient(client => new WebAppRequestHistoryCollection(client, Id));
        }

        /// <summary>
        /// Gets a workflow run repetition request history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WebAppRequestHistoryResource>> GetWebAppRequestHistoryAsync(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            return await GetWebAppRequestHistories().GetAsync(requestHistoryName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workflow run repetition request history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/requestHistories/{requestHistoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitionsRequestHistories_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebAppRequestHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestHistoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<WebAppRequestHistoryResource> GetWebAppRequestHistory(string requestHistoryName, CancellationToken cancellationToken = default)
        {
            return GetWebAppRequestHistories().Get(requestHistoryName, cancellationToken);
        }

        /// <summary>
        /// Get a workflow run action repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkflowRunActionRepetitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowRunActionRepetitionClientDiagnostics.CreateScope("WorkflowRunActionRepetitionResource.Get");
            scope.Start();
            try
            {
                var response = await _workflowRunActionRepetitionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowRunActionRepetitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workflow run action repetition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkflowRunActionRepetitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _workflowRunActionRepetitionClientDiagnostics.CreateScope("WorkflowRunActionRepetitionResource.Get");
            scope.Start();
            try
            {
                var response = _workflowRunActionRepetitionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowRunActionRepetitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a workflow run expression trace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/listExpressionTraces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitions_ListExpressionTraces</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkflowExpressionRoot"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkflowExpressionRoot> GetExpressionTracesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workflowRunActionRepetitionRestClient.CreateListExpressionTracesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workflowRunActionRepetitionRestClient.CreateListExpressionTracesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => WorkflowExpressionRoot.DeserializeWorkflowExpressionRoot(e), _workflowRunActionRepetitionClientDiagnostics, Pipeline, "WorkflowRunActionRepetitionResource.GetExpressionTraces", "inputs", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a workflow run expression trace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/hostruntime/runtime/webhooks/workflow/api/management/workflows/{workflowName}/runs/{runName}/actions/{actionName}/repetitions/{repetitionName}/listExpressionTraces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunActionRepetitions_ListExpressionTraces</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkflowRunActionRepetitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkflowExpressionRoot"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkflowExpressionRoot> GetExpressionTraces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workflowRunActionRepetitionRestClient.CreateListExpressionTracesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workflowRunActionRepetitionRestClient.CreateListExpressionTracesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => WorkflowExpressionRoot.DeserializeWorkflowExpressionRoot(e), _workflowRunActionRepetitionClientDiagnostics, Pipeline, "WorkflowRunActionRepetitionResource.GetExpressionTraces", "inputs", "nextLink", cancellationToken);
        }
    }
}
