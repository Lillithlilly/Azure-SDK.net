// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// MicrosoftSecurityIncidentCreation rule common property bag.
    /// </summary>
    public partial class MicrosoftSecurityIncidentCreationAlertRuleCommonProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftSecurityIncidentCreationAlertRuleCommonProperties class.
        /// </summary>
        public MicrosoftSecurityIncidentCreationAlertRuleCommonProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftSecurityIncidentCreationAlertRuleCommonProperties class.
        /// </summary>
        /// <param name="productFilter">The alerts' productName on which the
        /// cases will be generated. Possible values include: 'Microsoft Cloud
        /// App Security', 'Azure Security Center', 'Azure Advanced Threat
        /// Protection', 'Azure Active Directory Identity Protection', 'Azure
        /// Security Center for IoT', 'Office 365 Advanced Threat Protection',
        /// 'Microsoft Defender Advanced Threat Protection'</param>
        /// <param name="displayNamesFilter">the alerts' displayNames on which
        /// the cases will be generated</param>
        /// <param name="displayNamesExcludeFilter">the alerts' displayNames on
        /// which the cases will not be generated</param>
        /// <param name="severitiesFilter">the alerts' severities on which the
        /// cases will be generated</param>
        public MicrosoftSecurityIncidentCreationAlertRuleCommonProperties(string productFilter, IList<string> displayNamesFilter = default(IList<string>), IList<string> displayNamesExcludeFilter = default(IList<string>), IList<string> severitiesFilter = default(IList<string>))
        {
            DisplayNamesFilter = displayNamesFilter;
            DisplayNamesExcludeFilter = displayNamesExcludeFilter;
            ProductFilter = productFilter;
            SeveritiesFilter = severitiesFilter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the alerts' displayNames on which the cases will be
        /// generated
        /// </summary>
        [JsonProperty(PropertyName = "displayNamesFilter")]
        public IList<string> DisplayNamesFilter { get; set; }

        /// <summary>
        /// Gets or sets the alerts' displayNames on which the cases will not
        /// be generated
        /// </summary>
        [JsonProperty(PropertyName = "displayNamesExcludeFilter")]
        public IList<string> DisplayNamesExcludeFilter { get; set; }

        /// <summary>
        /// Gets or sets the alerts' productName on which the cases will be
        /// generated. Possible values include: 'Microsoft Cloud App Security',
        /// 'Azure Security Center', 'Azure Advanced Threat Protection', 'Azure
        /// Active Directory Identity Protection', 'Azure Security Center for
        /// IoT', 'Office 365 Advanced Threat Protection', 'Microsoft Defender
        /// Advanced Threat Protection'
        /// </summary>
        [JsonProperty(PropertyName = "productFilter")]
        public string ProductFilter { get; set; }

        /// <summary>
        /// Gets or sets the alerts' severities on which the cases will be
        /// generated
        /// </summary>
        [JsonProperty(PropertyName = "severitiesFilter")]
        public IList<string> SeveritiesFilter { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProductFilter == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProductFilter");
            }
        }
    }
}
