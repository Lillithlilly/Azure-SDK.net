// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests.Tests
{
    public class AccessReviewDecisionCollectionTests : AuthorizationTestBase
    {
        public AccessReviewDecisionCollectionTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<DiskCollection> GetDiskCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetDisks();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var collection = await GetDiskCollectionAsync();
            var diskName = Recording.GenerateAssetName("testDisk-");
            var input = ResourceDataHelper.GetEmptyDiskData(DefaultLocation);
            var lro = await collection.CreateOrUpdateAsync(diskName, input);
            Disk disk = lro.Value;
            Assert.AreEqual(diskName, disk.Data.Name);
        }
    }
}
