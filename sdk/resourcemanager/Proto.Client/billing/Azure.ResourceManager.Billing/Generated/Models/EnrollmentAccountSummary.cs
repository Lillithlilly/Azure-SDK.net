// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> An enrollment account resource. </summary>
    public partial class EnrollmentAccountSummary : Resource
    {
        /// <summary> Initializes a new instance of EnrollmentAccountSummary. </summary>
        public EnrollmentAccountSummary()
        {
        }

        /// <summary> Initializes a new instance of EnrollmentAccountSummary. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="principalName"> The account owner&apos;s principal name. </param>
        internal EnrollmentAccountSummary(string id, string name, string type, string principalName) : base(id, name, type)
        {
            PrincipalName = principalName;
        }

        /// <summary> The account owner&apos;s principal name. </summary>
        public string PrincipalName { get; }
    }
}