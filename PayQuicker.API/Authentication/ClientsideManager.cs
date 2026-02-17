// <copyright file="ClientsideManager.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using APIMatic.Core.Authentication;

namespace PayQuicker.API.Authentication
{
    /// <summary>
    /// ClientsideManager.
    /// </summary>
    internal class ClientsideManager : AuthManager, IClientsideCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientsideManager"/> class.
        /// </summary>
        /// <param name="clientsideModel">ClientsideModel.</param>
        public ClientsideManager(ClientsideModel clientsideModel)
        {
            this.AccessToken = clientsideModel?.AccessToken;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("Authorization",
                    this.AccessToken == null ? null : $"Bearer {this.AccessToken}"
                ).Required()));
        }

        /// <summary>
        /// Gets string value for accessToken.
        /// </summary>
        public string AccessToken { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="accessToken"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string accessToken)
        {
            return accessToken.Equals(this.AccessToken);
        }

    }

    public sealed class ClientsideModel
    {
        internal ClientsideModel()
        {
        }

        internal string AccessToken { get; set; }

        /// <summary>
        /// Creates an object of the ClientsideModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(AccessToken);
        }

        /// <summary>
        /// Builder class for ClientsideModel.
        /// </summary>
        public class Builder
        {
            private string accessToken;

            public Builder(string accessToken)
            {
                this.accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
            }

            /// <summary>
            /// Sets AccessToken.
            /// </summary>
            /// <param name="accessToken">AccessToken.</param>
            /// <returns>Builder.</returns>
            public Builder AccessToken(string accessToken)
            {
                this.accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
                return this;
            }

            /// <summary>
            /// Creates an object of the ClientsideModel using the values provided for the builder.
            /// </summary>
            /// <returns>ClientsideModel.</returns>
            public ClientsideModel Build()
            {
                return new ClientsideModel()
                {
                    AccessToken = this.accessToken
                };
            }
        }

        internal static ClientsideModel FromOptions(ClientsideModelOptions options)
        {
            var builder = new Builder(options.AccessToken);
            return builder.Build();
        }
    }

    public class ClientsideModelOptions
    {
        public string AccessToken { get; set; }
    }
}