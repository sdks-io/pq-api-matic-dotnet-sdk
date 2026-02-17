// <copyright file="IPrepaidCardsController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// IPrepaidCardsController.
    /// </summary>
    public interface IPrepaidCardsController
    {
        /// <summary>
        /// Retrieve a list of [prepaid cards](page:resources/prepaid-cards) by user token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PrepaidCardListResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardListResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardListResult response from the API call.</returns>
        Models.PrepaidCardListResult ListPrepaidCards(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of [prepaid cards](page:resources/prepaid-cards) by user token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardListResult response from the API call.</returns>
        Task<Models.PrepaidCardListResult> ListPrepaidCardsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Order a [prepaid card](page:resources/prepaid-cards) for the user by specifying a cardPackage.
        /// Assign a prepaid card to a user when a program token and card reference number are supplied.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        Models.PrepaidCardResult OrderPrepaidCard(
                string userToken,
                Models.OrderPrepaidCard body = null);

        /// <summary>
        /// Order a [prepaid card](page:resources/prepaid-cards) for the user by specifying a cardPackage.
        /// Assign a prepaid card to a user when a program token and card reference number are supplied.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        Task<Models.PrepaidCardResult> OrderPrepaidCardAsync(
                string userToken,
                Models.OrderPrepaidCard body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace a [prepaid card](page:resources/prepaid-cards) by destination token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        Models.PrepaidCardResult ReplacePrepaidCard(
                string userToken,
                string destinationToken,
                Models.ReplacePrepaidCard body = null);

        /// <summary>
        /// Replace a [prepaid card](page:resources/prepaid-cards) by destination token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        Task<Models.PrepaidCardResult> ReplacePrepaidCardAsync(
                string userToken,
                string destinationToken,
                Models.ReplacePrepaidCard body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve [prepaid card](page:resources/prepaid-cards) details by destination token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        Models.PrepaidCardResult RetrievePrepaidCard(
                string userToken,
                string destinationToken);

        /// <summary>
        /// Retrieve [prepaid card](page:resources/prepaid-cards) details by destination token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        Task<Models.PrepaidCardResult> RetrievePrepaidCardAsync(
                string userToken,
                string destinationToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Partial [prepaid card](page:resources/prepaid-cards) update.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        Models.PrepaidCardResult UpdatePrepaidCard(
                string userToken,
                string destinationToken,
                Models.UpdatePrepaidCard body = null);

        /// <summary>
        /// Partial [prepaid card](page:resources/prepaid-cards) update.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardResult response from the API call.</returns>
        Task<Models.PrepaidCardResult> UpdatePrepaidCardAsync(
                string userToken,
                string destinationToken,
                Models.UpdatePrepaidCard body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// TODO.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.AuthorizationListResult response from the API call.</returns>
        /// <returns>Returns the Models.AuthorizationListResult response from the API call.</returns>
        /// <returns>Returns the Models.AuthorizationListResult response from the API call.</returns>
        Models.AuthorizationListResult ListCardAuthorizations(
                string userToken,
                string destinationToken);

        /// <summary>
        /// TODO.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthorizationListResult response from the API call.</returns>
        Task<Models.AuthorizationListResult> ListCardAuthorizationsAsync(
                string userToken,
                string destinationToken,
                CancellationToken cancellationToken = default);
    }
}