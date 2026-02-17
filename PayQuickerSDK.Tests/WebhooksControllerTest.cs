// <copyright file="WebhooksControllerTest.cs" company="APIMatic">
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
    /// WebhooksControllerTest.
    /// </summary>
    [TestFixture]
    public class WebhooksControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IWebhooksController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.WebhooksController;
        }

        /// <summary>
        /// Retrieve a list of all [webhook subscriptions](page:resources/webhooks) that supports filtering, sorting, and pagination through existing mechanisms
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListSubscriptions()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.WebhookSubscriptionListResult result = null;
            try
            {
                result = await this.controller.ListSubscriptionsAsync(page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"webh-4cdcb012-8b3f-453f-af4f-c29e6091db92\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2021-08-09T18:31:55Z\",\"url\":\"https://api.sandbox.payquicker.io/integrations/internal/twohundred\",\"namespace\":\"PREPAIDCARDS.UPDATED.STATUS.CLOSEDSTOLEN\",\"status\":\"SUBSCRIBED\",\"links\":[{\"href\":\"https://platform.mypayquicker.dev/api/v2/webhooks/webh-4cdcb012-8b3f-453f-af4f-c29e6091db92\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2021-08-09T18:31:55Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\",\"namespace\":\"PAPERCHECKS.UPDATED.STATUS.REDEEMED\",\"status\":\"SUBSCRIBED\",\"links\":[{\"href\":\"https://platform.mypayquicker.dev/api/v2/webhooks/webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"params\":{\"rel\":\"self\"}}]},{\"namespace\":\"USERS.CREATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USERS.UPDATED.STATUS.REGISTRATIONINPROGRESS\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USERS.UPDATED.STATUS.REGISTRATIONCOMPLETE\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USERS.UPDATED.KYC.REQUIRED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USERS.UPDATED.KYC.PROVIDED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USERS.UPDATED.KYC.REJECTED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USERS.UPDATED.KYC.APPROVED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PREPAIDCARDS.CREATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PREPAIDCARDS.UPDATED.STATUS.ACTIVE\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PREPAIDCARDS.UPDATED.STATUS.CLOSED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PREPAIDCARDS.UPDATED.STATUS.CLOSEDLOST\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PREPAIDCARDS.UPDATED.STATUS.PENDINGACTIVATION\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PREPAIDCARDS.UPDATED.STATUS.PENDINGORDER\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PREPAIDCARDS.UPDATED.STATUS.SUSPENDED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"BANKACCOUNTS.CREATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"BANKACCOUNTS.UPDATED.STATUS.APPROVED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"BANKACCOUNTS.UPDATED.STATUS.DELETED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"BANKACCOUNTS.UPDATED.STATUS.COMPLIANCEHOLD\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"BANKACCOUNTS.UPDATED.DETAILS.MODIFIED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PAPERCHECKS.CREATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PAPERCHECKS.UPDATED.STATUS.INPROGRESS\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PAPERCHECKS.UPDATED.STATUS.CANCELLED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PAPERCHECKS.UPDATED.DETAILS.MODIFIED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"TRANSFERQUOTES.CREATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"TRANSFERQUOTES.ACCEPTED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"TRANSFERQUOTES.VOIDED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"TRANSFERQUOTES.CANCELLED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PAYMENTQUOTES.CREATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PAYMENTQUOTES.VOIDED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PAYMENTQUOTES.CANCELLED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"SPENDBACKQUOTES.CREATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"SPENDBACKQUOTES.ACCEPTED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"SPENDBACKQUOTES.VOIDED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"SPENDBACKQUOTES.CANCELLED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.CREATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.COMPLETED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.CANCELLED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.REFUNDED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.FAILED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.PENDING\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.SCHEDULED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.PROCESSING\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.REVERSED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.DETAILS.MODIFIED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USEREVENTS.STARTED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USEREVENTS.UPDATED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"USEREVENTS.COMPLETED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"RECEIPTS.UPDATED.STATUS.RETURNED\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"},{\"namespace\":\"PREPAIDCARDS.UPDATED.STATUS.PENDINGRELEASE\",\"status\":\"AVAILABLE\",\"token\":\"webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2020-07-24T14:53:08Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"100\",\"pageCount\":\"0\",\"recordCount\":\"0\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://platform.mypayquicker.dev/api/v2/webhooks\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Update a [webhook subscription](page:resources/webhooks)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateSubscription()
        {
            // Parameters for the API call
            API.Models.CreateWebhookRequest body = ApiHelper.JsonDeserialize<API.Models.CreateWebhookRequest>("{\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"}");

            // Perform API call
            API.Models.WebhookSubscriptionResult result = null;
            try
            {
                result = await this.controller.UpdateSubscriptionAsync(body);
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
                    "{\"token\":\"webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2022-04-13T05:53:48Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\",\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"status\":\"SUBSCRIBED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a [webhook subscription](page:resources/webhooks)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateSubscription()
        {
            // Parameters for the API call
            API.Models.CreateWebhookRequest body = ApiHelper.JsonDeserialize<API.Models.CreateWebhookRequest>("{\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"}");

            // Perform API call
            API.Models.WebhookSubscriptionResult result = null;
            try
            {
                result = await this.controller.CreateSubscriptionAsync(body);
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
                    "{\"token\":\"webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2022-04-13T05:53:48Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\",\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"status\":\"SUBSCRIBED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a [webhook subscription](page:resources/webhooks)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateSubscription1()
        {
            // Parameters for the API call
            API.Models.CreateWebhookRequest body = ApiHelper.JsonDeserialize<API.Models.CreateWebhookRequest>("{\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\"}");

            // Perform API call
            API.Models.WebhookSubscriptionResult result = null;
            try
            {
                result = await this.controller.CreateSubscriptionAsync(body);
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
                    "{\"token\":\"webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2022-04-13T05:53:48Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\",\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"status\":\"SUBSCRIBED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [webhook subscription](page:resources/webhooks) using the webhook token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveSubscription()
        {
            // Parameters for the API call
            string webhookToken = "webh-2dd54a53-3814-4ce1-862f-dc06b09ead4a";

            // Perform API call
            API.Models.WebhookSubscriptionResult result = null;
            try
            {
                result = await this.controller.RetrieveSubscriptionAsync(webhookToken);
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
                    "{\"token\":\"webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2022-04-13T05:53:48Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\",\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"status\":\"SUBSCRIBED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Delete a [webhook subscription](page:resources/webhooks).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteSubscription()
        {
            // Parameters for the API call
            string webhookToken = "webh-2dd54a53-3814-4ce1-862f-dc06b09ead4a";

            // Perform API call
            API.Models.WebhookSubscriptionResult result = null;
            try
            {
                result = await this.controller.DeleteSubscriptionAsync(webhookToken);
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
                    "{\"token\":\"webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"created\":\"2020-07-24T14:53:08Z\",\"lastUpdated\":\"2022-04-13T05:53:48Z\",\"url\":\"https://fawebhookreceiver.azurewebsites.net/api/receive\",\"namespace\":\"PAYMENTQUOTES.ACCEPTED\",\"status\":\"SUBSCRIBED\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}