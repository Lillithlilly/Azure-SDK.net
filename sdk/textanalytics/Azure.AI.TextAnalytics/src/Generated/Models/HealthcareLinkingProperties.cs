// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareLinkingProperties. </summary>
    internal partial class HealthcareLinkingProperties
    {
        /// <summary> Initializes a new instance of HealthcareLinkingProperties. </summary>
        internal HealthcareLinkingProperties()
        {
            Links = new ChangeTrackingList<EntityDataSource>();
        }

        /// <summary> Initializes a new instance of HealthcareLinkingProperties. </summary>
        /// <param name="assertion"> . </param>
        /// <param name="name"> Preferred name for the entity. Example: &apos;histologically&apos; would have a &apos;name&apos; of &apos;histologic&apos;. </param>
        /// <param name="links"> Entity references in known data sources. </param>
        internal HealthcareLinkingProperties(HealthcareEntityAssertion assertion, string name, IReadOnlyList<EntityDataSource> links)
        {
            Assertion = assertion;
            Name = name;
            Links = links;
        }

        public HealthcareEntityAssertion Assertion { get; }
        /// <summary> Preferred name for the entity. Example: &apos;histologically&apos; would have a &apos;name&apos; of &apos;histologic&apos;. </summary>
        public string Name { get; }
        /// <summary> Entity references in known data sources. </summary>
        public IReadOnlyList<EntityDataSource> Links { get; }
    }
}