// <copyright file="ISpendbackRefundsController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// ISpendbackRefundsController.
    /// </summary>
    public interface ISpendbackRefundsController
    {
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
        /// <returns>Returns the Models.SpendbackRefundListResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackRefundListResult response from the API call.</returns>
        Models.SpendbackRefundListResult ListSpendbackRefunds(
                string spendbackToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.SpendbackRefundListResult> ListSpendbackRefundsAsync(
                string spendbackToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Perform a [spendback](page:resources/spendbacks) refund for a partial amount.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        Models.SpendbackRefundResult CreateSpendbackRefundQuote(
                string spendbackToken,
                Models.CreateSpendbackRefundQuote body = null);

        /// <summary>
        /// Perform a [spendback](page:resources/spendbacks) refund for a partial amount.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        Task<Models.SpendbackRefundResult> CreateSpendbackRefundQuoteAsync(
                string spendbackToken,
                Models.CreateSpendbackRefundQuote body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel an spendback refund quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        Models.SpendbackRefundResult CancelSpendbackRefundQuote(
                string spendbackToken,
                string refundToken);

        /// <summary>
        /// Cancel an spendback refund quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        Task<Models.SpendbackRefundResult> CancelSpendbackRefundQuoteAsync(
                string spendbackToken,
                string refundToken,
                CancellationToken cancellationToken = default);

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
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        Models.SpendbackRefundResult RetrieveSpendbackRefund(
                string spendbackToken,
                string refundToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.SpendbackRefundResult> RetrieveSpendbackRefundAsync(
                string spendbackToken,
                string refundToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Accept a spendback return quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        Models.SpendbackRefundResult AcceptSpendbackRefundQuote(
                string spendbackToken,
                string refundToken);

        /// <summary>
        /// Accept a spendback return quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="refundToken">Required parameter: Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackRefundResult response from the API call.</returns>
        Task<Models.SpendbackRefundResult> AcceptSpendbackRefundQuoteAsync(
                string spendbackToken,
                string refundToken,
                CancellationToken cancellationToken = default);
    }
}