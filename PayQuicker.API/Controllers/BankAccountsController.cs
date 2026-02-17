// <copyright file="BankAccountsController.cs" company="APIMatic">
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
    /// BankAccountsController.
    /// </summary>
    internal class BankAccountsController : BaseController, IBankAccountsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountsController"/> class.
        /// </summary>
        internal BankAccountsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

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
        public Models.BankAccountListResult ListBankAccounts(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListBankAccountsAsync(userToken, page, pageSize, filter, sort, language));

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
        public async Task<Models.BankAccountListResult> ListBankAccountsAsync(
                string userToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/bank-accounts")
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
        /// Create a [bank account](page:resources/bank-accounts) using a user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        public Models.BankAccountResult CreateBankAccount(
                string userToken,
                Models.CreateOrUpdateBankAccount body = null)
            => CoreHelper.RunTask(CreateBankAccountAsync(userToken, body));

        /// <summary>
        /// Create a [bank account](page:resources/bank-accounts) using a user token.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        public async Task<Models.BankAccountResult> CreateBankAccountAsync(
                string userToken,
                Models.CreateOrUpdateBankAccount body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/users/{user-token}/bank-accounts")
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
        public Models.BankAccountResult RetrieveBankAccount(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(RetrieveBankAccountAsync(userToken, destinationToken, page, pageSize, filter, sort, language));

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
        public async Task<Models.BankAccountResult> RetrieveBankAccountAsync(
                string userToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/bank-accounts/{destination-token}")
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
        /// Update a [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        public Models.BankAccountResult UpdateBankAccount(
                string userToken,
                string destinationToken,
                Models.CreateOrUpdateBankAccount body = null)
            => CoreHelper.RunTask(UpdateBankAccountAsync(userToken, destinationToken, body));

        /// <summary>
        /// Update a [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        public async Task<Models.BankAccountResult> UpdateBankAccountAsync(
                string userToken,
                string destinationToken,
                Models.CreateOrUpdateBankAccount body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/users/{user-token}/bank-accounts/{destination-token}")
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
        /// Delete a user [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        public Models.OperationResult DeleteBankAccount(
                string userToken,
                string destinationToken)
            => CoreHelper.RunTask(DeleteBankAccountAsync(userToken, destinationToken));

        /// <summary>
        /// Delete a user [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        public async Task<Models.OperationResult> DeleteBankAccountAsync(
                string userToken,
                string destinationToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OperationResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/users/{user-token}/bank-accounts/{destination-token}")
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
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        public Models.BankAccountRequirementListResult RetrieveCreationRequirements(
                string userToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null)
            => CoreHelper.RunTask(RetrieveCreationRequirementsAsync(userToken, country, currency));

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        public async Task<Models.BankAccountRequirementListResult> RetrieveCreationRequirementsAsync(
                string userToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountRequirementListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/bank-accounts/requirements")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Query(query => query.Setup("country", (country.HasValue) ? CoreHelper.JsonSerialize(country.Value).Trim('\"') : null))
                      .Query(query => query.Setup("currency", (currency.HasValue) ? CoreHelper.JsonSerialize(currency.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

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
        public Models.BankAccountListResult ListCompanyBankAccounts(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(ListCompanyBankAccountsAsync(accountToken, page, pageSize, filter, sort, language));

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
        public async Task<Models.BankAccountListResult> ListCompanyBankAccountsAsync(
                string accountToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/accounts/{account-token}/bank-accounts")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("account-token", accountToken).Required())
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
        /// Create a company [bank account](page:resources/bank-accounts) using an account token.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        public Models.BankAccountResult CreateCompanyBankAccount(
                string accountToken,
                Models.CreateOrUpdateBankAccount body = null)
            => CoreHelper.RunTask(CreateCompanyBankAccountAsync(accountToken, body));

        /// <summary>
        /// Create a company [bank account](page:resources/bank-accounts) using an account token.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        public async Task<Models.BankAccountResult> CreateCompanyBankAccountAsync(
                string accountToken,
                Models.CreateOrUpdateBankAccount body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/accounts/{account-token}/bank-accounts")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("account-token", accountToken).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

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
        public Models.BankAccountResult RetrieveCompanyBankAccount(
                string accountToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null)
            => CoreHelper.RunTask(RetrieveCompanyBankAccountAsync(accountToken, destinationToken, page, pageSize, filter, sort, language));

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
        public async Task<Models.BankAccountResult> RetrieveCompanyBankAccountAsync(
                string accountToken,
                string destinationToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/accounts/{account-token}/bank-accounts/{destination-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("account-token", accountToken).Required())
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
        /// Update a company [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        public Models.BankAccountResult UpdateCompanyBankAccount(
                string accountToken,
                string destinationToken,
                Models.CreateOrUpdateBankAccount body = null)
            => CoreHelper.RunTask(UpdateCompanyBankAccountAsync(accountToken, destinationToken, body));

        /// <summary>
        /// Update a company [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResult response from the API call.</returns>
        public async Task<Models.BankAccountResult> UpdateCompanyBankAccountAsync(
                string accountToken,
                string destinationToken,
                Models.CreateOrUpdateBankAccount body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/accounts/{account-token}/bank-accounts/{destination-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("account-token", accountToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a company [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        public Models.OperationResult DeleteCompanyBankAccount(
                string accountToken,
                string destinationToken)
            => CoreHelper.RunTask(DeleteCompanyBankAccountAsync(accountToken, destinationToken));

        /// <summary>
        /// Delete a company [bank account](page:resources/bank-accounts).
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OperationResult response from the API call.</returns>
        public async Task<Models.OperationResult> DeleteCompanyBankAccountAsync(
                string accountToken,
                string destinationToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OperationResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/accounts/{account-token}/bank-accounts/{destination-token}")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("account-token", accountToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        public Models.BankAccountRequirementListResult RetrieveCompanyBankAccountCreationRequirements(
                string accountToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null)
            => CoreHelper.RunTask(RetrieveCompanyBankAccountCreationRequirementsAsync(accountToken, country, currency));

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        /// </summary>
        /// <param name="accountToken">Required parameter: Auto-generated unique identifier representing a company account, prefixed with `acct-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        public async Task<Models.BankAccountRequirementListResult> RetrieveCompanyBankAccountCreationRequirementsAsync(
                string accountToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountRequirementListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/accounts/{account-token}/bank-accounts/requirements")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("account-token", accountToken).Required())
                      .Query(query => query.Setup("country", (country.HasValue) ? CoreHelper.JsonSerialize(country.Value).Trim('\"') : null))
                      .Query(query => query.Setup("currency", (currency.HasValue) ? CoreHelper.JsonSerialize(currency.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the pre-paid card as the destination.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        public Models.BankAccountRequirementListResult RetrieveBankAccountCreationRequirementsForAPrepaidCard(
                string userToken,
                string destinationToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null)
            => CoreHelper.RunTask(RetrieveBankAccountCreationRequirementsForAPrepaidCardAsync(userToken, destinationToken, country, currency));

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the pre-paid card as the destination.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="destinationToken">Required parameter: Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`..</param>
        /// <param name="country">Optional parameter: Filter results by country..</param>
        /// <param name="currency">Optional parameter: Filter results by currency..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountRequirementListResult response from the API call.</returns>
        public async Task<Models.BankAccountRequirementListResult> RetrieveBankAccountCreationRequirementsForAPrepaidCardAsync(
                string userToken,
                string destinationToken,
                Models.Countries? country = null,
                Models.Currencies? currency = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountRequirementListResult>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/users/{user-token}/prepaid-cards/{destination-token}/bank-accounts/requirements")
                  .WithAuth("server")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("user-token", userToken).Required())
                      .Template(template => template.Setup("destination-token", destinationToken).Required())
                      .Query(query => query.Setup("country", (country.HasValue) ? CoreHelper.JsonSerialize(country.Value).Trim('\"') : null))
                      .Query(query => query.Setup("currency", (currency.HasValue) ? CoreHelper.JsonSerialize(currency.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("500", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context)))
                  .ErrorCase("0", CreateErrorCase("", (errorReason, context) => new ApiErrorResultException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}