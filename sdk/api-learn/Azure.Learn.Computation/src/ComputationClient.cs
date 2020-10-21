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
        public ComputationClient(string connectionString)
        {
        }

        /// <summary>
        /// client
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="options"></param>
        public ComputationClient(string connectionString, ComputationClientOptions options)
        {
        }

        /// <summary>
        /// client
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="credential"></param>
        /// <param name="options"></param>
        public ComputationClient(Uri uri, TokenCredential credential, ComputationClientOptions options = default)
        {
        }

        //public virtual Task<Response<ConfigurationSetting>> AddAsync(ConfigurationSetting setting, CancellationToken cancellationToken = default);
        //public virtual Response<ConfigurationSetting> Add(ConfigurationSetting setting, CancellationToken cancellationToken = default);

        //public virtual Task<Response<ConfigurationSetting>> SetAsync(ConfigurationSetting setting, CancellationToken cancellationToken = default);
        //public virtual Response<ConfigurationSetting> Set(ConfigurationSetting setting, CancellationToken cancellationToken = default);

        //public virtual Task<Response<ConfigurationSetting>> GetAsync(string key, SettingFilter filter = default, CancellationToken cancellationToken = default);
        //public virtual Response<ConfigurationSetting> Get(string key, SettingFilter filter = default, CancellationToken cancellationToken = default);

        //public virtual Task<Response<ConfigurationSetting>> DeleteAsync(string key, SettingFilter filter = default, CancellationToken cancellationToken = default);
        //public virtual Response<ConfigurationSetting> Delete(string key, SettingFilter filter = default, CancellationToken cancellationToken = default);
    }
}
