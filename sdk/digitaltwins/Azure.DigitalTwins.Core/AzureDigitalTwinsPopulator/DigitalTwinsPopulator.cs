// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.DigitalTwins.Core;
using Azure.DigitalTwins.Core.Serialization;

namespace AzureDigitalTwinsPopulator
{
    internal class DigitalTwinsPopulator
    {
        // Json folders and file paths
        private static readonly string s_dtdlDirectoryPath = Path.Combine(GetWorkingDirectory(), "DTDL");

        private static readonly string s_modelsPath = Path.Combine(s_dtdlDirectoryPath, "Models");
        private static readonly string s_twinsPath = Path.Combine(s_dtdlDirectoryPath, "DigitalTwins");
        private static readonly string s_relationshipsPath = Path.Combine(s_dtdlDirectoryPath, "Relationships");

        private readonly string _eventRouteId = $"sampleEventRouteId-{Guid.NewGuid()}";

        private readonly string eventhubEndpointName;
        private readonly DigitalTwinsClient client;

        public DigitalTwinsPopulator(DigitalTwinsClient dtClient, string eventhubEndpointName)
        {
            this.eventhubEndpointName = eventhubEndpointName;
            client = dtClient;
        }

        /// <summary>
        /// Creates all Models in the Models folder
        /// Creates all DigitalTwins in the DigitalTwins folder
        /// Connects all DigitalTwins using relationships in the Relationships folder.
        /// </summary>
        public async Task RunPopulatorAsync()
        {
            // Ensure existing twins with the same name are deleted first
            await DeleteTwinsAsync();

            // Create twin counterparts for all the models
            await CreateAllTwinsAsync();

            // Get all twins
            await QueryTwinsAsync();
        }

        public async Task DeleteTwinsAsync()
        {
            Dictionary<string, string> twins = FileHelper.LoadAllFilesInPath(s_twinsPath);

            foreach (KeyValuePair<string, string> twin in twins)
            {
                BasicDigitalTwin[] currentTwins = JsonSerializer.Deserialize<BasicDigitalTwin[]>(twin.Value);
                foreach (BasicDigitalTwin currentTwin in currentTwins)
                {
                    try
                    {
                        //// Delete all relationships
                        //AsyncPageable<string> relationships = client.GetRelationshipsAsync(digitalTwinId);
                        //await foreach (var relationshipJson in relationships)
                        //{
                        //    BasicRelationship relationship = JsonSerializer.Deserialize<BasicRelationship>(relationshipJson);
                        //    await client.DeleteRelationshipAsync(digitalTwinId, relationship.Id);
                        //    Console.WriteLine($"Found and deleted relationship '{relationship.Id}'.");
                        //}

                        //// Delete any incoming relationships
                        //AsyncPageable<IncomingRelationship> incomingRelationships = client.GetIncomingRelationshipsAsync(digitalTwinId);

                        //await foreach (IncomingRelationship incomingRelationship in incomingRelationships)
                        //{
                        //    await client.DeleteRelationshipAsync(incomingRelationship.SourceId, incomingRelationship.RelationshipId);
                        //    Console.WriteLine($"Found and deleted incoming relationship '{incomingRelationship.RelationshipId}'.");
                        //}

                        // Now the digital twin should be safe to delete
                        await client.DeleteDigitalTwinAsync(currentTwin.Id);
                        Console.WriteLine($"Deleted digital twin '{currentTwin.Id}'.");
                    }
                    catch (RequestFailedException ex) when (ex.Status == (int)HttpStatusCode.NotFound)
                    {
                        // Digital twin or relationship does not exist
                    }
                    catch (RequestFailedException ex)
                    {
                        Console.WriteLine($"Failed to delete due to {ex.Message}");
                        Environment.Exit(0);
                    }
                }
            }
        }

        public async Task CreateAllTwinsAsync()
        {
            Dictionary<string, string> twins = FileHelper.LoadAllFilesInPath(s_twinsPath);

            // Call APIs to create the twins.
            foreach (KeyValuePair<string, string> twin in twins)
            {
                BasicDigitalTwin[] currentTwins = JsonSerializer.Deserialize<BasicDigitalTwin[]>(twin.Value);
                foreach (BasicDigitalTwin currentTwin in currentTwins)
                {
                    try
                    {
                        //BasicDigitalTwin basicDigitalTwin = JsonSerializer.Deserialize<BasicDigitalTwin>(twin.Value);
                        Response<BasicDigitalTwin> response = await client.CreateDigitalTwinAsync<BasicDigitalTwin>(currentTwin.Id, currentTwin);

                        Console.WriteLine($"Created digital twin '{twin.Key}'.");
                        Console.WriteLine($"\tBody: {JsonSerializer.Serialize(response?.Value)}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not create digital twin due to {ex}");
                        Environment.Exit(0);
                    }
                }
            }
        }

        public async Task QueryTwinsAsync()
        {
            try
            {
                Console.WriteLine("Making a twin query and iterating over the results.");

                // This code snippet demonstrates the simplest way to iterate over the digital twin results, where paging
                // happens under the covers.
                AsyncPageable<string> asyncPageableResponse = client.QueryAsync("SELECT * FROM digitaltwins");

                // Iterate over the twin instances in the pageable response.
                // The "await" keyword here is required because new pages will be fetched when necessary,
                // which involves a request to the service.
                await foreach (string response in asyncPageableResponse)
                {
                    BasicDigitalTwin twin = JsonSerializer.Deserialize<BasicDigitalTwin>(response);
                    Console.WriteLine($"Found digital twin '{twin.Id}'");
                }

                Console.WriteLine("Making a twin query, with query-charge header extraction.");

                // This code snippet demonstrates how you could extract the query charges incurred when calling
                // the query API. It iterates over the response pages first to access to the query-charge header,
                // and then the digital twin results within each page.

                AsyncPageable<string> asyncPageableResponseWithCharge = client.QueryAsync("SELECT * FROM digitaltwins");
                int pageNum = 0;

                // The "await" keyword here is required as a call is made when fetching a new page.
                await foreach (Page<string> page in asyncPageableResponseWithCharge.AsPages())
                {
                    Console.WriteLine($"Page {++pageNum} results:");

                    // Extract the query-charge header from the page
                    if (QueryChargeHelper.TryGetQueryCharge(page, out float queryCharge))
                    {
                        Console.WriteLine($"Query charge was: {queryCharge}");
                    }

                    // Iterate over the twin instances.
                    // The "await" keyword is not required here as the paged response is local.
                    foreach (string response in page.Values)
                    {
                        BasicDigitalTwin twin = JsonSerializer.Deserialize<BasicDigitalTwin>(response);
                        Console.WriteLine($"Found digital twin '{twin.Id}'");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not query digital twins due to {ex}");
                Environment.Exit(0);
            }
        }

        private static string GetWorkingDirectory()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }
    }
}
