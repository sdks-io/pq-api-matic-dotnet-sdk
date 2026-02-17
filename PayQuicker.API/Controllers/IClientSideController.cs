// <copyright file="IClientSideController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IClientSideController.
    /// </summary>
    public interface IClientSideController
    {
        /// <summary>
        /// Generate a token used to reveal [prepaid card](page:resources/prepaid-cards) information in the form of image data (base64) or JSON.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="format">Required parameter: Desired format for the prepaid card data..</param>
        /// <param name="side">Optional parameter: Side to specify when retrieving a prepaid card's image data. *Required if IMAGE format specified..</param>
        /// <returns>Returns the Models.PrepaidCardDataTokenResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardDataTokenResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardDataTokenResult response from the API call.</returns>
        Models.PrepaidCardDataTokenResult CreateCardDataToken(
                string userToken,
                string destinationToken,
                Models.PrepaidCardDataType format,
                Models.PrepaidCardImageSide? side = null);

        /// <summary>
        /// Generate a token used to reveal [prepaid card](page:resources/prepaid-cards) information in the form of image data (base64) or JSON.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="format">Required parameter: Desired format for the prepaid card data..</param>
        /// <param name="side">Optional parameter: Side to specify when retrieving a prepaid card's image data. *Required if IMAGE format specified..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardDataTokenResult response from the API call.</returns>
        Task<Models.PrepaidCardDataTokenResult> CreateCardDataTokenAsync(
                string userToken,
                string destinationToken,
                Models.PrepaidCardDataType format,
                Models.PrepaidCardImageSide? side = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Return [prepaid card](page:resources/prepaid-cards) data in the form of image data, text, or both.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="format">Required parameter: Desired format for the prepaid card data..</param>
        /// <param name="side">Optional parameter: Side to specify when retrieving a prepaid card's image data. *Required if IMAGE format specified..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PrepaidCardDataResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardDataResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardDataResult response from the API call.</returns>
        Models.PrepaidCardDataResult RetrieveCardData(
                string userToken,
                string destinationToken,
                Models.PrepaidCardDataType format,
                Models.PrepaidCardImageSide? side = null,
                Models.RetrieveCardData body = null);

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
        Task<Models.PrepaidCardDataResult> RetrieveCardDataAsync(
                string userToken,
                string destinationToken,
                Models.PrepaidCardDataType format,
                Models.PrepaidCardImageSide? side = null,
                Models.RetrieveCardData body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve one part of a two-part token required to reveal or set a client side [prepaid card](page:resources/prepaid-cards) PIN.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.PrepaidCardPinTokenResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardPinTokenResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardPinTokenResult response from the API call.</returns>
        Models.PrepaidCardPinTokenResult CreateCardPINToken(
                string userToken,
                string destinationToken);

        /// <summary>
        /// Retrieve one part of a two-part token required to reveal or set a client side [prepaid card](page:resources/prepaid-cards) PIN.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardPinTokenResult response from the API call.</returns>
        Task<Models.PrepaidCardPinTokenResult> CreateCardPINTokenAsync(
                string userToken,
                string destinationToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Set a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards), if supported by program.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        Models.OperationResult UpdateCardPIN(
                string userToken,
                string destinationToken,
                Models.UpdateCardPin body = null);

        /// <summary>
        /// Set a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards), if supported by program.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        Task<Models.OperationResult> UpdateCardPINAsync(
                string userToken,
                string destinationToken,
                Models.UpdateCardPin body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Reveal a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PrepaidCardPinResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardPinResult response from the API call.</returns>
        /// <returns>Returns the Models.PrepaidCardPinResult response from the API call.</returns>
        Models.PrepaidCardPinResult RetrieveCardPIN(
                string userToken,
                string destinationToken,
                Models.RetrieveCardPin body = null);

        /// <summary>
        /// Reveal a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidCardPinResult response from the API call.</returns>
        Task<Models.PrepaidCardPinResult> RetrieveCardPINAsync(
                string userToken,
                string destinationToken,
                Models.RetrieveCardPin body = null,
                CancellationToken cancellationToken = default);
    }
}