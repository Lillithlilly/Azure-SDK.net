// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Batch.Jobs
{
    public static class BatchServiceClientExtensions
    {
        public static BatchJobClient CreateJobClient(this BatchServiceClient serviceClient)
        {
            return new BatchJobClient(serviceClient.EndPoint, serviceClient.Pipeline);
        }
    }
}
