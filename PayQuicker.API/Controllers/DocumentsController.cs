// <copyright file="DocumentsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using PayQuicker.API.Exceptions;
using PayQuicker.API.Http.Client;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// DocumentsController.
    /// </summary>
    internal class DocumentsController : BaseController, IDocumentsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsController"/> class.
        /// </summary>
        internal DocumentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

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
        public Models.DocumentListResult ListDocuments(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListDocumentsAsync(userToken, page, pageSize, filter, sort, language));

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
        public async Task<Models.DocumentListResult> ListDocumentsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DocumentListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/documents")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
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
        /// Upload a user [document](page:resources/documents).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="fields">Optional parameter: .</param>
        /// <param name="upload">Optional parameter: Document to be uploaded.</param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        public Models.DocumentResult UploadDocument(
                string userToken,
                Models.CreateOrUpdateDocumentFields fields = null,
                FileStreamInfo upload = null)
            => CoreHelper.RunTask(UploadDocumentAsync(userToken, fields, upload));

        /// <summary>
        /// Upload a user [document](page:resources/documents).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="fields">Optional parameter: .</param>
        /// <param name="upload">Optional parameter: Document to be uploaded.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        public async Task<Models.DocumentResult> UploadDocumentAsync(
                string userToken,
                Models.CreateOrUpdateDocumentFields fields = null,
                FileStreamInfo upload = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DocumentResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/users/{user-token}/documents")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Form(form => form.EncodingHeader("Content-Type", "application/json").Setup("fields", fields))
                      .Form(form => form.EncodingHeader("Content-Type", string.IsNullOrEmpty(upload.ContentType) ? "image/png" : upload.ContentType).Setup("upload", upload))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a single user [document](page:resources/documents) by its document token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        public Models.DocumentResult RetrieveDocument(
                string userToken,
                string documentToken)
            => CoreHelper.RunTask(RetrieveDocumentAsync(userToken, documentToken));

        /// <summary>
        /// Retrieve a single user [document](page:resources/documents) by its document token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        public async Task<Models.DocumentResult> RetrieveDocumentAsync(
                string userToken,
                string documentToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DocumentResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/documents/{document-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("document-token", documentToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Replace the user [documents](page:resources/documents) at the given document token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="fields">Optional parameter: .</param>
        /// <param name="upload">Optional parameter: Document to be uploaded.</param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        public Models.DocumentResult ReplaceDocument(
                string userToken,
                string documentToken,
                Models.CreateOrUpdateDocumentFields fields = null,
                FileStreamInfo upload = null)
            => CoreHelper.RunTask(ReplaceDocumentAsync(userToken, documentToken, fields, upload));

        /// <summary>
        /// Replace the user [documents](page:resources/documents) at the given document token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="documentToken">Required parameter: Auto-generated unique identifier representing an uploaded document, prefixed with `docu-`..</param>
        /// <param name="fields">Optional parameter: .</param>
        /// <param name="upload">Optional parameter: Document to be uploaded.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocumentResult response from the API call.</returns>
        public async Task<Models.DocumentResult> ReplaceDocumentAsync(
                string userToken,
                string documentToken,
                Models.CreateOrUpdateDocumentFields fields = null,
                FileStreamInfo upload = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DocumentResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/users/{user-token}/documents/{document-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("document-token", documentToken).Required())
                      .Form(form => form.EncodingHeader("Content-Type", "application/json").Setup("fields", fields))
                      .Form(form => form.EncodingHeader("Content-Type", string.IsNullOrEmpty(upload.ContentType) ? "image/png" : upload.ContentType).Setup("upload", upload))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

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
        public Models.DocumentRequirementsListResult ListUserDocumentRequirements(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListUserDocumentRequirementsAsync(userToken, page, pageSize, filter, sort, language));

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
        public async Task<Models.DocumentRequirementsListResult> ListUserDocumentRequirementsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DocumentRequirementsListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/documents/requirements")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
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
    }
}