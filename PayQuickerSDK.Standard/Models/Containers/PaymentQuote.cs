// <copyright file="PaymentQuote.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<PaymentQuote>),
        new[] {
            typeof(GatewayPaymentQuoteCase),
            typeof(PortalPaymentQuoteCase)
        },
        true
    )]
    public abstract class PaymentQuote
    {
        /// <summary>
        /// This is Gateway Payment Quote case.
        /// </summary>
        /// <returns>
        /// The PaymentQuote instance, wrapping the provided GatewayPaymentQuote value.
        /// </returns>
        public static PaymentQuote FromGatewayPaymentQuote(GatewayPaymentQuote gatewayPaymentQuote)
        {
            return new GatewayPaymentQuoteCase().Set(gatewayPaymentQuote);
        }

        /// <summary>
        /// This is PortalPaymentQuote case.
        /// </summary>
        /// <returns>
        /// The PaymentQuote instance, wrapping the provided PortalPaymentQuote value.
        /// </returns>
        public static PaymentQuote FromPortalPaymentQuote(PortalPaymentQuote portalPaymentQuote)
        {
            return new PortalPaymentQuoteCase().Set(portalPaymentQuote);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<GatewayPaymentQuote, T> gatewayPaymentQuote, Func<PortalPaymentQuote, T> portalPaymentQuote);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<GatewayPaymentQuote, T> gatewayPaymentQuote = null, Func<PortalPaymentQuote, T> portalPaymentQuote = null) =>
                Match(gatewayPaymentQuote, portalPaymentQuote);

        [JsonConverter(typeof(UnionTypeCaseConverter<GatewayPaymentQuoteCase, GatewayPaymentQuote>))]
        private sealed class GatewayPaymentQuoteCase : PaymentQuote, ICaseValue<GatewayPaymentQuoteCase, GatewayPaymentQuote>
        {
            public GatewayPaymentQuote Value;

            public override T Match<T>(Func<GatewayPaymentQuote, T> gatewayPaymentQuote, Func<PortalPaymentQuote, T> portalPaymentQuote) =>
                   gatewayPaymentQuote != null ? gatewayPaymentQuote(Value) : default;

            public GatewayPaymentQuoteCase Set(GatewayPaymentQuote value)
            {
                Value = value;
                return this;
            }

            public GatewayPaymentQuote Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GatewayPaymentQuoteCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PortalPaymentQuoteCase, PortalPaymentQuote>))]
        private sealed class PortalPaymentQuoteCase : PaymentQuote, ICaseValue<PortalPaymentQuoteCase, PortalPaymentQuote>
        {
            public PortalPaymentQuote Value;

            public override T Match<T>(Func<GatewayPaymentQuote, T> gatewayPaymentQuote, Func<PortalPaymentQuote, T> portalPaymentQuote) =>
                   portalPaymentQuote != null ? portalPaymentQuote(Value) : default;

            public PortalPaymentQuoteCase Set(PortalPaymentQuote value)
            {
                Value = value;
                return this;
            }

            public PortalPaymentQuote Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PortalPaymentQuoteCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}