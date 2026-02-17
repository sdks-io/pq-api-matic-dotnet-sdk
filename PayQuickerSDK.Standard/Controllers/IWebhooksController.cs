// <copyright file="IWebhooksController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// IWebhooksController.
    /// </summary>
    public interface IWebhooksController
    {
        /// <summary>
        /// Retrieve a list of all [webhook subscriptions](page:resources/webhooks) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.WebhookSubscriptionListResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionListResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionListResult response from the API call.</returns>
        Models.WebhookSubscriptionListResult ListSubscriptions(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.WebhookSubscriptionListResult> ListSubscriptionsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        Models.WebhookSubscriptionResult UpdateSubscription(
                Models.CreateWebhookRequest body = null);

        /// <summary>
        /// Update a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        Task<Models.WebhookSubscriptionResult> UpdateSubscriptionAsync(
                Models.CreateWebhookRequest body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        Models.WebhookSubscriptionResult CreateSubscription(
                Models.CreateWebhookRequest body = null);

        /// <summary>
        /// Create a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        Task<Models.WebhookSubscriptionResult> CreateSubscriptionAsync(
                Models.CreateWebhookRequest body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single [webhook subscription](page:resources/webhooks) using the webhook token.
        /// </summary>
        /// <param name="webhookToken">Required parameter: Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`..</param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        Models.WebhookSubscriptionResult RetrieveSubscription(
                string webhookToken);

        /// <summary>
        /// Retrieve a single [webhook subscription](page:resources/webhooks) using the webhook token.
        /// </summary>
        /// <param name="webhookToken">Required parameter: Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        Task<Models.WebhookSubscriptionResult> RetrieveSubscriptionAsync(
                string webhookToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="webhookToken">Required parameter: Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`..</param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        Models.WebhookSubscriptionResult DeleteSubscription(
                string webhookToken);

        /// <summary>
        /// Delete a [webhook subscription](page:resources/webhooks).
        /// </summary>
        /// <param name="webhookToken">Required parameter: Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WebhookSubscriptionResult response from the API call.</returns>
        Task<Models.WebhookSubscriptionResult> DeleteSubscriptionAsync(
                string webhookToken,
                CancellationToken cancellationToken = default);
    }
}