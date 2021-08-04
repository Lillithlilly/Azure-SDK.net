// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Messaging.EventHubs;

namespace Azure.Messaging.EventHubs.Producer
{
    /// <summary>
    /// This class allows the application to request an <see cref="EventData"/> instance be sent to a particular
    /// partition key or partition id.
    /// </summary>
    public class EnqueueEventOptions : SendEventOptions
    {
    }
}
