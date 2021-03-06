// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The LegalHold property of a blob container.
    /// </summary>
    public partial class LegalHoldProperties
    {
        /// <summary>
        /// Initializes a new instance of the LegalHoldProperties class.
        /// </summary>
        public LegalHoldProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LegalHoldProperties class.
        /// </summary>
        /// <param name="hasLegalHold">The hasLegalHold public property is set
        /// to true by SRP if there are at least one existing tag. The
        /// hasLegalHold public property is set to false by SRP if all existing
        /// legal hold tags are cleared out. There can be a maximum of 1000
        /// blob containers with hasLegalHold=true for a given account.</param>
        /// <param name="tags">The list of LegalHold tags of a blob
        /// container.</param>
        /// <param name="protectedAppendWritesHistory">Protected append blob
        /// writes history.</param>
        public LegalHoldProperties(bool? hasLegalHold = default(bool?), IList<TagProperty> tags = default(IList<TagProperty>), ProtectedAppendWritesHistory protectedAppendWritesHistory = default(ProtectedAppendWritesHistory))
        {
            HasLegalHold = hasLegalHold;
            Tags = tags;
            ProtectedAppendWritesHistory = protectedAppendWritesHistory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the hasLegalHold public property is set to true by SRP if
        /// there are at least one existing tag. The hasLegalHold public
        /// property is set to false by SRP if all existing legal hold tags are
        /// cleared out. There can be a maximum of 1000 blob containers with
        /// hasLegalHold=true for a given account.
        /// </summary>
        [JsonProperty(PropertyName = "hasLegalHold")]
        public bool? HasLegalHold { get; private set; }

        /// <summary>
        /// Gets or sets the list of LegalHold tags of a blob container.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<TagProperty> Tags { get; set; }

        /// <summary>
        /// Gets or sets protected append blob writes history.
        /// </summary>
        [JsonProperty(PropertyName = "protectedAppendWritesHistory")]
        public ProtectedAppendWritesHistory ProtectedAppendWritesHistory { get; set; }

    }
}
