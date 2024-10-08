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

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsHuntCommentResource"/> and their operations.
    /// Each <see cref="SecurityInsightsHuntCommentResource"/> in the collection will belong to the same instance of <see cref="SecurityInsightsHuntResource"/>.
    /// To get a <see cref="SecurityInsightsHuntCommentCollection"/> instance call the GetSecurityInsightsHuntComments method from an instance of <see cref="SecurityInsightsHuntResource"/>.
    /// </summary>
    public partial class SecurityInsightsHuntCommentCollection : ArmCollection, IEnumerable<SecurityInsightsHuntCommentResource>, IAsyncEnumerable<SecurityInsightsHuntCommentResource>
    {
        private readonly ClientDiagnostics _securityInsightsHuntCommentHuntCommentsClientDiagnostics;
        private readonly HuntCommentsRestOperations _securityInsightsHuntCommentHuntCommentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsHuntCommentCollection"/> class for mocking. </summary>
        protected SecurityInsightsHuntCommentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsHuntCommentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsHuntCommentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsHuntCommentHuntCommentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsHuntCommentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsHuntCommentResource.ResourceType, out string securityInsightsHuntCommentHuntCommentsApiVersion);
            _securityInsightsHuntCommentHuntCommentsRestClient = new HuntCommentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsHuntCommentHuntCommentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityInsightsHuntResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityInsightsHuntResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a hunt relation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments/{huntCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="huntCommentId"> The hunt comment id (GUID). </param>
        /// <param name="data"> The hunt  comment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="huntCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="huntCommentId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsHuntCommentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string huntCommentId, SecurityInsightsHuntCommentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(huntCommentId, nameof(huntCommentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsHuntCommentHuntCommentsClientDiagnostics.CreateScope("SecurityInsightsHuntCommentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsHuntCommentHuntCommentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, data, cancellationToken).ConfigureAwait(false);
                var uri = _securityInsightsHuntCommentHuntCommentsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsHuntCommentResource>(Response.FromValue(new SecurityInsightsHuntCommentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a hunt relation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments/{huntCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="huntCommentId"> The hunt comment id (GUID). </param>
        /// <param name="data"> The hunt  comment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="huntCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="huntCommentId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsHuntCommentResource> CreateOrUpdate(WaitUntil waitUntil, string huntCommentId, SecurityInsightsHuntCommentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(huntCommentId, nameof(huntCommentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsHuntCommentHuntCommentsClientDiagnostics.CreateScope("SecurityInsightsHuntCommentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsHuntCommentHuntCommentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, data, cancellationToken);
                var uri = _securityInsightsHuntCommentHuntCommentsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsHuntCommentResource>(Response.FromValue(new SecurityInsightsHuntCommentResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a hunt comment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments/{huntCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="huntCommentId"> The hunt comment id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="huntCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="huntCommentId"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsHuntCommentResource>> GetAsync(string huntCommentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(huntCommentId, nameof(huntCommentId));

            using var scope = _securityInsightsHuntCommentHuntCommentsClientDiagnostics.CreateScope("SecurityInsightsHuntCommentCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsHuntCommentHuntCommentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsHuntCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a hunt comment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments/{huntCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="huntCommentId"> The hunt comment id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="huntCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="huntCommentId"/> is null. </exception>
        public virtual Response<SecurityInsightsHuntCommentResource> Get(string huntCommentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(huntCommentId, nameof(huntCommentId));

            using var scope = _securityInsightsHuntCommentHuntCommentsClientDiagnostics.CreateScope("SecurityInsightsHuntCommentCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsHuntCommentHuntCommentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsHuntCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all hunt comments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsHuntCommentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsHuntCommentResource> GetAllAsync(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsHuntCommentHuntCommentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsHuntCommentHuntCommentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsHuntCommentResource(Client, SecurityInsightsHuntCommentData.DeserializeSecurityInsightsHuntCommentData(e)), _securityInsightsHuntCommentHuntCommentsClientDiagnostics, Pipeline, "SecurityInsightsHuntCommentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all hunt comments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsHuntCommentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsHuntCommentResource> GetAll(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsHuntCommentHuntCommentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsHuntCommentHuntCommentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderBy, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsHuntCommentResource(Client, SecurityInsightsHuntCommentData.DeserializeSecurityInsightsHuntCommentData(e)), _securityInsightsHuntCommentHuntCommentsClientDiagnostics, Pipeline, "SecurityInsightsHuntCommentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments/{huntCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="huntCommentId"> The hunt comment id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="huntCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="huntCommentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string huntCommentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(huntCommentId, nameof(huntCommentId));

            using var scope = _securityInsightsHuntCommentHuntCommentsClientDiagnostics.CreateScope("SecurityInsightsHuntCommentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsHuntCommentHuntCommentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments/{huntCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="huntCommentId"> The hunt comment id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="huntCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="huntCommentId"/> is null. </exception>
        public virtual Response<bool> Exists(string huntCommentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(huntCommentId, nameof(huntCommentId));

            using var scope = _securityInsightsHuntCommentHuntCommentsClientDiagnostics.CreateScope("SecurityInsightsHuntCommentCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsHuntCommentHuntCommentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments/{huntCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="huntCommentId"> The hunt comment id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="huntCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="huntCommentId"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityInsightsHuntCommentResource>> GetIfExistsAsync(string huntCommentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(huntCommentId, nameof(huntCommentId));

            using var scope = _securityInsightsHuntCommentHuntCommentsClientDiagnostics.CreateScope("SecurityInsightsHuntCommentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityInsightsHuntCommentHuntCommentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsHuntCommentResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsHuntCommentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/hunts/{huntId}/comments/{huntCommentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HuntComments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsHuntCommentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="huntCommentId"> The hunt comment id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="huntCommentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="huntCommentId"/> is null. </exception>
        public virtual NullableResponse<SecurityInsightsHuntCommentResource> GetIfExists(string huntCommentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(huntCommentId, nameof(huntCommentId));

            using var scope = _securityInsightsHuntCommentHuntCommentsClientDiagnostics.CreateScope("SecurityInsightsHuntCommentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityInsightsHuntCommentHuntCommentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, huntCommentId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsHuntCommentResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsHuntCommentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsHuntCommentResource> IEnumerable<SecurityInsightsHuntCommentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsHuntCommentResource> IAsyncEnumerable<SecurityInsightsHuntCommentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
