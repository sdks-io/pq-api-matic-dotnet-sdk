// <copyright file="ApiErrorResultException.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using PayQuicker.API.Http.Client;
using System.Collections.Generic;

namespace PayQuicker.API.Exceptions
{
    /// <summary>
    /// ApiErrorResultException.
    /// </summary>
    public class ApiErrorResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiErrorResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ApiErrorResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Error Severity
        /// </summary>
        [JsonProperty("severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Error Code Name
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// Error Code Number
        /// </summary>
        [JsonProperty("code")]
        public double Code { get; set; }

        /// <summary>
        /// Description of the error.
        /// </summary>
        [JsonProperty("message")]
        public new string Message { get; set; }

        /// <summary>
        /// Reference ID for issue tracking.
        /// </summary>
        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Timestamp of when the error occurred.
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// Request reference for issue tracking.
        /// </summary>
        [JsonProperty("requestRef", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestRef { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ApiErrorResultException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Severity = {this.Severity ?? "null"}");
            toStringOutput.Add($"Error = {this.Error ?? "null"}");
            toStringOutput.Add($"Code = {this.Code}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"ReferenceId = {this.ReferenceId ?? "null"}");
            toStringOutput.Add($"Timestamp = {this.Timestamp ?? "null"}");
            toStringOutput.Add($"RequestRef = {this.RequestRef ?? "null"}");
            toStringOutput.Add($"StackTrace = {(StackTrace != null ? $"\n{StackTrace}" : "null")}");
        }
    }
}