// <copyright file="UsersController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using PayQuickerSDK.Standard.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// UsersController.
    /// </summary>
    internal class UsersController : BaseController, IUsersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        internal UsersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [users](page:resources/user) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.UserListResult response from the API call.</returns>
        public Models.UserListResult ListUsers(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListUsersAsync(page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of [users](page:resources/user) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserListResult response from the API call.</returns>
        public async Task<Models.UserListResult> ListUsersAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users")
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
        /// Create a new [user](page:resources/user).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        public Models.UserResult CreateUser(
                Models.CreateOrUpdateUser body = null)
            => CoreHelper.RunTask(CreateUserAsync(body));

        /// <summary>
        /// Create a new [user](page:resources/user).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        public async Task<Models.UserResult> CreateUserAsync(
                Models.CreateOrUpdateUser body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/users")
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
        /// Update a [user](page:resources/user) object (change [email](#/rest/models/structures/email-address)], [address](#/rest/models/structures/address) change, etc.) using a user token.'.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        public Models.UserResult UpdateUser(
                string userToken,
                Models.CreateOrUpdateUser body = null)
            => CoreHelper.RunTask(UpdateUserAsync(userToken, body));

        /// <summary>
        /// Update a [user](page:resources/user) object (change [email](#/rest/models/structures/email-address)], [address](#/rest/models/structures/address) change, etc.) using a user token.'.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        public async Task<Models.UserResult> UpdateUserAsync(
                string userToken,
                Models.CreateOrUpdateUser body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/users/{user-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a single [user](page:resources/user) record by user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        public Models.UserResult RetrieveUser(
                string userToken)
            => CoreHelper.RunTask(RetrieveUserAsync(userToken));

        /// <summary>
        /// Retrieve a single [user](page:resources/user) record by user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        public async Task<Models.UserResult> RetrieveUserAsync(
                string userToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}