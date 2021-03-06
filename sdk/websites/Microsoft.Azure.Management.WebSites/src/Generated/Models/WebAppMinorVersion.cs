// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Web App stack minor version.
    /// </summary>
    public partial class WebAppMinorVersion
    {
        /// <summary>
        /// Initializes a new instance of the WebAppMinorVersion class.
        /// </summary>
        public WebAppMinorVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebAppMinorVersion class.
        /// </summary>
        /// <param name="displayText">Web App stack minor version (display
        /// only).</param>
        /// <param name="value">Web App stack major version name.</param>
        /// <param name="stackSettings">Settings associated with the minor
        /// version.</param>
        public WebAppMinorVersion(string displayText = default(string), string value = default(string), WebAppRuntimes stackSettings = default(WebAppRuntimes))
        {
            DisplayText = displayText;
            Value = value;
            StackSettings = stackSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets web App stack minor version (display only).
        /// </summary>
        [JsonProperty(PropertyName = "displayText")]
        public string DisplayText { get; private set; }

        /// <summary>
        /// Gets web App stack major version name.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        /// <summary>
        /// Gets settings associated with the minor version.
        /// </summary>
        [JsonProperty(PropertyName = "stackSettings")]
        public WebAppRuntimes StackSettings { get; private set; }

    }
}
