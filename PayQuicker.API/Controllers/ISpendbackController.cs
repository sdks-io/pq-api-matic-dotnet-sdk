// <copyright file="ISpendbackController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using PayQuicker.API.Models.Containers;
using PayQuicker.API.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// ISpendbackController.
    /// </summary>
    public interface ISpendbackController
    {
        /// <summary>
        /// Retrieve a list of [spendbacks](page:resources/spendbacks) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.SpendbackListResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackListResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackListResult response from the API call.</returns>
        Models.SpendbackListResult ListSpendbacks(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.SpendbackListResult> ListSpendbacksAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        Models.SpendbackResult CreateSpendbackQuote(
                SpendbackQuote body = null);

        /// <summary>
        /// Create a [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        Task<Models.SpendbackResult> CreateSpendbackQuoteAsync(
                SpendbackQuote body = null,
                CancellationToken cancellationToken = default);

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
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        Models.SpendbackResult RetrieveSpendback(
                string spendbackToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.SpendbackResult> RetrieveSpendbackAsync(
                string spendbackToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Accept an open [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        Models.SpendbackResult AcceptSpendbackQuote(
                string spendbackToken);

        /// <summary>
        /// Accept an open [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        Task<Models.SpendbackResult> AcceptSpendbackQuoteAsync(
                string spendbackToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel an open [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        Models.SpendbackResult CancelSpendbackQuote(
                string spendbackToken);

        /// <summary>
        /// Cancel an open [spendback](page:resources/spendbacks) quote.
        /// </summary>
        /// <param name="spendbackToken">Required parameter: Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SpendbackResult response from the API call.</returns>
        Task<Models.SpendbackResult> CancelSpendbackQuoteAsync(
                string spendbackToken,
                CancellationToken cancellationToken = default);
    }
}