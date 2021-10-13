// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Indexes.Models;
using Azure.Search.Documents.Models;
using NUnit.Framework;

namespace Azure.Search.Documents.Tests.Models
{
    [ClientTestFixture(SearchClientOptions.ServiceVersion.V2021_04_30_Preview)]
    public sealed class SkillTests : SearchTestBase
    {
        public SkillTests(bool async, SearchClientOptions.ServiceVersion serviceVersion)
            : base(async, serviceVersion, RecordedTestMode.Live /* to re-record */)
        {
        }

        [Test]
        public async Task EntityRecognition()
        {
            await using SearchResources resources = await SearchResources.CreateWithBlobStorageAndIndexAsync(this, true); // CreateWithHotelsIndexAsync(this);

            // Skills based on https://github.com/Azure-Samples/azure-search-sample-data/blob/master/hotelreviews/HotelReviews_skillset.json.
            var entityRecognitionSkill = new EntityRecognitionSkill(
                new[]
                {
                    new InputFieldMappingEntry("text") { Source = "/document/content" },
                    // new InputFieldMappingEntry("languageCode") { Source = "/document/Language" },
                },
                new[]
                {
                    new OutputFieldMappingEntry("locations") { TargetName = "places" },
                    new OutputFieldMappingEntry("emails"),
                })
            {
                Context = "/document",
                // Categories = new List<EntityCategory>() { "Person", "Email" },
                // DefaultLanguageCode = EntityRecognitionSkillLanguage.En,
                // MinimumPrecision = 0,
            };

            entityRecognitionSkill.Categories.Add(EntityCategory.Location);
            entityRecognitionSkill.Categories.Add(EntityCategory.Email);

            SearchIndexerSkillset skillset = new(Recording.Random.GetName(), new[] { entityRecognitionSkill })
            {
                CognitiveServicesAccount = new DefaultCognitiveServicesAccount(),
                KnowledgeStore = new KnowledgeStore(resources.StorageAccountConnectionString,new List<KnowledgeStoreProjection>()),
            };

            SearchIndexerClient client = resources.GetIndexerClient(new SearchClientOptions(ServiceVersion));

            skillset = await client.CreateSkillsetAsync(skillset);

            SearchIndexerDataSourceConnection dataSource = new(
                Recording.Random.GetName(),
                SearchIndexerDataSourceType.AzureBlob,
                resources.StorageAccountConnectionString,
                new SearchIndexerDataContainer(resources.BlobContainerName));
            dataSource = await client.CreateDataSourceConnectionAsync(dataSource);

            SearchIndexer indexer = new(Recording.Random.GetName(), dataSource.Name, resources.IndexName);
            await client.CreateIndexerAsync(indexer);
            await WaitForIndexingAsync(client, indexer.Name);

            await client.RunIndexerAsync(indexer.Name);
            await WaitForIndexingAsync(client, indexer.Name);

            SearchOptions searchOptions = new();
            searchOptions.IncludeTotalCount = true;

            SearchClient searchClient = resources.GetSearchClient();
            SearchResults<Hotel> searchResults = (await searchClient.SearchAsync<Hotel>("*", searchOptions)).Value;

            await foreach (SearchResult<Hotel> _ in searchResults.GetResultsAsync())
            {
            }

            // Assert.AreEqual(2, searchResults.TotalCount);

            // await TestSkillsetAsync(client, skillset, createdSkillset, skillsetName);
        }

        [Test]
        public async Task SentimentSkill()
        {
            await using SearchResources resources = await SearchResources.CreateWithBlobStorageAndIndexAsync(this, true);

            var searchIndex = (await resources.GetIndexClient().GetIndexAsync(resources.IndexName)).Value;

            searchIndex.Fields.Add(
                new SimpleField("Sentiment", SearchFieldDataType.String) { IsFilterable = true, IsSortable = true });
            await resources.GetIndexClient().CreateOrUpdateIndexAsync(searchIndex);

            SearchIndexerClient searchIndexerClient = resources.GetIndexerClient(new SearchClientOptions(ServiceVersion));
            string skillsetName = Recording.Random.GetName();

            SentimentSkill sentimentSkill = new(
                new[]
                {
                    new InputFieldMappingEntry("text") { Source = "/document/content" },
                },
                new[]
                {
                    new OutputFieldMappingEntry("sentiment") { TargetName = "sentiment" },
                    new OutputFieldMappingEntry("confidenceScores") { TargetName = "confidenceScores" },
                    new OutputFieldMappingEntry("sentences") { TargetName = "sentences" },
                },
                Indexes.Models.SentimentSkill.SkillVersion.V3)
            {
                IncludeOpinionMining = true
            };

            //KnowledgeStoreObjectProjectionSelector sentimentProjectionSelector = new(resources.BlobContainerName);
            //sentimentProjectionSelector.Source = "/document/sentiment";
            //sentimentProjectionSelector.GeneratedKeyName = "/document/sentiment2";

            //KnowledgeStoreObjectProjectionSelector confidenceScoreProjectionSelector = new(resources.BlobContainerName);
            //confidenceScoreProjectionSelector.Source = "/document/ConfidenceScores";
            //confidenceScoreProjectionSelector.GeneratedKeyName = "/document/ConfidenceScores2";

            //KnowledgeStoreObjectProjectionSelector sentencesProjectionSelector = new(resources.BlobContainerName);
            //sentencesProjectionSelector.Source = "/document/Sentences";
            //sentencesProjectionSelector.GeneratedKeyName = "/document/Sentences2";

            //KnowledgeStoreProjection projection = new();
            //projection.Objects.Add(sentimentProjectionSelector);
            //projection.Objects.Add(confidenceScoreProjectionSelector);
            //projection.Objects.Add(sentencesProjectionSelector);

            KnowledgeStore knowledgeStore = new(resources.StorageAccountConnectionString, new List<KnowledgeStoreProjection>());
            //knowledgeStore.Projections.Add(projection);

            SearchIndexerSkillset skillset = new(skillsetName, new[] { sentimentSkill })
            {
                CognitiveServicesAccount = new DefaultCognitiveServicesAccount(),
                KnowledgeStore = knowledgeStore,
            };
            skillset = await searchIndexerClient.CreateSkillsetAsync(skillset);

            SearchIndexerDataSourceConnection dataSource = new(
                Recording.Random.GetName(),
                SearchIndexerDataSourceType.AzureBlob,
                resources.StorageAccountConnectionString,
                new SearchIndexerDataContainer(resources.BlobContainerName));
            dataSource = await searchIndexerClient.CreateDataSourceConnectionAsync(dataSource);

            SearchIndexer indexer = new(Recording.Random.GetName(), dataSource.Name, resources.IndexName);
            indexer.OutputFieldMappings.Add(new FieldMapping("/document/sentiment") { TargetFieldName = "Sentiment" });

            await searchIndexerClient.CreateIndexerAsync(indexer);
            await WaitForIndexingAsync(searchIndexerClient, indexer.Name);

            //await searchIndexerClient.RunIndexerAsync(indexer.Name);
            //await WaitForIndexingAsync(searchIndexerClient, indexer.Name);

            SearchOptions searchOptions = new();
            searchOptions.IncludeTotalCount = true;

            SearchClient searchClient = resources.GetSearchClient();
            SearchResults<SearchDocument> searchResults = await searchClient.SearchAsync<SearchDocument>("*", searchOptions);

            await foreach (SearchResult<SearchDocument> result in searchResults.GetResultsAsync())
            {
                SearchDocument hotel = result.Document;

                //Console.WriteLine($"{hotel.HotelName} ({hotel.HotelId})");
                //Console.WriteLine($"  Sentiment: {hotel[]}");
            }
        }
    }
}
