// <copyright file="EventsControllerTest.cs" company="APIMatic">
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
    /// EventsControllerTest.
    /// </summary>
    [TestFixture]
    public class EventsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IEventsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.EventsController;
        }

        /// <summary>
        /// Retrieve a list of [user events](page:resources/user#list-user-events) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListEvents()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.EventListResult result = null;
            try
            {
                result = await this.controller.ListEventsAsync(userToken);
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
                    "{\"payload\":[{\"token\":\"evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292\",\"canBeCancelled\":false,\"eventRequirementCategoryType\":\"CATEGORY_UNDEFINED\",\"eventRequirementType\":\"TYPE_UNDEFINED\",\"eventStatus\":\"UNDEFINED\",\"eventType\":\"REQUIRED\",\"isComplete\":false,\"userAction\":\"NO_ACTION\",\"userImpact\":\"NO_IMPACT\",\"event\":\"WALLET_REGISTRATION\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events/evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"evnt-fe7c9063-0c86-400e-89e3-068c2f7e4f65\",\"canBeCancelled\":false,\"eventRequirementCategoryType\":\"CATEGORY_UNDEFINED\",\"eventRequirementType\":\"TYPE_UNDEFINED\",\"eventStatus\":\"UNDEFINED\",\"eventType\":\"REQUIRED\",\"isComplete\":false,\"userAction\":\"NO_ACTION\",\"userImpact\":\"NO_IMPACT\",\"event\":\"WALLET_REGISTRATION\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events/evnt-fe7c9063-0c86-400e-89e3-068c2f7e4f65\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"100\",\"pageCount\":\"0\",\"recordCount\":\"0\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a list of [user events](page:resources/user#list-user-events) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListEvents1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.EventListResult result = null;
            try
            {
                result = await this.controller.ListEventsAsync(userToken);
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
                    "{\"payload\":[{\"token\":\"evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292\",\"canBeCancelled\":false,\"eventRequirementCategoryType\":\"CATEGORY_UNDEFINED\",\"eventRequirementType\":\"TYPE_UNDEFINED\",\"eventStatus\":\"UNDEFINED\",\"eventType\":\"REQUIRED\",\"isComplete\":false,\"userAction\":\"NO_ACTION\",\"userImpact\":\"NO_IMPACT\",\"event\":\"WALLET_REGISTRATION\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events/evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"evnt-fe7c9063-0c86-400e-89e3-068c2f7e4f65\",\"canBeCancelled\":false,\"eventRequirementCategoryType\":\"CATEGORY_UNDEFINED\",\"eventRequirementType\":\"TYPE_UNDEFINED\",\"eventStatus\":\"UNDEFINED\",\"eventType\":\"REQUIRED\",\"isComplete\":false,\"userAction\":\"NO_ACTION\",\"userImpact\":\"NO_IMPACT\",\"event\":\"WALLET_REGISTRATION\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events/evnt-fe7c9063-0c86-400e-89e3-068c2f7e4f65\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"100\",\"pageCount\":\"0\",\"recordCount\":\"0\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [user event](page:resources/user#get-user-event).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveEvent()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string eventToken = "evnt-28491de2-5b22-4e30-028a-45901a10baa9";

            // Perform API call
            API.Models.UserEventResult result = null;
            try
            {
                result = await this.controller.RetrieveEventAsync(userToken, eventToken);
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
                    "{\"token\":\"evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292\",\"canBeCancelled\":false,\"eventRequirementCategoryType\":\"CATEGORY_UNDEFINED\",\"eventRequirementType\":\"TYPE_UNDEFINED\",\"eventStatus\":\"UNDEFINED\",\"eventType\":\"REQUIRED\",\"isComplete\":false,\"userAction\":\"NO_ACTION\",\"userImpact\":\"NO_IMPACT\",\"event\":\"WALLET_REGISTRATION\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events/evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}