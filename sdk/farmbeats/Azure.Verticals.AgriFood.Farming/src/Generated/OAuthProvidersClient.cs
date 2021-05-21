// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The OAuthProviders service client. </summary>
    public partial class OAuthProvidersClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of OAuthProvidersClient for mocking. </summary>
        protected OAuthProvidersClient()
        {
        }

        /// <summary> Initializes a new instance of OAuthProvidersClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public OAuthProvidersClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new FarmBeatsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { authPolicy, new LowLevelCallbackPolicy() });
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Returns a paginated list of oauthProvider resources. </summary>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// 
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> ListAsync(IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateListRequest(ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("OAuthProvidersClient.List");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a paginated list of oauthProvider resources. </summary>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// 
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response List(IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateListRequest(ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("OAuthProvidersClient.List");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="List"/> and <see cref="ListAsync"/> operations. </summary>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// 
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateListRequest(IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/oauth/providers", false);
            if (ids != null)
            {
                uri.AppendQueryDelimited("ids", ids, ",", true);
            }
            if (names != null)
            {
                uri.AppendQueryDelimited("names", names, ",", true);
            }
            if (propertyFilters != null)
            {
                uri.AppendQueryDelimited("propertyFilters", propertyFilters, ",", true);
            }
            if (statuses != null)
            {
                uri.AppendQueryDelimited("statuses", statuses, ",", true);
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a specified oauthProvider resource. </summary>
        /// <param name="oauthProviderId"> ID of the oauthProvider resource. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetAsync(string oauthProviderId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetRequest(oauthProviderId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("OAuthProvidersClient.Get");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a specified oauthProvider resource. </summary>
        /// <param name="oauthProviderId"> ID of the oauthProvider resource. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Get(string oauthProviderId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetRequest(oauthProviderId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("OAuthProvidersClient.Get");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Get"/> and <see cref="GetAsync"/> operations. </summary>
        /// <param name="oauthProviderId"> ID of the oauthProvider resource. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateGetRequest(string oauthProviderId, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/oauth/providers/", false);
            uri.AppendPath(oauthProviderId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Creates or updates an oauthProvider resource. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>appId</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> OAuth App ID for given OAuth Provider. </term>
        ///   </item>
        ///   <item>
        ///     <term>appSecret</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// OAuth App secret for given Provider.
        /// 
        /// Note: Won&apos;t be sent in response.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>apiKey</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// OAuth Api key for given Provider.
        /// 
        /// Note: currently Applicable to Climate provider. Won&apos;t be sent in response.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>isProductionApp</term>
        ///     <term>boolean</term>
        ///     <term></term>
        ///     <term>
        /// An optional flag to determine if the App is ready to be used for Production scenarios in the provider side or not. (Default value: false)
        /// 
        /// Note: Currently applicable for JohnDeere.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique OAuth provider ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>eTag</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The ETag value to implement optimistic concurrency. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>modifiedDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Name to identify resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>description</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Textual description of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>properties</term>
        ///     <term>Dictionary&lt;string, AnyObject&gt;</term>
        ///     <term></term>
        ///     <term>
        /// A collection of key value pairs that belongs to the resource.
        /// 
        /// Each pair must not have a key greater than 50 characters
        /// 
        /// and must not have a value greater than 150 characters.
        /// 
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="oauthProviderId"> ID of oauthProvider resource. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateAsync(string oauthProviderId, RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateCreateOrUpdateRequest(oauthProviderId, requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("OAuthProvidersClient.CreateOrUpdate");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 201:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an oauthProvider resource. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>appId</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> OAuth App ID for given OAuth Provider. </term>
        ///   </item>
        ///   <item>
        ///     <term>appSecret</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// OAuth App secret for given Provider.
        /// 
        /// Note: Won&apos;t be sent in response.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>apiKey</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// OAuth Api key for given Provider.
        /// 
        /// Note: currently Applicable to Climate provider. Won&apos;t be sent in response.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>isProductionApp</term>
        ///     <term>boolean</term>
        ///     <term></term>
        ///     <term>
        /// An optional flag to determine if the App is ready to be used for Production scenarios in the provider side or not. (Default value: false)
        /// 
        /// Note: Currently applicable for JohnDeere.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique OAuth provider ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>eTag</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The ETag value to implement optimistic concurrency. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>modifiedDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Name to identify resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>description</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Textual description of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>properties</term>
        ///     <term>Dictionary&lt;string, AnyObject&gt;</term>
        ///     <term></term>
        ///     <term>
        /// A collection of key value pairs that belongs to the resource.
        /// 
        /// Each pair must not have a key greater than 50 characters
        /// 
        /// and must not have a value greater than 150 characters.
        /// 
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="oauthProviderId"> ID of oauthProvider resource. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdate(string oauthProviderId, RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateCreateOrUpdateRequest(oauthProviderId, requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("OAuthProvidersClient.CreateOrUpdate");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 201:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="CreateOrUpdate"/> and <see cref="CreateOrUpdateAsync"/> operations. </summary>
        /// <param name="oauthProviderId"> ID of oauthProvider resource. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateCreateOrUpdateRequest(string oauthProviderId, RequestContent requestBody, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/oauth/providers/", false);
            uri.AppendPath(oauthProviderId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = requestBody;
            return message;
        }

        /// <summary> Deletes an specified oauthProvider resource. </summary>
        /// <param name="oauthProviderId"> ID of oauthProvider. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteAsync(string oauthProviderId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateDeleteRequest(oauthProviderId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("OAuthProvidersClient.Delete");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 204:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an specified oauthProvider resource. </summary>
        /// <param name="oauthProviderId"> ID of oauthProvider. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Delete(string oauthProviderId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateDeleteRequest(oauthProviderId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("OAuthProvidersClient.Delete");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 204:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Delete"/> and <see cref="DeleteAsync"/> operations. </summary>
        /// <param name="oauthProviderId"> ID of oauthProvider. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateDeleteRequest(string oauthProviderId, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/oauth/providers/", false);
            uri.AppendPath(oauthProviderId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}