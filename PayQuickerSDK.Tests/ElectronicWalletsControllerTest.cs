// <copyright file="ElectronicWalletsControllerTest.cs" company="APIMatic">
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
    /// ElectronicWalletsControllerTest.
    /// </summary>
    [TestFixture]
    public class ElectronicWalletsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IElectronicWalletsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ElectronicWalletsController;
        }

        /// <summary>
        /// Retrieve a list of [electronic wallets](page:resources/electronic-wallets) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListElectronicWallets()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.ElectronicWalletListResult result = null;
            try
            {
                result = await this.controller.ListElectronicWalletsAsync(userToken, page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"dest-969daa60-c743-4e4f-8609-559874f26d6c\",\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"fields\":[{\"key\":\"ACCOUNT_NUMBER\",\"value\":\"012345678\"},{\"key\":\"GOVERNMENT_ID\",\"value\":\"012345678\"}],\"status\":\"VERIFIED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/electronic-wallets/dest-969daa60-c743-4e4f-8609-559874f26d6c\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"5\",\"pageCount\":\"1\",\"recordCount\":\"1\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/electronic-wallets?page=1&pageSize=5&language=en-US\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a new [electronic wallet](page:resources/electronic-wallets) using a user token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateElectronicWallet()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.CreateOrUpdateElectronicWallet body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateElectronicWallet>("{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"fields\":[{\"key\":\"ACCOUNT_NUMBER\",\"value\":\"012345678\"},{\"key\":\"GOVERNMENT_ID\",\"value\":\"012345678\"}]}");

            // Perform API call
            API.Models.ElectronicWalletResult result = null;
            try
            {
                result = await this.controller.CreateElectronicWalletAsync(userToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"fields\":[{\"key\":\"ACCOUNT_NUMBER\",\"value\":\"012345678\"},{\"key\":\"GOVERNMENT_ID\",\"value\":\"012345678\"}],\"status\":\"VERIFIED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/electronic-wallets/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a new [electronic wallet](page:resources/electronic-wallets) using a user token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateElectronicWallet1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.CreateOrUpdateElectronicWallet body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateElectronicWallet>("{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"fields\":[{\"key\":\"ACCOUNT_NUMBER\",\"value\":\"012345678\"},{\"key\":\"GOVERNMENT_ID\",\"value\":\"012345678\"}]}");

            // Perform API call
            API.Models.ElectronicWalletResult result = null;
            try
            {
                result = await this.controller.CreateElectronicWalletAsync(userToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"fields\":[{\"key\":\"ACCOUNT_NUMBER\",\"value\":\"012345678\"},{\"key\":\"GOVERNMENT_ID\",\"value\":\"012345678\"}],\"status\":\"VERIFIED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/electronic-wallets/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve requirements for adding a [electronic wallet](page:resources/electronic-wallets) using the parameters provided.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveCreationRequirements()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.ElectronicWalletTypes electronicWalletType = ApiHelper.JsonDeserialize<API.Models.ElectronicWalletTypes>("\"TIGO_MONEY\"");
            API.Models.Countries country = ApiHelper.JsonDeserialize<API.Models.Countries>("\"US\"");
            API.Models.Currencies currency = ApiHelper.JsonDeserialize<API.Models.Currencies>("\"USD\"");

            // Perform API call
            API.Models.ElectronicWalletRequirementListResult result = null;
            try
            {
                result = await this.controller.RetrieveCreationRequirementsAsync(userToken, electronicWalletType, country, currency);
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
                    "{\"payload\":[{\"electronicWalletType\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"requirements\":[{\"requirement\":\"ACCOUNT_NUMBER\",\"format\":{\"example\":\"012345678\",\"legend\":[{\"key\":\"012345678\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Example Account Number\"},{\"language\":\"it-IT\",\"translation\":\"Esempio Numero del conto\"}]}]},\"description\":[{\"language\":\"en-US\",\"translation\":\"Account Number\"},{\"language\":\"it-IT\",\"translation\":\"Numero del conto\"}],\"validators\":[{\"validatorType\":\"REGEX\",\"expression\":\"^[0-9]{8}$\"}]},{\"requirement\":\"GOVERNMENT_ID\",\"format\":{\"example\":\"012345678\",\"legend\":[{\"key\":\"012345678\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Example Government Id\"},{\"language\":\"it-IT\",\"translation\":\"Esempio Carta d'Identità\"}]}]},\"description\":[{\"language\":\"en-US\",\"translation\":\"Government Id\"},{\"language\":\"it-IT\",\"translation\":\"Carta d'Identità\"}],\"validators\":[{\"validatorType\":\"REGEX\",\"expression\":\"^[0-9]{8}$\"}]}],\"quote\":{\"formattedAmount\":\"$4.32 USD (USD, en-US), 0,00 â‚¬ EUR (EUR, fr-FR)\",\"amount\":4.32,\"currency\":\"USD\"},\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"string\"}]}],\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"string\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [electronic wallet](page:resources/electronic-wallets) using a destination token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveElectronicWallet()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.ElectronicWalletResult result = null;
            try
            {
                result = await this.controller.RetrieveElectronicWalletAsync(userToken, destinationToken, page, pageSize, filter, sort, language);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"fields\":[{\"key\":\"ACCOUNT_NUMBER\",\"value\":\"012345678\"},{\"key\":\"GOVERNMENT_ID\",\"value\":\"012345678\"}],\"status\":\"VERIFIED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/electronic-wallets/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Update a [electronic wallet](page:resources/electronic-wallets).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateElectronicWallet()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.CreateOrUpdateElectronicWallet body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateElectronicWallet>("{\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"fields\":[{\"key\":\"ACCOUNT_NUMBER\",\"value\":\"012345678\"},{\"key\":\"GOVERNMENT_ID\",\"value\":\"012345678\"}]}");

            // Perform API call
            API.Models.ElectronicWalletResult result = null;
            try
            {
                result = await this.controller.UpdateElectronicWalletAsync(userToken, destinationToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"type\":\"TIGO_MONEY\",\"electronicWalletCountry\":\"SV\",\"electronicWalletCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"fields\":[{\"key\":\"ACCOUNT_NUMBER\",\"value\":\"012345678\"},{\"key\":\"GOVERNMENT_ID\",\"value\":\"012345678\"}],\"status\":\"VERIFIED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/electronic-wallets/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Delete a user [electronic wallet](page:resources/electronic-wallets).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteElectronicWallet()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";

            // Perform API call
            API.Models.OperationResult result = null;
            try
            {
                result = await this.controller.DeleteElectronicWalletAsync(userToken, destinationToken);
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
                    "{\"result\":true,\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}