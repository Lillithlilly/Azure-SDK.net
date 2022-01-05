// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Authorization.Tests;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests
{
    public class RoleEligibilityScheduleRequestCollectionTests : AuthorizationTestBase
    {
        public RoleEligibilityScheduleRequestCollectionTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<RoleEligibilityScheduleRequestCollection> GetRoleEligibilityScheduleRequestCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetRoleEligibilityScheduleRequests();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var collection = await GetRoleEligibilityScheduleRequestCollectionAsync();
            var groupName = Recording.GenerateAssetName("testRESR");
            var input = ResourceHelper.GetBasicRoleEligibilityScheduleRequestData();
            var lro = await collection.CreateOrUpdateAsync(groupName, input);
            var group = lro.Value;
            Assert.AreEqual(groupName, group.Data.Name);
        }
    }
}
