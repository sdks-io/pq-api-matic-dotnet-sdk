// <copyright file="ElectronicWalletsController.cs" company="APIMatic">
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
    /// ElectronicWalletsController.
    /// </summary>
    internal class ElectronicWalletsController : BaseController, IElectronicWalletsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletsController"/> class.
        /// </summary>
        internal ElectronicWalletsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of [electronic wallets](page:resources/electronic-wallets) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.ElectronicWalletListResult response from the API call.</returns>
        public Models.ElectronicWalletListResult ListElectronicWallets(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListElectronicWalletsAsync(userToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a list of [electronic wallets](page:resources/electronic-wallets) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ElectronicWalletListResult response from the API call.</returns>
        public async Task<Models.ElectronicWalletListResult> ListElectronicWalletsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ElectronicWalletListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/electronic-wallets")
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
        /// Create a new [electronic wallet](page:resources/electronic-wallets) using a user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        public Models.ElectronicWalletResult CreateElectronicWallet(
                string userToken,
                Models.CreateOrUpdateElectronicWallet body = null)
            => CoreHelper.RunTask(CreateElectronicWalletAsync(userToken, body));

        /// <summary>
        /// Create a new [electronic wallet](page:resources/electronic-wallets) using a user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        public async Task<Models.ElectronicWalletResult> CreateElectronicWalletAsync(
                string userToken,
                Models.CreateOrUpdateElectronicWallet body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ElectronicWalletResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/users/{user-token}/electronic-wallets")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve requirements for adding a [electronic wallet](page:resources/electronic-wallets) using the parameters provided.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="electronicWalletType">Optional parameter: Filter results by electronic wallet type..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <returns>Returns the Models.ElectronicWalletRequirementListResult response from the API call.</returns>
        public Models.ElectronicWalletRequirementListResult RetrieveCreationRequirements(
                string userToken,
                Models.ElectronicWalletTypes? electronicWalletType = null,
                Models.Countries? country = null,
                Models.Currencies? currency = null)
            => CoreHelper.RunTask(RetrieveCreationRequirementsAsync(userToken, electronicWalletType, country, currency));

        /// <summary>
        /// Retrieve requirements for adding a [electronic wallet](page:resources/electronic-wallets) using the parameters provided.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="electronicWalletType">Optional parameter: Filter results by electronic wallet type..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ElectronicWalletRequirementListResult response from the API call.</returns>
        public async Task<Models.ElectronicWalletRequirementListResult> RetrieveCreationRequirementsAsync(
                string userToken,
                Models.ElectronicWalletTypes? electronicWalletType = null,
                Models.Countries? country = null,
                Models.Currencies? currency = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ElectronicWalletRequirementListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/electronic-wallets/requirements")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Query(query => query.Setup("electronicWalletType", (electronicWalletType.HasValue) ? CoreHelper.JsonSerialize(electronicWalletType.Value).Trim('\"') : null))
                      .Query(query => query.Setup("country", (country.HasValue) ? CoreHelper.JsonSerialize(country.Value).Trim('\"') : null))
                      .Query(query => query.Setup("currency", (currency.HasValue) ? CoreHelper.JsonSerialize(currency.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a single [electronic wallet](page:resources/electronic-wallets) using a destination token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        public Models.ElectronicWalletResult RetrieveElectronicWallet(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(RetrieveElectronicWalletAsync(userToken, destinationToken, page, pageSize, filter, sort, language));

        /// <summary>
        /// Retrieve a single [electronic wallet](page:resources/electronic-wallets) using a destination token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        public async Task<Models.ElectronicWalletResult> RetrieveElectronicWalletAsync(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ElectronicWalletResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/electronic-wallets/{destination-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
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
        /// Update a [electronic wallet](page:resources/electronic-wallets).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        public Models.ElectronicWalletResult UpdateElectronicWallet(
                string userToken,
                string destinationToken,
                Models.CreateOrUpdateElectronicWallet body = null)
            => CoreHelper.RunTask(UpdateElectronicWalletAsync(userToken, destinationToken, body));

        /// <summary>
        /// Update a [electronic wallet](page:resources/electronic-wallets).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        public async Task<Models.ElectronicWalletResult> UpdateElectronicWalletAsync(
                string userToken,
                string destinationToken,
                Models.CreateOrUpdateElectronicWallet body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ElectronicWalletResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/users/{user-token}/electronic-wallets/{destination-token}")
                  .WithAuth("server")
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
        /// Delete a user [electronic wallet](page:resources/electronic-wallets).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        public Models.OperationResult DeleteElectronicWallet(
                string userToken,
                string destinationToken)
            => CoreHelper.RunTask(DeleteElectronicWalletAsync(userToken, destinationToken));

        /// <summary>
        /// Delete a user [electronic wallet](page:resources/electronic-wallets).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        public async Task<Models.OperationResult> DeleteElectronicWalletAsync(
                string userToken,
                string destinationToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OperationResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/users/{user-token}/electronic-wallets/{destination-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}