// <copyright file="WebhooksController.cs" company="APIMatic">
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
    /// WebhooksController.
    /// </summary>
    internal class WebhooksController : BaseController, IWebhooksController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksController"/> class.
        /// </summary>
        internal WebhooksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of all [webhook subscriptions](page:resources/webhooks) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.WebhookSubscriptionListResult response from the API call.</returns>
        public Models.WebhookSubscriptionListResult ListSubscriptions(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListSubscriptionsAsync(page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of all [webhook subscriptions](page:resources/webhooks) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionListResult response from the API call.</returns>
        public async Task<Models.WebhookSubscriptionListResult> ListSubscriptionsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WebhookSubscriptionListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/webhooks")
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
        /// Update a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        public Models.WebhookSubscriptionResult UpdateSubscription(
                Models.CreateWebhookRequest body = null)
            => CoreHelper.RunTask(UpdateSubscriptionAsync(body));

        /// <summary>
        /// Update a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        public async Task<Models.WebhookSubscriptionResult> UpdateSubscriptionAsync(
                Models.CreateWebhookRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WebhookSubscriptionResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/webhooks")
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
        /// Create a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        public Models.WebhookSubscriptionResult CreateSubscription(
                Models.CreateWebhookRequest body = null)
            => CoreHelper.RunTask(CreateSubscriptionAsync(body));

        /// <summary>
        /// Create a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        public async Task<Models.WebhookSubscriptionResult> CreateSubscriptionAsync(
                Models.CreateWebhookRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WebhookSubscriptionResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/webhooks")
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
        /// Retrieve a single [webhook subscription](page:resources/webhooks) using the webhook token.
        /// </summary>
        /// <param name="webhookToken">Required parameter: Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`..</param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        public Models.WebhookSubscriptionResult RetrieveSubscription(
                string webhookToken)
            => CoreHelper.RunTask(RetrieveSubscriptionAsync(webhookToken));

        /// <summary>
        /// Retrieve a single [webhook subscription](page:resources/webhooks) using the webhook token.
        /// </summary>
        /// <param name="webhookToken">Required parameter: Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        public async Task<Models.WebhookSubscriptionResult> RetrieveSubscriptionAsync(
                string webhookToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WebhookSubscriptionResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/webhooks/{webhook-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("webhook-token", webhookToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="webhookToken">Required parameter: Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`..</param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        public Models.WebhookSubscriptionResult DeleteSubscription(
                string webhookToken)
            => CoreHelper.RunTask(DeleteSubscriptionAsync(webhookToken));

        /// <summary>
        /// Delete a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="webhookToken">Required parameter: Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        public async Task<Models.WebhookSubscriptionResult> DeleteSubscriptionAsync(
                string webhookToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WebhookSubscriptionResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/webhooks/{webhook-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("webhook-token", webhookToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}