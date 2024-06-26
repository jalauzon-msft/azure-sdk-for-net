// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class NetworkFunctionOperationSource : IOperationSource<NetworkFunctionResource>
    {
        private readonly ArmClient _client;

        internal NetworkFunctionOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFunctionResource IOperationSource<NetworkFunctionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkFunctionData.DeserializeNetworkFunctionData(document.RootElement);
            return new NetworkFunctionResource(_client, data);
        }

        async ValueTask<NetworkFunctionResource> IOperationSource<NetworkFunctionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkFunctionData.DeserializeNetworkFunctionData(document.RootElement);
            return new NetworkFunctionResource(_client, data);
        }
    }
}
