// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Communication.Router
{
    /// <summary>
    /// The options for communication <see cref="RouterClient"/>.
    /// </summary>
    public class RouterClientOptions : ClientOptions
    {
        /// <summary>
        /// The latest version of the Router service.
        /// </summary>
        private const ServiceVersion LatestVersion = ServiceVersion.V2021_04_07;

        internal string ApiVersion { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterClientOptions"/>.
        /// </summary>
        public RouterClientOptions(ServiceVersion version = LatestVersion)
        {
            ApiVersion = version switch
            {
                ServiceVersion.V2021_04_07 => "2021-04-07",
                _ => throw new ArgumentOutOfRangeException(nameof(version)),
            };
        }

        /// <summary>
        /// The Router service version.
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// The V1 of the Router service.
            /// </summary>
#pragma warning disable CA1707 // Identifiers should not contain underscores
            V2021_04_07 = 1
#pragma warning restore CA1707 // Identifiers should not contain underscores
        }
    }
}
