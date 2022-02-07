// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Tests
{
    [ClientTestFixture(
    TextAnalyticsClientOptions.ServiceVersion.V3_1,
    TextAnalyticsClientOptions.ServiceVersion.V3_2_Preview_2)]
    public class AnalyzeOperationTests : TextAnalyticsClientLiveTestBase
    {
        public AnalyzeOperationTests(bool isAsync, TextAnalyticsClientOptions.ServiceVersion serviceVersion)
            : base(isAsync, serviceVersion)
        {
        }

        private static List<string> batchConvenienceDocuments = new List<string>
        {
            "Elon Musk is the CEO of SpaceX and Tesla.",
            "Tesla stock is up by 400% this year."
        };

        private static List<TextDocumentInput> batchDocuments = new List<TextDocumentInput>
        {
            new TextDocumentInput("1", "Elon Musk is the CEO of SpaceX and Tesla.")
            {
                 Language = "en",
            },
            new TextDocumentInput("2", "Tesla stock is up by 400% this year.")
            {
                 Language = "en",
            }
        };

        [RecordedTest]
        public async Task AnalyzeOperationWithPHIDomain()
        {
            TextAnalyticsClient client = GetClient();

            var documents = new List<string>
            {
                "A patient with medical id 12345678 whose phone number is 800-102-1100 is going under heart surgery",
            };

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                RecognizePiiEntitiesActions = new List<RecognizePiiEntitiesAction>() { new RecognizePiiEntitiesAction() { DomainFilter = PiiEntityDomain.ProtectedHealthInformation } },
                DisplayName = "AnalyzeOperationWithPHIDomain",
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(documents, batchActions, "en");

            await operation.WaitForCompletionAsync();

            //Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            IReadOnlyCollection<RecognizePiiEntitiesActionResult> piiActionsResults = resultCollection.RecognizePiiEntitiesResults;

            Assert.IsNotNull(piiActionsResults);

            RecognizePiiEntitiesResultCollection piiDocumentsResults = piiActionsResults.FirstOrDefault().DocumentsResults;
            Assert.AreEqual(1, piiDocumentsResults.Count);

            Assert.IsNotEmpty(piiDocumentsResults[0].Entities.RedactedText);

            Assert.IsFalse(piiDocumentsResults[0].HasError);
            Assert.AreEqual(2, piiDocumentsResults[0].Entities.Count);
        }
    }
}
