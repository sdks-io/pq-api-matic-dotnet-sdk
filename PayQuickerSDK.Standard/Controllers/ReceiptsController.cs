// <copyright file="ReceiptsController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using PayQuickerSDK.Standard.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// ReceiptsController.
    /// </summary>
    internal class ReceiptsController : BaseController, IReceiptsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptsController"/> class.
        /// </summary>
        internal ReceiptsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of all account(s) [receipts](page:resources/receipts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        public Models.ReceiptListResult ListAccountReceipts(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListAccountReceiptsAsync(accountToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of all account(s) [receipts](page:resources/receipts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        public async Task<Models.ReceiptListResult> ListAccountReceiptsAsync(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReceiptListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/accounts/{account-token}/receipts")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("account-token", accountToken).Required())
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
        /// Retrieve a single account [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        public Models.ReceiptResult RetrieveAccountReceipt(
                string accountToken,
                string receiptToken)
            => CoreHelper.RunTask(RetrieveAccountReceiptAsync(accountToken, receiptToken));

        /// <summary>
        /// Retrieve a single account [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        public async Task<Models.ReceiptResult> RetrieveAccountReceiptAsync(
                string accountToken,
                string receiptToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReceiptResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/accounts/{account-token}/receipts/{receipt-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("account-token", accountToken).Required())
                      .Template(template => template.Setup("receipt-token", receiptToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a list of [prepaid card](page:resources/prepaid-cards) [receipts](page:resources/receipts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        public Models.ReceiptListResult ListPrepaidCardReceipts(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListPrepaidCardReceiptsAsync(userToken, destinationToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of [prepaid card](page:resources/prepaid-cards) [receipts](page:resources/receipts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        public async Task<Models.ReceiptListResult> ListPrepaidCardReceiptsAsync(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReceiptListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/prepaid-cards/{destination-token}/receipts")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
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
        /// Retrieve a single user prepaid-card [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        public Models.ReceiptResult RetrievePrepaidCardReceipt(
                string userToken,
                string destinationToken,
                string receiptToken)
            => CoreHelper.RunTask(RetrievePrepaidCardReceiptAsync(userToken, destinationToken, receiptToken));

        /// <summary>
        /// Retrieve a single user prepaid-card [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        public async Task<Models.ReceiptResult> RetrievePrepaidCardReceiptAsync(
                string userToken,
                string destinationToken,
                string receiptToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReceiptResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/prepaid-cards/{destination-token}/receipts/{receipt-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
                      .Template(template => template.Setup("receipt-token", receiptToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a list of  user [receipts](page:resources/receipts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        public Models.ReceiptListResult ListUserReceipts(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListUserReceiptsAsync(userToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of  user [receipts](page:resources/receipts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        public async Task<Models.ReceiptListResult> ListUserReceiptsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReceiptListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/receipts")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
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
        /// Retrieve a single user [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        public Models.ReceiptResult RetrieveUserReceipt(
                string userToken,
                string receiptToken)
            => CoreHelper.RunTask(RetrieveUserReceiptAsync(userToken, receiptToken));

        /// <summary>
        /// Retrieve a single user [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        public async Task<Models.ReceiptResult> RetrieveUserReceiptAsync(
                string userToken,
                string receiptToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReceiptResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/receipts/{receipt-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("receipt-token", receiptToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}