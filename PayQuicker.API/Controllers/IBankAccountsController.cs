// <copyright file="IBankAccountsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IBankAccountsController.
    /// </summary>
    public interface IBankAccountsController
    {
        /// <summary>
        /// Retrieve a list of [bank accounts](page:resources/bank-accounts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.BankAccountListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountListResult response from the API call.</returns>
        Models.BankAccountListResult ListBankAccounts(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of [bank accounts](page:resources/bank-accounts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountListResult response from the API call.</returns>
        Task<Models.BankAccountListResult> ListBankAccountsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a [bank account](page:resources/bank-accounts) using a user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Models.BankAccountResult CreateBankAccount(
                string userToken,
                Models.CreateOrUpdateBankAccount body = null);

        /// <summary>
        /// Create a [bank account](page:resources/bank-accounts) using a user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Task<Models.BankAccountResult> CreateBankAccountAsync(
                string userToken,
                Models.CreateOrUpdateBankAccount body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single [bank account](page:resources/bank-accounts) using a destination token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Models.BankAccountResult RetrieveBankAccount(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a single [bank account](page:resources/bank-accounts) using a destination token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Task<Models.BankAccountResult> RetrieveBankAccountAsync(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Models.BankAccountResult UpdateBankAccount(
                string userToken,
                string destinationToken,
                Models.CreateOrUpdateBankAccount body = null);

        /// <summary>
        /// Update a [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Task<Models.BankAccountResult> UpdateBankAccountAsync(
                string userToken,
                string destinationToken,
                Models.CreateOrUpdateBankAccount body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a user [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        Models.OperationResult DeleteBankAccount(
                string userToken,
                string destinationToken);

        /// <summary>
        /// Delete a user [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        Task<Models.OperationResult> DeleteBankAccountAsync(
                string userToken,
                string destinationToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        Models.BankAccountRequirementListResult RetrieveCreationRequirements(
                string userToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null);

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        Task<Models.BankAccountRequirementListResult> RetrieveCreationRequirementsAsync(
                string userToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a list of company [bank accounts](page:resources/bank-accounts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.BankAccountListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountListResult response from the API call.</returns>
        Models.BankAccountListResult ListCompanyBankAccounts(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of company [bank accounts](page:resources/bank-accounts) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountListResult response from the API call.</returns>
        Task<Models.BankAccountListResult> ListCompanyBankAccountsAsync(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a company [bank account](page:resources/bank-accounts) using an account token.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Models.BankAccountResult CreateCompanyBankAccount(
                string accountToken,
                Models.CreateOrUpdateBankAccount body = null);

        /// <summary>
        /// Create a company [bank account](page:resources/bank-accounts) using an account token.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Task<Models.BankAccountResult> CreateCompanyBankAccountAsync(
                string accountToken,
                Models.CreateOrUpdateBankAccount body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single company [bank account](page:resources/bank-accounts) using a destination token.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Models.BankAccountResult RetrieveCompanyBankAccount(
                string accountToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a single company [bank account](page:resources/bank-accounts) using a destination token.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Task<Models.BankAccountResult> RetrieveCompanyBankAccountAsync(
                string accountToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a company [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Models.BankAccountResult UpdateCompanyBankAccount(
                string accountToken,
                string destinationToken,
                Models.CreateOrUpdateBankAccount body = null);

        /// <summary>
        /// Update a company [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        Task<Models.BankAccountResult> UpdateCompanyBankAccountAsync(
                string accountToken,
                string destinationToken,
                Models.CreateOrUpdateBankAccount body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a company [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        Models.OperationResult DeleteCompanyBankAccount(
                string accountToken,
                string destinationToken);

        /// <summary>
        /// Delete a company [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        Task<Models.OperationResult> DeleteCompanyBankAccountAsync(
                string accountToken,
                string destinationToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        Models.BankAccountRequirementListResult RetrieveCompanyBankAccountCreationRequirements(
                string accountToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null);

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        Task<Models.BankAccountRequirementListResult> RetrieveCompanyBankAccountCreationRequirementsAsync(
                string accountToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the pre-paid card as the destination.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        Models.BankAccountRequirementListResult RetrieveBankAccountCreationRequirementsForAPrepaidCard(
                string userToken,
                string destinationToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null);

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the pre-paid card as the destination.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        Task<Models.BankAccountRequirementListResult> RetrieveBankAccountCreationRequirementsForAPrepaidCardAsync(
                string userToken,
                string destinationToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null,
                CancellationToken cancellationToken = default);
    }
}