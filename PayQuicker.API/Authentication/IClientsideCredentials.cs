// <copyright file="IClientsideCredentials.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>

namespace PayQuicker.API.Authentication
{
    /// <summary>
    /// Authentication configuration interface for Clientside.
    /// </summary>
    public interface IClientsideCredentials
    {
        /// <summary>
        /// Gets string value for accessToken.
        /// </summary>
        string AccessToken { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="accessToken"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string accessToken);
    }
}