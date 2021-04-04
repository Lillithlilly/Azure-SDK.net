// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Azure.Management.Quantum.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Xunit;

namespace Microsoft.Azure.Management.Quantum.Tests
{
    public class WorkspaceOperationTests : QuantumManagementTestBase
    {
        private QuantumWorkspace CreateAndAssertWorkspace(string workspaceName, string location, string resourceGroup, string storageAccount, string providerId = null, string providerSkuId = null)
        {
            var offerings = QuantumClient.Offerings.List(location);
            var provider = offerings.First(
                    (p) =>
                    (!String.IsNullOrEmpty(providerId) && String.Equals(providerId, p.Id))
                    || (String.IsNullOrEmpty(providerId) && p.Name.Contains("Microsoft"))
                );
            Assert.NotNull(provider);

            var providerSku = provider.Properties.Skus.First(
                    (sku) =>
                    (!String.IsNullOrEmpty(providerSkuId) && String.Equals(providerSkuId, sku.Id))
                    || (String.IsNullOrEmpty(providerSkuId))
                );
            Assert.NotNull(providerSku);

            var createParams = new QuantumWorkspace
            {
                Location = location,
                Identity = new QuantumWorkspaceIdentity
                {
                    Type = ResourceIdentityType.SystemAssigned
                },
                Providers = new List<Provider>()
                {
                    new Provider()
                    {
                        ProviderId = provider.Id,
                        ProviderSku = providerSku.Id
                    }
                },
                StorageAccount = storageAccount,
            };

            var workspaceCreate = QuantumClient.Workspaces.CreateOrUpdate(resourceGroup, workspaceName, createParams);
            Assert.Equal(CommonTestFixture.WorkspaceType, workspaceCreate.Type);
            Assert.Equal(workspaceName, workspaceCreate.Name);
            Assert.Equal(location, workspaceCreate.Location);
            for (int i = 0; i < 600; i++)
            {
                var workspaceGet = QuantumClient.Workspaces.Get(resourceGroup, workspaceName);
                if (workspaceGet.ProvisioningState.Equals("Succeeded"))
                {
                    Assert.Equal(CommonTestFixture.WorkspaceType, workspaceGet.Type);
                    Assert.Equal(workspaceName, workspaceGet.Name);
                    Assert.Equal(location, workspaceGet.Location);
                    return workspaceGet;
                }

                Thread.Sleep(5000);
                Assert.True(i < 600, "Quantum Workspace is not in succeeded state even after 5 min.");
            }

            return null;
        }

        /// <summary>
        /// This test case will only run when QUANTUM_E2E_TESTS environment variable is set
        /// and it will use the following environment variables to create the workspace:
        /// - QUANTUM_WORKSPACE_NAME
        /// - LOCATION
        /// - RESOURCE_GROUP
        /// - STORAGE_ACCOUNT
        /// </summary>
        [Fact()]
        public void TestCreateWorkspace()
        {
            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("QUANTUM_E2E_TESTS")))
            {
                Assert.True(true);
                return;
            }

            TestInitialize(createResources: false);

            string workspaceName = Environment.GetEnvironmentVariable("QUANTUM_WORKSPACE_NAME");
            string location = Environment.GetEnvironmentVariable("LOCATION");
            string resourceGroup = Environment.GetEnvironmentVariable("RESOURCE_GROUP");
            string storageAccount = Environment.GetEnvironmentVariable("STORAGE_ACCOUNT");

            Assert.NotEmpty(workspaceName);
            Assert.NotEmpty(location);
            Assert.NotEmpty(resourceGroup);
            Assert.NotEmpty(storageAccount);

            CreateAndAssertWorkspace(workspaceName, location, resourceGroup, storageAccount);
        }

        [Fact]
        public void TestWorkspaceLifeCycle()
        {
            TestInitialize();

            // create workspace
            string workspaceName = TestUtilities.GenerateName("aqws");
            var workspace =  CreateAndAssertWorkspace(workspaceName, CommonData.Location, CommonData.ResourceGroupName, CommonData.StorageAccountId);

            // update workspace
            Dictionary<string, string> tagsToUpdate = new Dictionary<string, string> { { "TestTag", "TestUpdate" } };
            workspace.Tags = tagsToUpdate;
            var workspaceUpdate = QuantumClient.Workspaces.CreateOrUpdate(CommonData.ResourceGroupName, workspaceName, workspace);
            Assert.NotNull(workspaceUpdate.Tags);
            Assert.Equal("TestUpdate", workspaceUpdate.Tags["TestTag"]);

            // list workspace from resource group
            var firstPage = QuantumClient.Workspaces.ListByResourceGroup(CommonData.ResourceGroupName);
            var workspaceFromResourceGroup = QuantumManagementTestUtilities.ListResources(firstPage, QuantumClient.Workspaces.ListByResourceGroupNext);
            Assert.True(1 <= workspaceFromResourceGroup.Count);
            bool isFound = false;
            int workspaceCount = workspaceFromResourceGroup.Count;
            for (int i = 0; i < workspaceCount; i++)
            {
                if (workspaceFromResourceGroup[i].Name.Equals(workspaceName))
                {
                    isFound = true;
                    Assert.Equal(CommonTestFixture.WorkspaceType, workspaceFromResourceGroup[i].Type);
                    Assert.Equal(CommonData.Location, workspaceFromResourceGroup[i].Location);
                    break;
                }
            }

            Assert.True(isFound, string.Format("Workspace created earlier is not found when listing all in resource group {0}", CommonData.ResourceGroupName));

            // list workspace from subscription
            firstPage = QuantumClient.Workspaces.ListBySubscription();
            Assert.True(1 <= workspaceFromResourceGroup.Count);
            var workspaceFromSubscription = QuantumManagementTestUtilities.ListResources(firstPage, QuantumClient.Workspaces.ListBySubscriptionNext);
            Assert.True(1 <= workspaceFromSubscription.Count);
            isFound = false;
            for (int i = 0; i < workspaceFromSubscription.Count; i++)
            {
                if (workspaceFromSubscription[i].Name.Equals(workspaceName))
                {
                    isFound = true;
                    Assert.Equal(CommonTestFixture.WorkspaceType, workspaceFromSubscription[i].Type);
                    Assert.Equal(CommonData.Location, workspaceFromSubscription[i].Location);
                    break;
                }
            }

            Assert.True(isFound, string.Format("Workspace created earlier is not found when listing all in subscription {0}", CommonData.SubscriptionId));

            // delete workspace
            QuantumClient.Workspaces.Delete(CommonData.ResourceGroupName, workspaceName);
            firstPage = QuantumClient.Workspaces.ListByResourceGroup(CommonData.ResourceGroupName);
            var workspaceAfterDelete = QuantumManagementTestUtilities.ListResources(firstPage, QuantumClient.Workspaces.ListByResourceGroupNext);
            Assert.True(workspaceCount - 1 == workspaceAfterDelete.Count);
        }
    }
}