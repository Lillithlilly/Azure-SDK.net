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
    public class AppServiceCertificateResourceCollectionTests : AppServiceTestBase
    {
        public AppServiceCertificateResourceCollectionTests(bool isAsync)
           : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<AppServiceCertificateResourceCollection> GetAppServiceCertificateResourceCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var orderName = Recording.GenerateAssetName("testAppServiceCertificateOrder");
            var orderInput = ResourceDataHelper.GetBasicAppServiceCertificateOrderData("global");
            var lro = await resourceGroup.GetAppServiceCertificateOrders().CreateOrUpdateAsync(orderName, orderInput);
            var Order = lro.Value;
            return Order.GetAppServiceCertificateResources();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var container = await GetAppServiceCertificateResourceCollectionAsync();
            var name = Recording.GenerateAssetName("testAppServiceCertificateResource");
            var input = ResourceDataHelper.GetBasicAppServiceCertificateResourceData("global");
            var lro = await container.CreateOrUpdateAsync(name, input);
            var appServiceCertificateResource = lro.Value;
            Assert.AreEqual(name, appServiceCertificateResource.Data.Name);
        }
    }
}
