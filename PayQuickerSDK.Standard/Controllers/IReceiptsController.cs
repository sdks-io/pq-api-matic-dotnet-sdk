// <copyright file="IReceiptsController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// IReceiptsController.
    /// </summary>
    public interface IReceiptsController
    {
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
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        Models.ReceiptListResult ListAccountReceipts(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.ReceiptListResult> ListAccountReceiptsAsync(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single account [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        Models.ReceiptResult RetrieveAccountReceipt(
                string accountToken,
                string receiptToken);

        /// <summary>
        /// Retrieve a single account [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        Task<Models.ReceiptResult> RetrieveAccountReceiptAsync(
                string accountToken,
                string receiptToken,
                CancellationToken cancellationToken = default);

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
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        Models.ReceiptListResult ListPrepaidCardReceipts(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.ReceiptListResult> ListPrepaidCardReceiptsAsync(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single user prepaid-card [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        Models.ReceiptResult RetrievePrepaidCardReceipt(
                string userToken,
                string destinationToken,
                string receiptToken);

        /// <summary>
        /// Retrieve a single user prepaid-card [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        Task<Models.ReceiptResult> RetrievePrepaidCardReceiptAsync(
                string userToken,
                string destinationToken,
                string receiptToken,
                CancellationToken cancellationToken = default);

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
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptListResult response from the API call.</returns>
        Models.ReceiptListResult ListUserReceipts(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.ReceiptListResult> ListUserReceiptsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single user [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        Models.ReceiptResult RetrieveUserReceipt(
                string userToken,
                string receiptToken);

        /// <summary>
        /// Retrieve a single user [receipt](page:resources/receipts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="receiptToken">Required parameter: Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReceiptResult response from the API call.</returns>
        Task<Models.ReceiptResult> RetrieveUserReceiptAsync(
                string userToken,
                string receiptToken,
                CancellationToken cancellationToken = default);
    }
}