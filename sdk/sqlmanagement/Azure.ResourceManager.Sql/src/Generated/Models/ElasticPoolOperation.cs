// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A elastic pool operation. </summary>
    public partial class ElasticPoolOperation : Resource
    {
        /// <summary> Initializes a new instance of ElasticPoolOperation. </summary>
        public ElasticPoolOperation()
        {
        }

        /// <summary> Initializes a new instance of ElasticPoolOperation. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool the operation is being performed on. </param>
        /// <param name="operation"> The name of operation. </param>
        /// <param name="operationFriendlyName"> The friendly name of operation. </param>
        /// <param name="percentComplete"> The percentage of the operation completed. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="startTime"> The operation start time. </param>
        /// <param name="state"> The operation state. </param>
        /// <param name="errorCode"> The operation error code. </param>
        /// <param name="errorDescription"> The operation error description. </param>
        /// <param name="errorSeverity"> The operation error severity. </param>
        /// <param name="isUserError"> Whether or not the error is a user error. </param>
        /// <param name="estimatedCompletionTime"> The estimated completion time of the operation. </param>
        /// <param name="description"> The operation description. </param>
        /// <param name="isCancellable"> Whether the operation can be cancelled. </param>
        internal ElasticPoolOperation(ResourceIdentifier id, string name, ResourceType type, string elasticPoolName, string operation, string operationFriendlyName, int? percentComplete, string serverName, DateTimeOffset? startTime, string state, int? errorCode, string errorDescription, int? errorSeverity, bool? isUserError, DateTimeOffset? estimatedCompletionTime, string description, bool? isCancellable) : base(id, name, type)
        {
            ElasticPoolName = elasticPoolName;
            Operation = operation;
            OperationFriendlyName = operationFriendlyName;
            PercentComplete = percentComplete;
            ServerName = serverName;
            StartTime = startTime;
            State = state;
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
            ErrorSeverity = errorSeverity;
            IsUserError = isUserError;
            EstimatedCompletionTime = estimatedCompletionTime;
            Description = description;
            IsCancellable = isCancellable;
        }

        /// <summary> The name of the elastic pool the operation is being performed on. </summary>
        public string ElasticPoolName { get; }
        /// <summary> The name of operation. </summary>
        public string Operation { get; }
        /// <summary> The friendly name of operation. </summary>
        public string OperationFriendlyName { get; }
        /// <summary> The percentage of the operation completed. </summary>
        public int? PercentComplete { get; }
        /// <summary> The name of the server. </summary>
        public string ServerName { get; }
        /// <summary> The operation start time. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The operation state. </summary>
        public string State { get; }
        /// <summary> The operation error code. </summary>
        public int? ErrorCode { get; }
        /// <summary> The operation error description. </summary>
        public string ErrorDescription { get; }
        /// <summary> The operation error severity. </summary>
        public int? ErrorSeverity { get; }
        /// <summary> Whether or not the error is a user error. </summary>
        public bool? IsUserError { get; }
        /// <summary> The estimated completion time of the operation. </summary>
        public DateTimeOffset? EstimatedCompletionTime { get; }
        /// <summary> The operation description. </summary>
        public string Description { get; }
        /// <summary> Whether the operation can be cancelled. </summary>
        public bool? IsCancellable { get; }
    }
}
