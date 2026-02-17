// <copyright file="IJobsController.cs" company="APIMatic">
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
    /// IJobsController.
    /// </summary>
    public interface IJobsController
    {
        /// <summary>
        /// Retrieve a list of [jobs](page:resources/jobs) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PaymentJobListResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentJobListResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentJobListResult response from the API call.</returns>
        Models.PaymentJobListResult ListPaymentJobs(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of [jobs](page:resources/jobs) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentJobListResult response from the API call.</returns>
        Task<Models.PaymentJobListResult> ListPaymentJobsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a [payment](page:resources/jobs).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        Models.PaymentJobResult CreatePaymentJob(
                PaymentJob body = null);

        /// <summary>
        /// Create a [payment](page:resources/jobs).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        Task<Models.PaymentJobResult> CreatePaymentJobAsync(
                PaymentJob body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single payment [job](page:resources/jobs).
        /// </summary>
        /// <param name="jobToken">Required parameter: Auto-generated unique identifier representing a job, prefixed with `jobs-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        Models.PaymentJobResult RetrievePaymentJob(
                string jobToken,
                string filter = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a single payment [job](page:resources/jobs).
        /// </summary>
        /// <param name="jobToken">Required parameter: Auto-generated unique identifier representing a job, prefixed with `jobs-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        Task<Models.PaymentJobResult> RetrievePaymentJobAsync(
                string jobToken,
                string filter = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel an submitted payment [job](page:resources/jobs).
        /// </summary>
        /// <param name="jobToken">Required parameter: Auto-generated unique identifier representing a job, prefixed with `jobs-`..</param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        Models.PaymentJobResult CancelPaymentJob(
                string jobToken);

        /// <summary>
        /// Cancel an submitted payment [job](page:resources/jobs).
        /// </summary>
        /// <param name="jobToken">Required parameter: Auto-generated unique identifier representing a job, prefixed with `jobs-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        Task<Models.PaymentJobResult> CancelPaymentJobAsync(
                string jobToken,
                CancellationToken cancellationToken = default);
    }
}