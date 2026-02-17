// <copyright file="JobsController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using PayQuickerSDK.Standard.Exceptions;
using PayQuickerSDK.Standard.Models.Containers;
using PayQuickerSDK.Standard.Utilities;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// JobsController.
    /// </summary>
    internal class JobsController : BaseController, IJobsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobsController"/> class.
        /// </summary>
        internal JobsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [jobs](page:resources/jobs) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PaymentJobListResult response from the API call.</returns>
        public Models.PaymentJobListResult ListPaymentJobs(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListPaymentJobsAsync(page, pageSize, filter, sort, language));

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
        public async Task<Models.PaymentJobListResult> ListPaymentJobsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentJobListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/payments/jobs")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
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
        /// Create a [payment](page:resources/jobs).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        public Models.PaymentJobResult CreatePaymentJob(
                PaymentJob body = null)
            => CoreHelper.RunTask(CreatePaymentJobAsync(body));

        /// <summary>
        /// Create a [payment](page:resources/jobs).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        public async Task<Models.PaymentJobResult> CreatePaymentJobAsync(
                PaymentJob body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentJobResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/payments/jobs")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a single payment [job](page:resources/jobs).
        /// </summary>
        /// <param name="jobToken">Required parameter: Auto-generated unique identifier representing a job, prefixed with `jobs-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        public Models.PaymentJobResult RetrievePaymentJob(
                string jobToken,
                string filter = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(RetrievePaymentJobAsync(jobToken, filter, language));

        /// <summary>
        /// Retrieve a single payment [job](page:resources/jobs).
        /// </summary>
        /// <param name="jobToken">Required parameter: Auto-generated unique identifier representing a job, prefixed with `jobs-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        public async Task<Models.PaymentJobResult> RetrievePaymentJobAsync(
                string jobToken,
                string filter = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentJobResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/payments/jobs/{job-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("job-token", jobToken).Required())
                      .Query(query => query.Setup("filter", filter))
                      .Query(query => query.Setup("language", (language.HasValue) ? CoreHelper.JsonSerialize(language.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancel an submitted payment [job](page:resources/jobs).
        /// </summary>
        /// <param name="jobToken">Required parameter: Auto-generated unique identifier representing a job, prefixed with `jobs-`..</param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        public Models.PaymentJobResult CancelPaymentJob(
                string jobToken)
            => CoreHelper.RunTask(CancelPaymentJobAsync(jobToken));

        /// <summary>
        /// Cancel an submitted payment [job](page:resources/jobs).
        /// </summary>
        /// <param name="jobToken">Required parameter: Auto-generated unique identifier representing a job, prefixed with `jobs-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentJobResult response from the API call.</returns>
        public async Task<Models.PaymentJobResult> CancelPaymentJobAsync(
                string jobToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentJobResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/payments/jobs/{job-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("job-token", jobToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}