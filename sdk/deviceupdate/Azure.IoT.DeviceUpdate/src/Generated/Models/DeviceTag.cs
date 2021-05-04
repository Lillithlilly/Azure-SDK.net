// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> Device tag properties. </summary>
    public partial class DeviceTag
    {
        /// <summary> Initializes a new instance of DeviceTag. </summary>
        /// <param name="tagName"> Tag name. </param>
        /// <param name="deviceCount"> Number of devices with this tag. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tagName"/> is null. </exception>
        internal DeviceTag(string tagName, int deviceCount)
        {
            if (tagName == null)
            {
                throw new ArgumentNullException(nameof(tagName));
            }

            TagName = tagName;
            DeviceCount = deviceCount;
        }

        /// <summary> Tag name. </summary>
        public string TagName { get; }
        /// <summary> Number of devices with this tag. </summary>
        public int DeviceCount { get; }
    }
}