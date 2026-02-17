// <copyright file="AgreementsControllerTest.cs" company="APIMatic">
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
    /// AgreementsControllerTest.
    /// </summary>
    [TestFixture]
    public class AgreementsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IAgreementsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.AgreementsController;
        }

        /// <summary>
        /// Retrieve a list of program [agreements](page:resources/agreements) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListAgreements()
        {
            // Parameters for the API call
            string programToken = "prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.AgreementListResultJson result = null;
            try
            {
                result = await this.controller.ListAgreementsAsync(programToken, page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"agmt-b33d420f-6c1b-4a93-9455-d6585552b97d\",\"contentBase64\":\"DQogIGZvciB5b3VyIHBsYXN0aW...KPC9ib2R5Pg0KDQo8L2h0bWw+DQo=\",\"url\":\"https://cdn.payquicker.io/content/Agreements/Cardholder/v1/Languages_EN_US/CardholderAgreement-Consumer-ACH-20k-MCB-USD.pdf\",\"type\":\"CARD_HOLDER_AGREEMENT\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb/agreements/agmt-b33d420f-6c1b-4a93-9455-d6585552b97d\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"100\",\"pageCount\":\"0\",\"recordCount\":\"0\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb/agreements\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single program [agreement](page:resources/agreements).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveProgramAgreement()
        {
            // Parameters for the API call
            string programToken = "prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb";
            string agreementToken = "agmt-b33d420f-6c1b-4a93-9455-d6585552b97d";

            // Perform API call
            API.Models.AgreementResult result = null;
            try
            {
                result = await this.controller.RetrieveProgramAgreementAsync(programToken, agreementToken);
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
                    "{\"token\":\"agmt-b33d420f-6c1b-4a93-9455-d6585552b97d\",\"contentBase64\":\"DQogIGZvciB5b3VyIHBsYXN0aW...KPC9ib2R5Pg0KDQo8L2h0bWw+DQo=\",\"url\":\"https://cdn.payquicker.io/content/Agreements/Cardholder/v1/Languages_EN_US/CardholderAgreement-Consumer-ACH-20k-MCB-USD.pdf\",\"type\":\"CARD_HOLDER_AGREEMENT\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb/agreements/agmt-b33d420f-6c1b-4a93-9455-d6585552b97d\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Accept a single program [agreement](page:resources/agreements).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAcceptAgreement()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string agreementToken = "agmt-b33d420f-6c1b-4a93-9455-d6585552b97d";

            // Perform API call
            try
            {
                await this.controller.AcceptAgreementAsync(userToken, agreementToken);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}