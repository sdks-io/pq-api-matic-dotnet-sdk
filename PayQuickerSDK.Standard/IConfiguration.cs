// <copyright file="IConfiguration.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using PayQuickerSDK.Standard.Authentication;

namespace PayQuickerSDK.Standard
{
    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Date-based API Version specified in the header *required* on all calls.
        /// </summary>
        string XMyPayQuickerVersion { get; }

        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets Sandbox Environments
        /// </summary>
        Models.SandboxInstance SandboxInstance { get; }

        /// <summary>
        /// Gets UAT Environments
        /// </summary>
        Models.UatInstance UatInstance { get; }

        /// <summary>
        /// Gets the credentials to use with Server.
        /// </summary>
        IServerCredentials ServerCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with Server.
        /// </summary>
        ServerModel ServerModel { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:API.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Api);
    }
}