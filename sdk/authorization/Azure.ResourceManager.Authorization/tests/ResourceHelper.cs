// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests
{
    public static class ResourceHelper
    {
        private const string dummySSHKey = "ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQC+wWK73dCr+jgQOAxNsHAnNNNMEMWOHYEccp6wJm2gotpr9katuF/ZAdou5AaW1C61slRkHRkpRRX9FA9CYBiitZgvCCz+3nWNN7l/Up54Zps/pHWGZLHNJZRYyAB6j5yVLMVHIHriY49d/GZTZVNB8GoJv9Gakwc/fuEZYYl4YDFiGMBP///TzlI4jhiJzjKnEvqPFki5p2ZRJqcbCiF4pJrxUQR/RXqVFQdbRLZgYfJ8xGB878RENq3yQ39d8dVOkq4edbkzwcUmwwwkYVPIoDGsYLaRHnG+To7FvMeyO7xDVQkMKzopTQV8AuKpyvpqu0a9pWOMaiCyDytO7GGN you@me.com";

        // Temporary solution since the one in Azure.ResourceManager.Compute is internal
        public static IDictionary<string, string> ReplaceWith(this IDictionary<string, string> dest, IDictionary<string, string> src)
        {
            dest.Clear();
            foreach (var kv in src)
            {
                dest.Add(kv);
            }

            return dest;
        }

        public static void AssertTrackedResource(Resource r1, Resource r2)
        {
            Assert.AreEqual(r1.Name, r2.Name);
            Assert.AreEqual(r1.Id, r2.Id);
            Assert.AreEqual(r1.Type, r2.Type);
            //Assert.AreEqual(r1.Location, r2.Location);
            //Assert.AreEqual(r1.Tags, r2.Tags);
        }

        #region AccessReviewDecision
        public static void AssertAccessReviewDecision(AccessReviewDecisionData decision1, AccessReviewDecisionData decision2)
        {
            AssertTrackedResource(decision1, decision2);
            Assert.AreEqual(decision1.Decision, decision2.Decision);
            Assert.AreEqual(decision1.AppliedDateTime, decision2.AppliedDateTime);
            Assert.AreEqual(decision1.ReviewedDateTime, decision2.ReviewedDateTime);
        }

        public static AccessReviewDecisionData GetBasicAvailabilitySetData()
        {
            return new AccessReviewDecisionData();
        }
        #endregion
    }
}
