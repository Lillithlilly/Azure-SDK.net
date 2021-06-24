// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary> The Invoices service client. </summary>
    public partial class InvoicesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal InvoicesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of InvoicesOperations for mocking. </summary>
        protected InvoicesOperations()
        {
        }

        /// <summary> Initializes a new instance of InvoicesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID that uniquely identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal InvoicesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new InvoicesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets an invoice by billing account name and ID. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Invoice>> GetAsync(string billingAccountName, string invoiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(billingAccountName, invoiceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an invoice by billing account name and ID. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Invoice> Get(string billingAccountName, string invoiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(billingAccountName, invoiceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an invoice by ID. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Invoice>> GetByIdAsync(string invoiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.GetById");
            scope.Start();
            try
            {
                return await RestClient.GetByIdAsync(invoiceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an invoice by ID. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Invoice> GetById(string invoiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.GetById");
            scope.Start();
            try
            {
                return RestClient.GetById(invoiceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an invoice by subscription ID and invoice ID. </summary>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Invoice>> GetBySubscriptionAndInvoiceIdAsync(string invoiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.GetBySubscriptionAndInvoiceId");
            scope.Start();
            try
            {
                return await RestClient.GetBySubscriptionAndInvoiceIdAsync(invoiceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an invoice by subscription ID and invoice ID. </summary>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Invoice> GetBySubscriptionAndInvoiceId(string invoiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.GetBySubscriptionAndInvoiceId");
            scope.Start();
            try
            {
                return RestClient.GetBySubscriptionAndInvoiceId(invoiceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the invoices for a billing account for a given start date and end date. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="periodStartDate"> The start date to fetch the invoices. The date should be specified in MM-DD-YYYY format. </param>
        /// <param name="periodEndDate"> The end date to fetch the invoices. The date should be specified in MM-DD-YYYY format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="periodStartDate"/>, or <paramref name="periodEndDate"/> is null. </exception>
        public virtual AsyncPageable<Invoice> ListByBillingAccountAsync(string billingAccountName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (periodStartDate == null)
            {
                throw new ArgumentNullException(nameof(periodStartDate));
            }
            if (periodEndDate == null)
            {
                throw new ArgumentNullException(nameof(periodEndDate));
            }

            async Task<Page<Invoice>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingAccount");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByBillingAccountAsync(billingAccountName, periodStartDate, periodEndDate, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Invoice>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingAccount");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByBillingAccountNextPageAsync(nextLink, billingAccountName, periodStartDate, periodEndDate, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the invoices for a billing account for a given start date and end date. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="periodStartDate"> The start date to fetch the invoices. The date should be specified in MM-DD-YYYY format. </param>
        /// <param name="periodEndDate"> The end date to fetch the invoices. The date should be specified in MM-DD-YYYY format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="periodStartDate"/>, or <paramref name="periodEndDate"/> is null. </exception>
        public virtual Pageable<Invoice> ListByBillingAccount(string billingAccountName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (periodStartDate == null)
            {
                throw new ArgumentNullException(nameof(periodStartDate));
            }
            if (periodEndDate == null)
            {
                throw new ArgumentNullException(nameof(periodEndDate));
            }

            Page<Invoice> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingAccount");
                scope.Start();
                try
                {
                    var response = RestClient.ListByBillingAccount(billingAccountName, periodStartDate, periodEndDate, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Invoice> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingAccount");
                scope.Start();
                try
                {
                    var response = RestClient.ListByBillingAccountNextPage(nextLink, billingAccountName, periodStartDate, periodEndDate, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the invoices for a billing profile for a given start date and end date. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="periodStartDate"> The start date to fetch the invoices. The date should be specified in MM-DD-YYYY format. </param>
        /// <param name="periodEndDate"> The end date to fetch the invoices. The date should be specified in MM-DD-YYYY format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="billingProfileName"/>, <paramref name="periodStartDate"/>, or <paramref name="periodEndDate"/> is null. </exception>
        public virtual AsyncPageable<Invoice> ListByBillingProfileAsync(string billingAccountName, string billingProfileName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (billingProfileName == null)
            {
                throw new ArgumentNullException(nameof(billingProfileName));
            }
            if (periodStartDate == null)
            {
                throw new ArgumentNullException(nameof(periodStartDate));
            }
            if (periodEndDate == null)
            {
                throw new ArgumentNullException(nameof(periodEndDate));
            }

            async Task<Page<Invoice>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingProfile");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByBillingProfileAsync(billingAccountName, billingProfileName, periodStartDate, periodEndDate, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Invoice>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingProfile");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByBillingProfileNextPageAsync(nextLink, billingAccountName, billingProfileName, periodStartDate, periodEndDate, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the invoices for a billing profile for a given start date and end date. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="periodStartDate"> The start date to fetch the invoices. The date should be specified in MM-DD-YYYY format. </param>
        /// <param name="periodEndDate"> The end date to fetch the invoices. The date should be specified in MM-DD-YYYY format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="billingProfileName"/>, <paramref name="periodStartDate"/>, or <paramref name="periodEndDate"/> is null. </exception>
        public virtual Pageable<Invoice> ListByBillingProfile(string billingAccountName, string billingProfileName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (billingProfileName == null)
            {
                throw new ArgumentNullException(nameof(billingProfileName));
            }
            if (periodStartDate == null)
            {
                throw new ArgumentNullException(nameof(periodStartDate));
            }
            if (periodEndDate == null)
            {
                throw new ArgumentNullException(nameof(periodEndDate));
            }

            Page<Invoice> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingProfile");
                scope.Start();
                try
                {
                    var response = RestClient.ListByBillingProfile(billingAccountName, billingProfileName, periodStartDate, periodEndDate, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Invoice> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingProfile");
                scope.Start();
                try
                {
                    var response = RestClient.ListByBillingProfileNextPage(nextLink, billingAccountName, billingProfileName, periodStartDate, periodEndDate, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the invoices for a subscription. </summary>
        /// <param name="periodStartDate"> Invoice period start date. </param>
        /// <param name="periodEndDate"> Invoice period end date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="periodStartDate"/> or <paramref name="periodEndDate"/> is null. </exception>
        public virtual AsyncPageable<Invoice> ListByBillingSubscriptionAsync(string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default)
        {
            if (periodStartDate == null)
            {
                throw new ArgumentNullException(nameof(periodStartDate));
            }
            if (periodEndDate == null)
            {
                throw new ArgumentNullException(nameof(periodEndDate));
            }

            async Task<Page<Invoice>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingSubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByBillingSubscriptionAsync(periodStartDate, periodEndDate, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Invoice>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingSubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByBillingSubscriptionNextPageAsync(nextLink, periodStartDate, periodEndDate, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the invoices for a subscription. </summary>
        /// <param name="periodStartDate"> Invoice period start date. </param>
        /// <param name="periodEndDate"> Invoice period end date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="periodStartDate"/> or <paramref name="periodEndDate"/> is null. </exception>
        public virtual Pageable<Invoice> ListByBillingSubscription(string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default)
        {
            if (periodStartDate == null)
            {
                throw new ArgumentNullException(nameof(periodStartDate));
            }
            if (periodEndDate == null)
            {
                throw new ArgumentNullException(nameof(periodEndDate));
            }

            Page<Invoice> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingSubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListByBillingSubscription(periodStartDate, periodEndDate, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Invoice> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.ListByBillingSubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListByBillingSubscriptionNextPage(nextLink, periodStartDate, periodEndDate, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a URL to download an invoice. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="downloadToken"> Download token with document source and document ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="invoiceName"/>, or <paramref name="downloadToken"/> is null. </exception>
        public virtual async Task<InvoicesDownloadInvoiceOperation> StartDownloadInvoiceAsync(string billingAccountName, string invoiceName, string downloadToken, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (invoiceName == null)
            {
                throw new ArgumentNullException(nameof(invoiceName));
            }
            if (downloadToken == null)
            {
                throw new ArgumentNullException(nameof(downloadToken));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.StartDownloadInvoice");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DownloadInvoiceAsync(billingAccountName, invoiceName, downloadToken, cancellationToken).ConfigureAwait(false);
                return new InvoicesDownloadInvoiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadInvoiceRequest(billingAccountName, invoiceName, downloadToken).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a URL to download an invoice. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="downloadToken"> Download token with document source and document ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="invoiceName"/>, or <paramref name="downloadToken"/> is null. </exception>
        public virtual InvoicesDownloadInvoiceOperation StartDownloadInvoice(string billingAccountName, string invoiceName, string downloadToken, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (invoiceName == null)
            {
                throw new ArgumentNullException(nameof(invoiceName));
            }
            if (downloadToken == null)
            {
                throw new ArgumentNullException(nameof(downloadToken));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.StartDownloadInvoice");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DownloadInvoice(billingAccountName, invoiceName, downloadToken, cancellationToken);
                return new InvoicesDownloadInvoiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadInvoiceRequest(billingAccountName, invoiceName, downloadToken).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a URL to download multiple invoice documents (invoice pdf, tax receipts, credit notes) as a zip file. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="downloadUrls"> An array of download urls for individual documents. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="downloadUrls"/> is null. </exception>
        public virtual async Task<InvoicesDownloadMultipleBillingProfileInvoicesOperation> StartDownloadMultipleBillingProfileInvoicesAsync(string billingAccountName, IEnumerable<string> downloadUrls, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (downloadUrls == null)
            {
                throw new ArgumentNullException(nameof(downloadUrls));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.StartDownloadMultipleBillingProfileInvoices");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DownloadMultipleBillingProfileInvoicesAsync(billingAccountName, downloadUrls, cancellationToken).ConfigureAwait(false);
                return new InvoicesDownloadMultipleBillingProfileInvoicesOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadMultipleBillingProfileInvoicesRequest(billingAccountName, downloadUrls).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a URL to download multiple invoice documents (invoice pdf, tax receipts, credit notes) as a zip file. The operation is supported for billing accounts with agreement type Microsoft Partner Agreement or Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="downloadUrls"> An array of download urls for individual documents. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="downloadUrls"/> is null. </exception>
        public virtual InvoicesDownloadMultipleBillingProfileInvoicesOperation StartDownloadMultipleBillingProfileInvoices(string billingAccountName, IEnumerable<string> downloadUrls, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (downloadUrls == null)
            {
                throw new ArgumentNullException(nameof(downloadUrls));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.StartDownloadMultipleBillingProfileInvoices");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DownloadMultipleBillingProfileInvoices(billingAccountName, downloadUrls, cancellationToken);
                return new InvoicesDownloadMultipleBillingProfileInvoicesOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadMultipleBillingProfileInvoicesRequest(billingAccountName, downloadUrls).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a URL to download an invoice. </summary>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="downloadToken"> Download token with document source and document ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="invoiceName"/> or <paramref name="downloadToken"/> is null. </exception>
        public virtual async Task<InvoicesDownloadBillingSubscriptionInvoiceOperation> StartDownloadBillingSubscriptionInvoiceAsync(string invoiceName, string downloadToken, CancellationToken cancellationToken = default)
        {
            if (invoiceName == null)
            {
                throw new ArgumentNullException(nameof(invoiceName));
            }
            if (downloadToken == null)
            {
                throw new ArgumentNullException(nameof(downloadToken));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.StartDownloadBillingSubscriptionInvoice");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DownloadBillingSubscriptionInvoiceAsync(invoiceName, downloadToken, cancellationToken).ConfigureAwait(false);
                return new InvoicesDownloadBillingSubscriptionInvoiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadBillingSubscriptionInvoiceRequest(invoiceName, downloadToken).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a URL to download an invoice. </summary>
        /// <param name="invoiceName"> The ID that uniquely identifies an invoice. </param>
        /// <param name="downloadToken"> Download token with document source and document ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="invoiceName"/> or <paramref name="downloadToken"/> is null. </exception>
        public virtual InvoicesDownloadBillingSubscriptionInvoiceOperation StartDownloadBillingSubscriptionInvoice(string invoiceName, string downloadToken, CancellationToken cancellationToken = default)
        {
            if (invoiceName == null)
            {
                throw new ArgumentNullException(nameof(invoiceName));
            }
            if (downloadToken == null)
            {
                throw new ArgumentNullException(nameof(downloadToken));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.StartDownloadBillingSubscriptionInvoice");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DownloadBillingSubscriptionInvoice(invoiceName, downloadToken, cancellationToken);
                return new InvoicesDownloadBillingSubscriptionInvoiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadBillingSubscriptionInvoiceRequest(invoiceName, downloadToken).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a URL to download multiple invoice documents (invoice pdf, tax receipts, credit notes) as a zip file. </summary>
        /// <param name="downloadUrls"> An array of download urls for individual documents. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="downloadUrls"/> is null. </exception>
        public virtual async Task<InvoicesDownloadMultipleBillingSubscriptionInvoicesOperation> StartDownloadMultipleBillingSubscriptionInvoicesAsync(IEnumerable<string> downloadUrls, CancellationToken cancellationToken = default)
        {
            if (downloadUrls == null)
            {
                throw new ArgumentNullException(nameof(downloadUrls));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.StartDownloadMultipleBillingSubscriptionInvoices");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DownloadMultipleBillingSubscriptionInvoicesAsync(downloadUrls, cancellationToken).ConfigureAwait(false);
                return new InvoicesDownloadMultipleBillingSubscriptionInvoicesOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadMultipleBillingSubscriptionInvoicesRequest(downloadUrls).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a URL to download multiple invoice documents (invoice pdf, tax receipts, credit notes) as a zip file. </summary>
        /// <param name="downloadUrls"> An array of download urls for individual documents. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="downloadUrls"/> is null. </exception>
        public virtual InvoicesDownloadMultipleBillingSubscriptionInvoicesOperation StartDownloadMultipleBillingSubscriptionInvoices(IEnumerable<string> downloadUrls, CancellationToken cancellationToken = default)
        {
            if (downloadUrls == null)
            {
                throw new ArgumentNullException(nameof(downloadUrls));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoicesOperations.StartDownloadMultipleBillingSubscriptionInvoices");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DownloadMultipleBillingSubscriptionInvoices(downloadUrls, cancellationToken);
                return new InvoicesDownloadMultipleBillingSubscriptionInvoicesOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadMultipleBillingSubscriptionInvoicesRequest(downloadUrls).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}