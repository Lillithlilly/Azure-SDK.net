﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.Data.Batch.Models;

namespace Azure.Data.Batch
{
    public abstract class BaseClient
    {
        private Response<T> HandleResponse<T>(Response response, Func<JsonElement, T> deserialize)
        {
            T model = deserialize(JsonDocument.Parse(response.Content).RootElement);
            return Response.FromValue(model, response);
        }

        protected internal Response<T> HandleGet<T>(string id, Func<string, string, string, int?, Guid?, bool?, DateTimeOffset?, RequestConditions, RequestContext, Response> operation, Func<JsonElement, T> deserialize)
        {
            Response response = operation(id, null, null, null, null, null, null, null, null);
            return HandleResponse(response, deserialize);
        }

        protected internal async System.Threading.Tasks.Task<Response<T>> HandleGetAsync<T>(string id, Func<string, string, string, int?, Guid?, bool?, DateTimeOffset?, RequestConditions, RequestContext, System.Threading.Tasks.Task<Response>> operation, Func<JsonElement, T> deserialize)
        {
            Response response = await operation(id, null, null, null, null, null, null, null, null).ConfigureAwait(false);
            return HandleResponse(response, deserialize);
        }

        private Response<T> HandleResponse<T>(Response response) where T : BaseHeaders, new()
        {
            T headers = new();
            headers.Response = response;
            return Response.FromValue(headers, response);
        }

        protected Response<T> HandleAdd<T>(object contentObj, Func<RequestContent, int?, Guid?, bool?, DateTimeOffset?, RequestContext, Response> add) where T : BaseHeaders, new()
        {
            RequestContent content = ModelHelpers.ToRequestContent(contentObj);
            Response response = add(content, null, null, null, null, null);
            return HandleResponse<T>(response);
        }

        protected async System.Threading.Tasks.Task<Response<T>> HandleAddAsync<T>(object contentObj, Func<RequestContent, int?, Guid?, bool?, DateTimeOffset?, RequestContext, System.Threading.Tasks.Task<Response>> add) where T : BaseHeaders, new()
        {
            RequestContent content = ModelHelpers.ToRequestContent(contentObj);
            Response response = await add(content, null, null, null, null, null).ConfigureAwait(false);
            return HandleResponse<T>(response);
        }

        protected Response<T> HandleUpdate<T>(string id, object contentObj, Func<string, RequestContent, int?, Guid?, bool?, DateTimeOffset?, RequestConditions, RequestContext, Response> update) where T : BaseHeaders, new()
        {
            RequestContent content = ModelHelpers.ToRequestContent(contentObj);
            Response response = update(id, content, null, null, null, null, null, null);
            return HandleResponse<T>(response);
        }

        protected async System.Threading.Tasks.Task<Response<T>> HandleUpdateAsync<T>(string id, object contentObj, Func<string, RequestContent, int?, Guid?, bool?, DateTimeOffset?, RequestConditions, RequestContext, System.Threading.Tasks.Task<Response>> update) where T : BaseHeaders, new()
        {
            RequestContent content = ModelHelpers.ToRequestContent(contentObj);
            Response response = await update(id, content, null, null, null, null, null, null).ConfigureAwait(false);
            return HandleResponse<T>(response);
        }

        protected Response<T> HandlePatch<T>(string id, object contentObj, Func<string, RequestContent, int?, Guid?, bool?, DateTimeOffset?, RequestConditions, RequestContext, Response> patch) where T : BaseHeaders, new()
        {
            RequestContent content = ModelHelpers.ToRequestContent(contentObj);
            Response response = patch(id, content, null, null, null, null, null, null);
            return HandleResponse<T>(response);
        }

        protected async System.Threading.Tasks.Task<Response<T>> HandlePatchAsync<T>(string id, object contentObj, Func<string, RequestContent, int?, Guid?, bool?, DateTimeOffset?, RequestConditions, RequestContext, System.Threading.Tasks.Task<Response>> patch) where T : BaseHeaders, new()
        {
            RequestContent content = ModelHelpers.ToRequestContent(contentObj);
            Response response = await patch(id, content, null, null, null, null, null, null).ConfigureAwait(false);
            return HandleResponse<T>(response);
        }

        protected Response<T> HandleDelete<T>(string id, Func<string, int?, Guid?, bool?, DateTimeOffset?, RequestConditions, RequestContext, Response> delete) where T : BaseHeaders, new()
        {
            Response response = delete(id, null, null, null, null, null, null);
            return HandleResponse<T>(response);
        }

        protected async System.Threading.Tasks.Task<Response<T>> HandleDeleteAsync<T>(string id, Func<string, int?, Guid?, bool?, DateTimeOffset?, RequestConditions, RequestContext, System.Threading.Tasks.Task<Response>> delete) where T : BaseHeaders, new()
        {
            Response response = await delete(id, null, null, null, null, null, null).ConfigureAwait(false);
            return HandleResponse<T>(response);
        }
    }
}
