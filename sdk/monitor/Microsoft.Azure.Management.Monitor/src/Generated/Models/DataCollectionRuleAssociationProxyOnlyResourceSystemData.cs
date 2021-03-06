// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using System.Linq;

    /// <summary>
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    public partial class DataCollectionRuleAssociationProxyOnlyResourceSystemData : SystemData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataCollectionRuleAssociationProxyOnlyResourceSystemData class.
        /// </summary>
        public DataCollectionRuleAssociationProxyOnlyResourceSystemData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataCollectionRuleAssociationProxyOnlyResourceSystemData class.
        /// </summary>
        /// <param name="createdBy">The identity that created the
        /// resource.</param>
        /// <param name="createdByType">The type of identity that created the
        /// resource. Possible values include: 'User', 'Application',
        /// 'ManagedIdentity', 'Key'</param>
        /// <param name="createdAt">The timestamp of resource creation
        /// (UTC).</param>
        /// <param name="lastModifiedBy">The identity that last modified the
        /// resource.</param>
        /// <param name="lastModifiedByType">The type of identity that last
        /// modified the resource. Possible values include: 'User',
        /// 'Application', 'ManagedIdentity', 'Key'</param>
        /// <param name="lastModifiedAt">The timestamp of resource last
        /// modification (UTC)</param>
        public DataCollectionRuleAssociationProxyOnlyResourceSystemData(string createdBy = default(string), string createdByType = default(string), System.DateTime? createdAt = default(System.DateTime?), string lastModifiedBy = default(string), string lastModifiedByType = default(string), System.DateTime? lastModifiedAt = default(System.DateTime?))
            : base(createdBy, createdByType, createdAt, lastModifiedBy, lastModifiedByType, lastModifiedAt)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
