// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Gets the request plans with indication on each plan whether is approved
    /// by the admin, has pending request or not requested yet
    /// </summary>
    public partial class QueryRequestApproval
    {
        /// <summary>
        /// Initializes a new instance of the QueryRequestApproval class.
        /// </summary>
        public QueryRequestApproval()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryRequestApproval class.
        /// </summary>
        /// <param name="uniqueOfferId">Gets or sets unique offer id.</param>
        /// <param name="plansDetails">Gets or sets the plans details</param>
        /// <param name="etag">Gets or sets e-tag field </param>
        /// <param name="messageCode">Gets or sets the notification message
        /// id</param>
        public QueryRequestApproval(string uniqueOfferId = default(string), IDictionary<string, PlanDetails> plansDetails = default(IDictionary<string, PlanDetails>), string etag = default(string), long? messageCode = default(long?))
        {
            UniqueOfferId = uniqueOfferId;
            PlansDetails = plansDetails;
            Etag = etag;
            MessageCode = messageCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique offer id.
        /// </summary>
        [JsonProperty(PropertyName = "uniqueOfferId")]
        public string UniqueOfferId { get; set; }

        /// <summary>
        /// Gets or sets the plans details
        /// </summary>
        [JsonProperty(PropertyName = "plansDetails")]
        public IDictionary<string, PlanDetails> PlansDetails { get; set; }

        /// <summary>
        /// Gets or sets e-tag field
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the notification message id
        /// </summary>
        [JsonProperty(PropertyName = "messageCode")]
        public long? MessageCode { get; set; }

    }
}
