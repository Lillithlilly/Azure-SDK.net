// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Static site zip deployment ARM resource. </summary>
    public partial class StaticSiteZipDeploymentARMResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StaticSiteZipDeploymentARMResource. </summary>
        public StaticSiteZipDeploymentARMResource()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteZipDeploymentARMResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="appZipUri"> URL for the zipped app content. </param>
        /// <param name="apiZipUri"> URL for the zipped api content. </param>
        /// <param name="deploymentTitle"> A title to label the deployment. </param>
        /// <param name="provider"> The provider submitting this deployment. </param>
        /// <param name="functionLanguage"> The language of the api content, if it exists. </param>
        internal StaticSiteZipDeploymentARMResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, Uri appZipUri, Uri apiZipUri, string deploymentTitle, string provider, string functionLanguage) : base(id, name, resourceType, systemData, kind)
        {
            AppZipUri = appZipUri;
            ApiZipUri = apiZipUri;
            DeploymentTitle = deploymentTitle;
            Provider = provider;
            FunctionLanguage = functionLanguage;
        }

        /// <summary> URL for the zipped app content. </summary>
        public Uri AppZipUri { get; set; }
        /// <summary> URL for the zipped api content. </summary>
        public Uri ApiZipUri { get; set; }
        /// <summary> A title to label the deployment. </summary>
        public string DeploymentTitle { get; set; }
        /// <summary> The provider submitting this deployment. </summary>
        public string Provider { get; set; }
        /// <summary> The language of the api content, if it exists. </summary>
        public string FunctionLanguage { get; set; }
    }
}
