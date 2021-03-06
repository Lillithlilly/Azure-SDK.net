// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Rest.ClientRuntime.Azure.TestFramework
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Extensions to the TestEnvironment class.
    /// </summary>
    public static class TestEnvironmentExtensions
    {
        /// <summary>
        /// Gets the fully-qualified domain name suffix of an Azure Search service for the given test environment and service name.
        /// </summary>
        /// <param name="environment">The test environment.</param>
        /// <param name="searchServiceName">The name of the search service.</param>
        /// <returns>The fully-qualified domain name of the search service in the given environment.</returns>
        public static string GetSearchDnsSuffix(this TestEnvironment environment, string searchServiceName)
        {
            EnvironmentNames envName = LookupEnvironmentFromBaseUri(environment.BaseUri.AbsoluteUri);

            switch (envName)
            {
                case EnvironmentNames.Dogfood:
                    return "search-dogfood.windows-int.net";

                case EnvironmentNames.Next:
                    return "search-next.windows-int.net";

                case EnvironmentNames.Current:
                    return "search-current.windows-int.net";

                case EnvironmentNames.Prod:
                default:
                    // Assume PROD if all else fails.
                    return "search.windows.net";
            }
        }

        /// <summary>
        /// Gets the base URI of an Azure Search service for the given test environment and service name.
        /// </summary>
        /// <param name="environment">The test environment.</param>
        /// <param name="searchServiceName">The name of the search service.</param>
        /// <returns>The correct base URI of the search service in the given environment.</returns>
        public static Uri GetBaseSearchUri(this TestEnvironment environment, string searchServiceName)
        {
            const string UriFormat = "https://{0}.{1}/";
            string dnsSuffix = environment.GetSearchDnsSuffix(searchServiceName);
            return new Uri(String.Format(UriFormat, searchServiceName, dnsSuffix));
        }

        private static EnvironmentNames LookupEnvironmentFromBaseUri(string resourceManagementUri)
        {
            Dictionary<Uri, EnvironmentNames> envEndpoints = new Dictionary<Uri, EnvironmentNames>();

            envEndpoints.Add(
                new Uri("https://management.azure.com/"),
                EnvironmentNames.Prod);
            envEndpoints.Add(
                new Uri("https://api-dogfood.resources.windows-int.net/"),
                EnvironmentNames.Dogfood);
            envEndpoints.Add(
                new Uri("https://api-next.resources.windows-int.net/"),
                EnvironmentNames.Next);
            envEndpoints.Add(
                new Uri("https://api-current.resources.windows-int.net/"),
                EnvironmentNames.Current);

            foreach (Uri testUri in envEndpoints.Keys)
            {
                if (MatchEnvironmentBaseUri(testUri, resourceManagementUri))
                {
                    return envEndpoints[testUri];
                }
            }

            return EnvironmentNames.Prod;
        }

        private static bool MatchEnvironmentBaseUri(Uri testUri, string endpointValue)
        {
            endpointValue = EnsureTrailingSlash(endpointValue);
            return string.Equals(testUri.ToString(), endpointValue, StringComparison.OrdinalIgnoreCase);
        }

        private static string EnsureTrailingSlash(string uri)
        {
            if (uri.EndsWith("/"))
            {
                return uri;
            }

            return string.Format("{0}/", uri);
        }
    }
}
