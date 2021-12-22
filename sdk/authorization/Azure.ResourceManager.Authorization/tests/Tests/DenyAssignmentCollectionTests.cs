// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Authorization.Tests;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests
{
    public class DenyAssignmentCollectionTests : AuthorizationTestBase
    {
        public DenyAssignmentCollectionTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<DenyAssignmentCollection> GetDenyAssignmentCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetDenyAssignments();
        }
    }
}
