// <copyright file="IElectronicWalletsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IElectronicWalletsController.
    /// </summary>
    public interface IElectronicWalletsController
    {
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
        /// <returns>Returns the Models.ElectronicWalletListResult response from the API call.</returns>
        /// <returns>Returns the Models.ElectronicWalletListResult response from the API call.</returns>
        Models.ElectronicWalletListResult ListElectronicWallets(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.ElectronicWalletListResult> ListElectronicWalletsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new [electronic wallet](page:resources/electronic-wallets) using a user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        Models.ElectronicWalletResult CreateElectronicWallet(
                string userToken,
                Models.CreateOrUpdateElectronicWallet body = null);

        /// <summary>
        /// Create a new [electronic wallet](page:resources/electronic-wallets) using a user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        Task<Models.ElectronicWalletResult> CreateElectronicWalletAsync(
                string userToken,
                Models.CreateOrUpdateElectronicWallet body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve requirements for adding a [electronic wallet](page:resources/electronic-wallets) using the parameters provided.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="electronicWalletType">Optional parameter: Filter results by electronic wallet type..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <returns>Returns the Models.ElectronicWalletRequirementListResult response from the API call.</returns>
        /// <returns>Returns the Models.ElectronicWalletRequirementListResult response from the API call.</returns>
        /// <returns>Returns the Models.ElectronicWalletRequirementListResult response from the API call.</returns>
        Models.ElectronicWalletRequirementListResult RetrieveCreationRequirements(
                string userToken,
                Models.ElectronicWalletTypes? electronicWalletType = null,
                Models.Countries? country = null,
                Models.Currencies? currency = null);

        /// <summary>
        /// Retrieve requirements for adding a [electronic wallet](page:resources/electronic-wallets) using the parameters provided.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="electronicWalletType">Optional parameter: Filter results by electronic wallet type..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ElectronicWalletRequirementListResult response from the API call.</returns>
        Task<Models.ElectronicWalletRequirementListResult> RetrieveCreationRequirementsAsync(
                string userToken,
                Models.ElectronicWalletTypes? electronicWalletType = null,
                Models.Countries? country = null,
                Models.Currencies? currency = null,
                CancellationToken cancellationToken = default);

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
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        Models.ElectronicWalletResult RetrieveElectronicWallet(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

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
        Task<Models.ElectronicWalletResult> RetrieveElectronicWalletAsync(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a [electronic wallet](page:resources/electronic-wallets).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        Models.ElectronicWalletResult UpdateElectronicWallet(
                string userToken,
                string destinationToken,
                Models.CreateOrUpdateElectronicWallet body = null);

        /// <summary>
        /// Update a [electronic wallet](page:resources/electronic-wallets).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ElectronicWalletResult response from the API call.</returns>
        Task<Models.ElectronicWalletResult> UpdateElectronicWalletAsync(
                string userToken,
                string destinationToken,
                Models.CreateOrUpdateElectronicWallet body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a user [electronic wallet](page:resources/electronic-wallets).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        Models.OperationResult DeleteElectronicWallet(
                string userToken,
                string destinationToken);

        /// <summary>
        /// Delete a user [electronic wallet](page:resources/electronic-wallets).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        Task<Models.OperationResult> DeleteElectronicWalletAsync(
                string userToken,
                string destinationToken,
                CancellationToken cancellationToken = default);
    }
}