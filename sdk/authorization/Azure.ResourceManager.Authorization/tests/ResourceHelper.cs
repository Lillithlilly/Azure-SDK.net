// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Security.AccessControl;
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

        #region RoleAssignment
        public static void AssertRoleAssignment(RoleAssignmentData ra1, RoleAssignmentData ra2)
        {
            AssertTrackedResource(ra1, ra2);
            Assert.AreEqual(ra1.PrincipalId, ra2.PrincipalId);
            Assert.AreEqual(ra1.ConditionVersion, ra2.ConditionVersion);
            Assert.AreEqual(ra1.RoleDefinitionId, ra2.RoleDefinitionId);
        }

        public static RoleAssignmentData GetBasicRoleAssignmentData()
        {
            return new RoleAssignmentData();
        }

        public static RoleAssignmentCreateParameters GetBasicRoleAssignmentCreateParameters()
        {
            return new RoleAssignmentCreateParameters("", "")
            {
            };
        }
        #endregion

        #region RoleAssignmentScheduleRequest
        public static void AssertRoleAssignmentScheduleRequest(RoleAssignmentScheduleRequestData ra1, RoleAssignmentScheduleRequestData ra2)
        {
            AssertTrackedResource(ra1, ra2);
            Assert.AreEqual(ra1.PrincipalId, ra2.PrincipalId);
            Assert.AreEqual(ra1.ConditionVersion, ra2.ConditionVersion);
            Assert.AreEqual(ra1.RoleDefinitionId, ra2.RoleDefinitionId);
        }

        public static RoleAssignmentScheduleRequestData GetBasicRoleAssignmentScheduleRequestData()
        {
            return new RoleAssignmentScheduleRequestData();
        }
        #endregion

        #region RoleManagementPolicyAssignment
        public static void AssertRoleManagementPolicyAssignment(RoleManagementPolicyAssignmentData ra1, RoleManagementPolicyAssignmentData ra2)
        {
            AssertTrackedResource(ra1, ra2);
            Assert.AreEqual(ra1.RoleDefinitionId, ra2.RoleDefinitionId);
        }

        public static RoleManagementPolicyAssignmentData GetBasicRoleManagementPolicyAssignmentData()
        {
            return new RoleManagementPolicyAssignmentData();
        }
        #endregion

        #region RoleEligibilityScheduleRequest
        public static void AssertRoleEligibilityScheduleRequest(RoleEligibilityScheduleRequestData ra1, RoleEligibilityScheduleRequestData ra2)
        {
            AssertTrackedResource(ra1, ra2);
            Assert.AreEqual(ra1.PrincipalId, ra2.PrincipalId);
            Assert.AreEqual(ra1.ConditionVersion, ra2.ConditionVersion);
            Assert.AreEqual(ra1.RoleDefinitionId, ra2.RoleDefinitionId);
        }

        public static RoleEligibilityScheduleRequestData GetBasicRoleEligibilityScheduleRequestData()
        {
            return new RoleEligibilityScheduleRequestData();
        }
        #endregion

        #region RoleDefinition
        public static void AssertRoleDefinition(RoleDefinitionData ra1, RoleDefinitionData ra2)
        {
            AssertTrackedResource(ra1, ra2);
            Assert.AreEqual(ra1.Description, ra2.Description);
            Assert.AreEqual(ra1.RoleName, ra2.RoleName);
            Assert.AreEqual(ra1.AssignableScopes, ra2.AssignableScopes);
        }

        public static RoleDefinitionData GetBasicRoleDefinitionData(string Id)
        {
            return new RoleDefinitionData()
            {
                AssignableScopes =
                {
                    Id,
                },
                Permissions =
                {
                    new Permission()
                    {
                        Actions =
                        {
                            "Microsoft.Compute/*/read",
                            "Microsoft.Compute/virtualMachines/start/action",
                            "Microsoft.Compute/virtualMachines/restart/action",
                            "Microsoft.Network/*/read",
                            "Microsoft.Storage/*/read",
                            "Microsoft.Authorization/*/read",
                            "Microsoft.Resources/subscriptions/resourceGroups/read",
                            "Microsoft.Resources/subscriptions/resourceGroups/resources/read",
                            "Microsoft.Insights/alertRules/*"
                        },
                        DataActions =
                        {
                            "Microsoft.Storage/storageAccounts/blobServices/containers/blobs/*"
                        },
                        NotDataActions =
                        {
                            "Microsoft.Storage/storageAccounts/blobServices/containers/blobs/write"
                        }
                    }
                }
            };
        }
        #endregion
    }
}
