// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class DataSourceCredentialEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceCredentialType");
            writer.WriteStringValue(DataSourceCredentialType.ToString());
            writer.WritePropertyName("dataSourceCredentialName");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("dataSourceCredentialDescription");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static DataSourceCredentialEntity DeserializeDataSourceCredentialEntity(JsonElement element)
        {
            if (element.TryGetProperty("dataSourceCredentialType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureSQLConnectionString": return DataSourceSqlConnectionString.DeserializeDataSourceSqlConnectionString(element);
                    case "DataLakeGen2SharedKey": return DataSourceDataLakeGen2SharedKey.DeserializeDataSourceDataLakeGen2SharedKey(element);
                    case "ServicePrincipal": return DataSourceServicePrincipal.DeserializeDataSourceServicePrincipal(element);
                    case "ServicePrincipalInKV": return DataSourceServicePrincipalInKeyVault.DeserializeDataSourceServicePrincipalInKeyVault(element);
                }
            }
            DataSourceCredentialType dataSourceCredentialType = default;
            Optional<string> dataSourceCredentialId = default;
            string dataSourceCredentialName = default;
            Optional<string> dataSourceCredentialDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSourceCredentialType"))
                {
                    dataSourceCredentialType = new DataSourceCredentialType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialId"))
                {
                    dataSourceCredentialId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialName"))
                {
                    dataSourceCredentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialDescription"))
                {
                    dataSourceCredentialDescription = property.Value.GetString();
                    continue;
                }
            }
            return new DataSourceCredentialEntity(dataSourceCredentialType, dataSourceCredentialId.Value, dataSourceCredentialName, dataSourceCredentialDescription.Value);
        }
    }
}