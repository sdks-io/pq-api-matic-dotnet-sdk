// <copyright file="IEventsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IEventsController.
    /// </summary>
    public interface IEventsController
    {
        /// <summary>
        /// Retrieve a list of [user events](page:resources/user#list-user-events) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <returns>Returns the Models.EventListResult response from the API call.</returns>
        /// <returns>Returns the Models.EventListResult response from the API call.</returns>
        /// <returns>Returns the Models.EventListResult response from the API call.</returns>
        Models.EventListResult ListEvents(
                string userToken);

        /// <summary>
        /// Retrieve a list of [user events](page:resources/user#list-user-events) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EventListResult response from the API call.</returns>
        Task<Models.EventListResult> ListEventsAsync(
                string userToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single [user event](page:resources/user#get-user-event).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="eventToken">Required parameter: Auto-generated unique identifier representing an event, prefixed with `evnt-`..</param>
        /// <returns>Returns the Models.UserEventResult response from the API call.</returns>
        /// <returns>Returns the Models.UserEventResult response from the API call.</returns>
        /// <returns>Returns the Models.UserEventResult response from the API call.</returns>
        Models.UserEventResult RetrieveEvent(
                string userToken,
                string eventToken);

        /// <summary>
        /// Retrieve a single [user event](page:resources/user#get-user-event).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="eventToken">Required parameter: Auto-generated unique identifier representing an event, prefixed with `evnt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserEventResult response from the API call.</returns>
        Task<Models.UserEventResult> RetrieveEventAsync(
                string userToken,
                string eventToken,
                CancellationToken cancellationToken = default);
    }
}