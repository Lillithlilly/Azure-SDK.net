// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The object representing continuous mode backup policy. </summary>
    public partial class ContinuousModeBackupPolicy : BackupPolicy
    {
        /// <summary> Initializes a new instance of ContinuousModeBackupPolicy. </summary>
        public ContinuousModeBackupPolicy()
        {
            PolicyType = BackupPolicyType.Continuous;
        }

        /// <summary> Initializes a new instance of ContinuousModeBackupPolicy. </summary>
        /// <param name="policyType"> Describes the mode of backups. </param>
        /// <param name="migrationState"> The object representing the state of the migration between the backup policies. </param>
        internal ContinuousModeBackupPolicy(BackupPolicyType policyType, BackupPolicyMigrationState migrationState) : base(policyType, migrationState)
        {
            PolicyType = policyType;
        }
    }
}
