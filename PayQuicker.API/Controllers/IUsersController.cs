// <copyright file="IUsersController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IUsersController.
    /// </summary>
    public interface IUsersController
    {
        /// <summary>
        /// Retrieve a list of [users](page:resources/user) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.UserListResult response from the API call.</returns>
        /// <returns>Returns the Models.UserListResult response from the API call.</returns>
        /// <returns>Returns the Models.UserListResult response from the API call.</returns>
        Models.UserListResult ListUsers(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.UserListResult> ListUsersAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new [user](page:resources/user).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        Models.UserResult CreateUser(
                Models.CreateOrUpdateUser body = null);

        /// <summary>
        /// Create a new [user](page:resources/user).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        Task<Models.UserResult> CreateUserAsync(
                Models.CreateOrUpdateUser body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a [user](page:resources/user) object (change [email](#/rest/models/structures/email-address)], [address](#/rest/models/structures/address) change, etc.) using a user token.'.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        Models.UserResult UpdateUser(
                string userToken,
                Models.CreateOrUpdateUser body = null);

        /// <summary>
        /// Update a [user](page:resources/user) object (change [email](#/rest/models/structures/email-address)], [address](#/rest/models/structures/address) change, etc.) using a user token.'.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        Task<Models.UserResult> UpdateUserAsync(
                string userToken,
                Models.CreateOrUpdateUser body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single [user](page:resources/user) record by user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        Models.UserResult RetrieveUser(
                string userToken);

        /// <summary>
        /// Retrieve a single [user](page:resources/user) record by user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResult response from the API call.</returns>
        Task<Models.UserResult> RetrieveUserAsync(
                string userToken,
                CancellationToken cancellationToken = default);
    }
}