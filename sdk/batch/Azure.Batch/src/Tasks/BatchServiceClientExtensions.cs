// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Batch.Tasks
{
    public static class BatchServiceClientExtensions
    {
        public static BatchTaskClient CreateTaskClient(this BatchServiceClient serviceClient)
        {
            return new BatchTaskClient(serviceClient.EndPoint, serviceClient.Pipeline);
        }
    }
}
