// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Allow to exclude some variable satisfy the condition for the WAF check.
    /// </summary>
    public partial class OwaspCrsExclusionEntry
    {
        /// <summary>
        /// Initializes a new instance of the OwaspCrsExclusionEntry class.
        /// </summary>
        public OwaspCrsExclusionEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OwaspCrsExclusionEntry class.
        /// </summary>
        /// <param name="matchVariable">The variable to be excluded. Possible
        /// values include: 'RequestHeaderNames', 'RequestCookieNames',
        /// 'RequestArgNames', 'RequestHeaderKeys', 'RequestHeaderValues',
        /// 'RequestCookieKeys', 'RequestCookieValues', 'RequestArgKeys',
        /// 'RequestArgValues'</param>
        /// <param name="selectorMatchOperator">When matchVariable is a
        /// collection, operate on the selector to specify which elements in
        /// the collection this exclusion applies to. Possible values include:
        /// 'Equals', 'Contains', 'StartsWith', 'EndsWith', 'EqualsAny'</param>
        /// <param name="selector">When matchVariable is a collection, operator
        /// used to specify which elements in the collection this exclusion
        /// applies to.</param>
        /// <param name="exclusionManagedRuleSets">The managed rule sets that
        /// are associated with the exclusion.</param>
        public OwaspCrsExclusionEntry(string matchVariable, string selectorMatchOperator, string selector, IList<ExclusionManagedRuleSet> exclusionManagedRuleSets = default(IList<ExclusionManagedRuleSet>))
        {
            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
            ExclusionManagedRuleSets = exclusionManagedRuleSets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the variable to be excluded. Possible values include:
        /// 'RequestHeaderNames', 'RequestCookieNames', 'RequestArgNames',
        /// 'RequestHeaderKeys', 'RequestHeaderValues', 'RequestCookieKeys',
        /// 'RequestCookieValues', 'RequestArgKeys', 'RequestArgValues'
        /// </summary>
        [JsonProperty(PropertyName = "matchVariable")]
        public string MatchVariable { get; set; }

        /// <summary>
        /// Gets or sets when matchVariable is a collection, operate on the
        /// selector to specify which elements in the collection this exclusion
        /// applies to. Possible values include: 'Equals', 'Contains',
        /// 'StartsWith', 'EndsWith', 'EqualsAny'
        /// </summary>
        [JsonProperty(PropertyName = "selectorMatchOperator")]
        public string SelectorMatchOperator { get; set; }

        /// <summary>
        /// Gets or sets when matchVariable is a collection, operator used to
        /// specify which elements in the collection this exclusion applies to.
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public string Selector { get; set; }

        /// <summary>
        /// Gets or sets the managed rule sets that are associated with the
        /// exclusion.
        /// </summary>
        [JsonProperty(PropertyName = "exclusionManagedRuleSets")]
        public IList<ExclusionManagedRuleSet> ExclusionManagedRuleSets { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MatchVariable == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MatchVariable");
            }
            if (SelectorMatchOperator == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SelectorMatchOperator");
            }
            if (Selector == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Selector");
            }
            if (ExclusionManagedRuleSets != null)
            {
                foreach (var element in ExclusionManagedRuleSets)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
