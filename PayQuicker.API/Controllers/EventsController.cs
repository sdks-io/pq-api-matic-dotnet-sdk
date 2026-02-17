// <copyright file="EventsController.cs" company="APIMatic">
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
    /// EventsController.
    /// </summary>
    internal class EventsController : BaseController, IEventsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsController"/> class.
        /// </summary>
        internal EventsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [user events](page:resources/user#list-user-events) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <returns>Returns the Models.EventListResult response from the API call.</returns>
        public Models.EventListResult ListEvents(
                string userToken)
            => CoreHelper.RunTask(ListEventsAsync(userToken));

        /// <summary>
        /// Retrieve a list of [user events](page:resources/user#list-user-events) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EventListResult response from the API call.</returns>
        public async Task<Models.EventListResult> ListEventsAsync(
                string userToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EventListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/events")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a single [user event](page:resources/user#get-user-event).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="eventToken">Required parameter: Auto-generated unique identifier representing an event, prefixed with `evnt-`..</param>
        /// <returns>Returns the Models.UserEventResult response from the API call.</returns>
        public Models.UserEventResult RetrieveEvent(
                string userToken,
                string eventToken)
            => CoreHelper.RunTask(RetrieveEventAsync(userToken, eventToken));

        /// <summary>
        /// Retrieve a single [user event](page:resources/user#get-user-event).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="eventToken">Required parameter: Auto-generated unique identifier representing an event, prefixed with `evnt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserEventResult response from the API call.</returns>
        public async Task<Models.UserEventResult> RetrieveEventAsync(
                string userToken,
                string eventToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserEventResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/events/{event-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("event-token", eventToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}