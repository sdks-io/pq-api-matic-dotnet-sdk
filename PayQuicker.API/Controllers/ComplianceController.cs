// <copyright file="ComplianceController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using PayQuicker.API.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// ComplianceController.
    /// </summary>
    internal class ComplianceController : BaseController, IComplianceController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceController"/> class.
        /// </summary>
        internal ComplianceController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#list-user-idv-checks) by user token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <returns>Returns the Models.IdvCheckListResult response from the API call.</returns>
        public Models.IdvCheckListResult ListIdentityChecks(
                string userToken)
            => CoreHelper.RunTask(ListIdentityChecksAsync(userToken));

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#list-user-idv-checks) by user token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IdvCheckListResult response from the API call.</returns>
        public async Task<Models.IdvCheckListResult> ListIdentityChecksAsync(
                string userToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IdvCheckListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/idv-checks")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#retrieve-user-idv-check) by IDVC token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="idvcToken">Required parameter: Auto-generated unique identifier representing a user IDV check, prefixed with `idvc-`..</param>
        /// <returns>Returns the Models.IdvCheckResult response from the API call.</returns>
        public Models.IdvCheckResult RetrieveIdentityCheck(
                string userToken,
                string idvcToken)
            => CoreHelper.RunTask(RetrieveIdentityCheckAsync(userToken, idvcToken));

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#retrieve-user-idv-check) by IDVC token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="idvcToken">Required parameter: Auto-generated unique identifier representing a user IDV check, prefixed with `idvc-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IdvCheckResult response from the API call.</returns>
        public async Task<Models.IdvCheckResult> RetrieveIdentityCheckAsync(
                string userToken,
                string idvcToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IdvCheckResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/idv-checks/{idvc-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("idvc-token", idvcToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}