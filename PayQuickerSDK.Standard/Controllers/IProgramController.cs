// <copyright file="IProgramController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// IProgramController.
    /// </summary>
    public interface IProgramController
    {
        /// <summary>
        /// Retrieve a list of [programs](page:resources/programs) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.ProgramListResult response from the API call.</returns>
        /// <returns>Returns the Models.ProgramListResult response from the API call.</returns>
        /// <returns>Returns the Models.ProgramListResult response from the API call.</returns>
        Models.ProgramListResult ListPrograms(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a list of [programs](page:resources/programs) that supports filtering, sorting, and pagination through existing mechanisms.
        /// </summary>
        /// <param name="page">Required parameter: Page number of specific page to return.</param>
        /// <param name="pageSize">Required parameter: Number of items to be displayed per page.</param>
        /// <param name="filter">Optional parameter: Filter request results by specific criteria..</param>
        /// <param name="sort">Optional parameter: Sort request results by specific attribute..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramListResult response from the API call.</returns>
        Task<Models.ProgramListResult> ListProgramsAsync(
                int page,
                int pageSize,
                string filter = null,
                string sort = null,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a single [program](page:resources/programs) by its program token.
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <returns>Returns the Models.ProgramResult response from the API call.</returns>
        /// <returns>Returns the Models.ProgramResult response from the API call.</returns>
        /// <returns>Returns the Models.ProgramResult response from the API call.</returns>
        Models.ProgramResult RetrieveProgram(
                string programToken,
                Models.Languages? language = null);

        /// <summary>
        /// Retrieve a single [program](page:resources/programs) by its program token.
        /// </summary>
        /// <param name="programToken">Required parameter: Auto-generated unique identifier representing a program, prefixed with `prog-`..</param>
        /// <param name="language">Optional parameter: Filter results by language type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramResult response from the API call.</returns>
        Task<Models.ProgramResult> RetrieveProgramAsync(
                string programToken,
                Models.Languages? language = null,
                CancellationToken cancellationToken = default);
    }
}