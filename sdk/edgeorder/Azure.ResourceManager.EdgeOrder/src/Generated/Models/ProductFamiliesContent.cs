// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> The filters for showing the product families. </summary>
    public partial class ProductFamiliesContent
    {
        /// <summary> Initializes a new instance of ProductFamiliesContent. </summary>
        /// <param name="filterableProperties"> Dictionary of filterable properties on product family. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filterableProperties"/> is null. </exception>
        public ProductFamiliesContent(IDictionary<string, IList<FilterableProperty>> filterableProperties)
        {
            if (filterableProperties == null)
            {
                throw new ArgumentNullException(nameof(filterableProperties));
            }

            FilterableProperties = filterableProperties;
        }

        /// <summary> Dictionary of filterable properties on product family. </summary>
        public IDictionary<string, IList<FilterableProperty>> FilterableProperties { get; }
        /// <summary> Customer subscription properties. Clients can display available products to unregistered customers by explicitly passing subscription details. </summary>
        public CustomerSubscriptionDetails CustomerSubscriptionDetails { get; set; }
    }
}
