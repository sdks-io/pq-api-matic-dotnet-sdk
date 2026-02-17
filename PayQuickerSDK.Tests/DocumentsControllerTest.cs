// <copyright file="DocumentsControllerTest.cs" company="APIMatic">
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
    /// DocumentsControllerTest.
    /// </summary>
    [TestFixture]
    public class DocumentsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IDocumentsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.DocumentsController;
        }

        /// <summary>
        /// Retrieve a list of user [documents](page:resources/documents) that supports filtering, sorting, and pagination through existing mechanisms..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListDocuments()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.DocumentListResult result = null;
            try
            {
                result = await this.controller.ListDocumentsAsync(userToken, page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"createDate\":\"2022-05-04T18:59:38Z\",\"fields\":[{\"key\":\"TYPE\",\"value\":\"DRIVERS_LICENSE\"},{\"key\":\"STATUS\",\"value\":\"PROVIDED\"},{\"key\":\"EXPIRATION_DATE\",\"value\":\"10-31-2021\"}],\"filename\":\"List.jpg\",\"mimeType\":\"image/jpeg\",\"token\":\"docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/documents/docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"2\",\"pageCount\":\"0\",\"recordCount\":\"0\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/documents?page=1&pageSize=2\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Upload a user [document](page:resources/documents).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUploadDocument()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.CreateOrUpdateDocumentFields fields = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateDocumentFields>("{\r\n  \"fields\": [\r\n    {\r\n      \"key\": \"EXPIRATION_DATE\",\r\n      \"value\": \"string\"\r\n    }\r\n  ]\r\n}");
            FileStreamInfo upload = null;

            // Perform API call
            API.Models.DocumentResult result = null;
            try
            {
                result = await this.controller.UploadDocumentAsync(userToken, fields, upload);
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
                    "{\"createDate\":\"2022-05-04T18:59:38Z\",\"fields\":[{\"key\":\"EXPIRATION_DATE\",\"value\":\"10-31-2021\"},{\"key\":\"TYPE\",\"value\":\"DRIVERS_LICENSE\"},{\"key\":\"STATUS\",\"value\":\"PROVIDED\"}],\"token\":\"docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/documents/docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Upload a user [document](page:resources/documents).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUploadDocument1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.CreateOrUpdateDocumentFields fields = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateDocumentFields>("{\r\n  \"fields\": [\r\n    {\r\n      \"key\": \"EXPIRATION_DATE\",\r\n      \"value\": \"string\"\r\n    }\r\n  ]\r\n}");
            FileStreamInfo upload = null;

            // Perform API call
            API.Models.DocumentResult result = null;
            try
            {
                result = await this.controller.UploadDocumentAsync(userToken, fields, upload);
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
                    "{\"createDate\":\"2022-05-04T18:59:38Z\",\"fields\":[{\"key\":\"EXPIRATION_DATE\",\"value\":\"10-31-2021\"},{\"key\":\"TYPE\",\"value\":\"DRIVERS_LICENSE\"},{\"key\":\"STATUS\",\"value\":\"PROVIDED\"}],\"token\":\"docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/documents/docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single user [document](page:resources/documents) by its document token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveDocument()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string documentToken = "docu-6e582242-5dd4-4883-b0c2-488e09a26595";

            // Perform API call
            API.Models.DocumentResult result = null;
            try
            {
                result = await this.controller.RetrieveDocumentAsync(userToken, documentToken);
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
                    "{\"createDate\":\"2022-05-04T18:59:38Z\",\"fields\":[{\"key\":\"EXPIRATION_DATE\",\"value\":\"10-31-2021\"},{\"key\":\"TYPE\",\"value\":\"DRIVERS_LICENSE\"},{\"key\":\"STATUS\",\"value\":\"PROVIDED\"}],\"token\":\"docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/documents/docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Replace the user [documents](page:resources/documents) at the given document token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestReplaceDocument()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string documentToken = "docu-6e582242-5dd4-4883-b0c2-488e09a26595";
            API.Models.CreateOrUpdateDocumentFields fields = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateDocumentFields>("{\r\n  \"fields\": [\r\n    {\r\n      \"key\": \"EXPIRATION_DATE\",\r\n      \"value\": \"string\"\r\n    }\r\n  ]\r\n}");
            FileStreamInfo upload = null;

            // Perform API call
            API.Models.DocumentResult result = null;
            try
            {
                result = await this.controller.ReplaceDocumentAsync(userToken, documentToken, fields, upload);
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
                    "{\"createDate\":\"2022-05-04T18:59:38Z\",\"fields\":[{\"key\":\"EXPIRATION_DATE\",\"value\":\"10-31-2021\"},{\"key\":\"TYPE\",\"value\":\"DRIVERS_LICENSE\"},{\"key\":\"STATUS\",\"value\":\"PROVIDED\"}],\"token\":\"docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/documents/docu-2053aaad-c1a5-45e2-a2da-f71287f32800\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}