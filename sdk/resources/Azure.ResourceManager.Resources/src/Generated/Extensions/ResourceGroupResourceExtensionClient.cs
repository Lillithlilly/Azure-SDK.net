// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ArmDeploymentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArmDeploymentResources and their operations over a ArmDeploymentResource. </returns>
        public virtual ArmDeploymentCollection GetArmDeployments()
        {
            return GetCachedClient(Client => new ArmDeploymentCollection(Client, Id));
        }

        /// <summary> Gets a collection of ArmApplicationResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArmApplicationResources and their operations over a ArmApplicationResource. </returns>
        public virtual ArmApplicationCollection GetArmApplications()
        {
            return GetCachedClient(Client => new ArmApplicationCollection(Client, Id));
        }

        /// <summary> Gets a collection of ArmApplicationDefinitionResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArmApplicationDefinitionResources and their operations over a ArmApplicationDefinitionResource. </returns>
        public virtual ArmApplicationDefinitionCollection GetArmApplicationDefinitions()
        {
            return GetCachedClient(Client => new ArmApplicationDefinitionCollection(Client, Id));
        }

        /// <summary> Gets a collection of JitRequestResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of JitRequestResources and their operations over a JitRequestResource. </returns>
        public virtual JitRequestCollection GetJitRequests()
        {
            return GetCachedClient(Client => new JitRequestCollection(Client, Id));
        }

        /// <summary> Gets a collection of ArmDeploymentScriptResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArmDeploymentScriptResources and their operations over a ArmDeploymentScriptResource. </returns>
        public virtual ArmDeploymentScriptCollection GetArmDeploymentScripts()
        {
            return GetCachedClient(Client => new ArmDeploymentScriptCollection(Client, Id));
        }

        /// <summary> Gets a collection of TemplateSpecResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of TemplateSpecResources and their operations over a TemplateSpecResource. </returns>
        public virtual TemplateSpecCollection GetTemplateSpecs()
        {
            return GetCachedClient(Client => new TemplateSpecCollection(Client, Id));
        }
    }
}
