// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> A secure URL that can be used to download a an entity until the URL expires. </summary>
    public partial class DownloadUrl
    {
        /// <summary> Initializes a new instance of DownloadUrl. </summary>
        internal DownloadUrl()
        {
        }

        /// <summary> Initializes a new instance of DownloadUrl. </summary>
        /// <param name="expiryTime"> The time in UTC when the download URL will expire. </param>
        /// <param name="url"> The URL to the PDF file. </param>
        internal DownloadUrl(DateTimeOffset? expiryTime, string url)
        {
            ExpiryTime = expiryTime;
            Url = url;
        }

        /// <summary> The time in UTC when the download URL will expire. </summary>
        public DateTimeOffset? ExpiryTime { get; }
        /// <summary> The URL to the PDF file. </summary>
        public string Url { get; }
    }
}