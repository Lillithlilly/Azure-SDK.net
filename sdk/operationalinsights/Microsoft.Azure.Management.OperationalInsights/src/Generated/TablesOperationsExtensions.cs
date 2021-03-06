// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TablesOperations.
    /// </summary>
    public static partial class TablesOperationsExtensions
    {
            /// <summary>
            /// Gets all the tables for the specified Log Analytics workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IEnumerable<Table> ListByWorkspace(this ITablesOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListByWorkspaceAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the tables for the specified Log Analytics workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Table>> ListByWorkspaceAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update or Create a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to update table properties.
            /// </param>
            public static Table CreateOrUpdate(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, Table parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, tableName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update or Create a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to update table properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Table> CreateOrUpdateAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, Table parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, tableName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to update table properties.
            /// </param>
            public static Table Update(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, Table parameters)
            {
                return operations.UpdateAsync(resourceGroupName, workspaceName, tableName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to update table properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Table> UpdateAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, Table parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, tableName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            public static Table Get(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, tableName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Table> GetAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, tableName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            public static void Delete(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, tableName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, tableName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Migrate a Log Analytics table from support of the Data Collector API and
            /// Custom Fields features to support of Data Collection Rule-based Custom
            /// Logs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            public static void Migrate(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName)
            {
                operations.MigrateAsync(resourceGroupName, workspaceName, tableName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Migrate a Log Analytics table from support of the Data Collector API and
            /// Custom Fields features to support of Data Collection Rule-based Custom
            /// Logs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task MigrateAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.MigrateWithHttpMessagesAsync(resourceGroupName, workspaceName, tableName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update or Create a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to update table properties.
            /// </param>
            public static Table BeginCreateOrUpdate(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, Table parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, workspaceName, tableName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update or Create a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to update table properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Table> BeginCreateOrUpdateAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, Table parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, tableName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to update table properties.
            /// </param>
            public static Table BeginUpdate(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, Table parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, workspaceName, tableName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to update table properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Table> BeginUpdateAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, Table parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, tableName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            public static void BeginDelete(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName)
            {
                operations.BeginDeleteAsync(resourceGroupName, workspaceName, tableName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Log Analytics workspace table.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ITablesOperations operations, string resourceGroupName, string workspaceName, string tableName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, tableName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
