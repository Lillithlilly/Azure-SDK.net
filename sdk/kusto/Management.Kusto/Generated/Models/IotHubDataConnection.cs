// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing an iot hub data connection.
    /// </summary>
    [Newtonsoft.Json.JsonObject("IotHub")]
    [Rest.Serialization.JsonTransformation]
    public partial class IotHubDataConnection : DataConnection
    {
        /// <summary>
        /// Initializes a new instance of the IotHubDataConnection class.
        /// </summary>
        public IotHubDataConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubDataConnection class.
        /// </summary>
        /// <param name="iotHubResourceId">The resource ID of the Iot hub to be
        /// used to create a data connection.</param>
        /// <param name="consumerGroup">The iot hub consumer group.</param>
        /// <param name="sharedAccessPolicyName">The name of the share access
        /// policy</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tableName">The table where the data should be
        /// ingested. Optionally the table information can be added to each
        /// message.</param>
        /// <param name="mappingRuleName">The mapping rule to be used to ingest
        /// the data. Optionally the mapping information can be added to each
        /// message.</param>
        /// <param name="dataFormat">The data format of the message. Optionally
        /// the data format can be added to each message. Possible values
        /// include: 'MULTIJSON', 'JSON', 'CSV', 'TSV', 'SCSV', 'SOHSV', 'PSV',
        /// 'TXT', 'RAW', 'SINGLEJSON', 'AVRO', 'TSVE', 'PARQUET', 'ORC',
        /// 'APACHEAVRO', 'W3CLOGFILE'</param>
        /// <param name="eventSystemProperties">System properties of the iot
        /// hub</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Running', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Moving'</param>
        public IotHubDataConnection(string iotHubResourceId, string consumerGroup, string sharedAccessPolicyName, string id = default(string), string name = default(string), string type = default(string), string location = default(string), string tableName = default(string), string mappingRuleName = default(string), string dataFormat = default(string), IList<string> eventSystemProperties = default(IList<string>), string provisioningState = default(string))
            : base(id, name, type, location)
        {
            IotHubResourceId = iotHubResourceId;
            ConsumerGroup = consumerGroup;
            TableName = tableName;
            MappingRuleName = mappingRuleName;
            DataFormat = dataFormat;
            EventSystemProperties = eventSystemProperties;
            SharedAccessPolicyName = sharedAccessPolicyName;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the Iot hub to be used to create a
        /// data connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.iotHubResourceId")]
        public string IotHubResourceId { get; set; }

        /// <summary>
        /// Gets or sets the iot hub consumer group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consumerGroup")]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// Gets or sets the table where the data should be ingested.
        /// Optionally the table information can be added to each message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the mapping rule to be used to ingest the data.
        /// Optionally the mapping information can be added to each message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mappingRuleName")]
        public string MappingRuleName { get; set; }

        /// <summary>
        /// Gets or sets the data format of the message. Optionally the data
        /// format can be added to each message. Possible values include:
        /// 'MULTIJSON', 'JSON', 'CSV', 'TSV', 'SCSV', 'SOHSV', 'PSV', 'TXT',
        /// 'RAW', 'SINGLEJSON', 'AVRO', 'TSVE', 'PARQUET', 'ORC',
        /// 'APACHEAVRO', 'W3CLOGFILE'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataFormat")]
        public string DataFormat { get; set; }

        /// <summary>
        /// Gets or sets system properties of the iot hub
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventSystemProperties")]
        public IList<string> EventSystemProperties { get; set; }

        /// <summary>
        /// Gets or sets the name of the share access policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedAccessPolicyName")]
        public string SharedAccessPolicyName { get; set; }

        /// <summary>
        /// Gets or sets the provisioned state of the resource. Possible values
        /// include: 'Running', 'Creating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Moving'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IotHubResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IotHubResourceId");
            }
            if (ConsumerGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsumerGroup");
            }
            if (SharedAccessPolicyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SharedAccessPolicyName");
            }
        }
    }
}