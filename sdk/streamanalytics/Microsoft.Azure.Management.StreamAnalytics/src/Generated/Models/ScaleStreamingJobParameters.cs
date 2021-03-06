// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Scale Streaming Job operation.
    /// </summary>
    public partial class ScaleStreamingJobParameters
    {
        /// <summary>
        /// Initializes a new instance of the ScaleStreamingJobParameters
        /// class.
        /// </summary>
        public ScaleStreamingJobParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScaleStreamingJobParameters
        /// class.
        /// </summary>
        /// <param name="streamingUnits">Specifies the number of streaming
        /// units that the streaming job will scale to.</param>
        public ScaleStreamingJobParameters(int? streamingUnits = default(int?))
        {
            StreamingUnits = streamingUnits;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the number of streaming units that the
        /// streaming job will scale to.
        /// </summary>
        [JsonProperty(PropertyName = "streamingUnits")]
        public int? StreamingUnits { get; set; }

    }
}
