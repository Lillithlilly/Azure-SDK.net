// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Authorization.Tests;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests
{
    public class RoleAssignmentScheduleRequestCollectionTests : AuthorizationTestBase
    {
        public RoleAssignmentScheduleRequestCollectionTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<RoleAssignmentScheduleRequestCollection> GetRoleAssignmentScheduleRequestCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetRoleAssignmentScheduleRequests();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var collection = await GetRoleAssignmentScheduleRequestCollectionAsync();
            var rasrName = Recording.GenerateAssetName("testRASR");
            var input = ResourceHelper.GetBasicRoleAssignmentScheduleRequestData();
            var lro = await collection.CreateOrUpdateAsync(rasrName, input);
            var rasr = lro.Value;
            Assert.AreEqual(rasrName, rasr.Data.Name);
        }
    }
}
