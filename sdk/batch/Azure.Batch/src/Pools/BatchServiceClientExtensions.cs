// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Batch.Pools
{
    public static class BatchServiceClientExtensions
    {
        public static BatchPoolClient CreatePoolClient(this BatchServiceClient serviceClient)
        {
            return new BatchPoolClient(serviceClient.EndPoint, serviceClient.Pipeline);
        }
    }
}
