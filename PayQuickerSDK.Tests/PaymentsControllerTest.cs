// <copyright file="PaymentsControllerTest.cs" company="APIMatic">
// PayQuickerSDK.Tests
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using NUnit.Framework;
using Newtonsoft.Json.Converters;
using PayQuicker.API;
using PayQuicker.API.Controllers;
using PayQuicker.API.Exceptions;
using PayQuicker.API.Http.Client;
using PayQuicker.API.Http.Response;
using PayQuicker.API.Models.Containers;
using PayQuicker.API.Utilities;

namespace PayQuicker.API
{
    /// <summary>
    /// PaymentsControllerTest.
    /// </summary>
    [TestFixture]
    public class PaymentsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IPaymentsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PaymentsController;
        }

        /// <summary>
        /// Retrieve a list of [payments](page:resources/payments) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListPayments()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.PaymentListResult result = null;
            try
            {
                result = await this.controller.ListPaymentsAsync(page, pageSize, filter, sort, language);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"payload\":[{\"token\":\"pmnt-9ed0cd25-aaf5-4683-9a29-b02a9dc40400\",\"amount\":-1500,\"autoAcceptQuote\":false,\"clientPaymentId\":\"3cdb0e3f-666a-4a32-86e3-676c8593262a\",\"created\":\"2021-06-08T19:25:13Z\",\"currency\":\"USD\",\"destinationToken\":\"user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-c05ac500-c5b0-4870-8e66-1004eee26e4b\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-9ed0cd25-aaf5-4683-9a29-b02a9dc40400\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"pmnt-5cd70578-fabd-4bed-8e60-af69addb21a1\",\"amount\":120,\"autoAcceptQuote\":false,\"clientPaymentId\":\"6739f368-fa91-46d3-a221-5cd0d75be85a\",\"created\":\"2021-06-08T19:26:04Z\",\"currency\":\"USD\",\"destinationToken\":\"user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"CANCELLED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-5cd70578-fabd-4bed-8e60-af69addb21a1\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"pmnt-cb279676-6ecf-46e5-b5c8-96f0b6b9ae59\",\"amount\":-50,\"autoAcceptQuote\":true,\"clientPaymentId\":\"9422dab5-2ea8-47af-8d25-a10aef6efa50\",\"created\":\"2021-06-08T19:26:26Z\",\"currency\":\"USD\",\"destinationToken\":\"user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-b1d53179-dd25-4f53-b9ae-d3f23832b7a8\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-cb279676-6ecf-46e5-b5c8-96f0b6b9ae59\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"3\",\"pageCount\":\"99\",\"recordCount\":\"296\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments?page=1&pageSize=3&language=en-US\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a [payment](page:resources/payments) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreatePaymentQuote()
        {
            // Parameters for the API call
            PaymentQuote body = null;

            // Perform API call
            API.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.CreatePaymentQuoteAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"token\":\"pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"amount\":-1500,\"autoAcceptQuote\":false,\"clientPaymentId\":\"de6269af-e3b0-4d4b-801d-367776b32f63\",\"created\":\"2022-04-26T15:16:18Z\",\"currency\":\"USD\",\"destinationToken\":\"dest-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-30bfaaf3-69bc-4ed5-ad6a-d38705cf0281\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a [payment](page:resources/payments) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreatePaymentQuote1()
        {
            // Parameters for the API call
            PaymentQuote body = null;

            // Perform API call
            API.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.CreatePaymentQuoteAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"token\":\"pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"amount\":-1500,\"autoAcceptQuote\":false,\"clientPaymentId\":\"de6269af-e3b0-4d4b-801d-367776b32f63\",\"created\":\"2022-04-26T15:16:18Z\",\"currency\":\"USD\",\"destinationToken\":\"dest-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-30bfaaf3-69bc-4ed5-ad6a-d38705cf0281\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [payment](page:resources/payments).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrievePayment()
        {
            // Parameters for the API call
            string paymentToken = "pmnt-d3ff8a0d-aec9-49a6-a95b-6191aebeca20";
            string filter = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.RetrievePaymentAsync(paymentToken, filter, language);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"token\":\"pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"amount\":-1500,\"autoAcceptQuote\":false,\"clientPaymentId\":\"de6269af-e3b0-4d4b-801d-367776b32f63\",\"created\":\"2022-04-26T15:16:18Z\",\"currency\":\"USD\",\"destinationToken\":\"dest-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-30bfaaf3-69bc-4ed5-ad6a-d38705cf0281\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Accept an open [payment](page:resources/payments) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAcceptPaymentQuote()
        {
            // Parameters for the API call
            string paymentToken = "pmnt-d3ff8a0d-aec9-49a6-a95b-6191aebeca20";

            // Perform API call
            API.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.AcceptPaymentQuoteAsync(paymentToken);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"token\":\"pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"amount\":-1500,\"autoAcceptQuote\":false,\"clientPaymentId\":\"de6269af-e3b0-4d4b-801d-367776b32f63\",\"created\":\"2022-04-26T15:16:18Z\",\"currency\":\"USD\",\"destinationToken\":\"dest-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-30bfaaf3-69bc-4ed5-ad6a-d38705cf0281\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Accept an open [payment](page:resources/payments) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAcceptPaymentQuote1()
        {
            // Parameters for the API call
            string paymentToken = "pmnt-d3ff8a0d-aec9-49a6-a95b-6191aebeca20";

            // Perform API call
            API.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.AcceptPaymentQuoteAsync(paymentToken);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"token\":\"pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"amount\":-1500,\"autoAcceptQuote\":false,\"clientPaymentId\":\"de6269af-e3b0-4d4b-801d-367776b32f63\",\"created\":\"2022-04-26T15:16:18Z\",\"currency\":\"USD\",\"destinationToken\":\"dest-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-30bfaaf3-69bc-4ed5-ad6a-d38705cf0281\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Cancel an open [payment](page:resources/payments) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCancelPaymentQuote()
        {
            // Parameters for the API call
            string paymentToken = "pmnt-d3ff8a0d-aec9-49a6-a95b-6191aebeca20";

            // Perform API call
            API.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.CancelPaymentQuoteAsync(paymentToken);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"token\":\"pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"amount\":-1500,\"autoAcceptQuote\":false,\"clientPaymentId\":\"de6269af-e3b0-4d4b-801d-367776b32f63\",\"created\":\"2022-04-26T15:16:18Z\",\"currency\":\"USD\",\"destinationToken\":\"dest-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-30bfaaf3-69bc-4ed5-ad6a-d38705cf0281\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Perform a [payment](page:resources/payments) retraction for the full payment amount.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetractPayment()
        {
            // Parameters for the API call
            string paymentToken = "pmnt-d3ff8a0d-aec9-49a6-a95b-6191aebeca20";

            // Perform API call
            API.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.RetractPaymentAsync(paymentToken);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"token\":\"pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"amount\":-1500,\"autoAcceptQuote\":false,\"clientPaymentId\":\"de6269af-e3b0-4d4b-801d-367776b32f63\",\"created\":\"2022-04-26T15:16:18Z\",\"currency\":\"USD\",\"destinationToken\":\"dest-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"memo\":\"Payment 1 Memo\",\"note\":\"Payment 1 Note\",\"purpose\":\"INCOME\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-30bfaaf3-69bc-4ed5-ad6a-d38705cf0281\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/payments/pmnt-37be18b6-301a-4a37-8723-ddf645abcdb7\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}