// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters to reconcile to the GitRepository source kind type.
    /// </summary>
    public partial class GitRepositoryDefinition
    {
        /// <summary>
        /// Initializes a new instance of the GitRepositoryDefinition class.
        /// </summary>
        public GitRepositoryDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GitRepositoryDefinition class.
        /// </summary>
        /// <param name="url">The URL to sync for the flux configuration git
        /// repository.</param>
        /// <param name="timeoutInSeconds">The maximum time to attempt to
        /// reconcile the cluster git repository source with the
        /// remote.</param>
        /// <param name="syncIntervalInSeconds">The interval at which to
        /// re-reconcile the cluster git repository source with the
        /// remote.</param>
        /// <param name="repositoryRef">The source reference for the
        /// GitRepository object.</param>
        /// <param name="sshKnownHosts">Base64-encoded known_hosts value
        /// containing public SSH keys required to access private git
        /// repositories over SSH</param>
        /// <param name="httpsUser">Plaintext HTTPS username used to access
        /// private git repositories over HTTPS</param>
        /// <param name="httpsCACert">Base64-encoded HTTPS certificate
        /// authority contents used to access git private git repositories over
        /// HTTPS</param>
        /// <param name="localAuthRef">Name of a local secret on the Kubernetes
        /// cluster to use as the authentication secret rather than the managed
        /// or user-provided configuration secrets.</param>
        public GitRepositoryDefinition(string url = default(string), long? timeoutInSeconds = default(long?), long? syncIntervalInSeconds = default(long?), RepositoryRefDefinition repositoryRef = default(RepositoryRefDefinition), string sshKnownHosts = default(string), string httpsUser = default(string), string httpsCACert = default(string), string localAuthRef = default(string))
        {
            Url = url;
            TimeoutInSeconds = timeoutInSeconds;
            SyncIntervalInSeconds = syncIntervalInSeconds;
            RepositoryRef = repositoryRef;
            SshKnownHosts = sshKnownHosts;
            HttpsUser = httpsUser;
            HttpsCACert = httpsCACert;
            LocalAuthRef = localAuthRef;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL to sync for the flux configuration git
        /// repository.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the maximum time to attempt to reconcile the cluster
        /// git repository source with the remote.
        /// </summary>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public long? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the interval at which to re-reconcile the cluster git
        /// repository source with the remote.
        /// </summary>
        [JsonProperty(PropertyName = "syncIntervalInSeconds")]
        public long? SyncIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the source reference for the GitRepository object.
        /// </summary>
        [JsonProperty(PropertyName = "repositoryRef")]
        public RepositoryRefDefinition RepositoryRef { get; set; }

        /// <summary>
        /// Gets or sets base64-encoded known_hosts value containing public SSH
        /// keys required to access private git repositories over SSH
        /// </summary>
        [JsonProperty(PropertyName = "sshKnownHosts")]
        public string SshKnownHosts { get; set; }

        /// <summary>
        /// Gets or sets plaintext HTTPS username used to access private git
        /// repositories over HTTPS
        /// </summary>
        [JsonProperty(PropertyName = "httpsUser")]
        public string HttpsUser { get; set; }

        /// <summary>
        /// Gets or sets base64-encoded HTTPS certificate authority contents
        /// used to access git private git repositories over HTTPS
        /// </summary>
        [JsonProperty(PropertyName = "httpsCACert")]
        public string HttpsCACert { get; set; }

        /// <summary>
        /// Gets or sets name of a local secret on the Kubernetes cluster to
        /// use as the authentication secret rather than the managed or
        /// user-provided configuration secrets.
        /// </summary>
        [JsonProperty(PropertyName = "localAuthRef")]
        public string LocalAuthRef { get; set; }

    }
}
