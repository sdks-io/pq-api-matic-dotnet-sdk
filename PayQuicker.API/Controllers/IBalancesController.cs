// <copyright file="IBalancesController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IBalancesController.
    /// </summary>
    public interface IBalancesController
    {
        /// <summary>
        /// Retrieve a list of bank account [balances](page:resources/balances) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.BalanceListResult response from the API call.</returns>
        /// <returns>Returns the Models.BalanceListResult response from the API call.</returns>
        /// <returns>Returns the Models.BalanceListResult response from the API call.</returns>
        Models.BalanceListResult ListAccountBalances(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of bank account [balances](page:resources/balances) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BalanceListResult response from the API call.</returns>
        Task<Models.BalanceListResult> ListAccountBalancesAsync(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a list of user [balances](page:resources/balances) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.BalanceListResult response from the API call.</returns>
        /// <returns>Returns the Models.BalanceListResult response from the API call.</returns>
        /// <returns>Returns the Models.BalanceListResult response from the API call.</returns>
        Models.BalanceListResult ListUserBalances(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of user [balances](page:resources/balances) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BalanceListResult response from the API call.</returns>
        Task<Models.BalanceListResult> ListUserBalancesAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a [prepaid card](page:resources/prepaid-cards) [balances](page:resources/balances) by destination token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.BalanceResult response from the API call.</returns>
        /// <returns>Returns the Models.BalanceResult response from the API call.</returns>
        /// <returns>Returns the Models.BalanceResult response from the API call.</returns>
        Models.BalanceResult RetrieveCardBalance(
                string userToken,
                string destinationToken,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a [prepaid card](page:resources/prepaid-cards) [balances](page:resources/balances) by destination token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BalanceResult response from the API call.</returns>
        Task<Models.BalanceResult> RetrieveCardBalanceAsync(
                string userToken,
                string destinationToken,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);
    }
}