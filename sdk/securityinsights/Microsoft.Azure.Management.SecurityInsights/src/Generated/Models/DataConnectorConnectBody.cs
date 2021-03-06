// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents Codeless API Polling data connector.
    /// </summary>
    public partial class DataConnectorConnectBody
    {
        /// <summary>
        /// Initializes a new instance of the DataConnectorConnectBody class.
        /// </summary>
        public DataConnectorConnectBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataConnectorConnectBody class.
        /// </summary>
        /// <param name="kind">The authentication kind used to poll the data.
        /// Possible values include: 'Basic', 'OAuth2', 'APIKey'</param>
        /// <param name="apiKey">The API key of the audit server.</param>
        /// <param name="clientSecret">The client secret of the OAuth 2.0
        /// application.</param>
        /// <param name="clientId">The client id of the OAuth 2.0
        /// application.</param>
        /// <param name="authorizationCode">The authorization code used in
        /// OAuth 2.0 code flow to issue a token.</param>
        /// <param name="userName">The user name in the audit log
        /// server.</param>
        /// <param name="password">The user password in the audit log
        /// server.</param>
        public DataConnectorConnectBody(string kind = default(string), string apiKey = default(string), string clientSecret = default(string), string clientId = default(string), string authorizationCode = default(string), string userName = default(string), string password = default(string), IList<object> requestConfigUserInputValues = default(IList<object>))
        {
            Kind = kind;
            ApiKey = apiKey;
            ClientSecret = clientSecret;
            ClientId = clientId;
            AuthorizationCode = authorizationCode;
            UserName = userName;
            Password = password;
            RequestConfigUserInputValues = requestConfigUserInputValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the authentication kind used to poll the data.
        /// Possible values include: 'Basic', 'OAuth2', 'APIKey'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets the API key of the audit server.
        /// </summary>
        [JsonProperty(PropertyName = "apiKey")]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the client secret of the OAuth 2.0 application.
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the client id of the OAuth 2.0 application.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the authorization code used in OAuth 2.0 code flow to
        /// issue a token.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationCode")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Gets or sets the user name in the audit log server.
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user password in the audit log server.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestConfigUserInputValues")]
        public IList<object> RequestConfigUserInputValues { get; set; }

    }
}
