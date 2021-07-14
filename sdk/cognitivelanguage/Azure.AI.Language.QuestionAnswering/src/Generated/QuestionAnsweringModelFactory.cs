// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.QuestionAnswering.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class QuestionAnsweringModelFactory
    {
        /// <summary> Initializes a new instance of KnowledgebaseAnswers. </summary>
        /// <param name="answers"> Represents Answer Result list. </param>
        /// <returns> A new <see cref="Models.KnowledgebaseAnswers"/> instance for mocking. </returns>
        public static KnowledgebaseAnswers KnowledgebaseAnswers(IEnumerable<KnowledgebaseAnswer> answers = null)
        {
            answers ??= new List<KnowledgebaseAnswer>();

            return new KnowledgebaseAnswers(answers?.ToList());
        }

        /// <summary> Initializes a new instance of KnowledgebaseAnswer. </summary>
        /// <param name="questions"> List of questions. </param>
        /// <param name="answer"> The Answer. </param>
        /// <param name="confidenceScore"> Answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="id"> ID of the QnA result. </param>
        /// <param name="source"> Source of QnA result. </param>
        /// <param name="metadata"> Metadata associated with the answer, useful to categorize or filter question answers. </param>
        /// <param name="dialog"> Dialog associated with Answer. </param>
        /// <param name="answerSpan"> Answer span object of QnA with respect to user&apos;s question. </param>
        /// <returns> A new <see cref="Models.KnowledgebaseAnswer"/> instance for mocking. </returns>
        public static KnowledgebaseAnswer KnowledgebaseAnswer(IEnumerable<string> questions = null, string answer = null, double? confidenceScore = null, int? id = null, string source = null, IReadOnlyDictionary<string, string> metadata = null, KnowledgebaseAnswerDialog dialog = null, AnswerSpan answerSpan = null)
        {
            questions ??= new List<string>();
            metadata ??= new Dictionary<string, string>();

            return new KnowledgebaseAnswer(questions?.ToList(), answer, confidenceScore, id, source, metadata, dialog, answerSpan);
        }

        /// <summary> Initializes a new instance of KnowledgebaseAnswerDialog. </summary>
        /// <param name="isContextOnly"> To mark if a prompt is relevant only with a previous question or not. If true, do not include this QnA as search result for queries without context; otherwise, if false, ignores context and includes this QnA in search result. </param>
        /// <param name="prompts"> List of 0 to 20 prompts associated with the answer. </param>
        /// <returns> A new <see cref="Models.KnowledgebaseAnswerDialog"/> instance for mocking. </returns>
        public static KnowledgebaseAnswerDialog KnowledgebaseAnswerDialog(bool? isContextOnly = null, IEnumerable<KnowledgebaseAnswerPrompt> prompts = null)
        {
            prompts ??= new List<KnowledgebaseAnswerPrompt>();

            return new KnowledgebaseAnswerDialog(isContextOnly, prompts?.ToList());
        }

        /// <summary> Initializes a new instance of KnowledgebaseAnswerPrompt. </summary>
        /// <param name="displayOrder"> Index of the prompt - used in ordering of the prompts. </param>
        /// <param name="qnaId"> QnA ID corresponding to the prompt. </param>
        /// <param name="displayText"> Text displayed to represent a follow up question prompt. </param>
        /// <returns> A new <see cref="Models.KnowledgebaseAnswerPrompt"/> instance for mocking. </returns>
        public static KnowledgebaseAnswerPrompt KnowledgebaseAnswerPrompt(int? displayOrder = null, int? qnaId = null, string displayText = null)
        {
            return new KnowledgebaseAnswerPrompt(displayOrder, qnaId, displayText);
        }

        /// <summary> Initializes a new instance of AnswerSpan. </summary>
        /// <param name="text"> Predicted text of answer span. </param>
        /// <param name="confidenceScore"> Predicted score of answer span, value ranges from 0 to 1. </param>
        /// <param name="offset"> The answer span offset from the start of answer. </param>
        /// <param name="length"> The length of the answer span. </param>
        /// <returns> A new <see cref="Models.AnswerSpan"/> instance for mocking. </returns>
        public static AnswerSpan AnswerSpan(string text = null, double? confidenceScore = null, int? offset = null, int? length = null)
        {
            return new AnswerSpan(text, confidenceScore, offset, length);
        }

        /// <summary> Initializes a new instance of TextAnswers. </summary>
        /// <param name="answers"> Represents the answer results. </param>
        /// <returns> A new <see cref="Models.TextAnswers"/> instance for mocking. </returns>
        public static TextAnswers TextAnswers(IEnumerable<TextAnswer> answers = null)
        {
            answers ??= new List<TextAnswer>();

            return new TextAnswers(answers?.ToList());
        }

        /// <summary> Initializes a new instance of TextAnswer. </summary>
        /// <param name="answer"> Answer. </param>
        /// <param name="confidenceScore"> answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="id"> record ID. </param>
        /// <param name="answerSpan"> Answer span object with respect to user&apos;s question. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <returns> A new <see cref="Models.TextAnswer"/> instance for mocking. </returns>
        public static TextAnswer TextAnswer(string answer = null, double? confidenceScore = null, string id = null, AnswerSpan answerSpan = null, int? offset = null, int? length = null)
        {
            return new TextAnswer(answer, confidenceScore, id, answerSpan, offset, length);
        }
    }
}