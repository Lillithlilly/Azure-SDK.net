// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List Restore Ranges Response
    /// </summary>
    public partial class AzureBackupFindRestorableTimeRangesResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureBackupFindRestorableTimeRangesResponse class.
        /// </summary>
        public AzureBackupFindRestorableTimeRangesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureBackupFindRestorableTimeRangesResponse class.
        /// </summary>
        /// <param name="restorableTimeRanges">Returns the Restore Ranges
        /// available on the Backup Instance.</param>
        public AzureBackupFindRestorableTimeRangesResponse(IList<RestorableTimeRange> restorableTimeRanges = default(IList<RestorableTimeRange>), string objectType = default(string))
        {
            RestorableTimeRanges = restorableTimeRanges;
            ObjectType = objectType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets returns the Restore Ranges available on the Backup
        /// Instance.
        /// </summary>
        [JsonProperty(PropertyName = "restorableTimeRanges")]
        public IList<RestorableTimeRange> RestorableTimeRanges { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

    }
}