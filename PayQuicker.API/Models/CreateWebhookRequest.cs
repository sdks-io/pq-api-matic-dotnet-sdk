// <copyright file="CreateWebhookRequest.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// CreateWebhookRequest.
    /// </summary>
    public class CreateWebhookRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest"/> class.
        /// </summary>
        public CreateWebhookRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest"/> class.
        /// </summary>
        /// <param name="mNamespace">namespace.</param>
        /// <param name="url">url.</param>
        public CreateWebhookRequest(
            Models.WebhookNamespaces? mNamespace = null,
            string url = null)
        {
            this.MNamespace = mNamespace;
            this.Url = url;
        }

        /// <summary>
        /// Namespace used to identify and refer to the object
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WebhookNamespaces? MNamespace { get; set; }

        /// <summary>
        /// Full path of the URI used for this object
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateWebhookRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateWebhookRequest other &&
                (this.MNamespace == null && other.MNamespace == null ||
                 this.MNamespace?.Equals(other.MNamespace) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MNamespace = {(this.MNamespace == null ? "null" : this.MNamespace.ToString())}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}