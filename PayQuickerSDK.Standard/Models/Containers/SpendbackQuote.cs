// <copyright file="SpendbackQuote.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace PayQuickerSDK.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<SpendbackQuote>),
        new[] {
            typeof(GatewaySpendbackQuoteCase),
            typeof(PortalSpendbackQuoteCase)
        },
        true
    )]
    public abstract class SpendbackQuote
    {
        /// <summary>
        /// This is GatewaySpendbackQuote case.
        /// </summary>
        /// <returns>
        /// The SpendbackQuote instance, wrapping the provided GatewaySpendbackQuote value.
        /// </returns>
        public static SpendbackQuote FromGatewaySpendbackQuote(GatewaySpendbackQuote gatewaySpendbackQuote)
        {
            return new GatewaySpendbackQuoteCase().Set(gatewaySpendbackQuote);
        }

        /// <summary>
        /// This is PortalSpendbackQuote case.
        /// </summary>
        /// <returns>
        /// The SpendbackQuote instance, wrapping the provided PortalSpendbackQuote value.
        /// </returns>
        public static SpendbackQuote FromPortalSpendbackQuote(PortalSpendbackQuote portalSpendbackQuote)
        {
            return new PortalSpendbackQuoteCase().Set(portalSpendbackQuote);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<GatewaySpendbackQuote, T> gatewaySpendbackQuote, Func<PortalSpendbackQuote, T> portalSpendbackQuote);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<GatewaySpendbackQuote, T> gatewaySpendbackQuote = null, Func<PortalSpendbackQuote, T> portalSpendbackQuote = null) =>
                Match(gatewaySpendbackQuote, portalSpendbackQuote);

        [JsonConverter(typeof(UnionTypeCaseConverter<GatewaySpendbackQuoteCase, GatewaySpendbackQuote>))]
        private sealed class GatewaySpendbackQuoteCase : SpendbackQuote, ICaseValue<GatewaySpendbackQuoteCase, GatewaySpendbackQuote>
        {
            public GatewaySpendbackQuote Value;

            public override T Match<T>(Func<GatewaySpendbackQuote, T> gatewaySpendbackQuote, Func<PortalSpendbackQuote, T> portalSpendbackQuote) =>
                   gatewaySpendbackQuote != null ? gatewaySpendbackQuote(Value) : default;

            public GatewaySpendbackQuoteCase Set(GatewaySpendbackQuote value)
            {
                Value = value;
                return this;
            }

            public GatewaySpendbackQuote Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GatewaySpendbackQuoteCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PortalSpendbackQuoteCase, PortalSpendbackQuote>))]
        private sealed class PortalSpendbackQuoteCase : SpendbackQuote, ICaseValue<PortalSpendbackQuoteCase, PortalSpendbackQuote>
        {
            public PortalSpendbackQuote Value;

            public override T Match<T>(Func<GatewaySpendbackQuote, T> gatewaySpendbackQuote, Func<PortalSpendbackQuote, T> portalSpendbackQuote) =>
                   portalSpendbackQuote != null ? portalSpendbackQuote(Value) : default;

            public PortalSpendbackQuoteCase Set(PortalSpendbackQuote value)
            {
                Value = value;
                return this;
            }

            public PortalSpendbackQuote Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PortalSpendbackQuoteCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}