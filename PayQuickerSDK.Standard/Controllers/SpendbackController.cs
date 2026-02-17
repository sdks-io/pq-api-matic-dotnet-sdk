// <copyright file="SpendbackController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using PayQuickerSDK.Standard.Exceptions;
using PayQuickerSDK.Standard.Models.Containers;
using PayQuickerSDK.Standard.Utilities;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// SpendbackController.
    /// </summary>
    internal class SpendbackController : BaseController, ISpendbackController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendbackController"/> class.
        /// </summary>
        internal SpendbackController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [spendbacks](page:resources/spendbacks) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.SpendbackListResult response from the API call.</returns>
        public Models.SpendbackListResult ListSpendbacks(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListSpendbacksAsync(page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of [spendbacks](page:resources/spendbacks) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackListResult response from the API call.</returns>
        public async Task<Models.SpendbackListResult> ListSpendbacksAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/spend-back")
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
        /// Create a [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        public Models.SpendbackResult CreateSpendbackQuote(
                SpendbackQuote body = null)
            => CoreHelper.RunTask(CreateSpendbackQuoteAsync(body));

        /// <summary>
        /// Create a [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        public async Task<Models.SpendbackResult> CreateSpendbackQuoteAsync(
                SpendbackQuote body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/spend-back")
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
        /// Retrieve a single [spendbacks](page:resources/spendbacks) quote using the spendback token.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        public Models.SpendbackResult RetrieveSpendback(
                string spendbackToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(RetrieveSpendbackAsync(spendbackToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a single [spendbacks](page:resources/spendbacks) quote using the spendback token.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        public async Task<Models.SpendbackResult> RetrieveSpendbackAsync(
                string spendbackToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/spend-back/{spendback-token}")
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
        /// Accept an open [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        public Models.SpendbackResult AcceptSpendbackQuote(
                string spendbackToken)
            => CoreHelper.RunTask(AcceptSpendbackQuoteAsync(spendbackToken));

        /// <summary>
        /// Accept an open [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        public async Task<Models.SpendbackResult> AcceptSpendbackQuoteAsync(
                string spendbackToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/spend-back/{spendback-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("spendback-token", spendbackToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancel an open [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        public Models.SpendbackResult CancelSpendbackQuote(
                string spendbackToken)
            => CoreHelper.RunTask(CancelSpendbackQuoteAsync(spendbackToken));

        /// <summary>
        /// Cancel an open [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        public async Task<Models.SpendbackResult> CancelSpendbackQuoteAsync(
                string spendbackToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SpendbackResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/spend-back/{spendback-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("spendback-token", spendbackToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}