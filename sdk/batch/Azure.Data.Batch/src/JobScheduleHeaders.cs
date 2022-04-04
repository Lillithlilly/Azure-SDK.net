// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public class JobScheduleHeaders
    {
        private readonly Response _response;
        public JobScheduleHeaders(Response response)
        {
            _response = response;
        }
        public Guid? ClientRequestId => _response.Headers.TryGetValue("client-request-id", out Guid? value) ? value : null;
        public Guid? RequestId => _response.Headers.TryGetValue("request-id", out Guid? value) ? value : null;
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        public string DataServiceId => _response.Headers.TryGetValue("DataServiceId", out string value) ? value : null;
    }
}
