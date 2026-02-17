// <copyright file="IPaymentsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using PayQuicker.API.Models.Containers;
using PayQuicker.API.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IPaymentsController.
    /// </summary>
    public interface IPaymentsController
    {
        /// <summary>
        /// Retrieve a list of [payments](page:resources/payments) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PaymentListResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentListResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentListResult response from the API call.</returns>
        Models.PaymentListResult ListPayments(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of [payments](page:resources/payments) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentListResult response from the API call.</returns>
        Task<Models.PaymentListResult> ListPaymentsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Models.PaymentResult CreatePaymentQuote(
                PaymentQuote body = null);

        /// <summary>
        /// Create a [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Task<Models.PaymentResult> CreatePaymentQuoteAsync(
                PaymentQuote body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single [payment](page:resources/payments).
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Models.PaymentResult RetrievePayment(
                string paymentToken,
                string filter = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a single [payment](page:resources/payments).
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Task<Models.PaymentResult> RetrievePaymentAsync(
                string paymentToken,
                string filter = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Accept an open [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Models.PaymentResult AcceptPaymentQuote(
                string paymentToken);

        /// <summary>
        /// Accept an open [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Task<Models.PaymentResult> AcceptPaymentQuoteAsync(
                string paymentToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel an open [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Models.PaymentResult CancelPaymentQuote(
                string paymentToken);

        /// <summary>
        /// Cancel an open [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Task<Models.PaymentResult> CancelPaymentQuoteAsync(
                string paymentToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Perform a [payment](page:resources/payments) retraction for the full payment amount.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Models.PaymentResult RetractPayment(
                string paymentToken);

        /// <summary>
        /// Perform a [payment](page:resources/payments) retraction for the full payment amount.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        Task<Models.PaymentResult> RetractPaymentAsync(
                string paymentToken,
                CancellationToken cancellationToken = default);
    }
}