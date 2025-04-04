// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Identity;
using Azure.ResourceManager.DataFactory.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_DataFactoryPipelineResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PipelinesGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Pipelines_Get.json
            // this example is just showing the usage of "Pipelines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryPipelineResource created on azure
            // for more information of creating DataFactoryPipelineResource, please refer to the document of DataFactoryPipelineResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string pipelineName = "examplePipeline";
            ResourceIdentifier dataFactoryPipelineResourceId = DataFactoryPipelineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, pipelineName);
            DataFactoryPipelineResource dataFactoryPipeline = client.GetDataFactoryPipelineResource(dataFactoryPipelineResourceId);

            // invoke the operation
            DataFactoryPipelineResource result = await dataFactoryPipeline.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryPipelineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PipelinesDelete()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Pipelines_Delete.json
            // this example is just showing the usage of "Pipelines_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryPipelineResource created on azure
            // for more information of creating DataFactoryPipelineResource, please refer to the document of DataFactoryPipelineResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string pipelineName = "examplePipeline";
            ResourceIdentifier dataFactoryPipelineResourceId = DataFactoryPipelineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, pipelineName);
            DataFactoryPipelineResource dataFactoryPipeline = client.GetDataFactoryPipelineResource(dataFactoryPipelineResourceId);

            // invoke the operation
            await dataFactoryPipeline.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PipelinesCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Pipelines_Create.json
            // this example is just showing the usage of "Pipelines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryPipelineResource created on azure
            // for more information of creating DataFactoryPipelineResource, please refer to the document of DataFactoryPipelineResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string pipelineName = "examplePipeline";
            ResourceIdentifier dataFactoryPipelineResourceId = DataFactoryPipelineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, pipelineName);
            DataFactoryPipelineResource dataFactoryPipeline = client.GetDataFactoryPipelineResource(dataFactoryPipelineResourceId);

            // invoke the operation
            DataFactoryPipelineData data = new DataFactoryPipelineData
            {
                Activities = {new ForEachActivity("ExampleForeachActivity", new DataFactoryExpression(DataFactoryExpressionType.Expression, "@pipeline().parameters.OutputBlobNameList"), new PipelineActivity[]
{
new CopyActivity("ExampleCopyActivity", new DataFactoryBlobSource(), new DataFactoryBlobSink())
{
Inputs = {new DatasetReference(DatasetReferenceType.DatasetReference, "exampleDataset")
{
Parameters =
{
["MyFileName"] = BinaryData.FromObjectAsJson("examplecontainer.csv"),
["MyFolderPath"] = BinaryData.FromObjectAsJson("examplecontainer")
},
}},
Outputs = {new DatasetReference(DatasetReferenceType.DatasetReference, "exampleDataset")
{
Parameters =
{
["MyFileName"] = BinaryData.FromObjectAsJson(new
{
type = "Expression",
value = "@item()",
}),
["MyFolderPath"] = BinaryData.FromObjectAsJson("examplecontainer")
},
}},
DataIntegrationUnits = null,
}
})
{
IsSequential = true,
}},
                Parameters =
{
["JobId"] = new EntityParameterSpecification(EntityParameterType.String),
["OutputBlobNameList"] = new EntityParameterSpecification(EntityParameterType.Array)
},
                Variables =
{
["TestVariableArray"] = new PipelineVariableSpecification(PipelineVariableType.Array)
},
                RunDimensions =
{
["JobId"] = BinaryData.FromObjectAsJson(new
{
type = "Expression",
value = "@pipeline().parameters.JobId",
})
},
                ElapsedTimeMetricDuration = BinaryData.FromObjectAsJson("0.00:10:00"),
            };
            ArmOperation<DataFactoryPipelineResource> lro = await dataFactoryPipeline.UpdateAsync(WaitUntil.Completed, data);
            DataFactoryPipelineResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryPipelineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PipelinesUpdate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Pipelines_Update.json
            // this example is just showing the usage of "Pipelines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryPipelineResource created on azure
            // for more information of creating DataFactoryPipelineResource, please refer to the document of DataFactoryPipelineResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string pipelineName = "examplePipeline";
            ResourceIdentifier dataFactoryPipelineResourceId = DataFactoryPipelineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, pipelineName);
            DataFactoryPipelineResource dataFactoryPipeline = client.GetDataFactoryPipelineResource(dataFactoryPipelineResourceId);

            // invoke the operation
            DataFactoryPipelineData data = new DataFactoryPipelineData
            {
                Description = "Example description",
                Activities = {new ForEachActivity("ExampleForeachActivity", new DataFactoryExpression(DataFactoryExpressionType.Expression, "@pipeline().parameters.OutputBlobNameList"), new PipelineActivity[]
{
new CopyActivity("ExampleCopyActivity", new DataFactoryBlobSource(), new DataFactoryBlobSink())
{
Inputs = {new DatasetReference(DatasetReferenceType.DatasetReference, "exampleDataset")
{
Parameters =
{
["MyFileName"] = BinaryData.FromObjectAsJson("examplecontainer.csv"),
["MyFolderPath"] = BinaryData.FromObjectAsJson("examplecontainer")
},
}},
Outputs = {new DatasetReference(DatasetReferenceType.DatasetReference, "exampleDataset")
{
Parameters =
{
["MyFileName"] = BinaryData.FromObjectAsJson(new
{
type = "Expression",
value = "@item()",
}),
["MyFolderPath"] = BinaryData.FromObjectAsJson("examplecontainer")
},
}},
DataIntegrationUnits = null,
}
})
{
IsSequential = true,
}},
                Parameters =
{
["OutputBlobNameList"] = new EntityParameterSpecification(EntityParameterType.Array)
},
                ElapsedTimeMetricDuration = BinaryData.FromObjectAsJson("0.00:10:00"),
            };
            ArmOperation<DataFactoryPipelineResource> lro = await dataFactoryPipeline.UpdateAsync(WaitUntil.Completed, data);
            DataFactoryPipelineResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryPipelineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateRun_PipelinesCreateRun()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Pipelines_CreateRun.json
            // this example is just showing the usage of "Pipelines_CreateRun" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryPipelineResource created on azure
            // for more information of creating DataFactoryPipelineResource, please refer to the document of DataFactoryPipelineResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string pipelineName = "examplePipeline";
            ResourceIdentifier dataFactoryPipelineResourceId = DataFactoryPipelineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, pipelineName);
            DataFactoryPipelineResource dataFactoryPipeline = client.GetDataFactoryPipelineResource(dataFactoryPipelineResourceId);

            // invoke the operation
            IDictionary<string, BinaryData> parameterValueSpecification = new Dictionary<string, BinaryData>
            {
                ["OutputBlobNameList"] = BinaryData.FromObjectAsJson(new object[]
            {
"exampleoutput.csv"
            })
            };
            string referencePipelineRunId = null;
            PipelineCreateRunResult result = await dataFactoryPipeline.CreateRunAsync(parameterValueSpecification: parameterValueSpecification, referencePipelineRunId: referencePipelineRunId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
