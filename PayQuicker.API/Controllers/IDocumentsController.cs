// <copyright file="IDocumentsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using PayQuicker.API.Http.Client;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IDocumentsController.
    /// </summary>
    public interface IDocumentsController
    {
        /// <summary>
        /// Retrieve a list of user [documents](page:resources/documents) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.DocumentListResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentListResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentListResult response from the API call.</returns>
        Models.DocumentListResult ListDocuments(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of user [documents](page:resources/documents) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocumentListResult response from the API call.</returns>
        Task<Models.DocumentListResult> ListDocumentsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a user [document](page:resources/documents).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="fields">Optional parameter: .</param>
        /// <param name="upload">Optional parameter: Document to be uploaded.</param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        Models.DocumentResult UploadDocument(
                string userToken,
                Models.CreateOrUpdateDocumentFields fields = null,
                FileStreamInfo upload = null);

        /// <summary>
        /// Upload a user [document](page:resources/documents).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="fields">Optional parameter: .</param>
        /// <param name="upload">Optional parameter: Document to be uploaded.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        Task<Models.DocumentResult> UploadDocumentAsync(
                string userToken,
                Models.CreateOrUpdateDocumentFields fields = null,
                FileStreamInfo upload = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single user [document](page:resources/documents) by its document token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        Models.DocumentResult RetrieveDocument(
                string userToken,
                string documentToken);

        /// <summary>
        /// Retrieve a single user [document](page:resources/documents) by its document token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        Task<Models.DocumentResult> RetrieveDocumentAsync(
                string userToken,
                string documentToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace the user [documents](page:resources/documents) at the given document token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="fields">Optional parameter: .</param>
        /// <param name="upload">Optional parameter: Document to be uploaded.</param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        Models.DocumentResult ReplaceDocument(
                string userToken,
                string documentToken,
                Models.CreateOrUpdateDocumentFields fields = null,
                FileStreamInfo upload = null);

        /// <summary>
        /// Replace the user [documents](page:resources/documents) at the given document token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="fields">Optional parameter: .</param>
        /// <param name="upload">Optional parameter: Document to be uploaded.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        Task<Models.DocumentResult> ReplaceDocumentAsync(
                string userToken,
                string documentToken,
                Models.CreateOrUpdateDocumentFields fields = null,
                FileStreamInfo upload = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a list of user documents that the user can provide.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.DocumentRequirementsListResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentRequirementsListResult response from the API call.</returns>
        /// <returns>Returns the Models.DocumentRequirementsListResult response from the API call.</returns>
        Models.DocumentRequirementsListResult ListUserDocumentRequirements(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Returns a list of user documents that the user can provide.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocumentRequirementsListResult response from the API call.</returns>
        Task<Models.DocumentRequirementsListResult> ListUserDocumentRequirementsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);
    }
}