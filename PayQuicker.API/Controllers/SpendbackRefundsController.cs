// <copyright file="SpendbackRefundsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using PayQuicker.API.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// SpendbackRefundsController.
    /// </summary>
    internal class SpendbackRefundsController : BaseController, ISpendbackRefundsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendbackRefundsController"/> class.
        /// </summary>
        internal SpendbackRefundsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [spendbacks](page:resources/spendbacks) refunds that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.SpendbackRefundListResult response from the API call.</returns>
        public Models.SpendbackRefundListResult ListSpendbackRefunds(
                string spendbackToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListSpendbackRefundsAsync(spendbackToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of [spendbacks](page:resources/spendbacks) refunds that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackRefundListResult response from the API call.</returns>
        public async Task<Models.SpendbackRefundListResult> ListSpendbackRefundsAsync(
                string spendbackToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackRefundListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/spend-back/{spendback-token}/refund")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("spendback-token", spendbackToken).Required())
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
        /// Perform a [spendback](page:resources/spendbacks) refund for a partial amount.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        public Models.SpendbackRefundResult CreateSpendbackRefundQuote(
                string spendbackToken,
                Models.CreateSpendbackRefundQuote body = null)
            => CoreHelper.RunTask(CreateSpendbackRefundQuoteAsync(spendbackToken, body));

        /// <summary>
        /// Perform a [spendback](page:resources/spendbacks) refund for a partial amount.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        public async Task<Models.SpendbackRefundResult> CreateSpendbackRefundQuoteAsync(
                string spendbackToken,
                Models.CreateSpendbackRefundQuote body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackRefundResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/spend-back/{spendback-token}/refund")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("spendback-token", spendbackToken).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancel an spendback refund quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        public Models.SpendbackRefundResult CancelSpendbackRefundQuote(
                string spendbackToken,
                string refundToken)
            => CoreHelper.RunTask(CancelSpendbackRefundQuoteAsync(spendbackToken, refundToken));

        /// <summary>
        /// Cancel an spendback refund quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        public async Task<Models.SpendbackRefundResult> CancelSpendbackRefundQuoteAsync(
                string spendbackToken,
                string refundToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackRefundResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/spend-back/{spendback-token}/refund/{refund-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("spendback-token", spendbackToken).Required())
                      .Template(template => template.Setup("refund-token", refundToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a single spendback refund using the rfnd token.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        public Models.SpendbackRefundResult RetrieveSpendbackRefund(
                string spendbackToken,
                string refundToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(RetrieveSpendbackRefundAsync(spendbackToken, refundToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a single spendback refund using the rfnd token.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        public async Task<Models.SpendbackRefundResult> RetrieveSpendbackRefundAsync(
                string spendbackToken,
                string refundToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackRefundResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/spend-back/{spendback-token}/refund/{refund-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("spendback-token", spendbackToken).Required())
                      .Template(template => template.Setup("refund-token", refundToken).Required())
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
        /// Accept a spendback return quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        public Models.SpendbackRefundResult AcceptSpendbackRefundQuote(
                string spendbackToken,
                string refundToken)
            => CoreHelper.RunTask(AcceptSpendbackRefundQuoteAsync(spendbackToken, refundToken));

        /// <summary>
        /// Accept a spendback return quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        public async Task<Models.SpendbackRefundResult> AcceptSpendbackRefundQuoteAsync(
                string spendbackToken,
                string refundToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackRefundResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/spend-back/{spendback-token}/refund/{refund-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("spendback-token", spendbackToken).Required())
                      .Template(template => template.Setup("refund-token", refundToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}