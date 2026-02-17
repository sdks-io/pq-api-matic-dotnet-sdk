// <copyright file="IOAuthAuthorizationController.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PayQuickerSDK.Standard.Controllers
{
    /// <summary>
    /// IOAuthAuthorizationController.
    /// </summary>
    public interface IOAuthAuthorizationController
    {
        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="authorization">Required parameter: Authorization header in Basic auth format.</param>
        /// <param name="scope">Optional parameter: Requested scopes as a space-delimited list..</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.OAuthToken response from the API call.</returns>
        /// <returns>Returns the Models.OAuthToken response from the API call.</returns>
        /// <returns>Returns the Models.OAuthToken response from the API call.</returns>
        Models.OAuthToken RequestTokenServer(
                string authorization,
                string scope = null,
                Dictionary<string, object> fieldParameters = null);

        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="authorization">Required parameter: Authorization header in Basic auth format.</param>
        /// <param name="scope">Optional parameter: Requested scopes as a space-delimited list..</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OAuthToken response from the API call.</returns>
        Task<Models.OAuthToken> RequestTokenServerAsync(
                string authorization,
                string scope = null,
                Dictionary<string, object> fieldParameters = null,
                CancellationToken cancellationToken = default);
    }
}