// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Analytics.Synapse.AccessControl
{
    /// <summary> Check access response details. </summary>
    public partial class CheckAccessDecision
    {
        /// <summary> Initializes a new instance of CheckAccessDecision. </summary>
        internal CheckAccessDecision()
        {
        }

        /// <summary> Initializes a new instance of CheckAccessDecision. </summary>
        /// <param name="accessDecision"> Access Decision. </param>
        /// <param name="actionId"> Action Id. </param>
        /// <param name="roleAssignment"> Role Assignment response details. </param>
        internal CheckAccessDecision(string accessDecision, string actionId, RoleAssignmentDetails roleAssignment)
        {
            AccessDecision = accessDecision;
            ActionId = actionId;
            RoleAssignment = roleAssignment;
        }

        /// <summary> Access Decision. </summary>
        public string AccessDecision { get; }
        /// <summary> Action Id. </summary>
        public string ActionId { get; }
        /// <summary> Role Assignment response details. </summary>
        public RoleAssignmentDetails RoleAssignment { get; }
    }
}
