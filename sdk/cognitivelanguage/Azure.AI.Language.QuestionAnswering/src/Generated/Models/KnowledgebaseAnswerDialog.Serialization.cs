// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering.Models
{
    public partial class KnowledgebaseAnswerDialog
    {
        internal static KnowledgebaseAnswerDialog DeserializeKnowledgebaseAnswerDialog(JsonElement element)
        {
            Optional<bool> isContextOnly = default;
            Optional<IReadOnlyList<KnowledgebaseAnswerPrompt>> prompts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isContextOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isContextOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("prompts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnowledgebaseAnswerPrompt> array = new List<KnowledgebaseAnswerPrompt>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgebaseAnswerPrompt.DeserializeKnowledgebaseAnswerPrompt(item));
                    }
                    prompts = array;
                    continue;
                }
            }
            return new KnowledgebaseAnswerDialog(Optional.ToNullable(isContextOnly), Optional.ToList(prompts));
        }
    }
}