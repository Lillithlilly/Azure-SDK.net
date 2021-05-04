// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> Device metadata. </summary>
    public partial class Device
    {
        /// <summary> Initializes a new instance of Device. </summary>
        /// <param name="deviceId"> Device identity. </param>
        /// <param name="deviceClassId"> Device class identity. </param>
        /// <param name="manufacturer"> Device manufacturer. </param>
        /// <param name="model"> Device model. </param>
        /// <param name="onLatestUpdate"> Boolean flag indicating whether the latest update is installed on the device. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceId"/>, <paramref name="deviceClassId"/>, <paramref name="manufacturer"/>, or <paramref name="model"/> is null. </exception>
        internal Device(string deviceId, string deviceClassId, string manufacturer, string model, bool onLatestUpdate)
        {
            if (deviceId == null)
            {
                throw new ArgumentNullException(nameof(deviceId));
            }
            if (deviceClassId == null)
            {
                throw new ArgumentNullException(nameof(deviceClassId));
            }
            if (manufacturer == null)
            {
                throw new ArgumentNullException(nameof(manufacturer));
            }
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            DeviceId = deviceId;
            DeviceClassId = deviceClassId;
            Manufacturer = manufacturer;
            Model = model;
            OnLatestUpdate = onLatestUpdate;
        }

        /// <summary> Initializes a new instance of Device. </summary>
        /// <param name="deviceId"> Device identity. </param>
        /// <param name="deviceClassId"> Device class identity. </param>
        /// <param name="manufacturer"> Device manufacturer. </param>
        /// <param name="model"> Device model. </param>
        /// <param name="groupId"> Device group identity. </param>
        /// <param name="lastAttemptedUpdateId"> Update identity. </param>
        /// <param name="deploymentStatus"> State of the device in its last deployment. </param>
        /// <param name="installedUpdateId"> Update identity. </param>
        /// <param name="onLatestUpdate"> Boolean flag indicating whether the latest update is installed on the device. </param>
        /// <param name="lastDeploymentId"> The deployment identifier for the last deployment to the device. </param>
        internal Device(string deviceId, string deviceClassId, string manufacturer, string model, string groupId, UpdateId lastAttemptedUpdateId, DeviceDeploymentState? deploymentStatus, UpdateId installedUpdateId, bool onLatestUpdate, string lastDeploymentId)
        {
            DeviceId = deviceId;
            DeviceClassId = deviceClassId;
            Manufacturer = manufacturer;
            Model = model;
            GroupId = groupId;
            LastAttemptedUpdateId = lastAttemptedUpdateId;
            DeploymentStatus = deploymentStatus;
            InstalledUpdateId = installedUpdateId;
            OnLatestUpdate = onLatestUpdate;
            LastDeploymentId = lastDeploymentId;
        }

        /// <summary> Device identity. </summary>
        public string DeviceId { get; }
        /// <summary> Device class identity. </summary>
        public string DeviceClassId { get; }
        /// <summary> Device manufacturer. </summary>
        public string Manufacturer { get; }
        /// <summary> Device model. </summary>
        public string Model { get; }
        /// <summary> Device group identity. </summary>
        public string GroupId { get; }
        /// <summary> Update identity. </summary>
        public UpdateId LastAttemptedUpdateId { get; }
        /// <summary> State of the device in its last deployment. </summary>
        public DeviceDeploymentState? DeploymentStatus { get; }
        /// <summary> Update identity. </summary>
        public UpdateId InstalledUpdateId { get; }
        /// <summary> Boolean flag indicating whether the latest update is installed on the device. </summary>
        public bool OnLatestUpdate { get; }
        /// <summary> The deployment identifier for the last deployment to the device. </summary>
        public string LastDeploymentId { get; }
    }
}