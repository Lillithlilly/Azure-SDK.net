// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The billing profile details of the partner of the customer for an indirect motion. </summary>
    public partial class IndirectRelationshipInfo
    {
        /// <summary> Initializes a new instance of IndirectRelationshipInfo. </summary>
        internal IndirectRelationshipInfo()
        {
        }

        /// <summary> Initializes a new instance of IndirectRelationshipInfo. </summary>
        /// <param name="billingAccountName"> The billing account name of the partner or the customer for an indirect motion. </param>
        /// <param name="billingProfileName"> The billing profile name of the partner or the customer for an indirect motion. </param>
        /// <param name="displayName"> The display name of the partner or customer for an indirect motion. </param>
        internal IndirectRelationshipInfo(string billingAccountName, string billingProfileName, string displayName)
        {
            BillingAccountName = billingAccountName;
            BillingProfileName = billingProfileName;
            DisplayName = displayName;
        }

        /// <summary> The billing account name of the partner or the customer for an indirect motion. </summary>
        public string BillingAccountName { get; }
        /// <summary> The billing profile name of the partner or the customer for an indirect motion. </summary>
        public string BillingProfileName { get; }
        /// <summary> The display name of the partner or customer for an indirect motion. </summary>
        public string DisplayName { get; }
    }
}