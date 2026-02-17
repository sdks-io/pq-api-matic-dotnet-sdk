// <copyright file="InvitationsControllerTest.cs" company="APIMatic">
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
    /// InvitationsControllerTest.
    /// </summary>
    [TestFixture]
    public class InvitationsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IInvitationsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.InvitationsController;
        }

        /// <summary>
        /// Retrieve a list of [invitations](page:resources/invitations) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListInvitations()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.InvitationListResult result = null;
            try
            {
                result = await this.controller.ListInvitationsAsync(page, pageSize, filter, sort, language);
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
        /// Create a [invitation](page:resources/invitations) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateInvitation()
        {
            // Parameters for the API call
            API.Models.CreateInvitation body = ApiHelper.JsonDeserialize<API.Models.CreateInvitation>("{\"amount\":1500,\"currency\":\"USD\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"destinationToken\":\"dest-ae92315b-6190-4e56-bdf5-c0189ac420a1\",\"note\":\"Payment 1 Note\",\"memo\":\"Payment 1 Memo\",\"purpose\":\"INCOME\",\"clientPaymentId\":\"929fcf00-5a4f-4613-bd78-ed8dc33797b9\",\"autoAcceptQuote\":false,\"notBefore\":\"2022-04-26T15:16:18Z\",\"notAfter\":\"2022-04-26T15:19:20Z\"}");

            // Perform API call
            API.Models.InvitationResult result = null;
            try
            {
                result = await this.controller.CreateInvitationAsync(body);
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
        /// Create a [invitation](page:resources/invitations) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateInvitation1()
        {
            // Parameters for the API call
            API.Models.CreateInvitation body = ApiHelper.JsonDeserialize<API.Models.CreateInvitation>("{\"amount\":1500,\"currency\":\"USD\",\"sourceToken\":\"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860\",\"destinationToken\":\"dest-ae92315b-6190-4e56-bdf5-c0189ac420a1\",\"note\":\"Payment 1 Note\",\"memo\":\"Payment 1 Memo\",\"purpose\":\"INCOME\",\"clientPaymentId\":\"929fcf00-5a4f-4613-bd78-ed8dc33797b9\",\"autoAcceptQuote\":false,\"notBefore\":\"2022-04-26T15:16:18Z\",\"notAfter\":\"2022-04-26T15:19:20Z\"}");

            // Perform API call
            API.Models.InvitationResult result = null;
            try
            {
                result = await this.controller.CreateInvitationAsync(body);
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
        /// Retrieve a single [invitation](page:resources/invitations).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveInvitation()
        {
            // Parameters for the API call
            string invitationToken = "invt-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string filter = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.InvitationResult result = null;
            try
            {
                result = await this.controller.RetrieveInvitationAsync(invitationToken, filter, language);
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
        /// Accept an open [invitation](page:resources/invitations) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateInvitation()
        {
            // Parameters for the API call
            string invitationToken = "invt-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.InvitationResult result = null;
            try
            {
                result = await this.controller.UpdateInvitationAsync(invitationToken);
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
        /// Accept an open [invitation](page:resources/invitations) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateInvitation1()
        {
            // Parameters for the API call
            string invitationToken = "invt-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.InvitationResult result = null;
            try
            {
                result = await this.controller.UpdateInvitationAsync(invitationToken);
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
        /// Cancel an open [invitation](page:resources/invitations) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCancelInvitation()
        {
            // Parameters for the API call
            string invitationToken = "invt-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.InvitationResult result = null;
            try
            {
                result = await this.controller.CancelInvitationAsync(invitationToken);
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