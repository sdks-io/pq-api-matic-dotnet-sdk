// <copyright file="AgreementsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using PayQuicker.API.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// AgreementsController.
    /// </summary>
    internal class AgreementsController : BaseController, IAgreementsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementsController"/> class.
        /// </summary>
        internal AgreementsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of program [agreements](page:resources/agreements) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.AgreementListResultJson response from the API call.</returns>
        public Models.AgreementListResultJson ListAgreements(
                string programToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListAgreementsAsync(programToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of program [agreements](page:resources/agreements) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AgreementListResultJson response from the API call.</returns>
        public async Task<Models.AgreementListResultJson> ListAgreementsAsync(
                string programToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AgreementListResultJson>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/programs/{program-token}/agreements")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("program-token", programToken).Required())
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
        /// Retrieve a single program [agreement](page:resources/agreements).
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="agreementToken">Required parameter: Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`..</param>
        /// <returns>Returns the Models.AgreementResult response from the API call.</returns>
        public Models.AgreementResult RetrieveProgramAgreement(
                string programToken,
                string agreementToken)
            => CoreHelper.RunTask(RetrieveProgramAgreementAsync(programToken, agreementToken));

        /// <summary>
        /// Retrieve a single program [agreement](page:resources/agreements).
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="agreementToken">Required parameter: Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AgreementResult response from the API call.</returns>
        public async Task<Models.AgreementResult> RetrieveProgramAgreementAsync(
                string programToken,
                string agreementToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AgreementResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/programs/{program-token}/agreements/{agreement-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("program-token", programToken).Required())
                      .Template(template => template.Setup("agreement-token", agreementToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Accept a single program [agreement](page:resources/agreements).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="agreementToken">Required parameter: Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`..</param>
        public void AcceptAgreement(
                string userToken,
                string agreementToken)
            => CoreHelper.RunVoidTask(AcceptAgreementAsync(userToken, agreementToken));

        /// <summary>
        /// Accept a single program [agreement](page:resources/agreements).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="agreementToken">Required parameter: Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task AcceptAgreementAsync(
                string userToken,
                string agreementToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/users/{user-token}/agreements/{agreement-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("agreement-token", agreementToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}