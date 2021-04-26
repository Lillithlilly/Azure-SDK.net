﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The data stored in JSON format. </summary>
    public partial class JsonFormat : DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of JsonFormat. </summary>
        public JsonFormat()
        {
            Type = "JsonFormat";
        }

        /// <summary> File pattern of JSON. To be more specific, the way of separating a collection of JSON objects. The default value is &apos;setOfObjects&apos;. It is case-sensitive. </summary>
        public JsonFormatFilePattern? FilePattern { get; set; }
        /// <summary> The character used to separate nesting levels. Default value is &apos;.&apos; (dot). Type: string (or Expression with resultType string). </summary>
        public object NestingSeparator { get; set; }
        /// <summary> The code page name of the preferred encoding. If not provided, the default value is &apos;utf-8&apos;, unless the byte order mark (BOM) denotes another Unicode encoding. The full list of supported values can be found in the &apos;Name&apos; column of the table of encodings in the following reference: https://go.microsoft.com/fwlink/?linkid=861078. Type: string (or Expression with resultType string). </summary>
        public object EncodingName { get; set; }
        /// <summary> The JSONPath of the JSON array element to be flattened. Example: &quot;$.ArrayPath&quot;. Type: string (or Expression with resultType string). </summary>
        public object JsonNodeReference { get; set; }
        /// <summary> The JSONPath definition for each column mapping with a customized column name to extract data from JSON file. For fields under root object, start with &quot;$&quot;; for fields inside the array chosen by jsonNodeReference property, start from the array element. Example: {&quot;Column1&quot;: &quot;$.Column1Path&quot;, &quot;Column2&quot;: &quot;Column2PathInArray&quot;}. Type: object (or Expression with resultType object). </summary>
        public object JsonPathDefinition { get; set; }
    }
}