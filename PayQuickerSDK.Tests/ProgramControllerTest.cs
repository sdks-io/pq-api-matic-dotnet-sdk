// <copyright file="ProgramControllerTest.cs" company="APIMatic">
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
    /// ProgramControllerTest.
    /// </summary>
    [TestFixture]
    public class ProgramControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IProgramController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ProgramController;
        }

        /// <summary>
        /// Retrieve a list of [programs](page:resources/programs) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListPrograms()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.ProgramListResult result = null;
            try
            {
                result = await this.controller.ListProgramsAsync(page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"prog-0146a716-4055-2598-ce14-df5ece519a98\",\"currency\":\"USD\",\"bank\":\"PATHWARD\",\"electricWallets\":[{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\"},{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"GT\",\"electronicWalletCurrency\":\"GTQ\"},{\"type\":\"AIRTEL_MONEY\",\"electronicWalletCountry\":\"TZ\",\"electronicWalletCurrency\":\"TZS\"},{\"type\":\"MCASH\",\"electronicWalletCountry\":\"LK\",\"electronicWalletCurrency\":\"LKR\"}],\"type\":\"COMMERCIAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-0146a716-4055-2598-ce14-df5ece519a98\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"prog-dbfe1489-f3ba-3f5a-6904-9b9ad91ceaf6\",\"currency\":\"MXN\",\"bank\":\"PATHWARD\",\"electricWallets\":[],\"type\":\"COMMERCIAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-dbfe1489-f3ba-3f5a-6904-9b9ad91ceaf6\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"prog-8a9e37bf-d9a9-a40a-96c4-e286d1fa8fc5\",\"currency\":\"USD\",\"bank\":\"PATHWARD\",\"electricWallets\":[{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\"},{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"GT\",\"electronicWalletCurrency\":\"GTQ\"},{\"type\":\"AIRTEL_MONEY\",\"electronicWalletCountry\":\"TZ\",\"electronicWalletCurrency\":\"TZS\"},{\"type\":\"MCASH\",\"electronicWalletCountry\":\"LK\",\"electronicWalletCurrency\":\"LKR\"}],\"type\":\"COMMERCIAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-8a9e37bf-d9a9-a40a-96c4-e286d1fa8fc5\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"prog-76f58bb0-c8ae-d0fa-d1e4-15143ffb53fa\",\"currency\":\"EUR\",\"bank\":\"PPS\",\"electricWallets\":[],\"type\":\"COMMERCIAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-76f58bb0-c8ae-d0fa-d1e4-15143ffb53fa\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"prog-bbde39a9-04ca-1c0a-5d74-758a4ad47b84\",\"currency\":\"GBP\",\"bank\":\"PPS\",\"electricWallets\":[],\"type\":\"COMMERCIAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-bbde39a9-04ca-1c0a-5d74-758a4ad47b84\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"prog-8136128b-3f5b-2f69-15a4-f25592ebce51\",\"currency\":\"MXN\",\"bank\":\"PATHWARD\",\"electricWallets\":[],\"type\":\"COMMERCIAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-8136128b-3f5b-2f69-15a4-f25592ebce51\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"prog-42469a3e-15c8-11f8-02a4-1053f176700e\",\"currency\":\"EUR\",\"bank\":\"PATHWARD\",\"electricWallets\":[{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\"},{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"GT\",\"electronicWalletCurrency\":\"GTQ\"},{\"type\":\"AIRTEL_MONEY\",\"electronicWalletCountry\":\"TZ\",\"electronicWalletCurrency\":\"TZS\"},{\"type\":\"MCASH\",\"electronicWalletCountry\":\"LK\",\"electronicWalletCurrency\":\"LKR\"}],\"type\":\"COMMERCIAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-42469a3e-15c8-11f8-02a4-1053f176700e\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"prog-f8725c56-b289-8f4b-1f94-cd27f2963cbf\",\"currency\":\"HKD\",\"bank\":\"PATHWARD\",\"electricWallets\":[],\"type\":\"COMMERCIAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-f8725c56-b289-8f4b-1f94-cd27f2963cbf\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"prog-95753dc7-0b4a-65a9-7bd4-6504b6774cb9\",\"currency\":\"USD\",\"bank\":\"MCB\",\"electricWallets\":[],\"type\":\"CONSUMER_GPR\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-95753dc7-0b4a-65a9-7bd4-6504b6774cb9\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"100\",\"pageCount\":\"0\",\"recordCount\":\"0\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [program](page:resources/programs) by its program token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveProgram()
        {
            // Parameters for the API call
            string programToken = "prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.ProgramResult result = null;
            try
            {
                result = await this.controller.RetrieveProgramAsync(programToken, language);
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
                    "{\"token\":\"prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb\",\"currency\":\"USD\",\"bank\":\"MCB\",\"electricWallets\":[{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\"},{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"GT\",\"electronicWalletCurrency\":\"GTQ\"},{\"type\":\"AIRTEL_MONEY\",\"electronicWalletCountry\":\"TZ\",\"electronicWalletCurrency\":\"TZS\"},{\"type\":\"MCASH\",\"electronicWalletCountry\":\"LK\",\"electronicWalletCurrency\":\"LKR\"}],\"type\":\"CONSUMER_GPR\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/programs/prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}