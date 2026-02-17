// <copyright file="PaymentsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using PayQuicker.API.Exceptions;
using PayQuicker.API.Models.Containers;
using PayQuicker.API.Utilities;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// PaymentsController.
    /// </summary>
    internal class PaymentsController : BaseController, IPaymentsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsController"/> class.
        /// </summary>
        internal PaymentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [payments](page:resources/payments) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PaymentListResult response from the API call.</returns>
        public Models.PaymentListResult ListPayments(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListPaymentsAsync(page, pageSize, filter, sort, language));

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
        public async Task<Models.PaymentListResult> ListPaymentsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/payments")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", page))
                      .Query(query => query.Setup("pageSize", pageSize))
                      .Query(query => query.Setup("filter", filter))
                      .Query(query => query.Setup("sort", sort))
                      .Query(query => query.Setup("language", (language.HasValue) ? CoreHelper.JsonSerialize(language.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public Models.PaymentResult CreatePaymentQuote(
                PaymentQuote body = null)
            => CoreHelper.RunTask(CreatePaymentQuoteAsync(body));

        /// <summary>
        /// Create a [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public async Task<Models.PaymentResult> CreatePaymentQuoteAsync(
                PaymentQuote body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/payments")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a single [payment](page:resources/payments).
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public Models.PaymentResult RetrievePayment(
                string paymentToken,
                string filter = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(RetrievePaymentAsync(paymentToken, filter, language));

        /// <summary>
        /// Retrieve a single [payment](page:resources/payments).
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public async Task<Models.PaymentResult> RetrievePaymentAsync(
                string paymentToken,
                string filter = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/payments/{payment-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("payment-token", paymentToken).Required())
                      .Query(query => query.Setup("filter", filter))
                      .Query(query => query.Setup("language", (language.HasValue) ? CoreHelper.JsonSerialize(language.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Accept an open [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public Models.PaymentResult AcceptPaymentQuote(
                string paymentToken)
            => CoreHelper.RunTask(AcceptPaymentQuoteAsync(paymentToken));

        /// <summary>
        /// Accept an open [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public async Task<Models.PaymentResult> AcceptPaymentQuoteAsync(
                string paymentToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/payments/{payment-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("payment-token", paymentToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancel an open [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public Models.PaymentResult CancelPaymentQuote(
                string paymentToken)
            => CoreHelper.RunTask(CancelPaymentQuoteAsync(paymentToken));

        /// <summary>
        /// Cancel an open [payment](page:resources/payments) quote.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public async Task<Models.PaymentResult> CancelPaymentQuoteAsync(
                string paymentToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/payments/{payment-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("payment-token", paymentToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Perform a [payment](page:resources/payments) retraction for the full payment amount.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public Models.PaymentResult RetractPayment(
                string paymentToken)
            => CoreHelper.RunTask(RetractPaymentAsync(paymentToken));

        /// <summary>
        /// Perform a [payment](page:resources/payments) retraction for the full payment amount.
        /// </summary>
        /// <param name="paymentToken">Required parameter: Auto-generated unique identifier representing an individual payment transaction and quote, prefixed with `pmnt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentResult response from the API call.</returns>
        public async Task<Models.PaymentResult> RetractPaymentAsync(
                string paymentToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/payments/{payment-token}/retract")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("payment-token", paymentToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}