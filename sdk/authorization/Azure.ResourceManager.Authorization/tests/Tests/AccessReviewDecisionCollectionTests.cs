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
        //private async Task<AccessReviewDecisionCollection> GetAccessReviewDecisionCollectionAsync()
        //{
            //var resourceGroup = await CreateResourceGroupAsync();
             //resourceGroup.GetRoleAssignmentScheduleInstances();
        //}
    }
}
