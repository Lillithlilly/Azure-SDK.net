// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Invoice section properties with create subscription permission. </summary>
    public partial class InvoiceSectionWithCreateSubPermission
    {
        /// <summary> Initializes a new instance of InvoiceSectionWithCreateSubPermission. </summary>
        internal InvoiceSectionWithCreateSubPermission()
        {
            EnabledAzurePlans = new ChangeTrackingList<AzurePlan>();
        }

        /// <summary> Initializes a new instance of InvoiceSectionWithCreateSubPermission. </summary>
        /// <param name="invoiceSectionId"> The ID of the invoice section. </param>
        /// <param name="invoiceSectionDisplayName"> The name of the invoice section. </param>
        /// <param name="invoiceSectionSystemId"> The system generated unique identifier for an invoice section. </param>
        /// <param name="billingProfileId"> The ID of the billing profile for the invoice section. </param>
        /// <param name="billingProfileDisplayName"> The name of the billing profile for the invoice section. </param>
        /// <param name="billingProfileStatus"> The status of the billing profile. </param>
        /// <param name="billingProfileStatusReasonCode"> Reason for the specified billing profile status. </param>
        /// <param name="billingProfileSpendingLimit"> The billing profile spending limit. </param>
        /// <param name="billingProfileSystemId"> The system generated unique identifier for a billing profile. </param>
        /// <param name="enabledAzurePlans"> Enabled azure plans for the associated billing profile. </param>
        internal InvoiceSectionWithCreateSubPermission(string invoiceSectionId, string invoiceSectionDisplayName, string invoiceSectionSystemId, string billingProfileId, string billingProfileDisplayName, BillingProfileStatus? billingProfileStatus, StatusReasonCodeForBillingProfile? billingProfileStatusReasonCode, SpendingLimitForBillingProfile? billingProfileSpendingLimit, string billingProfileSystemId, IReadOnlyList<AzurePlan> enabledAzurePlans)
        {
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionDisplayName = invoiceSectionDisplayName;
            InvoiceSectionSystemId = invoiceSectionSystemId;
            BillingProfileId = billingProfileId;
            BillingProfileDisplayName = billingProfileDisplayName;
            BillingProfileStatus = billingProfileStatus;
            BillingProfileStatusReasonCode = billingProfileStatusReasonCode;
            BillingProfileSpendingLimit = billingProfileSpendingLimit;
            BillingProfileSystemId = billingProfileSystemId;
            EnabledAzurePlans = enabledAzurePlans;
        }

        /// <summary> The ID of the invoice section. </summary>
        public string InvoiceSectionId { get; }
        /// <summary> The name of the invoice section. </summary>
        public string InvoiceSectionDisplayName { get; }
        /// <summary> The system generated unique identifier for an invoice section. </summary>
        public string InvoiceSectionSystemId { get; }
        /// <summary> The ID of the billing profile for the invoice section. </summary>
        public string BillingProfileId { get; }
        /// <summary> The name of the billing profile for the invoice section. </summary>
        public string BillingProfileDisplayName { get; }
        /// <summary> The status of the billing profile. </summary>
        public BillingProfileStatus? BillingProfileStatus { get; }
        /// <summary> Reason for the specified billing profile status. </summary>
        public StatusReasonCodeForBillingProfile? BillingProfileStatusReasonCode { get; }
        /// <summary> The billing profile spending limit. </summary>
        public SpendingLimitForBillingProfile? BillingProfileSpendingLimit { get; }
        /// <summary> The system generated unique identifier for a billing profile. </summary>
        public string BillingProfileSystemId { get; }
        /// <summary> Enabled azure plans for the associated billing profile. </summary>
        public IReadOnlyList<AzurePlan> EnabledAzurePlans { get; }
    }
}