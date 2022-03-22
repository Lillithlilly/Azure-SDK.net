// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager
{
    /// <summary>
    /// The entry point for all ARM clients.
    /// </summary>
    [CodeGenSuppress("GetTenant", typeof(ResourceIdentifier))]
    public partial class ArmClient
    {
        #region PolicyAssignmentResource
        /// <summary> Gets an object representing a PolicyAssignmentResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentResource" /> object. </returns>
        public virtual PolicyAssignmentResource GetPolicyAssignmentResource(ResourceIdentifier id)
        {
            PolicyAssignmentResource.ValidateResourceId(id);
            return new PolicyAssignmentResource(this, id);
        }
        #endregion

        #region ResourceGroupResource
        /// <summary> Gets an object representing a ResourceGroupResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceGroupResource" /> object. </returns>
        public virtual ResourceGroupResource GetResourceGroupResource(ResourceIdentifier id)
        {
            ResourceGroupResource.ValidateResourceId(id);
            return new ResourceGroupResource(this, id);
        }
        #endregion

        #region ResourceProviderResource
        /// <summary> Gets an object representing a ResourceProviderResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceProviderResource" /> object. </returns>
        public virtual ResourceProviderResource GetResourceProviderResource(ResourceIdentifier id)
        {
            ResourceProviderResource.ValidateResourceId(id);
            return new ResourceProviderResource(this, id);
        }
        #endregion

        #region ResourceLinkResource
        /// <summary> Gets an object representing a ResourceLink along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceLinkResource" /> object. </returns>
        public virtual ResourceLinkResource GetResourceLinkResource(ResourceIdentifier id)
        {
            ResourceLinkResource.ValidateResourceId(id);
            return new ResourceLinkResource(this, id);
        }
        #endregion

        #region SubscriptionPolicyDefinitionResource
        /// <summary> Gets an object representing a SubscriptionPolicyDefinitionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionPolicyDefinitionResource" /> object. </returns>
        public virtual SubscriptionPolicyDefinitionResource GetSubscriptionPolicyDefinitionResource(ResourceIdentifier id)
        {
            SubscriptionPolicyDefinitionResource.ValidateResourceId(id);
            return new SubscriptionPolicyDefinitionResource(this, id);
        }
        #endregion

        #region TenantPolicyDefinitionResource
        /// <summary> Gets an object representing a TenantPolicyDefinitionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantPolicyDefinitionResource" /> object. </returns>
        public virtual TenantPolicyDefinitionResource GetTenantPolicyDefinitionResource(ResourceIdentifier id)
        {
            TenantPolicyDefinitionResource.ValidateResourceId(id);
            return new TenantPolicyDefinitionResource(this, id);
        }
        #endregion

        #region ManagementGroupPolicyDefinitionResource
        /// <summary> Gets an object representing a ManagementGroupPolicyDefinitionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementGroupPolicyDefinitionResource" /> object. </returns>
        public virtual ManagementGroupPolicyDefinitionResource GetManagementGroupPolicyDefinitionResource(ResourceIdentifier id)
        {
            ManagementGroupPolicyDefinitionResource.ValidateResourceId(id);
            return new ManagementGroupPolicyDefinitionResource(this, id);
        }
        #endregion

        #region SubscriptionPolicySetDefinitionResource
        /// <summary> Gets an object representing a SubscriptionPolicySetDefinitionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionPolicySetDefinitionResource" /> object. </returns>
        public virtual SubscriptionPolicySetDefinitionResource GetSubscriptionPolicySetDefinitionResource(ResourceIdentifier id)
        {
            SubscriptionPolicySetDefinitionResource.ValidateResourceId(id);
            return new SubscriptionPolicySetDefinitionResource(this, id);
        }
        #endregion

        #region TenantPolicySetDefinitionResource
        /// <summary> Gets an object representing a TenantPolicySetDefinitionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantPolicySetDefinitionResource" /> object. </returns>
        public virtual TenantPolicySetDefinitionResource GetTenantPolicySetDefinitionResource(ResourceIdentifier id)
        {
            TenantPolicySetDefinitionResource.ValidateResourceId(id);
            return new TenantPolicySetDefinitionResource(this, id);
        }
        #endregion

        #region ManagementGroupPolicySetDefinitionResource
        /// <summary> Gets an object representing a ManagementGroupPolicySetDefinitionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementGroupPolicySetDefinitionResource" /> object. </returns>
        public virtual ManagementGroupPolicySetDefinitionResource GetManagementGroupPolicySetDefinitionResource(ResourceIdentifier id)
        {
            ManagementGroupPolicySetDefinitionResource.ValidateResourceId(id);
            return new ManagementGroupPolicySetDefinitionResource(this, id);
        }
        #endregion

        #region PolicyExemptionResource
        /// <summary> Gets an object representing a PolicyExemptionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PolicyExemptionResource" /> object. </returns>
        public virtual PolicyExemptionResource GetPolicyExemptionResource(ResourceIdentifier id)
        {
            PolicyExemptionResource.ValidateResourceId(id);
            return new PolicyExemptionResource(this, id);
        }
        #endregion

        #region DataPolicyManifestResource
        /// <summary> Gets an object representing a DataPolicyManifestResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataPolicyManifestResource" /> object. </returns>
        public virtual DataPolicyManifestResource GetDataPolicyManifestResource(ResourceIdentifier id)
        {
            DataPolicyManifestResource.ValidateResourceId(id);
            return new DataPolicyManifestResource(this, id);
        }
        #endregion

        #region ManagementLockResource
        /// <summary> Gets an object representing a ManagementLockResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementLockResource" /> object. </returns>
        public virtual ManagementLockResource GetManagementLockResource(ResourceIdentifier id)
        {
            ManagementLockResource.ValidateResourceId(id);
            return new ManagementLockResource(this, id);
        }
        #endregion

        #region SubscriptionResource
        /// <summary> Gets an object representing a SubscriptionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionResource" /> object. </returns>
        public virtual SubscriptionResource GetSubscriptionResource(ResourceIdentifier id)
        {
            SubscriptionResource.ValidateResourceId(id);
            return new SubscriptionResource(this, id);
        }
        #endregion

        #region FeatureResource
        /// <summary> Gets an object representing a FeatureResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FeatureResource" /> object. </returns>
        public virtual FeatureResource GetFeatureResource(ResourceIdentifier id)
        {
            FeatureResource.ValidateResourceId(id);
            return new FeatureResource(this, id);
        }
        #endregion
    }
}
