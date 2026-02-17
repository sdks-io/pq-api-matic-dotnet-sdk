// <copyright file="SpendbackRefundsControllerTest.cs" company="APIMatic">
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
    /// SpendbackRefundsControllerTest.
    /// </summary>
    [TestFixture]
    public class SpendbackRefundsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ISpendbackRefundsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SpendbackRefundsController;
        }

        /// <summary>
        /// Retrieve a list of [spendbacks](page:resources/spendbacks) refunds that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListSpendbackRefunds()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.SpendbackRefundListResult result = null;
            try
            {
                result = await this.controller.ListSpendbackRefundsAsync(spendbackToken, page, pageSize, filter, sort, language);
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
        }

        /// <summary>
        /// Perform a [spendback](page:resources/spendbacks) refund for a partial amount.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateSpendbackRefundQuote()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
            API.Models.CreateSpendbackRefundQuote body = ApiHelper.JsonDeserialize<API.Models.CreateSpendbackRefundQuote>("{\"amount\":1.13}");

            // Perform API call
            API.Models.SpendbackRefundResult result = null;
            try
            {
                result = await this.controller.CreateSpendbackRefundQuoteAsync(spendbackToken, body);
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
        }

        /// <summary>
        /// Cancel an spendback refund quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCancelSpendbackRefundQuote()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
            string refundToken = "rfnd-c39437e1-dc80-4293-8211-c14b5a32f762";

            // Perform API call
            API.Models.SpendbackRefundResult result = null;
            try
            {
                result = await this.controller.CancelSpendbackRefundQuoteAsync(spendbackToken, refundToken);
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
        }

        /// <summary>
        /// Retrieve a single spendback refund using the rfnd token.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveSpendbackRefund()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
            string refundToken = "rfnd-c39437e1-dc80-4293-8211-c14b5a32f762";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.SpendbackRefundResult result = null;
            try
            {
                result = await this.controller.RetrieveSpendbackRefundAsync(spendbackToken, refundToken, page, pageSize, filter, sort, language);
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
        }

        /// <summary>
        /// Accept a spendback return quote..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAcceptSpendbackRefundQuote()
        {
            // Parameters for the API call
            string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
            string refundToken = "rfnd-c39437e1-dc80-4293-8211-c14b5a32f762";

            // Perform API call
            API.Models.SpendbackRefundResult result = null;
            try
            {
                result = await this.controller.AcceptSpendbackRefundQuoteAsync(spendbackToken, refundToken);
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
        }
    }
}