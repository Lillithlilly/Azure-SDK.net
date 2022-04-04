// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.Data.Batch.Models;

namespace Azure.Data.Batch
{
    public partial class JobScheduleClient
    {
        public virtual Response<JobSchedule> GetJobSchedule(string jobScheduleId)
        {
            Response response = GetJobSchedule(jobScheduleId, context: new RequestContext());
            var j = JsonDocument.Parse(response.Content).RootElement;
            JobSchedule jobSchedule = JobSchedule.DeserializeJobSchedule(j);
            return Response.FromValue(jobSchedule, response);
        }

        public virtual Response<JobScheduleHeaders> AddJobSchedule(JobSchedule jobSchedule)
        {
            RequestContent content = ModelHelpers.ToRequestContent(jobSchedule);
            Response response = Add(content);
            JobScheduleHeaders headers = new JobScheduleHeaders(response);
            return Response.FromValue(headers, response);
        }

        public virtual Response<JobScheduleHeaders> UpdateJobSchedule(JobSchedule jobSchedule)
        {
            RequestContent content = ModelHelpers.ToRequestContent(jobSchedule);
            Response response = Update(jobSchedule.Id, content);
            JobScheduleHeaders headers = new JobScheduleHeaders(response);
            return Response.FromValue(headers, response);
        }

        public virtual Response<JobScheduleHeaders> PatchJobSchedule(string jobScheduleId, Schedule schedule = null, JobSpecification specification = null)
        {
            JobScheduleUpdate update = new JobScheduleUpdate();
            update.Schedule = schedule;
            update.JobSpecification = specification;

            RequestContent content = ModelHelpers.ToRequestContent(update);
            Response response = Patch(jobScheduleId, content);
            JobScheduleHeaders headers = new JobScheduleHeaders(response);
            return Response.FromValue(headers, response);
        }

        public virtual Response<JobScheduleHeaders> DeleteJobSchedule(string jobScheduleId)
        {
            Response response = Delete(jobScheduleId);
            JobScheduleHeaders headers = new JobScheduleHeaders(response);
            return Response.FromValue(headers, response);
        }
    }
}
