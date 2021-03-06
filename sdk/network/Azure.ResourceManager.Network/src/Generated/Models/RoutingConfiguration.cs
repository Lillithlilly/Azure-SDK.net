// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Routing Configuration indicating the associated and propagated route tables for this connection. </summary>
    public partial class RoutingConfiguration
    {
        /// <summary> Initializes a new instance of RoutingConfiguration. </summary>
        public RoutingConfiguration()
        {
        }

        /// <summary> Initializes a new instance of RoutingConfiguration. </summary>
        /// <param name="associatedRouteTable"> The resource id RouteTable associated with this RoutingConfiguration. </param>
        /// <param name="propagatedRouteTables"> The list of RouteTables to advertise the routes to. </param>
        /// <param name="vnetRoutes"> List of routes that control routing from VirtualHub into a virtual network connection. </param>
        internal RoutingConfiguration(WritableSubResource associatedRouteTable, PropagatedRouteTable propagatedRouteTables, VnetRoute vnetRoutes)
        {
            AssociatedRouteTable = associatedRouteTable;
            PropagatedRouteTables = propagatedRouteTables;
            VnetRoutes = vnetRoutes;
        }

        /// <summary> The resource id RouteTable associated with this RoutingConfiguration. </summary>
        internal WritableSubResource AssociatedRouteTable { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AssociatedRouteTableId
        {
            get => AssociatedRouteTable is null ? default : AssociatedRouteTable.Id;
            set
            {
                if (AssociatedRouteTable is null)
                    AssociatedRouteTable = new WritableSubResource();
                AssociatedRouteTable.Id = value;
            }
        }

        /// <summary> The list of RouteTables to advertise the routes to. </summary>
        public PropagatedRouteTable PropagatedRouteTables { get; set; }
        /// <summary> List of routes that control routing from VirtualHub into a virtual network connection. </summary>
        internal VnetRoute VnetRoutes { get; set; }
        /// <summary> List of all Static Routes. </summary>
        public IList<StaticRoute> StaticRoutes
        {
            get
            {
                if (VnetRoutes is null)
                    VnetRoutes = new VnetRoute();
                return VnetRoutes.StaticRoutes;
            }
        }
    }
}
