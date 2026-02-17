// <copyright file="JobsControllerTest.cs" company="APIMatic">
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
    /// JobsControllerTest.
    /// </summary>
    [TestFixture]
    public class JobsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IJobsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.JobsController;
        }

        /// <summary>
        /// Retrieve a list of [jobs](page:resources/jobs) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListPaymentJobs()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.PaymentJobListResult result = null;
            try
            {
                result = await this.controller.ListPaymentJobsAsync(page, pageSize, filter, sort, language);
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
        /// Create a [payment](page:resources/jobs).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreatePaymentJob()
        {
            // Parameters for the API call
            PaymentJob body = null;

            // Perform API call
            API.Models.PaymentJobResult result = null;
            try
            {
                result = await this.controller.CreatePaymentJobAsync(body);
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
        /// Create a [payment](page:resources/jobs).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreatePaymentJob1()
        {
            // Parameters for the API call
            PaymentJob body = null;

            // Perform API call
            API.Models.PaymentJobResult result = null;
            try
            {
                result = await this.controller.CreatePaymentJobAsync(body);
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
        /// Retrieve a single payment [job](page:resources/jobs).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrievePaymentJob()
        {
            // Parameters for the API call
            string jobToken = "jobs-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string filter = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.PaymentJobResult result = null;
            try
            {
                result = await this.controller.RetrievePaymentJobAsync(jobToken, filter, language);
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
        /// Cancel an submitted payment [job](page:resources/jobs).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCancelPaymentJob()
        {
            // Parameters for the API call
            string jobToken = "jobs-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.PaymentJobResult result = null;
            try
            {
                result = await this.controller.CancelPaymentJobAsync(jobToken);
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