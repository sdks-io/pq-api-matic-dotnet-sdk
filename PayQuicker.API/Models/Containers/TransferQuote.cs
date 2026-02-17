// <copyright file="TransferQuote.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace PayQuicker.API.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<TransferQuote>),
        new[] {
            typeof(GatewayTransferQuoteCase),
            typeof(PortalTransferQuoteCase)
        },
        true
    )]
    public abstract class TransferQuote
    {
        /// <summary>
        /// This is GatewayTransferQuote case.
        /// </summary>
        /// <returns>
        /// The TransferQuote instance, wrapping the provided GatewayTransferQuote value.
        /// </returns>
        public static TransferQuote FromGatewayTransferQuote(GatewayTransferQuote gatewayTransferQuote)
        {
            return new GatewayTransferQuoteCase().Set(gatewayTransferQuote);
        }

        /// <summary>
        /// This is PortalTransferQuote case.
        /// </summary>
        /// <returns>
        /// The TransferQuote instance, wrapping the provided PortalTransferQuote value.
        /// </returns>
        public static TransferQuote FromPortalTransferQuote(PortalTransferQuote portalTransferQuote)
        {
            return new PortalTransferQuoteCase().Set(portalTransferQuote);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<GatewayTransferQuote, T> gatewayTransferQuote, Func<PortalTransferQuote, T> portalTransferQuote);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<GatewayTransferQuote, T> gatewayTransferQuote = null, Func<PortalTransferQuote, T> portalTransferQuote = null) =>
                Match(gatewayTransferQuote, portalTransferQuote);

        [JsonConverter(typeof(UnionTypeCaseConverter<GatewayTransferQuoteCase, GatewayTransferQuote>))]
        private sealed class GatewayTransferQuoteCase : TransferQuote, ICaseValue<GatewayTransferQuoteCase, GatewayTransferQuote>
        {
            public GatewayTransferQuote Value;

            public override T Match<T>(Func<GatewayTransferQuote, T> gatewayTransferQuote, Func<PortalTransferQuote, T> portalTransferQuote) =>
                   gatewayTransferQuote != null ? gatewayTransferQuote(Value) : default;

            public GatewayTransferQuoteCase Set(GatewayTransferQuote value)
            {
                Value = value;
                return this;
            }

            public GatewayTransferQuote Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GatewayTransferQuoteCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PortalTransferQuoteCase, PortalTransferQuote>))]
        private sealed class PortalTransferQuoteCase : TransferQuote, ICaseValue<PortalTransferQuoteCase, PortalTransferQuote>
        {
            public PortalTransferQuote Value;

            public override T Match<T>(Func<GatewayTransferQuote, T> gatewayTransferQuote, Func<PortalTransferQuote, T> portalTransferQuote) =>
                   portalTransferQuote != null ? portalTransferQuote(Value) : default;

            public PortalTransferQuoteCase Set(PortalTransferQuote value)
            {
                Value = value;
                return this;
            }

            public PortalTransferQuote Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PortalTransferQuoteCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}