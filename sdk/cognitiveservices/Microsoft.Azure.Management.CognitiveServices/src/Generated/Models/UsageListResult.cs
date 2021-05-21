// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response to a list usage request.
    /// </summary>
    public partial class UsageListResult
    {
        /// <summary>
        /// Initializes a new instance of the UsageListResult class.
        /// </summary>
        public UsageListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageListResult class.
        /// </summary>
        /// <param name="value">The list of usages for Cognitive Service
        /// account.</param>
        public UsageListResult(IList<Usage> value = default(IList<Usage>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of usages for Cognitive Service account.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Usage> Value { get; set; }

    }
}