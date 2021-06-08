// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DataMasking
    {
        /// <summary>
        /// Initializes a new instance of the DataMasking class.
        /// </summary>
        public DataMasking()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataMasking class.
        /// </summary>
        /// <param name="queryParams">Masking settings for Url query
        /// parameters</param>
        /// <param name="headers">Masking settings for headers</param>
        public DataMasking(IList<DataMaskingEntity> queryParams = default(IList<DataMaskingEntity>), IList<DataMaskingEntity> headers = default(IList<DataMaskingEntity>))
        {
            QueryParams = queryParams;
            Headers = headers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets masking settings for Url query parameters
        /// </summary>
        [JsonProperty(PropertyName = "queryParams")]
        public IList<DataMaskingEntity> QueryParams { get; set; }

        /// <summary>
        /// Gets or sets masking settings for headers
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IList<DataMaskingEntity> Headers { get; set; }

    }
}