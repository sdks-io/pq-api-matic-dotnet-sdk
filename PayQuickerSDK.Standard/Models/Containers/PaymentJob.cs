// <copyright file="PaymentJob.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<PaymentJob>),
        new[] {
            typeof(GatewayPaymentJobCase),
            typeof(PortalPaymentJobCase)
        },
        true
    )]
    public abstract class PaymentJob
    {
        /// <summary>
        /// This is Gateway Payment Job case.
        /// </summary>
        /// <returns>
        /// The PaymentJob instance, wrapping the provided GatewayPaymentJob value.
        /// </returns>
        public static PaymentJob FromGatewayPaymentJob(GatewayPaymentJob gatewayPaymentJob)
        {
            return new GatewayPaymentJobCase().Set(gatewayPaymentJob);
        }

        /// <summary>
        /// This is Portal Payment Job case.
        /// </summary>
        /// <returns>
        /// The PaymentJob instance, wrapping the provided PortalPaymentJob value.
        /// </returns>
        public static PaymentJob FromPortalPaymentJob(PortalPaymentJob portalPaymentJob)
        {
            return new PortalPaymentJobCase().Set(portalPaymentJob);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<GatewayPaymentJob, T> gatewayPaymentJob, Func<PortalPaymentJob, T> portalPaymentJob);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(Func<GatewayPaymentJob, T> gatewayPaymentJob = null, Func<PortalPaymentJob, T> portalPaymentJob = null) =>
                Match(gatewayPaymentJob, portalPaymentJob);

        [JsonConverter(typeof(UnionTypeCaseConverter<GatewayPaymentJobCase, GatewayPaymentJob>))]
        private sealed class GatewayPaymentJobCase : PaymentJob, ICaseValue<GatewayPaymentJobCase, GatewayPaymentJob>
        {
            public GatewayPaymentJob Value;

            public override T Match<T>(Func<GatewayPaymentJob, T> gatewayPaymentJob, Func<PortalPaymentJob, T> portalPaymentJob) =>
                   gatewayPaymentJob != null ? gatewayPaymentJob(Value) : default;

            public GatewayPaymentJobCase Set(GatewayPaymentJob value)
            {
                Value = value;
                return this;
            }

            public GatewayPaymentJob Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GatewayPaymentJobCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PortalPaymentJobCase, PortalPaymentJob>))]
        private sealed class PortalPaymentJobCase : PaymentJob, ICaseValue<PortalPaymentJobCase, PortalPaymentJob>
        {
            public PortalPaymentJob Value;

            public override T Match<T>(Func<GatewayPaymentJob, T> gatewayPaymentJob, Func<PortalPaymentJob, T> portalPaymentJob) =>
                   portalPaymentJob != null ? portalPaymentJob(Value) : default;

            public PortalPaymentJobCase Set(PortalPaymentJob value)
            {
                Value = value;
                return this;
            }

            public PortalPaymentJob Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PortalPaymentJobCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}