// <copyright file="InvitationsController.cs" company="APIMatic">
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
    /// InvitationsController.
    /// </summary>
    internal class InvitationsController : BaseController, IInvitationsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationsController"/> class.
        /// </summary>
        internal InvitationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [invitations](page:resources/invitations) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.InvitationListResult response from the API call.</returns>
        public Models.InvitationListResult ListInvitations(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListInvitationsAsync(page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of [invitations](page:resources/invitations) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationListResult response from the API call.</returns>
        public async Task<Models.InvitationListResult> ListInvitationsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvitationListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/invitations")
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
        /// Create a [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        public Models.InvitationResult CreateInvitation(
                Models.CreateInvitation body = null)
            => CoreHelper.RunTask(CreateInvitationAsync(body));

        /// <summary>
        /// Create a [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        public async Task<Models.InvitationResult> CreateInvitationAsync(
                Models.CreateInvitation body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvitationResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/invitations")
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
        /// Retrieve a single [invitation](page:resources/invitations).
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        public Models.InvitationResult RetrieveInvitation(
                string invitationToken,
                string filter = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(RetrieveInvitationAsync(invitationToken, filter, language));

        /// <summary>
        /// Retrieve a single [invitation](page:resources/invitations).
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        public async Task<Models.InvitationResult> RetrieveInvitationAsync(
                string invitationToken,
                string filter = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvitationResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/invitations/{invitation-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("invitation-token", invitationToken).Required())
                      .Query(query => query.Setup("filter", filter))
                      .Query(query => query.Setup("language", (language.HasValue) ? CoreHelper.JsonSerialize(language.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Accept an open [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        public Models.InvitationResult UpdateInvitation(
                string invitationToken)
            => CoreHelper.RunTask(UpdateInvitationAsync(invitationToken));

        /// <summary>
        /// Accept an open [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        public async Task<Models.InvitationResult> UpdateInvitationAsync(
                string invitationToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvitationResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/invitations/{invitation-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("invitation-token", invitationToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancel an open [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        public Models.InvitationResult CancelInvitation(
                string invitationToken)
            => CoreHelper.RunTask(CancelInvitationAsync(invitationToken));

        /// <summary>
        /// Cancel an open [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        public async Task<Models.InvitationResult> CancelInvitationAsync(
                string invitationToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvitationResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/invitations/{invitation-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("invitation-token", invitationToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}