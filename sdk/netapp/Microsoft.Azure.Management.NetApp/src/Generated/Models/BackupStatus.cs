// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Backup status
    /// </summary>
    public partial class BackupStatus
    {
        /// <summary>
        /// Initializes a new instance of the BackupStatus class.
        /// </summary>
        public BackupStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupStatus class.
        /// </summary>
        /// <param name="healthy">Backup health status</param>
        /// <param name="relationshipStatus">Status of the backup mirror
        /// relationship. Possible values include: 'Idle',
        /// 'Transferring'</param>
        /// <param name="mirrorState">The status of the backup. Possible values
        /// include: 'Uninitialized', 'Mirrored', 'Broken'</param>
        /// <param name="unhealthyReason">Reason for the unhealthy backup
        /// relationship</param>
        /// <param name="errorMessage">Displays error message if the backup is
        /// in an error state</param>
        /// <param name="lastTransferSize">Displays the last transfer
        /// size</param>
        /// <param name="lastTransferType">Displays the last transfer
        /// type</param>
        /// <param name="totalTransferBytes">Displays the total bytes
        /// transferred</param>
        public BackupStatus(bool? healthy = default(bool?), string relationshipStatus = default(string), string mirrorState = default(string), string unhealthyReason = default(string), string errorMessage = default(string), long? lastTransferSize = default(long?), string lastTransferType = default(string), long? totalTransferBytes = default(long?))
        {
            Healthy = healthy;
            RelationshipStatus = relationshipStatus;
            MirrorState = mirrorState;
            UnhealthyReason = unhealthyReason;
            ErrorMessage = errorMessage;
            LastTransferSize = lastTransferSize;
            LastTransferType = lastTransferType;
            TotalTransferBytes = totalTransferBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets backup health status
        /// </summary>
        [JsonProperty(PropertyName = "healthy")]
        public bool? Healthy { get; private set; }

        /// <summary>
        /// Gets status of the backup mirror relationship. Possible values
        /// include: 'Idle', 'Transferring'
        /// </summary>
        [JsonProperty(PropertyName = "relationshipStatus")]
        public string RelationshipStatus { get; private set; }

        /// <summary>
        /// Gets the status of the backup. Possible values include:
        /// 'Uninitialized', 'Mirrored', 'Broken'
        /// </summary>
        [JsonProperty(PropertyName = "mirrorState")]
        public string MirrorState { get; private set; }

        /// <summary>
        /// Gets reason for the unhealthy backup relationship
        /// </summary>
        [JsonProperty(PropertyName = "unhealthyReason")]
        public string UnhealthyReason { get; private set; }

        /// <summary>
        /// Gets displays error message if the backup is in an error state
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets displays the last transfer size
        /// </summary>
        [JsonProperty(PropertyName = "lastTransferSize")]
        public long? LastTransferSize { get; private set; }

        /// <summary>
        /// Gets displays the last transfer type
        /// </summary>
        [JsonProperty(PropertyName = "lastTransferType")]
        public string LastTransferType { get; private set; }

        /// <summary>
        /// Gets displays the total bytes transferred
        /// </summary>
        [JsonProperty(PropertyName = "totalTransferBytes")]
        public long? TotalTransferBytes { get; private set; }

    }
}
