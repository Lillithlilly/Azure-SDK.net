// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response from the List namespace operation. </summary>
    public partial class NetworkRuleSetIPRules
    {
        /// <summary> Initializes a new instance of NetworkRuleSetIPRules. </summary>
        public NetworkRuleSetIPRules()
        {
        }

        /// <summary> Initializes a new instance of NetworkRuleSetIPRules. </summary>
        /// <param name="ipMask"> IP Mask. </param>
        /// <param name="action"> The IP Filter Action. </param>
        internal NetworkRuleSetIPRules(string ipMask, NetworkRuleIPAction? action)
        {
            IPMask = ipMask;
            Action = action;
        }

        /// <summary> IP Mask. </summary>
        public string IPMask { get; set; }
        /// <summary> The IP Filter Action. </summary>
        public NetworkRuleIPAction? Action { get; set; }
    }
}
