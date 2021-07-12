// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Pipeline;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Communication.Router.Models;

namespace Azure.Communication.Router
{
    /// <summary>
    /// The Azure Communication Services Router client.
    /// </summary>
    public class RouterClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        internal RouterRestClient RestClient { get; }

        #region public constructors - all arguments need null check

        /// <summary> Initializes a new instance of <see cref="RouterClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        public RouterClient(string connectionString)
            : this(
                ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString))),
                new RouterClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouterClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public RouterClient(string connectionString, RouterClientOptions options)
            : this(
                ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString))),
                options ?? new RouterClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouterClient"/>.</summary>
        /// <param name="endpoint">The URI of the Azure Communication Services resource.</param>
        /// <param name="keyCredential">The <see cref="AzureKeyCredential"/> used to authenticate requests.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public RouterClient(Uri endpoint, AzureKeyCredential keyCredential, RouterClientOptions options = default)
            : this(
                Argument.CheckNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                Argument.CheckNotNull(keyCredential, nameof(keyCredential)),
                options ?? new RouterClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouterClient"/>.</summary>
        /// <param name="endpoint">The URI of the Azure Communication Services resource.</param>
        /// <param name="tokenCredential">The TokenCredential used to authenticate requests, such as DefaultAzureCredential.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public RouterClient(Uri endpoint, TokenCredential tokenCredential, RouterClientOptions options = default)
            : this(
                Argument.CheckNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                Argument.CheckNotNull(tokenCredential, nameof(tokenCredential)),
                options ?? new RouterClientOptions())
        {
        }

        #endregion

        #region private constructors

        private RouterClient(ConnectionString connectionString, RouterClientOptions options)
            : this(connectionString.GetRequired("endpoint"), options.BuildHttpPipeline(connectionString), options)
        {
        }

        private RouterClient(string endpoint, TokenCredential tokenCredential, RouterClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(tokenCredential), options)
        {
        }

        private RouterClient(string endpoint, AzureKeyCredential keyCredential, RouterClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(keyCredential), options)
        {
        }

        private RouterClient(string endpoint, HttpPipeline httpPipeline, RouterClientOptions options)
        {
            _clientDiagnostics = new ClientDiagnostics(options);
            RestClient = new RouterRestClient(_clientDiagnostics, httpPipeline, new Uri(endpoint), options.ApiVersion);
        }

        #endregion

        /// <summary>Initializes a new instance of <see cref="RouterClient"/> for mocking.</summary>
        protected RouterClient()
        {
            _clientDiagnostics = null;
            RestClient = null;
        }

        /// <summary> Creates or updates a channel. </summary>
        /// <param name="body"> Model of channel to be created or updated. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<UpsertChannelResponse>> CreateChannelIfNotExistsAsync(UpsertChannelRequest body,
            string ifMatch = null, CancellationToken cancellationToken = default)
        {
            // Argument.AssertNotNullOrEmpty(body, nameof(body));
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.CreateChannelIfNotExistsAsync(body, ifMatch, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Creates or updates a channel. </summary>
        /// <param name="body"> Model of channel to be created or updated. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<UpsertChannelResponse> CreateChannelIfNotExists(UpsertChannelRequest body, string ifMatch = null,
            CancellationToken cancellationToken = default)
        {
            // Argument.AssertNotNullOrEmpty(body, nameof(body));
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.CreateChannelIfNotExists(body, ifMatch, cancellationToken);
        }

        /// <summary> Retrieves custom channels. </summary>
        /// <param name="type"> Specifies Managed Channels or Custom Channels, left blank returns all channels. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ChannelCollection>> ListChannelsAsync(string type = null,
            int? maxPageSize = null,
            string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListChannelsAsync(type, maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves custom channels. </summary>
        /// <param name="type"> Specifies Managed Channels or Custom Channels, left blank returns all channels. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ChannelCollection> ListChannels(string type = null, int? maxPageSize = null,
            string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return RestClient.ListChannels(type, maxPageSize, continuationToken, cancellationToken);
        }

        /// <summary> Retrieves an existing channel by Id. </summary>
        /// <param name="id"> Id of the channel to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<Channel>> GetChannelAsync(string id,
            CancellationToken cancellationToken = default)
        {
            return await RestClient.GetChannelAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves an existing channel by Id. </summary>
        /// <param name="id"> Id of the channel to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<Channel> GetChannel(string id, CancellationToken cancellationToken = default)
        {
            return RestClient.GetChannel(id, cancellationToken);
        }

        /// <summary> Deletes a channel by Id. </summary>
        /// <param name="id"> Id of the channel to delete. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response> DeleteChannelAsync(string id, string ifMatch = null,
            CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteChannelAsync(id, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a channel by Id. </summary>
        /// <param name="id"> Id of the channel to delete. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response DeleteChannel(string id, string ifMatch = null,
            CancellationToken cancellationToken = default)
        {
            return RestClient.DeleteChannel(id, ifMatch, cancellationToken);
        }

        /// <summary> Creates a new classification policy. </summary>
        /// <param name="body"> The CreateClassificationPolicyRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<CreateClassificationPolicyResponse>> CreateClassificationPolicyAsync(
            CreateClassificationPolicyRequest body, CancellationToken cancellationToken = default)
        {
            // Argument.AssertNotNullOrEmpty(body, nameof(body));
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.CreateClassificationPolicyAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new classification policy. </summary>
        /// <param name="body"> The CreateClassificationPolicyRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<CreateClassificationPolicyResponse> CreateClassificationPolicy(
            CreateClassificationPolicyRequest body, CancellationToken cancellationToken = default)
        {
            // Argument.AssertNotNullOrEmpty(body, nameof(body));
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.CreateClassificationPolicy(body, cancellationToken);
        }

        /// <summary> Retrieves existing classification policies. </summary>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="continuationToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ClassificationPolicyCollection>> ListClassificationPoliciesAsync(int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListClassificationPoliciesAsync(maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing classification policies. </summary>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="continuationToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ClassificationPolicyCollection> ListClassificationPolicies(int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return RestClient.ListClassificationPolicies(maxPageSize, continuationToken, cancellationToken);
        }

        /// <summary> Updates an existing classification policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="body"> The UpdateClassificationPolicyRequest to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<ClassificationPolicy>> UpdateClassificationPolicyAsync(string id, UpdateClassificationPolicyRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            // Argument.AssertNotNullOrEmpty(body, nameof(body));
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.UpdateClassificationPolicyAsync(id, body, ifMatch, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Updates an existing classification policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="body"> The UpdateClassificationPolicyRequest to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="body"/> is null. </exception>
        public virtual Response<ClassificationPolicy> UpdateClassificationPolicy(string id, UpdateClassificationPolicyRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            // Argument.AssertNotNullOrEmpty(body, nameof(body));
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.UpdateClassificationPolicy(id, body, ifMatch, cancellationToken);
        }

        /// <summary> Retrieves an existing classification policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<ClassificationPolicy>> GetClassificationPolicyAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.GetClassificationPolicyAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves an existing classification policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<ClassificationPolicy> GetClassificationPolicy(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.GetClassificationPolicy(id, cancellationToken);
        }

        /// <summary> Creates a new distribution policy. </summary>
        /// <param name="body"> The CreateDistributionPolicyRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<CreateDistributionPolicyResponse>> CreateDistributionPolicyAsync(CreateDistributionPolicyRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.CreateDistributionPolicyAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new distribution policy. </summary>
        /// <param name="body"> The CreateDistributionPolicyRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<CreateDistributionPolicyResponse> CreateDistributionPolicy(CreateDistributionPolicyRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.CreateDistributionPolicy(body, cancellationToken);
        }

        /// <summary> Retrieves existing distribution policies. </summary>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="continuationToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DistributionPolicyCollection>> ListDistributionPoliciesAsync(int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListDistributionPoliciesAsync(maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing distribution policies. </summary>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="continuationToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DistributionPolicyCollection> ListDistributionPolicies(int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return RestClient.ListDistributionPolicies(maxPageSize, continuationToken, cancellationToken);
        }

        /// <summary> Retrieves an existing distribution policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<DistributionPolicy>> GetDistributionPolicyAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.GetDistributionPolicyAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves an existing distribution policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<DistributionPolicy> GetDistributionPolicy(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.GetDistributionPolicy(id, cancellationToken);
        }

        /// <summary> Updates an existing distribution policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="body"> The UpdateDistributionPolicyRequest to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<DistributionPolicy>> UpdateDistributionPolicyAsync(string id, UpdateDistributionPolicyRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.UpdateDistributionPolicyAsync(id, body, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates an existing distribution policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="body"> The UpdateDistributionPolicyRequest to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="body"/> is null. </exception>
        public virtual Response<DistributionPolicy> UpdateDistributionPolicy(string id, UpdateDistributionPolicyRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.UpdateDistributionPolicy(id, body, ifMatch, cancellationToken);
        }

        /// <summary> Delete a distribution policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response> DeleteDistributionPolicyAsync(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.DeleteDistributionPolicyAsync(id, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Delete a distribution policy by Id. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response DeleteDistributionPolicy(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.DeleteDistributionPolicy(id, ifMatch, cancellationToken);
        }

        /// <summary> Creates a new exception policy. </summary>
        /// <param name="body"> Model of Exception Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<CreateExceptionPolicyResponse>> CreateExceptionPolicyAsync(CreateExceptionPolicyRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.CreateExceptionPolicyAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new exception policy. </summary>
        /// <param name="body"> Model of Exception Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<CreateExceptionPolicyResponse> CreateExceptionPolicy(CreateExceptionPolicyRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.CreateExceptionPolicy(body, cancellationToken);
        }

        /// <summary> Retrieves existing exception policies. </summary>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExceptionPolicyCollection>> ListExceptionPoliciesAsync(int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListExceptionPoliciesAsync(maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing exception policies. </summary>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExceptionPolicyCollection> ListExceptionPolicies(int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return RestClient.ListExceptionPolicies(maxPageSize, continuationToken, cancellationToken);
        }

        /// <summary> Retrieves an existing exception policy by Id. </summary>
        /// <param name="id"> Id of the exception policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<ExceptionPolicy>> GetExceptionPolicyAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.GetExceptionPolicyAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves an existing exception policy by Id. </summary>
        /// <param name="id"> Id of the exception policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<ExceptionPolicy> GetExceptionPolicy(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.GetExceptionPolicy(id, cancellationToken);
        }

        /// <summary> Deletes a exception policy by Id. </summary>
        /// <param name="id"> Id of the exception policy to delete. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response> DeleteExceptionPolicyAsync(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.DeleteExceptionPolicyAsync(id, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a exception policy by Id. </summary>
        /// <param name="id"> Id of the exception policy to delete. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response DeleteExceptionPolicy(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.DeleteExceptionPolicy(id, ifMatch, cancellationToken);
        }

        /// <summary> Updates a exception policy by Id. </summary>
        /// <param name="id"> Id of the exception policy to update. </param>
        /// <param name="body"> Model to use for updating a exception policy. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<UpdateExceptionPolicyResponse>> UpdateExceptionPolicyAsync(string id, UpdateExceptionPolicyRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.UpdateExceptionPolicyAsync(id, body, ifMatch, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Updates a exception policy by Id. </summary>
        /// <param name="id"> Id of the exception policy to update. </param>
        /// <param name="body"> Model to use for updating a exception policy. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="body"/> is null. </exception>
        public virtual Response<UpdateExceptionPolicyResponse> UpdateExceptionPolicy(string id, UpdateExceptionPolicyRequest body,
            string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.UpdateExceptionPolicy(id, body, ifMatch, cancellationToken);
        }

        /// <summary> Creates a new job to be routed. </summary>
        /// <param name="body"> The CreateJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CreateJobResponse>> CreateJobAsync(CreateJobRequest body = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateJobAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new job to be routed. </summary>
        /// <param name="body"> The CreateJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CreateJobResponse> CreateJob(CreateJobRequest body = null, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateJob(body, cancellationToken);
        }

        /// <summary> Retrieves an existing job by Id. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual async Task<Response<Job>> GetJobAsync(string jobId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return await RestClient.GetJobAsync(jobId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves an existing job by Id. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual Response<Job> GetJob(string jobId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return RestClient.GetJob(jobId, cancellationToken);
        }

        /// <summary> Updates an existing job by Id, potentially forcing it to be reclassified. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="body"> The UpdateJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<Job>> UpdateJobAsync(string jobId, UpdateJobRequest body, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.UpdateJobAsync(jobId, body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates an existing job by Id, potentially forcing it to be reclassified. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="body"> The UpdateJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="body"/> is null. </exception>
        public virtual Response<Job> UpdateJob(string jobId, UpdateJobRequest body, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.UpdateJob(jobId, body, cancellationToken);
        }

        /// <summary> Retrieves existing jobs by queue. </summary>
        /// <param name="queueId"> The String to use. </param>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="skip"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueId"/> is null. </exception>
        public virtual async Task<Response<JobCollection>> ListJobsAsync(string queueId, int? maxPageSize = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            if (queueId == null)
            {
                throw new ArgumentNullException(nameof(queueId));
            }

            return await RestClient.ListJobsAsync(queueId, maxPageSize, skip, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves existing jobs by queue. </summary>
        /// <param name="queueId"> The String to use. </param>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="skip"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueId"/> is null. </exception>
        public virtual Response<JobCollection> ListJobs(string queueId, int? maxPageSize = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            if (queueId == null)
            {
                throw new ArgumentNullException(nameof(queueId));
            }

            return RestClient.ListJobs(queueId, maxPageSize, skip, cancellationToken);
        }

        /// <summary> Submits request to cancel an existing job by Id while supplying free-form cancellation reason. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="body"> The CancelJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<Response> CancelJobAsync(string jobId, CancelJobRequest body, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.CancelJobAsync(jobId, body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Submits request to cancel an existing job by Id while supplying free-form cancellation reason. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="body"> The CancelJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="body"/> is null. </exception>
        public virtual Response CancelJob(string jobId, CancelJobRequest body, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.CancelJob(jobId, body, cancellationToken);
        }

        /// <summary> Completes an assigned job. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="body"> The CompleteJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual async Task<Response> CompleteJobAsync(string jobId, CompleteJobRequest body = null, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return await RestClient.CompleteJobAsync(jobId, body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Completes an assigned job. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="body"> The CompleteJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual Response CompleteJob(string jobId, CompleteJobRequest body = null, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return RestClient.CompleteJob(jobId, body, cancellationToken);
        }

        /// <summary> Closes a completed job. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="body"> The CloseJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual async Task<Response> CloseJobAsync(string jobId, CloseJobRequest body = null, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return await RestClient.CloseJobAsync(jobId, body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Closes a completed job. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="body"> The CloseJobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        public virtual Response CloseJob(string jobId, CloseJobRequest body = null, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return RestClient.CloseJob(jobId, body, cancellationToken);
        }

        /// <summary> Accepts an offer to work on a job and returns a 409/Conflict if another agent accepted the job already. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="workerId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        public virtual async Task<Response<AcceptJobOfferResponse>> AcceptJobAsync(string jobId, string workerId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return await RestClient.AcceptJobAsync(jobId, workerId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Accepts an offer to work on a job and returns a 409/Conflict if another agent accepted the job already. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="workerId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        public virtual Response<AcceptJobOfferResponse> AcceptJob(string jobId, string workerId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return RestClient.AcceptJob(jobId, workerId, cancellationToken);
        }

        /// <summary> Declines an offer to work on a job. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="workerId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        public virtual async Task<Response> DeclineJobAsync(string jobId, string workerId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return await RestClient.DeclineJobAsync(jobId, workerId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Declines an offer to work on a job. </summary>
        /// <param name="jobId"> The String to use. </param>
        /// <param name="workerId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        public virtual Response DeclineJob(string jobId, string workerId, CancellationToken cancellationToken = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return RestClient.DeclineJob(jobId, workerId, cancellationToken);
        }

        /// <summary> Creates a new queue to be routed. </summary>
        /// <param name="body"> Model of queue to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<CreateQueueResponse>> CreateQueueAsync(CreateQueueRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.CreateQueueAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new queue to be routed. </summary>
        /// <param name="body"> Model of queue to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<CreateQueueResponse> CreateQueue(CreateQueueRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.CreateQueue(body, cancellationToken);
        }

        /// <summary> Retrieves existing queues. </summary>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QueueCollection>> ListQueuesAsync(int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListQueuesAsync(maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing queues. </summary>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QueueCollection> ListQueues(int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return RestClient.ListQueues(maxPageSize, continuationToken, cancellationToken);
        }

        /// <summary> Retrieves an existing queue by Id. </summary>
        /// <param name="id"> Id of the queue to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<Queue>> GetQueueAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.GetQueueAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves an existing queue by Id. </summary>
        /// <param name="id"> Id of the queue to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<Queue> GetQueue(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.GetQueue(id, cancellationToken);
        }

        /// <summary> Deletes a queue by Id. </summary>
        /// <param name="id"> Id of the queue to delete. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response> DeleteQueueAsync(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.DeleteQueueAsync(id, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a queue by Id. </summary>
        /// <param name="id"> Id of the queue to delete. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response DeleteQueue(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.DeleteQueue(id, ifMatch, cancellationToken);
        }

        /// <summary> Update a queue by id. </summary>
        /// <param name="id"> Id of the queue to update. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="body"> Model to use for updating queue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<UpdateQueueResponse>> UpdateQueueAsync(string id, UpdateQueueRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.UpdateQueueAsync(id, body, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Update a queue by id. </summary>
        /// <param name="id"> Id of the queue to update. </param>
        /// <param name="ifMatch"> Concurrency token for CosmosDB. </param>
        /// <param name="body"> Model to use for updating queue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<UpdateQueueResponse> UpdateQueue(string id, UpdateQueueRequest body = null, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.UpdateQueue(id, body, ifMatch, cancellationToken);
        }

        /// <summary> Registers a worker to process jobs. </summary>
        /// <param name="body"> The RegisterWorkerRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<Worker>> RegisterWorkerAsync(RegisterWorkerRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return await RestClient.RegisterWorkerAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Registers a worker to process jobs. </summary>
        /// <param name="body"> The RegisterWorkerRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<Worker> RegisterWorker(RegisterWorkerRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            return RestClient.RegisterWorker(body, cancellationToken);
        }

        /// <summary> Deregisters a worker from processing jobs. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response> DeregisterWorkerAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await RestClient.DeregisterWorkerAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deregisters a worker from processing jobs. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response DeregisterWorker(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return RestClient.DeregisterWorker(id, cancellationToken);
        }

        /// <summary> Retrieves available workers. Pass Channel Id to get workers available in that particular channel. </summary>
        /// <param name="channelId"> Worker available in the particular channel. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkerCollection>> GetAvailableWorkersAsync(string channelId = null, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return await RestClient
                .GetAvailableWorkersAsync(channelId, maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves available workers. Pass Channel Id to get workers available in that particular channel. </summary>
        /// <param name="channelId"> Worker available in the particular channel. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkerCollection> GetAvailableWorkers(string channelId = null, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            return RestClient.GetAvailableWorkers(channelId, maxPageSize, continuationToken, cancellationToken);
        }

        /// <summary> Retrieves an existing worker by Id. </summary>
        /// <param name="workerId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerId"/> is null. </exception>
        public virtual async Task<Response<Worker>> GetWorkerAsync(string workerId, CancellationToken cancellationToken = default)
        {
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return await RestClient.GetWorkerAsync(workerId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves an existing worker by Id. </summary>
        /// <param name="workerId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerId"/> is null. </exception>
        public virtual Response<Worker> GetWorker(string workerId, CancellationToken cancellationToken = default)
        {
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return RestClient.GetWorker(workerId, cancellationToken);
        }

        /// <summary> Releases capacity consumed by a job within a workers socket collection. </summary>
        /// <param name="workerId"> The String to use. </param>
        /// <param name="body"> The ReleaseCapacityRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerId"/> is null. </exception>
        public virtual async Task<Response> ReleaseCapacityAsync(string workerId, ReleaseCapacityRequest body = null, CancellationToken cancellationToken = default)
        {
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return await RestClient.ReleaseCapacityAsync(workerId, body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Releases capacity consumed by a job within a workers socket collection. </summary>
        /// <param name="workerId"> The String to use. </param>
        /// <param name="body"> The ReleaseCapacityRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workerId"/> is null. </exception>
        public virtual Response ReleaseCapacity(string workerId, ReleaseCapacityRequest body = null, CancellationToken cancellationToken = default)
        {
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return RestClient.ReleaseCapacity(workerId, body, cancellationToken);
        }

        /// <summary> Retrieves custom channels. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="type"> Specifies Managed Channels or Custom Channels, left blank returns all channels. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual async Task<Response<ChannelCollection>> ListChannelsNextPageAsync(string nextLink, string type = null, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return await RestClient
                .ListChannelsNextPageAsync(nextLink, type, maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves custom channels. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="type"> Specifies Managed Channels or Custom Channels, left blank returns all channels. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual Response<ChannelCollection> ListChannelsNextPage(string nextLink, string type = null, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return RestClient.ListChannelsNextPage(nextLink, type, maxPageSize, continuationToken, cancellationToken);
        }

        /// <summary> Retrieves existing classification policies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="continuationToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual async Task<Response<ClassificationPolicyCollection>> ListClassificationPoliciesNextPageAsync(string nextLink, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return await RestClient
                .ListClassificationPoliciesNextPageAsync(nextLink, maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing classification policies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="continuationToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual Response<ClassificationPolicyCollection> ListClassificationPoliciesNextPage(string nextLink, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return RestClient.ListClassificationPoliciesNextPage(nextLink, maxPageSize, continuationToken, cancellationToken);
        }

        /// <summary> Retrieves existing distribution policies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="continuationToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual async Task<Response<DistributionPolicyCollection>> ListDistributionPoliciesNextPageAsync(string nextLink, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return await RestClient
                .ListDistributionPoliciesNextPageAsync(nextLink, maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing distribution policies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="continuationToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual Response<DistributionPolicyCollection> ListDistributionPoliciesNextPage(string nextLink, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return RestClient.ListDistributionPoliciesNextPage(nextLink, maxPageSize, continuationToken,
                cancellationToken);
        }

        /// <summary> Retrieves existing exception policies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual async Task<Response<ExceptionPolicyCollection>> ListExceptionPoliciesNextPageAsync(string nextLink, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return await RestClient
                .ListExceptionPoliciesNextPageAsync(nextLink, maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing exception policies. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual Response<ExceptionPolicyCollection> ListExceptionPoliciesNextPage(string nextLink, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return RestClient.ListExceptionPoliciesNextPage(nextLink, maxPageSize, continuationToken,
                cancellationToken);
        }

        /// <summary> Retrieves existing jobs by queue. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="queueId"> The String to use. </param>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="skip"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="queueId"/> is null. </exception>
        public virtual async Task<Response<JobCollection>> ListJobsNextPageAsync(string nextLink, string queueId, int? maxPageSize = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (queueId == null)
            {
                throw new ArgumentNullException(nameof(queueId));
            }

            return await RestClient.ListJobsNextPageAsync(nextLink, queueId, maxPageSize, skip, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing jobs by queue. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="queueId"> The String to use. </param>
        /// <param name="maxPageSize"> The Integer to use. </param>
        /// <param name="skip"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="queueId"/> is null. </exception>
        public virtual Response<JobCollection> ListJobsNextPage(string nextLink, string queueId, int? maxPageSize = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (queueId == null)
            {
                throw new ArgumentNullException(nameof(queueId));
            }

            return RestClient.ListJobsNextPage(nextLink, queueId, maxPageSize, skip, cancellationToken);
        }

        /// <summary> Retrieves existing queues. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual async Task<Response<QueueCollection>> ListQueuesNextPageAsync(string nextLink, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return await ListQueuesNextPageAsync(nextLink, maxPageSize, continuationToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary> Retrieves existing queues. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> Number of objects to return per page. </param>
        /// <param name="continuationToken"> Token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual Response<QueueCollection> ListQueuesNextPage(string nextLink, int? maxPageSize = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return RestClient.ListQueuesNextPage(nextLink, maxPageSize, continuationToken, cancellationToken);
        }
    }
}
