// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines a Spatial Analysis person line crossing operation eventing configuration. </summary>
    public partial class SpatialAnalysisPersonLineCrossingEvent : SpatialAnalysisOperationEventBase
    {
        /// <summary> Initializes a new instance of SpatialAnalysisPersonLineCrossingEvent. </summary>
        public SpatialAnalysisPersonLineCrossingEvent()
        {
        }

        /// <summary> Initializes a new instance of SpatialAnalysisPersonLineCrossingEvent. </summary>
        /// <param name="threshold"> The event threshold. </param>
        /// <param name="focus"> The operation focus type. </param>
        internal SpatialAnalysisPersonLineCrossingEvent(string threshold, SpatialAnalysisOperationFocus? focus) : base(threshold, focus)
        {
        }
    }
}