// <copyright file="BankAccountsControllerTest.cs" company="APIMatic">
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
    /// BankAccountsControllerTest.
    /// </summary>
    [TestFixture]
    public class BankAccountsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IBankAccountsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.BankAccountsController;
        }

        /// <summary>
        /// Retrieve a list of [bank accounts](page:resources/bank-accounts) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListBankAccounts()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.BankAccountListResult result = null;
            try
            {
                result = await this.controller.ListBankAccountsAsync(userToken, page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"dest-969daa60-c743-4e4f-8609-559874f26d6c\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T16:26:25Z\",\"description\":\"Official USD Testing Bank Account 2\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7899\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5688\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Harry Grady\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 2\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-969daa60-c743-4e4f-8609-559874f26d6c\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"5\",\"pageCount\":\"1\",\"recordCount\":\"1\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts?page=1&pageSize=5&language=en-US\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a [bank account](page:resources/bank-accounts) using a user token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateBankAccount()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.CreateOrUpdateBankAccount body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateBankAccount>("{\"bankAccountOwnershipType\":\"BUSINESS\",\"description\":\"Official USD Testing Bank Account 1\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"type\":\"SAVINGS\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"01234567890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"012345678\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Hazel Mosciski\"}]}");

            // Perform API call
            API.Models.BankAccountResult result = null;
            try
            {
                result = await this.controller.CreateBankAccountAsync(userToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"description\":\"Official USD Testing Bank Account 1\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5678\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Dennis Bruen\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a [bank account](page:resources/bank-accounts) using a user token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateBankAccount1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.CreateOrUpdateBankAccount body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateBankAccount>("{\"bankAccountOwnershipType\":\"BUSINESS\",\"description\":\"Official USD Testing Bank Account 1\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"type\":\"SAVINGS\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"01234567890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"012345678\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Hazel Mosciski\"}]}");

            // Perform API call
            API.Models.BankAccountResult result = null;
            try
            {
                result = await this.controller.CreateBankAccountAsync(userToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"description\":\"Official USD Testing Bank Account 1\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5678\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Dennis Bruen\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [bank account](page:resources/bank-accounts) using a destination token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveBankAccount()
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
            API.Models.BankAccountResult result = null;
            try
            {
                result = await this.controller.RetrieveBankAccountAsync(userToken, destinationToken, page, pageSize, filter, sort, language);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"description\":\"Official USD Testing Bank Account 1\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5678\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Dennis Bruen\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Update a [bank account](page:resources/bank-accounts).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateBankAccount()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.CreateOrUpdateBankAccount body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateBankAccount>("{\"bankAccountOwnershipType\":\"BUSINESS\",\"description\":\"Official USD Testing Bank Account 1\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"type\":\"SAVINGS\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"01234567890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"012345678\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Hazel Mosciski\"}]}");

            // Perform API call
            API.Models.BankAccountResult result = null;
            try
            {
                result = await this.controller.UpdateBankAccountAsync(userToken, destinationToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"description\":\"Official USD Testing Bank Account 1\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5678\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Dennis Bruen\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Delete a user [bank account](page:resources/bank-accounts).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteBankAccount()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";

            // Perform API call
            API.Models.OperationResult result = null;
            try
            {
                result = await this.controller.DeleteBankAccountAsync(userToken, destinationToken);
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

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveCreationRequirements()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.Countries country = ApiHelper.JsonDeserialize<API.Models.Countries>("\"US\"");
            API.Models.Currencies currency = ApiHelper.JsonDeserialize<API.Models.Currencies>("\"USD\"");

            // Perform API call
            API.Models.BankAccountRequirementListResult result = null;
            try
            {
                result = await this.controller.RetrieveCreationRequirementsAsync(userToken, country, currency);
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
                    "{\"payload\":[{\"bankCountry\":\"IT\",\"bankCurrency\":\"EUR\",\"requirements\":[{\"requirement\":\"BANK_IBAN\",\"format\":{\"example\":\"IT43K0310412701000000820420\",\"legend\":[{\"key\":\"IT43K0310412701000000820420\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Example IBAN\"},{\"language\":\"it-IT\",\"translation\":\"Esempio IBAN\"}]}]},\"description\":[{\"language\":\"en-US\",\"translation\":\"IBAN\"},{\"language\":\"it-IT\",\"translation\":\"IBAN\"}],\"validators\":[{\"validatorType\":\"REGEX\",\"expression\":\"^IT\\\\\\\\d{2}[A-Z]\\\\\\\\d{10}[0-9A-Z]{12}$\"}]},{\"requirement\":\"BANK_SWIFT_BIC\",\"format\":{\"example\":\"01234567890\",\"legend\":[{\"key\":\"01234567890\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Example Swift/BIC\"},{\"language\":\"it-IT\",\"translation\":\"Esempio Swift/BIC\"}]}]},\"description\":[{\"language\":\"en-US\",\"translation\":\"Swift/BIC\"},{\"language\":\"it-IT\",\"translation\":\"Swift/BIC\"}],\"validators\":[{\"validatorType\":\"REGEX\",\"expression\":\"^[a-z0-9A-Z]{8,11}$\"}]}],\"quote\":{\"formattedAmount\":\"$4.32 USD (USD, en-US), 0,00 â‚¬ EUR (EUR, fr-FR)\",\"amount\":4.32,\"currency\":\"USD\"},\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"string\"}]}],\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"string\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a list of company [bank accounts](page:resources/bank-accounts) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListCompanyBankAccounts()
        {
            // Parameters for the API call
            string accountToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.BankAccountListResult result = null;
            try
            {
                result = await this.controller.ListCompanyBankAccountsAsync(accountToken, page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"dest-969daa60-c743-4e4f-8609-559874f26d6c\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T16:26:25Z\",\"description\":\"Official USD Testing Bank Account 2\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7899\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5688\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Harry Grady\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 2\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-969daa60-c743-4e4f-8609-559874f26d6c\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"5\",\"pageCount\":\"1\",\"recordCount\":\"1\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts?page=1&pageSize=5&language=en-US\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a company [bank account](page:resources/bank-accounts) using an account token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCompanyBankAccount()
        {
            // Parameters for the API call
            string accountToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860";
            API.Models.CreateOrUpdateBankAccount body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateBankAccount>("{\"bankAccountOwnershipType\":\"BUSINESS\",\"description\":\"Official USD Testing Bank Account 1\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"type\":\"SAVINGS\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"01234567890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"012345678\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Hazel Mosciski\"}]}");

            // Perform API call
            API.Models.BankAccountResult result = null;
            try
            {
                result = await this.controller.CreateCompanyBankAccountAsync(accountToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"description\":\"Official USD Testing Bank Account 1\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5678\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Dennis Bruen\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a company [bank account](page:resources/bank-accounts) using an account token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCompanyBankAccount1()
        {
            // Parameters for the API call
            string accountToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860";
            API.Models.CreateOrUpdateBankAccount body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateBankAccount>("{\"bankAccountOwnershipType\":\"BUSINESS\",\"description\":\"Official USD Testing Bank Account 1\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"type\":\"SAVINGS\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"01234567890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"012345678\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Hazel Mosciski\"}]}");

            // Perform API call
            API.Models.BankAccountResult result = null;
            try
            {
                result = await this.controller.CreateCompanyBankAccountAsync(accountToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"description\":\"Official USD Testing Bank Account 1\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5678\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Dennis Bruen\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single company [bank account](page:resources/bank-accounts) using a destination token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveCompanyBankAccount()
        {
            // Parameters for the API call
            string accountToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.BankAccountResult result = null;
            try
            {
                result = await this.controller.RetrieveCompanyBankAccountAsync(accountToken, destinationToken, page, pageSize, filter, sort, language);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"description\":\"Official USD Testing Bank Account 1\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5678\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Dennis Bruen\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Update a company [bank account](page:resources/bank-accounts).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateCompanyBankAccount()
        {
            // Parameters for the API call
            string accountToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.CreateOrUpdateBankAccount body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateBankAccount>("{\"bankAccountOwnershipType\":\"BUSINESS\",\"description\":\"Official USD Testing Bank Account 1\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"type\":\"SAVINGS\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"01234567890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"012345678\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Hazel Mosciski\"}]}");

            // Perform API call
            API.Models.BankAccountResult result = null;
            try
            {
                result = await this.controller.UpdateCompanyBankAccountAsync(accountToken, destinationToken, body);
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
                    "{\"token\":\"dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"bankAccountOwnershipType\":\"BUSINESS\",\"bankCountry\":\"US\",\"bankCurrency\":\"USD\",\"createdOn\":\"2022-05-20T15:48:54Z\",\"description\":\"Official USD Testing Bank Account 1\",\"fields\":[{\"key\":\"BANK_BBAN\",\"value\":\"****7890\"},{\"key\":\"BANK_ACH_ABA\",\"value\":\"****5678\"},{\"key\":\"BENEFICIARY_NAME\",\"value\":\"Dennis Bruen\"},{\"key\":\"BANK_NAME\",\"value\":\"API V2 USD BANK 1\"}],\"status\":\"VERIFIED\",\"type\":\"SAVINGS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Delete a company [bank account](page:resources/bank-accounts).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteCompanyBankAccount()
        {
            // Parameters for the API call
            string accountToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";

            // Perform API call
            API.Models.OperationResult result = null;
            try
            {
                result = await this.controller.DeleteCompanyBankAccountAsync(accountToken, destinationToken);
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

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveCompanyBankAccountCreationRequirements()
        {
            // Parameters for the API call
            string accountToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860";
            API.Models.Countries country = ApiHelper.JsonDeserialize<API.Models.Countries>("\"US\"");
            API.Models.Currencies currency = ApiHelper.JsonDeserialize<API.Models.Currencies>("\"USD\"");

            // Perform API call
            API.Models.BankAccountRequirementListResult result = null;
            try
            {
                result = await this.controller.RetrieveCompanyBankAccountCreationRequirementsAsync(accountToken, country, currency);
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
                    "{\"payload\":[{\"bankCountry\":\"IT\",\"bankCurrency\":\"EUR\",\"requirements\":[{\"requirement\":\"BANK_IBAN\",\"format\":{\"example\":\"IT43K0310412701000000820420\",\"legend\":[{\"key\":\"IT43K0310412701000000820420\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Example IBAN\"},{\"language\":\"it-IT\",\"translation\":\"Esempio IBAN\"}]}]},\"description\":[{\"language\":\"en-US\",\"translation\":\"IBAN\"},{\"language\":\"it-IT\",\"translation\":\"IBAN\"}],\"validators\":[{\"validatorType\":\"REGEX\",\"expression\":\"^IT\\\\\\\\d{2}[A-Z]\\\\\\\\d{10}[0-9A-Z]{12}$\"}]},{\"requirement\":\"BANK_SWIFT_BIC\",\"format\":{\"example\":\"01234567890\",\"legend\":[{\"key\":\"01234567890\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Example Swift/BIC\"},{\"language\":\"it-IT\",\"translation\":\"Esempio Swift/BIC\"}]}]},\"description\":[{\"language\":\"en-US\",\"translation\":\"Swift/BIC\"},{\"language\":\"it-IT\",\"translation\":\"Swift/BIC\"}],\"validators\":[{\"validatorType\":\"REGEX\",\"expression\":\"^[a-z0-9A-Z]{8,11}$\"}]}],\"quote\":{\"formattedAmount\":\"$4.32 USD (USD, en-US), 0,00 â‚¬ EUR (EUR, fr-FR)\",\"amount\":4.32,\"currency\":\"USD\"},\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"string\"}]}],\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"string\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the pre-paid card as the destination.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveBankAccountCreationRequirementsForAPrepaidCard()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.Countries country = ApiHelper.JsonDeserialize<API.Models.Countries>("\"US\"");
            API.Models.Currencies currency = ApiHelper.JsonDeserialize<API.Models.Currencies>("\"USD\"");

            // Perform API call
            API.Models.BankAccountRequirementListResult result = null;
            try
            {
                result = await this.controller.RetrieveBankAccountCreationRequirementsForAPrepaidCardAsync(userToken, destinationToken, country, currency);
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
                    "{\"payload\":[{\"bankCountry\":\"IT\",\"bankCurrency\":\"EUR\",\"requirements\":[{\"requirement\":\"BANK_IBAN\",\"format\":{\"example\":\"IT43K0310412701000000820420\",\"legend\":[{\"key\":\"IT43K0310412701000000820420\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Example IBAN\"},{\"language\":\"it-IT\",\"translation\":\"Esempio IBAN\"}]}]},\"description\":[{\"language\":\"en-US\",\"translation\":\"IBAN\"},{\"language\":\"it-IT\",\"translation\":\"IBAN\"}],\"validators\":[{\"validatorType\":\"REGEX\",\"expression\":\"^IT\\\\\\\\d{2}[A-Z]\\\\\\\\d{10}[0-9A-Z]{12}$\"}]},{\"requirement\":\"BANK_SWIFT_BIC\",\"format\":{\"example\":\"01234567890\",\"legend\":[{\"key\":\"01234567890\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Example Swift/BIC\"},{\"language\":\"it-IT\",\"translation\":\"Esempio Swift/BIC\"}]}]},\"description\":[{\"language\":\"en-US\",\"translation\":\"Swift/BIC\"},{\"language\":\"it-IT\",\"translation\":\"Swift/BIC\"}],\"validators\":[{\"validatorType\":\"REGEX\",\"expression\":\"^[a-z0-9A-Z]{8,11}$\"}]}],\"quote\":{\"formattedAmount\":\"$4.32 USD (USD, en-US), 0,00 â‚¬ EUR (EUR, fr-FR)\",\"amount\":4.32,\"currency\":\"USD\"},\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"string\"}]}],\"links\":[{\"params\":{\"rel\":\"self\"},\"href\":\"string\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}