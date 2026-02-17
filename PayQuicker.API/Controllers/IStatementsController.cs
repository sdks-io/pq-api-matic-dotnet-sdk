// <copyright file="IStatementsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IStatementsController.
    /// </summary>
    public interface IStatementsController
    {
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
        /// <returns>Returns the Models.StatementListResult response from the API call.</returns>
        /// <returns>Returns the Models.StatementListResult response from the API call.</returns>
        Models.StatementListResult ListPrepaidCardStatements(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.StatementListResult> ListPrepaidCardStatementsAsync(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single prepaid card agreement.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        Models.StatementResult RetrievePrepaidCardStatement(
                string userToken,
                string destinationToken,
                string documentToken);

        /// <summary>
        /// Retrieve a single prepaid card agreement.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        Task<Models.StatementResult> RetrievePrepaidCardStatementAsync(
                string userToken,
                string destinationToken,
                string documentToken,
                CancellationToken cancellationToken = default);

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
        /// <returns>Returns the Models.StatementListResult response from the API call.</returns>
        /// <returns>Returns the Models.StatementListResult response from the API call.</returns>
        Models.StatementListResult ListStatements(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.StatementListResult> ListStatementsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a specific statement.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        Models.StatementResult RetrieveStatement(
                string userToken,
                string documentToken);

        /// <summary>
        /// Return a specific statement.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StatementResult response from the API call.</returns>
        Task<Models.StatementResult> RetrieveStatementAsync(
                string userToken,
                string documentToken,
                CancellationToken cancellationToken = default);
    }
}