// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MgmtTypeSpec.Models;

namespace MgmtTypeSpec
{
    internal partial class PrivateLinks
    {
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrivateLinks for mocking. </summary>
        protected PrivateLinks()
        {
        }

        internal PrivateLinks(HttpPipeline pipeline, Uri endpoint, string apiVersion)
        {
            _endpoint = endpoint;
            Pipeline = pipeline;
            _apiVersion = apiVersion;
        }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public HttpPipeline Pipeline { get; }

        /// <summary>
        /// [Protocol Method] list private links on the given resource
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response GetAllPrivateLinkResources(Guid subscriptionId, string resourceGroupName, RequestContext context)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            using HttpMessage message = CreateGetAllPrivateLinkResourcesRequest(subscriptionId, resourceGroupName, context);
            return Pipeline.ProcessMessage(message, context);
        }

        /// <summary>
        /// [Protocol Method] list private links on the given resource
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> GetAllPrivateLinkResourcesAsync(Guid subscriptionId, string resourceGroupName, RequestContext context)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            using HttpMessage message = CreateGetAllPrivateLinkResourcesRequest(subscriptionId, resourceGroupName, context);
            return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> list private links on the given resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<PrivateLinkResourceListResult> GetAllPrivateLinkResources(Guid subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            Response result = GetAllPrivateLinkResources(subscriptionId, resourceGroupName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
            return Response.FromValue((PrivateLinkResourceListResult)result, result);
        }

        /// <summary> list private links on the given resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<PrivateLinkResourceListResult>> GetAllPrivateLinkResourcesAsync(Guid subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            Response result = await GetAllPrivateLinkResourcesAsync(subscriptionId, resourceGroupName, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
            return Response.FromValue((PrivateLinkResourceListResult)result, result);
        }

        /// <summary>
        /// [Protocol Method] Starts the SAP Application Server Instance.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateLinkResourceName"> The name of the private link associated with the Azure resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response Start(Guid subscriptionId, string resourceGroupName, string privateLinkResourceName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(privateLinkResourceName, nameof(privateLinkResourceName));

            using HttpMessage message = CreateStartRequest(subscriptionId, resourceGroupName, privateLinkResourceName, content, context);
            return Pipeline.ProcessMessage(message, context);
        }

        /// <summary>
        /// [Protocol Method] Starts the SAP Application Server Instance.
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateLinkResourceName"> The name of the private link associated with the Azure resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> StartAsync(Guid subscriptionId, string resourceGroupName, string privateLinkResourceName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(privateLinkResourceName, nameof(privateLinkResourceName));

            using HttpMessage message = CreateStartRequest(subscriptionId, resourceGroupName, privateLinkResourceName, content, context);
            return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> Starts the SAP Application Server Instance. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateLinkResourceName"> The name of the private link associated with the Azure resource. </param>
        /// <param name="body"> SAP Application server instance start request body. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response Start(Guid subscriptionId, string resourceGroupName, string privateLinkResourceName, StartRequest body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(privateLinkResourceName, nameof(privateLinkResourceName));

            return Start(subscriptionId, resourceGroupName, privateLinkResourceName, body, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null);
        }

        /// <summary> Starts the SAP Application Server Instance. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateLinkResourceName"> The name of the private link associated with the Azure resource. </param>
        /// <param name="body"> SAP Application server instance start request body. </param>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response> StartAsync(Guid subscriptionId, string resourceGroupName, string privateLinkResourceName, StartRequest body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(privateLinkResourceName, nameof(privateLinkResourceName));

            return await StartAsync(subscriptionId, resourceGroupName, privateLinkResourceName, body, cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
        }
    }
}
