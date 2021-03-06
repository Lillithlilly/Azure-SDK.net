// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Azure Blob Storage content. </summary>
    internal partial class AzureBlobContentSource
    {
        /// <summary> Initializes a new instance of AzureBlobContentSource. </summary>
        /// <param name="containerUrl"> Azure Blob Storage container URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerUrl"/> is null. </exception>
        public AzureBlobContentSource(string containerUrl)
        {
            if (containerUrl == null)
            {
                throw new ArgumentNullException(nameof(containerUrl));
            }

            ContainerUrl = containerUrl;
        }

        /// <summary> Azure Blob Storage container URL. </summary>
        public string ContainerUrl { get; }
        /// <summary> Blob name prefix. </summary>
        public string Prefix { get; set; }
    }
}
