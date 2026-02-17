// <copyright file="ITransfersController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using PayQuickerSDK.Standard.Models.Containers;
using PayQuickerSDK.Standard.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// ITransfersController.
    /// </summary>
    public interface ITransfersController
    {
        /// <summary>
        /// Retrieve a list of [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        Models.TransferListResult ListTransfers(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.TransferListResult> ListTransfersAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new [transfer](page:resources/transfers) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Models.TransferResult CreateTransferQuote(
                TransferQuote body = null);

        /// <summary>
        /// Create a new [transfer](page:resources/transfers) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Task<Models.TransferResult> CreateTransferQuoteAsync(
                TransferQuote body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve details of a specific [transfer](page:resources/transfers) represented by a transfer token.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Models.TransferResult RetrieveTransfer(
                string transferToken);

        /// <summary>
        /// Retrieve details of a specific [transfer](page:resources/transfers) represented by a transfer token.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Task<Models.TransferResult> RetrieveTransferAsync(
                string transferToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Accept a [transfer](page:resources/transfers) quote.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Models.TransferResult AcceptTransferQuote(
                string transferToken);

        /// <summary>
        /// Accept a [transfer](page:resources/transfers) quote.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Task<Models.TransferResult> AcceptTransferQuoteAsync(
                string transferToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Optional [transfer](page:resources/transfers) quote cancellation that auto-cancels after a period organically expires or when account activity invalidates the quote.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Models.TransferResult CancelTransferQuote(
                string transferToken);

        /// <summary>
        /// Optional [transfer](page:resources/transfers) quote cancellation that auto-cancels after a period organically expires or when account activity invalidates the quote.
        /// </summary>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Task<Models.TransferResult> CancelTransferQuoteAsync(
                string transferToken,
                CancellationToken cancellationToken = default);

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
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferListResult response from the API call.</returns>
        Models.TransferListResult ListUserTransfers(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.TransferListResult> ListUserTransfersAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a specific user bank [transfer](page:resources/transfers).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing a transfer, prefixed with `xfer-`..</param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Models.TransferResult RetrieveUserTransfer(
                string userToken,
                string transferToken);

        /// <summary>
        /// Retrieve a specific user bank [transfer](page:resources/transfers).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="transferToken">Required parameter: Auto-generated unique identifier representing a transfer, prefixed with `xfer-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransferResult response from the API call.</returns>
        Task<Models.TransferResult> RetrieveUserTransferAsync(
                string userToken,
                string transferToken,
                CancellationToken cancellationToken = default);
    }
}