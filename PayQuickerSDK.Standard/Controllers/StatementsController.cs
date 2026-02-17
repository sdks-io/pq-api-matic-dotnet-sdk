// <copyright file="StatementsController.cs" company="APIMatic">
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
    /// StatementsController.
    /// </summary>
    internal class StatementsController : BaseController, IStatementsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementsController"/> class.
        /// </summary>
        internal StatementsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List Prepaid Card Statements for specific user.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.StatementListResult response from the API call.</returns>
        public Models.StatementListResult ListPrepaidCardStatements(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListPrepaidCardStatementsAsync(userToken, destinationToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// List Prepaid Card Statements for specific user.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StatementListResult response from the API call.</returns>
        public async Task<Models.StatementListResult> ListPrepaidCardStatementsAsync(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StatementListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/prepaid-cards/{destination-token}/statements")
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
        /// Retrieve a single prepaid card agreement.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        public Models.StatementResult RetrievePrepaidCardStatement(
                string userToken,
                string destinationToken,
                string documentToken)
            => CoreHelper.RunTask(RetrievePrepaidCardStatementAsync(userToken, destinationToken, documentToken));

        /// <summary>
        /// Retrieve a single prepaid card agreement.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        public async Task<Models.StatementResult> RetrievePrepaidCardStatementAsync(
                string userToken,
                string destinationToken,
                string documentToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StatementResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/prepaid-cards/{destination-token}/statements/{document-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
                      .Template(template => template.Setup("document-token", documentToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns all statements for the specified user.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.StatementListResult response from the API call.</returns>
        public Models.StatementListResult ListStatements(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListStatementsAsync(userToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Returns all statements for the specified user.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StatementListResult response from the API call.</returns>
        public async Task<Models.StatementListResult> ListStatementsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StatementListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/statements")
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
        /// Return a specific statement.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        public Models.StatementResult RetrieveStatement(
                string userToken,
                string documentToken)
            => CoreHelper.RunTask(RetrieveStatementAsync(userToken, documentToken));

        /// <summary>
        /// Return a specific statement.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        public async Task<Models.StatementResult> RetrieveStatementAsync(
                string userToken,
                string documentToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StatementResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/statements/{document-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("document-token", documentToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}