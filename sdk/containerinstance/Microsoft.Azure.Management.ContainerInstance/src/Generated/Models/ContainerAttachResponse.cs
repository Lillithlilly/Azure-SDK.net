// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The information for the output stream from container attach.
    /// </summary>
    public partial class ContainerAttachResponse
    {
        /// <summary>
        /// Initializes a new instance of the ContainerAttachResponse class.
        /// </summary>
        public ContainerAttachResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerAttachResponse class.
        /// </summary>
        /// <param name="webSocketUri">The uri for the output stream from the
        /// attach.</param>
        /// <param name="password">The password to the output stream from the
        /// attach. Send as an Authorization header value when connecting to
        /// the websocketUri.</param>
        public ContainerAttachResponse(string webSocketUri = default(string), string password = default(string))
        {
            WebSocketUri = webSocketUri;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the uri for the output stream from the attach.
        /// </summary>
        [JsonProperty(PropertyName = "webSocketUri")]
        public string WebSocketUri { get; set; }

        /// <summary>
        /// Gets or sets the password to the output stream from the attach.
        /// Send as an Authorization header value when connecting to the
        /// websocketUri.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}
