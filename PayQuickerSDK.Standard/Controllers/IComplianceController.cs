// <copyright file="IComplianceController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// IComplianceController.
    /// </summary>
    public interface IComplianceController
    {
        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#list-user-idv-checks) by user token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <returns>Returns the Models.IdvCheckListResult response from the API call.</returns>
        /// <returns>Returns the Models.IdvCheckListResult response from the API call.</returns>
        /// <returns>Returns the Models.IdvCheckListResult response from the API call.</returns>
        Models.IdvCheckListResult ListIdentityChecks(
                string userToken);

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#list-user-idv-checks) by user token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IdvCheckListResult response from the API call.</returns>
        Task<Models.IdvCheckListResult> ListIdentityChecksAsync(
                string userToken,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#retrieve-user-idv-check) by IDVC token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="idvcToken">Required parameter: Auto-generated unique identifier representing a user IDV check, prefixed with `idvc-`..</param>
        /// <returns>Returns the Models.IdvCheckResult response from the API call.</returns>
        /// <returns>Returns the Models.IdvCheckResult response from the API call.</returns>
        /// <returns>Returns the Models.IdvCheckResult response from the API call.</returns>
        Models.IdvCheckResult RetrieveIdentityCheck(
                string userToken,
                string idvcToken);

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#retrieve-user-idv-check) by IDVC token that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="userToken">Required parameter: Auto-generated unique identifier representing a user, prefixed with `user-`..</param>
        /// <param name="idvcToken">Required parameter: Auto-generated unique identifier representing a user IDV check, prefixed with `idvc-`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IdvCheckResult response from the API call.</returns>
        Task<Models.IdvCheckResult> RetrieveIdentityCheckAsync(
                string userToken,
                string idvcToken,
                CancellationToken cancellationToken = default);
    }
}