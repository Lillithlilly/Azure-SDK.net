// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class AppServiceDomainCollectionTests : AppServiceTestBase
    {
        //protected Location DomainLocation => Location.
        public AppServiceDomainCollectionTests(bool isAsync)
           : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<AppServiceDomainCollection> GetAppServiceDomainCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetAppServiceDomains();
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var container = await GetAppServiceDomainCollectionAsync();
            var name = Recording.GenerateAssetName("www.contoso.com");
            var input = ResourceDataHelper.GetBasicAppServiceDomainData("global");
            var lro = await container.CreateOrUpdateAsync(name, input);
            var domain = lro.Value;
            Assert.AreEqual(name, domain.Data.Name);
        }
    }
}
