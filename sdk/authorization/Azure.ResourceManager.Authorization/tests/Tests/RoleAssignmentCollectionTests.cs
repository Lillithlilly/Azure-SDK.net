// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Authorization.Tests;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests
{
    public class RoleAssignmentCollectionTests : AuthorizationTestBase
    {
        public RoleAssignmentCollectionTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<RoleAssignmentCollection> GetRoleAssignmentCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetRoleAssignments();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var collection = await GetRoleAssignmentCollectionAsync();
            var groupName = Recording.GenerateAssetName("testRA-");
            var input = ResourceHelper.GetBasicRoleAssignmentCreateParameters();
            var lro = await collection.CreateOrUpdateAsync(groupName, input);
            var group = lro.Value;
            Assert.AreEqual(groupName, group.Data.Name);
        }
    }
}
