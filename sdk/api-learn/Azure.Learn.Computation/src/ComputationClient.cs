// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Learn.Computation
{
    /// <summary>
    /// client
    /// </summary>
    public class ComputationClient
    {
        /// <summary> Initializes a new instance of ComputationClient for mocking. </summary>
        protected ComputationClient()
        {
        }

        /// <summary>
        /// client
        /// </summary>
        /// <param name="connectionString"></param>
        public ComputationClient(string connectionString) : this(connectionString, new ComputationClientOptions())
        {
            connectionString = null;
        }

        /// <summary>
        /// client
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="options"></param>
        public ComputationClient(string connectionString, ComputationClientOptions options)
        {
            connectionString = null;
            options = null;
        }

        /// <summary>
        /// client
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="credential"></param>
        /// <param name="options"></param>
        public ComputationClient(Uri endpoint, TokenCredential credential, ComputationClientOptions options = default)
        {
            endpoint = null;
            credential = null;
            options = new ComputationClientOptions();
        }
    }
}
