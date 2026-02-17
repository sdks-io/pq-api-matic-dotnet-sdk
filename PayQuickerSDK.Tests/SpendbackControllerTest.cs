// <copyright file="SpendbackControllerTest.cs" company="APIMatic">
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
    /// SpendbackControllerTest.
    /// </summary>
    [TestFixture]
    public class SpendbackControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ISpendbackController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SpendbackController;
        }

        /// <summary>
        /// Retrieve a list of [spendbacks](page:resources/spendbacks) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListSpendbacks()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.SpendbackListResult result = null;
            try
            {
                result = await this.controller.ListSpendbacksAsync(page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"spnd-c62fd949-78ef-4f32-aef7-5de8d0c6f4a7\",\"amount\":300,\"autoAcceptQuote\":false,\"clientSpendbackId\":\"8c3b61d7-1f5a-4bb9-8ffc-ac756c27a3e1\",\"created\":\"2021-06-08T19:30:03Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-4aaa0738-24d9-40bd-a548-18932a6c7f5c\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-c62fd949-78ef-4f32-aef7-5de8d0c6f4a7\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"spnd-9d769a60-4d59-4905-bb46-8f6856121f2a\",\"amount\":35,\"autoAcceptQuote\":false,\"clientSpendbackId\":\"37ebee96-eb48-4689-8079-b650e2a4e753\",\"created\":\"2021-06-08T19:31:56Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2\",\"status\":\"CANCELLED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-9d769a60-4d59-4905-bb46-8f6856121f2a\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"spnd-bc16fb78-e391-4796-8a82-4fe7d7473c1a\",\"amount\":100,\"autoAcceptQuote\":true,\"clientSpendbackId\":\"35bc04d0-e98f-4ca9-817b-d62c3b320d6f\",\"created\":\"2021-06-08T19:33:18Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-6dbd9a70-75c9-49b7-aff6-34708ed491df\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-bc16fb78-e391-4796-8a82-4fe7d7473c1a\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"spnd-4d14117c-3e8b-4275-9863-f85762ac32fb\",\"amount\":100,\"autoAcceptQuote\":true,\"clientSpendbackId\":\"SPENDBACKRETURN-79f6126943bd451f99bb38649da1ea10\",\"created\":\"2021-06-08T19:34:33Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-70739320-c917-425c-a77a-d647c65fd175\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"status\":\"FAILED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4d14117c-3e8b-4275-9863-f85762ac32fb\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"spnd-25b877b2-fb00-4c9a-a464-f91a6597e752\",\"amount\":20,\"autoAcceptQuote\":true,\"clientSpendbackId\":\"9b97af1c-53b6-42a0-b19c-eaffdc48a854\",\"created\":\"2021-06-08T19:35:00Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-e69b9edb-23c3-4a47-900c-60b7addbbae2\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-25b877b2-fb00-4c9a-a464-f91a6597e752\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"5\",\"pageCount\":\"13\",\"recordCount\":\"64\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back?page=1&pageSize=5&language=en-US\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a [spendback](page:resources/spendbacks) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateSpendbackQuote()
        {
            // Parameters for the API call
            SpendbackQuote body = null;

            // Perform API call
            API.Models.SpendbackResult result = null;
            try
            {
                result = await this.controller.CreateSpendbackQuoteAsync(body);
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
                    "{\"token\":\"spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"amount\":300,\"autoAcceptQuote\":false,\"clientSpendbackId\":\"08c6d59d-a04d-4603-8104-10c9d4c61f0d\",\"created\":\"2022-05-02T16:45:09Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"status\":\"PENDING_ACCEPTANCE\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a [spendback](page:resources/spendbacks) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateSpendbackQuote1()
        {
            // Parameters for the API call
            SpendbackQuote body = null;

            // Perform API call
            API.Models.SpendbackResult result = null;
            try
            {
                result = await this.controller.CreateSpendbackQuoteAsync(body);
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
                    "{\"token\":\"spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"amount\":300,\"autoAcceptQuote\":false,\"clientSpendbackId\":\"08c6d59d-a04d-4603-8104-10c9d4c61f0d\",\"created\":\"2022-05-02T16:45:09Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"status\":\"PENDING_ACCEPTANCE\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [spendbacks](page:resources/spendbacks) quote using the spendback token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveSpendback()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.SpendbackResult result = null;
            try
            {
                result = await this.controller.RetrieveSpendbackAsync(spendbackToken, page, pageSize, filter, sort, language);
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
                    "{\"token\":\"spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"amount\":300,\"autoAcceptQuote\":false,\"clientSpendbackId\":\"08c6d59d-a04d-4603-8104-10c9d4c61f0d\",\"created\":\"2022-05-02T16:45:09Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"status\":\"PENDING_ACCEPTANCE\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Accept an open [spendback](page:resources/spendbacks) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAcceptSpendbackQuote()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";

            // Perform API call
            API.Models.SpendbackResult result = null;
            try
            {
                result = await this.controller.AcceptSpendbackQuoteAsync(spendbackToken);
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
                    "{\"token\":\"spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"amount\":300,\"autoAcceptQuote\":false,\"clientSpendbackId\":\"08c6d59d-a04d-4603-8104-10c9d4c61f0d\",\"created\":\"2022-05-02T16:45:09Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"status\":\"PENDING_ACCEPTANCE\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Accept an open [spendback](page:resources/spendbacks) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAcceptSpendbackQuote1()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";

            // Perform API call
            API.Models.SpendbackResult result = null;
            try
            {
                result = await this.controller.AcceptSpendbackQuoteAsync(spendbackToken);
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
                    "{\"token\":\"spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"amount\":300,\"autoAcceptQuote\":false,\"clientSpendbackId\":\"08c6d59d-a04d-4603-8104-10c9d4c61f0d\",\"created\":\"2022-05-02T16:45:09Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"status\":\"PENDING_ACCEPTANCE\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Cancel an open [spendback](page:resources/spendbacks) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCancelSpendbackQuote()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";

            // Perform API call
            API.Models.SpendbackResult result = null;
            try
            {
                result = await this.controller.CancelSpendbackQuoteAsync(spendbackToken);
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
                    "{\"token\":\"spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"amount\":300,\"autoAcceptQuote\":false,\"clientSpendbackId\":\"08c6d59d-a04d-4603-8104-10c9d4c61f0d\",\"created\":\"2022-05-02T16:45:09Z\",\"currency\":\"USD\",\"destinationToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"memo\":\"Spendback 1 Memo\",\"note\":\"Spendback 1 Note\",\"purpose\":\"EXPENSE\",\"sourceToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"status\":\"PENDING_ACCEPTANCE\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}