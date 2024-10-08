﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Identity
{
    internal class AppServiceManagedIdentitySource : ManagedIdentitySource
    {
        // MSI Constants. Docs for MSI are available here https://learn.microsoft.com/azure/app-service/overview-managed-identity
        protected virtual string AppServiceMsiApiVersion { get { throw new NotImplementedException(); } }
        protected virtual string SecretHeaderName { get { throw new NotImplementedException(); } }
        protected virtual string ClientIdHeaderName { get { throw new NotImplementedException(); } }

        private const string MsiEndpointInvalidUriError = "The environment variable MSI_ENDPOINT contains an invalid Uri.";

        private readonly Uri _endpoint;
        private readonly string _secret;
        private readonly ManagedIdentityId _managedIdentityId;

        protected static bool TryValidateEnvVars(string msiEndpoint, string secret, out Uri endpointUri)
        {
            endpointUri = null;
            // if BOTH the env vars endpoint and secret values are null, this MSI provider is unavailable.
            // Also validate that IdentityServerThumbprint is null or empty to differentiate from Service Fabric.
            if (string.IsNullOrEmpty(msiEndpoint) || string.IsNullOrEmpty(secret))
            {
                return false;
            }

            try
            {
                endpointUri = new Uri(msiEndpoint);
            }
            catch (FormatException ex)
            {
                throw new AuthenticationFailedException(MsiEndpointInvalidUriError, ex);
            }

            return true;
        }

        protected AppServiceManagedIdentitySource(CredentialPipeline pipeline, Uri endpoint, string secret,
            ManagedIdentityClientOptions options) : base(pipeline)
        {
            _endpoint = endpoint;
            _secret = secret;
            _managedIdentityId = options.ManagedIdentityId;
        }

        protected override Request CreateRequest(string[] scopes)
        {
            // covert the scopes to a resource string
            string resource = ScopeUtilities.ScopesToResource(scopes);

            Request request = Pipeline.HttpPipeline.CreateRequest();

            request.Method = RequestMethod.Get;
            request.Headers.Add(SecretHeaderName, _secret);
            request.Uri.Reset(_endpoint);
            request.Uri.AppendQuery("api-version", AppServiceMsiApiVersion);
            request.Uri.AppendQuery("resource", resource);

            string idQueryParam = _managedIdentityId?._idType switch
            {
                ManagedIdentityIdType.ClientId => ClientIdHeaderName,
                ManagedIdentityIdType.ResourceId => Constants.ManagedIdentityResourceId,
                _ => null
            };

            if (idQueryParam != null)
            {
                request.Uri.AppendQuery(idQueryParam, _managedIdentityId._userAssignedId);
            }

            return request;
        }
    }
}
