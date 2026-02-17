// <copyright file="ComplianceControllerTest.cs" company="APIMatic">
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
    /// ComplianceControllerTest.
    /// </summary>
    [TestFixture]
    public class ComplianceControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IComplianceController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ComplianceController;
        }

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#list-user-idv-checks) by user token that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListIdentityChecks()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.IdvCheckListResult result = null;
            try
            {
                result = await this.controller.ListIdentityChecksAsync(userToken);
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
                    "{\"payload\":[{\"idvProviderReference\":\"yPV0h4o1Yw3QzdLAvA7a\",\"idvResult\":\"PASS\",\"idvSubResult\":\"HARD\",\"idvProvider\":\"HOOYU\",\"createdOn\":\"2020-02-21T22:00:00Z\",\"raw\":\"<RAW IDV processor output, for informational /debugging purposes only>\",\"idvCheckType\":\"NON_DOCUMENTARY\",\"idvDisposition\":\"FINAL\",\"token\":\"idvc-7e7567e0-c2db-485d-896d-45901a10baa9\",\"userToken\":\"user-f012bc86-4d42-415b-a8b2-be5e0b90e59a\",\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"https://api.payquicker.io/api/v2/users/user-f012bc86-4d42-415b-a8b2-be5e0b90e59a/idv-checks/idvc-7e7567e0-c2db-485d-896d-45901a10baa9\"}]}],\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"https://api.payquicker.io/api/v2/users/user-f012bc86-4d42-415b-a8b2-be5e0b90e59a/idv-checks\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a list of [IDV checks](page:resources/user#retrieve-user-idv-check) by IDVC token that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveIdentityCheck()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string idvcToken = "idvc-7e7567e0-c2db-485d-896d-45901a10baa9";

            // Perform API call
            API.Models.IdvCheckResult result = null;
            try
            {
                result = await this.controller.RetrieveIdentityCheckAsync(userToken, idvcToken);
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
                    "{\"createdOn\":\"2022-04-20T17:34:50Z\",\"idvCheckType\":\"PII\",\"idvDispostion\":\"UNDEFINED\",\"idvProvider\":\"FISIDOLOGY\",\"idvResult\":\"PASS\",\"idvSubResult\":\"HARD\",\"token\":\"idvc-5a04bacf-f99c-4962-8c02-d8e744c625d6\",\"userToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/idv-checks/idvc-5a04bacf-f99c-4962-8c02-d8e744c625d6\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}