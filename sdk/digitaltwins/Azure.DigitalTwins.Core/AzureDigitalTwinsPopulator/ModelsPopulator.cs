// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using Azure;
using Azure.DigitalTwins.Core;

namespace AzureDigitalTwinsPopulator
{
    internal class ModelsPopulator
    {
        // Json folders and file paths
        private static readonly string s_dtdlDirectoryPath = Path.Combine(GetWorkingDirectory(), "DTDL");

        private static readonly string s_modelsPath = Path.Combine(s_dtdlDirectoryPath, "Models");

        private readonly string eventhubEndpointName;
        private readonly DigitalTwinsClient client;

        public ModelsPopulator(DigitalTwinsClient dtClient, string eventhubEndpointName)
        {
            this.eventhubEndpointName = eventhubEndpointName;
            client = dtClient;
        }

        public async Task RunPopulatorAsync()
        {
            // Delete existing models
            await DeleteAllModelsAsync();

            // Create all the models
            await AddAllModelsAsync();

            // Get all models
            await GetAllModelsAsync();
        }

        private async Task DeleteAllModelsAsync()
        {
            try
            {
                // This is to ensure models are deleted in an order such that no other models are referencing it
                var models = new Queue();
                models.Enqueue(SamplesConstants.RoomModelId);
                models.Enqueue(SamplesConstants.WifiModelId);
                models.Enqueue(SamplesConstants.BuildingModelId);
                models.Enqueue(SamplesConstants.FloorModelId);
                models.Enqueue(SamplesConstants.HvacModelId);

                foreach (string modelId in models)
                {
                    await client.DeleteModelAsync(modelId);
                    Console.WriteLine($"Deleted model '{modelId}'.");
                }
            }
            catch (RequestFailedException ex) when (ex.Status == (int)HttpStatusCode.NotFound)
            {
                // Model does not exist.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to delete models due to:\n{ex}");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Loads all the models found in the Models directory into memory and uses CreateModelsAsync API to create all the models in the ADT service instance
        /// </summary>
        private async Task AddAllModelsAsync()
        {
            List<string> modelsToCreate = FileHelper.LoadAllFilesInPath(s_modelsPath).Values.ToList();

            if (modelsToCreate == null || !modelsToCreate.Any())
            {
                throw new Exception("Could not load models from disk.");
            }

            try
            {
                await client.CreateModelsAsync(modelsToCreate);
                Console.WriteLine("Created models.");
            }
            catch (RequestFailedException ex) when (ex.Status == (int)HttpStatusCode.Conflict)
            {
                Console.WriteLine($"One or more models already exist. Continuing with the sample optimistically.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to create models due to:\n{ex}");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Gets all the models within the ADT service instance.
        /// </summary>
        public async Task GetAllModelsAsync()
        {
            try
            {
                // Get all the twin types
                AsyncPageable<DigitalTwinsModelData> allModels = client.GetModelsAsync();
                await foreach (DigitalTwinsModelData model in allModels)
                {
                    Console.WriteLine($"Retrieved model '{model.Id}', " +
                        $"display name '{model.DisplayName["en"]}', " +
                        $"upload time '{model.UploadTime}', " +
                        $"and decommissioned '{model.Decommissioned}'");
                }
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine($"Failed to list models due to:\n{ex}");
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
