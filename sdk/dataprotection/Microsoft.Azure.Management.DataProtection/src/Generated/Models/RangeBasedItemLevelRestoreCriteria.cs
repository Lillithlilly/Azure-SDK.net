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
    using System.Linq;

    /// <summary>
    /// Item Level target info for restore operation
    /// </summary>
    [Newtonsoft.Json.JsonObject("RangeBasedItemLevelRestoreCriteria")]
    public partial class RangeBasedItemLevelRestoreCriteria : ItemLevelRestoreCriteria
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RangeBasedItemLevelRestoreCriteria class.
        /// </summary>
        public RangeBasedItemLevelRestoreCriteria()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RangeBasedItemLevelRestoreCriteria class.
        /// </summary>
        /// <param name="minMatchingValue">minimum value for range prefix
        /// match</param>
        /// <param name="maxMatchingValue">maximum value for range prefix
        /// match</param>
        public RangeBasedItemLevelRestoreCriteria(string minMatchingValue = default(string), string maxMatchingValue = default(string))
        {
            MinMatchingValue = minMatchingValue;
            MaxMatchingValue = maxMatchingValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minimum value for range prefix match
        /// </summary>
        [JsonProperty(PropertyName = "minMatchingValue")]
        public string MinMatchingValue { get; set; }

        /// <summary>
        /// Gets or sets maximum value for range prefix match
        /// </summary>
        [JsonProperty(PropertyName = "maxMatchingValue")]
        public string MaxMatchingValue { get; set; }

    }
}