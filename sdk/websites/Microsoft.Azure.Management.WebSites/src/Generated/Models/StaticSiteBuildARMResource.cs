// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Static Site Build ARM resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSiteBuildARMResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the StaticSiteBuildARMResource class.
        /// </summary>
        public StaticSiteBuildARMResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StaticSiteBuildARMResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="buildId">An identifier for the static site
        /// build.</param>
        /// <param name="sourceBranch">The source branch.</param>
        /// <param name="pullRequestTitle">The title of a pull request that a
        /// static site build is related to.</param>
        /// <param name="hostname">The hostname for a static site
        /// build.</param>
        /// <param name="createdTimeUtc">When this build was created.</param>
        /// <param name="lastUpdatedOn">When this build was updated.</param>
        /// <param name="status">The status of the static site build. Possible
        /// values include: 'WaitingForDeployment', 'Uploading', 'Deploying',
        /// 'Ready', 'Failed', 'Deleting', 'Detached'</param>
        /// <param name="userProvidedFunctionApps">User provided function apps
        /// registered with the static site build</param>
        public StaticSiteBuildARMResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string buildId = default(string), string sourceBranch = default(string), string pullRequestTitle = default(string), string hostname = default(string), System.DateTime? createdTimeUtc = default(System.DateTime?), System.DateTime? lastUpdatedOn = default(System.DateTime?), string status = default(string), IList<StaticSiteUserProvidedFunctionApp> userProvidedFunctionApps = default(IList<StaticSiteUserProvidedFunctionApp>))
            : base(id, name, kind, type)
        {
            BuildId = buildId;
            SourceBranch = sourceBranch;
            PullRequestTitle = pullRequestTitle;
            Hostname = hostname;
            CreatedTimeUtc = createdTimeUtc;
            LastUpdatedOn = lastUpdatedOn;
            Status = status;
            UserProvidedFunctionApps = userProvidedFunctionApps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets an identifier for the static site build.
        /// </summary>
        [JsonProperty(PropertyName = "properties.buildId")]
        public string BuildId { get; private set; }

        /// <summary>
        /// Gets the source branch.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceBranch")]
        public string SourceBranch { get; private set; }

        /// <summary>
        /// Gets the title of a pull request that a static site build is
        /// related to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pullRequestTitle")]
        public string PullRequestTitle { get; private set; }

        /// <summary>
        /// Gets the hostname for a static site build.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostname")]
        public string Hostname { get; private set; }

        /// <summary>
        /// Gets when this build was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTimeUtc")]
        public System.DateTime? CreatedTimeUtc { get; private set; }

        /// <summary>
        /// Gets when this build was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedOn")]
        public System.DateTime? LastUpdatedOn { get; private set; }

        /// <summary>
        /// Gets the status of the static site build. Possible values include:
        /// 'WaitingForDeployment', 'Uploading', 'Deploying', 'Ready',
        /// 'Failed', 'Deleting', 'Detached'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets user provided function apps registered with the static site
        /// build
        /// </summary>
        [JsonProperty(PropertyName = "properties.userProvidedFunctionApps")]
        public IList<StaticSiteUserProvidedFunctionApp> UserProvidedFunctionApps { get; private set; }

    }
}
