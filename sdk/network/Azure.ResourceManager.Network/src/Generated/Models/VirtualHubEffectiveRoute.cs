// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The effective route configured on the virtual hub or specified resource. </summary>
    internal partial class VirtualHubEffectiveRoute
    {
        /// <summary> Initializes a new instance of VirtualHubEffectiveRoute. </summary>
        internal VirtualHubEffectiveRoute()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
            NextHops = new ChangeTrackingList<string>();
        }

        /// <summary> The list of address prefixes. </summary>
        public IReadOnlyList<string> AddressPrefixes { get; }
        /// <summary> The list of next hops. </summary>
        public IReadOnlyList<string> NextHops { get; }
        /// <summary> The type of the next hop. </summary>
        public string NextHopType { get; }
        /// <summary> The ASPath of this route. </summary>
        public string AsPath { get; }
        /// <summary> The origin of this route. </summary>
        public string RouteOrigin { get; }
    }
}
