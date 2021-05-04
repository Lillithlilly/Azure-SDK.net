// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.Translation.Document.Models;

namespace Azure.AI.Translation.Document
{
    /// <summary> Job status response. </summary>
    public partial class TranslationStatusResult
    {
        /// <summary> Initializes a new instance of TranslationStatusResult. </summary>
        /// <param name="translationId"> Id of the operation. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="summary"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="translationId"/> or <paramref name="summary"/> is null. </exception>
        internal TranslationStatusResult(string translationId, DateTimeOffset createdOn, DateTimeOffset lastModified, TranslationStatus status, StatusSummary summary)
        {
            if (translationId == null)
            {
                throw new ArgumentNullException(nameof(translationId));
            }
            if (summary == null)
            {
                throw new ArgumentNullException(nameof(summary));
            }

            TranslationId = translationId;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Status = status;
            Summary = summary;
        }

        /// <summary> Initializes a new instance of TranslationStatusResult. </summary>
        /// <param name="translationId"> Id of the operation. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="error"> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </param>
        /// <param name="summary"> . </param>
        internal TranslationStatusResult(string translationId, DateTimeOffset createdOn, DateTimeOffset lastModified, TranslationStatus status, DocumentTranslationError error, StatusSummary summary)
        {
            TranslationId = translationId;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Status = status;
            Error = error;
            Summary = summary;
        }
        /// <summary> List of possible statuses for job or document. </summary>
        public TranslationStatus Status { get; }
        /// <summary> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </summary>
        public DocumentTranslationError Error { get; }
    }
}