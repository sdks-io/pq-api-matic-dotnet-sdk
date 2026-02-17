// <copyright file="ClientSideController.cs" company="APIMatic">
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
    /// ClientSideController.
    /// </summary>
    internal class ClientSideController : BaseController, IClientSideController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideController"/> class.
        /// </summary>
        internal ClientSideController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Generate a token used to reveal [prepaid card](page:resources/prepaid-cards) information in the form of image data (base64) or JSON.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="format">Required parameter: Desired format for the prepaid card data..</param>
        /// <param name="side">Optional parameter: Side to specify when retrieving a prepaid card's image data. *Required if IMAGE format specified..</param>
        /// <returns>Returns the Models.PrepaidCardDataTokenResult response from the API call.</returns>
        public Models.PrepaidCardDataTokenResult CreateCardDataToken(
                string userToken,
                string destinationToken,
                Models.PrepaidCardDataType format,
                Models.PrepaidCardImageSide? side = null)
            => CoreHelper.RunTask(CreateCardDataTokenAsync(userToken, destinationToken, format, side));

        /// <summary>
        /// Generate a token used to reveal [prepaid card](page:resources/prepaid-cards) information in the form of image data (base64) or JSON.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="format">Required parameter: Desired format for the prepaid card data..</param>
        /// <param name="side">Optional parameter: Side to specify when retrieving a prepaid card's image data. *Required if IMAGE format specified..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardDataTokenResult response from the API call.</returns>
        public async Task<Models.PrepaidCardDataTokenResult> CreateCardDataTokenAsync(
                string userToken,
                string destinationToken,
                Models.PrepaidCardDataType format,
                Models.PrepaidCardImageSide? side = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PrepaidCardDataTokenResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/prepaid-cards/{destination-token}/pci")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
                      .Query(query => query.Setup("format", CoreHelper.JsonSerialize(format).Trim('\"')))
                      .Query(query => query.Setup("side", (side.HasValue) ? CoreHelper.JsonSerialize(side.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Return [prepaid card](page:resources/prepaid-cards) data in the form of image data, text, or both.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="format">Required parameter: Desired format for the prepaid card data..</param>
        /// <param name="side">Optional parameter: Side to specify when retrieving a prepaid card's image data. *Required if IMAGE format specified..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PrepaidCardDataResult response from the API call.</returns>
        public Models.PrepaidCardDataResult RetrieveCardData(
                string userToken,
                string destinationToken,
                Models.PrepaidCardDataType format,
                Models.PrepaidCardImageSide? side = null,
                Models.RetrieveCardData body = null)
            => CoreHelper.RunTask(RetrieveCardDataAsync(userToken, destinationToken, format, side, body));

        /// <summary>
        /// Return [prepaid card](page:resources/prepaid-cards) data in the form of image data, text, or both.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="format">Required parameter: Desired format for the prepaid card data..</param>
        /// <param name="side">Optional parameter: Side to specify when retrieving a prepaid card's image data. *Required if IMAGE format specified..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardDataResult response from the API call.</returns>
        public async Task<Models.PrepaidCardDataResult> RetrieveCardDataAsync(
                string userToken,
                string destinationToken,
                Models.PrepaidCardDataType format,
                Models.PrepaidCardImageSide? side = null,
                Models.RetrieveCardData body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PrepaidCardDataResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/users/{user-token}/prepaid-cards/{destination-token}/pci")
                  .WithAuth("clientside")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
                      .Query(query => query.Setup("format", CoreHelper.JsonSerialize(format).Trim('\"')))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Query(query => query.Setup("side", (side.HasValue) ? CoreHelper.JsonSerialize(side.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve one part of a two-part token required to reveal or set a client side [prepaid card](page:resources/prepaid-cards) PIN.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.PrepaidCardPinTokenResult response from the API call.</returns>
        public Models.PrepaidCardPinTokenResult CreateCardPINToken(
                string userToken,
                string destinationToken)
            => CoreHelper.RunTask(CreateCardPINTokenAsync(userToken, destinationToken));

        /// <summary>
        /// Retrieve one part of a two-part token required to reveal or set a client side [prepaid card](page:resources/prepaid-cards) PIN.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardPinTokenResult response from the API call.</returns>
        public async Task<Models.PrepaidCardPinTokenResult> CreateCardPINTokenAsync(
                string userToken,
                string destinationToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PrepaidCardPinTokenResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/prepaid-cards/{destination-token}/pin")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Set a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards), if supported by program.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        public Models.OperationResult UpdateCardPIN(
                string userToken,
                string destinationToken,
                Models.UpdateCardPin body = null)
            => CoreHelper.RunTask(UpdateCardPINAsync(userToken, destinationToken, body));

        /// <summary>
        /// Set a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards), if supported by program.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        public async Task<Models.OperationResult> UpdateCardPINAsync(
                string userToken,
                string destinationToken,
                Models.UpdateCardPin body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OperationResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/users/{user-token}/prepaid-cards/{destination-token}/pin")
                  .WithAuth("clientside")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reveal a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PrepaidCardPinResult response from the API call.</returns>
        public Models.PrepaidCardPinResult RetrieveCardPIN(
                string userToken,
                string destinationToken,
                Models.RetrieveCardPin body = null)
            => CoreHelper.RunTask(RetrieveCardPINAsync(userToken, destinationToken, body));

        /// <summary>
        /// Reveal a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardPinResult response from the API call.</returns>
        public async Task<Models.PrepaidCardPinResult> RetrieveCardPINAsync(
                string userToken,
                string destinationToken,
                Models.RetrieveCardPin body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PrepaidCardPinResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/users/{user-token}/prepaid-cards/{destination-token}/pin")
                  .WithAuth("clientside")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}