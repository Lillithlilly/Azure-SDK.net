// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.Translation.Document.Models;

namespace Azure.AI.Translation.Document
{
    /// <summary> Source of the input documents. </summary>
    public partial class TranslationSource
    {
        /// <summary> Initializes a new instance of TranslationSource. </summary>
        /// <param name="sourceUri"> Location of the folder / container or single file with your documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceUri"/> is null. </exception>
        public TranslationSource(Uri sourceUri)
        {
            if (sourceUri == null)
            {
                throw new ArgumentNullException(nameof(sourceUri));
            }

            SourceUri = sourceUri;
        }
    }
}
