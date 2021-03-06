// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Collection of metric definitions. </summary>
    internal partial class ResourceMetricDefinitionCollection
    {
        /// <summary> Initializes a new instance of ResourceMetricDefinitionCollection. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ResourceMetricDefinitionCollection(IEnumerable<ResourceMetricDefinition> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ResourceMetricDefinitionCollection. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal ResourceMetricDefinitionCollection(IReadOnlyList<ResourceMetricDefinition> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<ResourceMetricDefinition> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
