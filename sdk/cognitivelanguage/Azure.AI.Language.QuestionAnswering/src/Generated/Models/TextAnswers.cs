// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering.Models
{
    /// <summary> Represents the answer results. </summary>
    public partial class TextAnswers
    {
        /// <summary> Initializes a new instance of TextAnswers. </summary>
        internal TextAnswers()
        {
            Answers = new ChangeTrackingList<TextAnswer>();
        }

        /// <summary> Initializes a new instance of TextAnswers. </summary>
        /// <param name="answers"> Represents the answer results. </param>
        internal TextAnswers(IReadOnlyList<TextAnswer> answers)
        {
            Answers = answers;
        }

        /// <summary> Represents the answer results. </summary>
        public IReadOnlyList<TextAnswer> Answers { get; }
    }
}