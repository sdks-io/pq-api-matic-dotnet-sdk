// <copyright file="PrepaidCardsControllerTest.cs" company="APIMatic">
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
    /// PrepaidCardsControllerTest.
    /// </summary>
    [TestFixture]
    public class PrepaidCardsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IPrepaidCardsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PrepaidCardsController;
        }

        /// <summary>
        /// Retrieve a list of [prepaid cards](page:resources/prepaid-cards) by user token that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListPrepaidCards()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.PrepaidCardListResult result = null;
            try
            {
                result = await this.controller.ListPrepaidCardsAsync(userToken, page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"dest-b61bc870-8ab8-4870-a209-6398b60269d5\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******3940\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-04-20T18:43:15Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"04/2025\",\"status\":\"PENDING_ACTIVATION\",\"bankInDetails\":[{\"key\":\"BANK_ACH_ABA\",\"value\":\"026014892\"},{\"key\":\"BANK_BBAN\",\"value\":\"8037390305203\"}],\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"dest-9a8f1dc9-5e59-4ce5-a919-fc586d85d6e5\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******4628\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-04-20T18:42:47Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"06/2025\",\"status\":\"CLOSED_LOST_STOLEN_DAMAGED\",\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-9a8f1dc9-5e59-4ce5-a919-fc586d85d6e5\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"dest-d9c6edab-ddec-4941-b980-f33cfe2f9f6b\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******1805\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-04-20T18:36:16Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"10/2025\",\"status\":\"CLOSED_LOST_STOLEN_DAMAGED\",\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-2bbfc967-d12e-4647-a887-d905172fb4bc\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-d9c6edab-ddec-4941-b980-f33cfe2f9f6b\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"100\",\"pageCount\":\"1\",\"recordCount\":\"3\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Order a [prepaid card](page:resources/prepaid-cards) for the user by specifying a cardPackage.
        ///
        ///Assign a prepaid card to a user when a program token and card reference number are supplied..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestOrderPrepaidCard()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.OrderPrepaidCard body = ApiHelper.JsonDeserialize<API.Models.OrderPrepaidCard>("{\"cardPackage\":\"712940\",\"programToken\":\"prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb\"}");

            // Perform API call
            API.Models.PrepaidCardResult result = null;
            try
            {
                result = await this.controller.OrderPrepaidCardAsync(userToken, body);
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
                    "{\"token\":\"dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******2127\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-05-06T18:14:52Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"06/2025\",\"status\":\"PENDING_ACTIVATION\",\"bankInDetails\":[{\"key\":\"BANK_ACH_ABA\",\"value\":\"026014892\"},{\"key\":\"BANK_BBAN\",\"value\":\"8037390853101\"}],\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-ae92315b-6190-4e56-bdf5-c0189ac420a1\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/prepaid-cards/dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Order a [prepaid card](page:resources/prepaid-cards) for the user by specifying a cardPackage.
        ///
        ///Assign a prepaid card to a user when a program token and card reference number are supplied..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestOrderPrepaidCard1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.OrderPrepaidCard body = ApiHelper.JsonDeserialize<API.Models.OrderPrepaidCard>("{\"cardPackage\":\"712940\",\"programToken\":\"prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb\"}");

            // Perform API call
            API.Models.PrepaidCardResult result = null;
            try
            {
                result = await this.controller.OrderPrepaidCardAsync(userToken, body);
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
                    "{\"token\":\"dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******2127\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-05-06T18:14:52Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"06/2025\",\"status\":\"PENDING_ACTIVATION\",\"bankInDetails\":[{\"key\":\"BANK_ACH_ABA\",\"value\":\"026014892\"},{\"key\":\"BANK_BBAN\",\"value\":\"8037390853101\"}],\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-ae92315b-6190-4e56-bdf5-c0189ac420a1\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/prepaid-cards/dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Replace a [prepaid card](page:resources/prepaid-cards) by destination token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestReplacePrepaidCard()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.ReplacePrepaidCard body = ApiHelper.JsonDeserialize<API.Models.ReplacePrepaidCard>("{\"cardPackage\":\"23654\",\"cardReplacementReason\":\"LOST\"}");

            // Perform API call
            API.Models.PrepaidCardResult result = null;
            try
            {
                result = await this.controller.ReplacePrepaidCardAsync(userToken, destinationToken, body);
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
                    "{\"token\":\"dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******2127\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-05-06T18:14:52Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"06/2025\",\"status\":\"PENDING_ACTIVATION\",\"bankInDetails\":[{\"key\":\"BANK_ACH_ABA\",\"value\":\"026014892\"},{\"key\":\"BANK_BBAN\",\"value\":\"8037390853101\"}],\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-ae92315b-6190-4e56-bdf5-c0189ac420a1\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/prepaid-cards/dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Replace a [prepaid card](page:resources/prepaid-cards) by destination token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestReplacePrepaidCard1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.ReplacePrepaidCard body = ApiHelper.JsonDeserialize<API.Models.ReplacePrepaidCard>("{\"cardPackage\":\"23654\",\"cardReplacementReason\":\"LOST\"}");

            // Perform API call
            API.Models.PrepaidCardResult result = null;
            try
            {
                result = await this.controller.ReplacePrepaidCardAsync(userToken, destinationToken, body);
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
                    "{\"token\":\"dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******2127\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-05-06T18:14:52Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"06/2025\",\"status\":\"PENDING_ACTIVATION\",\"bankInDetails\":[{\"key\":\"BANK_ACH_ABA\",\"value\":\"026014892\"},{\"key\":\"BANK_BBAN\",\"value\":\"8037390853101\"}],\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-ae92315b-6190-4e56-bdf5-c0189ac420a1\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/prepaid-cards/dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve [prepaid card](page:resources/prepaid-cards) details by destination token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrievePrepaidCard()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";

            // Perform API call
            API.Models.PrepaidCardResult result = null;
            try
            {
                result = await this.controller.RetrievePrepaidCardAsync(userToken, destinationToken);
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
                    "{\"token\":\"dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******2127\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-05-06T18:14:52Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"06/2025\",\"status\":\"PENDING_ACTIVATION\",\"bankInDetails\":[{\"key\":\"BANK_ACH_ABA\",\"value\":\"026014892\"},{\"key\":\"BANK_BBAN\",\"value\":\"8037390853101\"}],\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-ae92315b-6190-4e56-bdf5-c0189ac420a1\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/prepaid-cards/dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Partial [prepaid card](page:resources/prepaid-cards) update.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdatePrepaidCard()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.UpdatePrepaidCard body = ApiHelper.JsonDeserialize<API.Models.UpdatePrepaidCard>("{\"cardPackage\":\"\",\"status\":\"QUEUED\"}");

            // Perform API call
            API.Models.PrepaidCardResult result = null;
            try
            {
                result = await this.controller.UpdatePrepaidCardAsync(userToken, destinationToken, body);
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
                    "{\"token\":\"dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"cardNetwork\":\"VISA\",\"cardNumber\":\"483318******2127\",\"cardPackage\":\"712940\",\"country\":\"US\",\"createdOn\":\"2022-05-06T18:14:52Z\",\"currency\":\"USD\",\"cvv\":\"***\",\"expires\":\"06/2025\",\"status\":\"PENDING_ACTIVATION\",\"bankInDetails\":[{\"key\":\"BANK_ACH_ABA\",\"value\":\"026014892\"},{\"key\":\"BANK_BBAN\",\"value\":\"8037390853101\"}],\"capabilities\":[\"BANK_IN\",\"SET_PIN\",\"APPLEPAY\",\"GOOGLEPAY\",\"SAMSUNGPAY\"],\"userToken\":\"user-ae92315b-6190-4e56-bdf5-c0189ac420a1\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/prepaid-cards/dest-fcd31b51-0968-4537-8722-f486bdd5cd74\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListCardAuthorizations()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";

            // Perform API call
            API.Models.AuthorizationListResult result = null;
            try
            {
                result = await this.controller.ListCardAuthorizationsAsync(userToken, destinationToken);
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
                    "{\"payload\":[{\"type\":\"UNSETTLED_AUTHORIZATION\",\"createdOn\":\"2022-05-04T13:22:53Z\",\"sign\":\"DEBIT\",\"sourceToken\":\"dest-8e35fc1b-82f4-4bf5-93d1-27f71a192bc2\",\"amount\":-35,\"currency\":\"USD\",\"status\":\"UNSETTLED\",\"descriptions\":[{\"language\":\"en-US\",\"translation\":\"Completed Bank Transfer Request\"}],\"authDate\":\"2022-05-04T13:22:53Z\",\"reference\":\"CC008AB44895\"}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"100\",\"pageCount\":\"0\",\"recordCount\":\"0\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-cf6244d7-f6b8-4625-906a-9f21fc8c774b/prepaid-cards/dest-8e35fc1b-82f4-4bf5-93d1-27f71a192bc2/authorizations\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}