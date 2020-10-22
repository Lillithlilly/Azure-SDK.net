using System;
using System.Threading.Tasks;
using Azure.DigitalTwins.Core;
using Azure.Identity;
using CommandLine;

namespace AzureDigitalTwinsPopulator
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            // Parse and validate paramters

            Options options = null;
            ParserResult<Options> result = Parser.Default.ParseArguments<Options>(args)
                .WithParsed(parsedOptions =>
                {
                    options = parsedOptions;
                })
                .WithNotParsed(errors =>
                {
                    Environment.Exit(1);
                });

            // Instantiate the client
            DigitalTwinsClient dtClient = GetDigitalTwinsClient(
                    options.TenantId,
                    options.ClientId,
                    options.ClientSecret,
                    options.AdtEndpoint);

            var modelsPopulator = new ModelsPopulator(dtClient, options.EventHubEndpointName);
            await modelsPopulator.RunPopulatorAsync();

            var twinsPopulator = new DigitalTwinsPopulator(dtClient, options.EventHubEndpointName);
            await twinsPopulator.RunPopulatorAsync();
        }

        private static DigitalTwinsClient GetDigitalTwinsClient(string tenantId, string clientId, string clientSecret, string adtEndpoint)
        {
            // These environment variables are necessary for DefaultAzureCredential to use application Id and client secret to login.
            Environment.SetEnvironmentVariable("AZURE_CLIENT_SECRET", clientSecret);
            Environment.SetEnvironmentVariable("AZURE_CLIENT_ID", clientId);
            Environment.SetEnvironmentVariable("AZURE_TENANT_ID", tenantId);

            // DefaultAzureCredential supports different authentication mechanisms and determines the appropriate credential type based of the environment it is executing in.
            // It attempts to use multiple credential types in an order until it finds a working credential.
            var tokenCredential = new DefaultAzureCredential();

            var client = new DigitalTwinsClient(
                new Uri(adtEndpoint),
                tokenCredential);

            return client;
        }
    }
}
