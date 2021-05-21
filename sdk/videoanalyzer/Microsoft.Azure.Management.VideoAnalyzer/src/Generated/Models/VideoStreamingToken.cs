// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Video streaming token grants access to the video streaming URLs which
    /// can be used by an compatible HLS or DASH player.
    /// </summary>
    public partial class VideoStreamingToken
    {
        /// <summary>
        /// Initializes a new instance of the VideoStreamingToken class.
        /// </summary>
        public VideoStreamingToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoStreamingToken class.
        /// </summary>
        /// <param name="expirationDate">The streaming token expiration date in
        /// ISO8601 format (eg. 2021-01-01T00:00:00Z).</param>
        /// <param name="token">The streaming token value to be added to the
        /// video streaming URL as the value for a "token" query string
        /// parameter. The token is specific to a single video.</param>
        public VideoStreamingToken(System.DateTime expirationDate = default(System.DateTime), string token = default(string))
        {
            ExpirationDate = expirationDate;
            Token = token;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the streaming token expiration date in ISO8601 format (eg.
        /// 2021-01-01T00:00:00Z).
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public System.DateTime ExpirationDate { get; private set; }

        /// <summary>
        /// Gets the streaming token value to be added to the video streaming
        /// URL as the value for a "token" query string parameter. The token is
        /// specific to a single video.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; private set; }

    }
}