// <copyright file="TransfersController.cs" company="APIMatic">
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
    /// TransfersController.
    /// </summary>
    internal class TransfersController : BaseController, ITransfersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransfersController"/> class.
        /// </summary>
        internal TransfersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        public Models.TransferListResult ListTransfers(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListTransfersAsync(page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        public async Task<Models.TransferListResult> ListTransfersAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransferListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/transfers")
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
        /// Create a new [transfer](page:resources/transfers) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public Models.TransferResult CreateTransferQuote(
                TransferQuote body = null)
            => CoreHelper.RunTask(CreateTransferQuoteAsync(body));

        /// <summary>
        /// Create a new [transfer](page:resources/transfers) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public async Task<Models.TransferResult> CreateTransferQuoteAsync(
                TransferQuote body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransferResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/transfers")
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
        /// Retrieve details of a specific [transfer](page:resources/transfers) represented by a transfer token.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public Models.TransferResult RetrieveTransfer(
                string transferToken)
            => CoreHelper.RunTask(RetrieveTransferAsync(transferToken));

        /// <summary>
        /// Retrieve details of a specific [transfer](page:resources/transfers) represented by a transfer token.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public async Task<Models.TransferResult> RetrieveTransferAsync(
                string transferToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransferResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/transfers/{transfer-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("transfer-token", transferToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Accept a [transfer](page:resources/transfers) quote.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public Models.TransferResult AcceptTransferQuote(
                string transferToken)
            => CoreHelper.RunTask(AcceptTransferQuoteAsync(transferToken));

        /// <summary>
        /// Accept a [transfer](page:resources/transfers) quote.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public async Task<Models.TransferResult> AcceptTransferQuoteAsync(
                string transferToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransferResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/transfers/{transfer-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("transfer-token", transferToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Optional [transfer](page:resources/transfers) quote cancellation that auto-cancels after a period organically expires or when account activity invalidates the quote.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public Models.TransferResult CancelTransferQuote(
                string transferToken)
            => CoreHelper.RunTask(CancelTransferQuoteAsync(transferToken));

        /// <summary>
        /// Optional [transfer](page:resources/transfers) quote cancellation that auto-cancels after a period organically expires or when account activity invalidates the quote.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public async Task<Models.TransferResult> CancelTransferQuoteAsync(
                string transferToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransferResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/transfers/{transfer-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("transfer-token", transferToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a list of user [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        public Models.TransferListResult ListUserTransfers(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListUserTransfersAsync(userToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of user [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        public async Task<Models.TransferListResult> ListUserTransfersAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransferListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/transfers")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Query(query => query.Setup("page", page))
                      .Query(query => query.Setup("pageSize", pageSize))
                      .Query(query => query.Setup("filter", filter))
                      .Query(query => query.Setup("sort", sort))
                      .Query(query => query.Setup("language", (language.HasValue) ? CoreHelper.JsonSerialize(language.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a specific user bank [transfer](page:resources/transfers).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing a transfer, prefixed with `xfer-`..</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public Models.TransferResult RetrieveUserTransfer(
                string userToken,
                string transferToken)
            => CoreHelper.RunTask(RetrieveUserTransferAsync(userToken, transferToken));

        /// <summary>
        /// Retrieve a specific user bank [transfer](page:resources/transfers).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing a transfer, prefixed with `xfer-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        public async Task<Models.TransferResult> RetrieveUserTransferAsync(
                string userToken,
                string transferToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransferResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/transfers/{transfer-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("transfer-token", transferToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}