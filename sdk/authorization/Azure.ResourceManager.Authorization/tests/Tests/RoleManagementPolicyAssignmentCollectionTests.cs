// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Authorization.Tests;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests
{
    public class RoleManagementPolicyAssignmentCollectionTests : AuthorizationTestBase
    {
        public RoleManagementPolicyAssignmentCollectionTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<RoleManagementPolicyAssignmentCollection> GetRoleManagementPolicyAssignmentCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetRoleManagementPolicyAssignments();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var collection = await GetRoleManagementPolicyAssignmentCollectionAsync();
            var groupName = Recording.GenerateAssetName("testRMPA");
            var input = ResourceHelper.GetBasicRoleManagementPolicyAssignmentData();
            var lro = await collection.CreateOrUpdateAsync(groupName, input);
            var group = lro.Value;
            Assert.AreEqual(groupName, group.Data.Name);
        }
    }
}
