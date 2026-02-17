// <copyright file="IAgreementsController.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuicker.API.Controllers
{
    /// <summary>
    /// IAgreementsController.
    /// </summary>
    public interface IAgreementsController
    {
        /// <summary>
        /// Retrieve a list of program [agreements](page:resources/agreements) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.AgreementListResultJson response from the API call.</returns>
        /// <returns>Returns the Models.AgreementListResultJson response from the API call.</returns>
        /// <returns>Returns the Models.AgreementListResultJson response from the API call.</returns>
        Models.AgreementListResultJson ListAgreements(
                string programToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of program [agreements](page:resources/agreements) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AgreementListResultJson response from the API call.</returns>
        Task<Models.AgreementListResultJson> ListAgreementsAsync(
                string programToken,
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single program [agreement](page:resources/agreements).
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="agreementToken">Required parameter: Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`..</param>
        /// <returns>Returns the Models.AgreementResult response from the API call.</returns>
        /// <returns>Returns the Models.AgreementResult response from the API call.</returns>
        /// <returns>Returns the Models.AgreementResult response from the API call.</returns>
        Models.AgreementResult RetrieveProgramAgreement(
                string programToken,
                string agreementToken);

        /// <summary>
        /// Retrieve a single program [agreement](page:resources/agreements).
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="agreementToken">Required parameter: Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AgreementResult response from the API call.</returns>
        Task<Models.AgreementResult> RetrieveProgramAgreementAsync(
                string programToken,
                string agreementToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Accept a single program [agreement](page:resources/agreements).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="agreementToken">Required parameter: Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`..</param>
        void AcceptAgreement(
                string userToken,
                string agreementToken);

        /// <summary>
        /// Accept a single program [agreement](page:resources/agreements).
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="agreementToken">Required parameter: Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        Task AcceptAgreementAsync(
                string userToken,
                string agreementToken,
                CancellationToken cancellationToken = default);
    }
}