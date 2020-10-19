// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Learn.AppConfig
{
    /// <summary>
    /// ConfigurationSetting
    /// </summary>
    [CodeGenModel("KeyValue")]
    public partial class ConfigurationSetting
    {
        /// <summary>
        /// Etag
        /// </summary>
        [CodeGenMember("Etag")]
        public ETag ETag { get; }
    }
}
