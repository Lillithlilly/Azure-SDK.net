﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public class JobScheduleHeaders : BaseHeaders
    {
        public JobScheduleHeaders() : base()
        {
        }

        public JobScheduleHeaders(Response response) : base(response)
        {
        }
    }
}
