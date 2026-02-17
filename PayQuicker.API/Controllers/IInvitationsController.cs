// <copyright file="IInvitationsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IInvitationsController.
    /// </summary>
    public interface IInvitationsController
    {
        /// <summary>
        /// Retrieve a list of [invitations](page:resources/invitations) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.InvitationListResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationListResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationListResult response from the API call.</returns>
        Models.InvitationListResult ListInvitations(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.InvitationListResult> ListInvitationsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        Models.InvitationResult CreateInvitation(
                Models.CreateInvitation body = null);

        /// <summary>
        /// Create a [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        Task<Models.InvitationResult> CreateInvitationAsync(
                Models.CreateInvitation body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single [invitation](page:resources/invitations).
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        Models.InvitationResult RetrieveInvitation(
                string invitationToken,
                string filter = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a single [invitation](page:resources/invitations).
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        Task<Models.InvitationResult> RetrieveInvitationAsync(
                string invitationToken,
                string filter = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Accept an open [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        Models.InvitationResult UpdateInvitation(
                string invitationToken);

        /// <summary>
        /// Accept an open [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        Task<Models.InvitationResult> UpdateInvitationAsync(
                string invitationToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel an open [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        Models.InvitationResult CancelInvitation(
                string invitationToken);

        /// <summary>
        /// Cancel an open [invitation](page:resources/invitations) quote.
        /// </summary>
        /// <param name="invitationToken">Required parameter: Auto-generated unique identifier representing an invite, prefixed with `invt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvitationResult response from the API call.</returns>
        Task<Models.InvitationResult> CancelInvitationAsync(
                string invitationToken,
                CancellationToken cancellationToken = default);
    }
}