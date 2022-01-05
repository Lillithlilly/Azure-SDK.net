// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Authorization.Tests;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests
    {
        public class RoleDefinitionCollectionTests : AuthorizationTestBase
        {
        public RoleDefinitionCollectionTests(bool isAsync)
                : base(isAsync, RecordedTestMode.Record)
            {
            }
        private async Task<RoleDefinitionCollection> GetRoleDefinitionCollectionAsync()
            {
                var resourceGroup = await CreateResourceGroupAsync();
                return resourceGroup.GetRoleDefinitions();
            }

            [TestCase]
            [RecordedTest]
            public async Task CreateOrUpdate()
            {
                var subId = DefaultSubscription.Id;
                var collection = await GetRoleDefinitionCollectionAsync();
                var roleName = "7b266cd7-0bba-4ae2-8423-90ede5e1e898";
                var input = ResourceHelper.GetBasicRoleDefinitionData(subId);
                var lro = await collection.CreateOrUpdateAsync(roleName, input);
                var roledefinition = lro.Value;
                Assert.AreEqual(roleName, roledefinition.Data.Name);
            }
    }
}
