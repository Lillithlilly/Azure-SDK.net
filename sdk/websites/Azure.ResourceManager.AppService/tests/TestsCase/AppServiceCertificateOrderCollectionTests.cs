// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class AppServiceCertificateOrderCollectionTests : AppServiceTestBase
    {
        public AppServiceCertificateOrderCollectionTests(bool isAsync)
           : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        private async Task<AppServiceCertificateOrderCollection> GetAppServiceCertificateOrderCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetAppServiceCertificateOrders();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var container = await GetAppServiceCertificateOrderCollectionAsync();
            var name = Recording.GenerateAssetName("testAppServiceCertificateOrder");
            var input = ResourceDataHelper.GetBasicAppServiceCertificateOrderData("global");
            var lro = await container.CreateOrUpdateAsync(name, input);
            var appServiceCertificateOrder = lro.Value;
            Assert.AreEqual(name, appServiceCertificateOrder.Data.Name);
        }
    }
}
