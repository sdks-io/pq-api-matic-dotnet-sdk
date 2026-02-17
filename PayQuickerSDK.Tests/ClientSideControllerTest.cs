// <copyright file="ClientSideControllerTest.cs" company="APIMatic">
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
    /// ClientSideControllerTest.
    /// </summary>
    [TestFixture]
    public class ClientSideControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IClientSideController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ClientSideController;
        }

        /// <summary>
        /// Generate a token used to reveal [prepaid card](page:resources/prepaid-cards) information in the form of image data (base64) or JSON.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCardDataToken()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.PrepaidCardDataType format = ApiHelper.JsonDeserialize<API.Models.PrepaidCardDataType>("\"TEXT\"");
            API.Models.PrepaidCardImageSide side = ApiHelper.JsonDeserialize<API.Models.PrepaidCardImageSide>("\"FRONT\"");

            // Perform API call
            API.Models.PrepaidCardDataTokenResult result = null;
            try
            {
                result = await this.controller.CreateCardDataTokenAsync(userToken, destinationToken, format, side);
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
                    "{\"cardProcessorType\":\"QOLO\",\"resourceValue\":\"b61bc8708ab84870a2096398b60269d5\",\"token\":\"iEureKuLW1gZQ7d3/2ijX4+6bDZuUwpp2QmhPfedarncS2Cde1Ebmby+dxfeP7+Iaty9YYCLFwY42HHOm03dliH7Jp0Yo/sjOb/FmSQ3IOVYpNSYBcZYGmgpyBEG9gPa2HRIKK8+NcPVjjb+0gfqFAI52Emk0P+VPaBZ2NgsENV/I4MuIkWsUXha3QZh49a0EK3wO14jwR4BosY/rk0/9F5uJEWUjv8gvPej+dCFyMnybjj6jPK9f/gFlPUYVHuS\",\"tokenPurposeType\":\"CARD_OPERATION\",\"url\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5/pci?token=iEureKuLW1gZQ7d3%2f2ijX4%2b6bDZuUwpp2QmhPfedarncS2Cde1Ebmby%2bdxfeP7%2bIaty9YYCLFwY42HHOm03dliH7Jp0Yo%2fsjOb%2fFmSQ3IOVYpNSYBcZYGmgpyBEG9gPa2HRIKK8%2bNcPVjjb%2b0gfqFAI52Emk0P%2bVPaBZ2NgsENV%2fI4MuIkWsUXha3QZh49a0EK3wO14jwR4BosY%2frk0%2f9F5uJEWUjv8gvPej%2bdCFyMnybjj6jPK9f%2fgFlPUYVHuS&format=TEXT\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5/pci/iEureKuLW1gZQ7d3/2ijX4+6bDZuUwpp2QmhPfedarncS2Cde1Ebmby+dxfeP7+Iaty9YYCLFwY42HHOm03dliH7Jp0Yo/sjOb/FmSQ3IOVYpNSYBcZYGmgpyBEG9gPa2HRIKK8+NcPVjjb+0gfqFAI52Emk0P+VPaBZ2NgsENV/I4MuIkWsUXha3QZh49a0EK3wO14jwR4BosY/rk0/9F5uJEWUjv8gvPej+dCFyMnybjj6jPK9f/gFlPUYVHuS\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Return [prepaid card](page:resources/prepaid-cards) data in the form of image data, text, or both.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveCardData()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.PrepaidCardDataType format = ApiHelper.JsonDeserialize<API.Models.PrepaidCardDataType>("\"TEXT\"");
            API.Models.PrepaidCardImageSide side = ApiHelper.JsonDeserialize<API.Models.PrepaidCardImageSide>("\"FRONT\"");
            API.Models.RetrieveCardData body = ApiHelper.JsonDeserialize<API.Models.RetrieveCardData>("{\"Token\":\"iEureKuLW1gZQ7d3/2ijX4+6bDZuUwpp2QmhPfedarncS2Cde1Ebmby+dxfeP7+Iaty9YYCLFwY42HHOm03dliH7Jp0Yo/sjOb/FmSQ3IOVYpNSYBcZYGmgpyBEG9gPa2HRIKK8+NcPVjjb+0gfqFAI52Emk0P+VPaBZ2NgsENV/I4MuIkWsUXha3QZh49a0EK3wO14jwR4BosY/rk0/9F5uJEWUjv8gvPej+dCFyMnybjj6jPK9f/gFlPUYVHuS\"}");

            // Perform API call
            API.Models.PrepaidCardDataResult result = null;
            try
            {
                result = await this.controller.RetrieveCardDataAsync(userToken, destinationToken, format, side, body);
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
                    "{\"cardNumber\":4833180000103940,\"cvvNumber\":\"709\",\"expiration\":\"04/25\",\"nameOnCard\":\"SIDNEY MAYER\",\"token\":\"dest-b61bc870-8ab8-4870-a209-6398b60269d5\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5/pci\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Return [prepaid card](page:resources/prepaid-cards) data in the form of image data, text, or both.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveCardData1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.PrepaidCardDataType format = ApiHelper.JsonDeserialize<API.Models.PrepaidCardDataType>("\"TEXT\"");
            API.Models.PrepaidCardImageSide side = ApiHelper.JsonDeserialize<API.Models.PrepaidCardImageSide>("\"FRONT\"");
            API.Models.RetrieveCardData body = ApiHelper.JsonDeserialize<API.Models.RetrieveCardData>("{\"Token\":\"iEureKuLW1gZQ7d3/2ijX4+6bDZuUwpp2QmhPfedarncS2Cde1Ebmby+dxfeP7+Iaty9YYCLFwY42HHOm03dliH7Jp0Yo/sjOb/FmSQ3IOVYpNSYBcZYGmgpyBEG9gPa2HRIKK8+NcPVjjb+0gfqFAI52Emk0P+VPaBZ2NgsENV/I4MuIkWsUXha3QZh49a0EK3wO14jwR4BosY/rk0/9F5uJEWUjv8gvPej+dCFyMnybjj6jPK9f/gFlPUYVHuS\"}");

            // Perform API call
            API.Models.PrepaidCardDataResult result = null;
            try
            {
                result = await this.controller.RetrieveCardDataAsync(userToken, destinationToken, format, side, body);
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
                    "{\"cardNumber\":4833180000103940,\"cvvNumber\":\"709\",\"expiration\":\"04/25\",\"nameOnCard\":\"SIDNEY MAYER\",\"token\":\"dest-b61bc870-8ab8-4870-a209-6398b60269d5\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5/pci\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve one part of a two-part token required to reveal or set a client side [prepaid card](page:resources/prepaid-cards) PIN.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCardPINToken()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";

            // Perform API call
            API.Models.PrepaidCardPinTokenResult result = null;
            try
            {
                result = await this.controller.CreateCardPINTokenAsync(userToken, destinationToken);
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
                    "{\"cardProcessorType\":\"QOLO\",\"cardPinToken\":\"/YnZvwn9Q5TczQhubfjB8Sq1inIVtMGnKT9ywAcan60uavrMNeMAR1RGyuWj7N8XOiy7W2QrEXGzM/668UIJMzTFOlVqSrkQSn22ErWCb5BQTYXl04sF1nW73u8aykRHi1c4lGhu3kSrTKxqqN/GtEJTcDV+SfBj/huWQZrdWTxdbnN2XX5jqNkGUHbfkFU0s9oxxwX6cYYreBbtmo0WFSLS0o2RT+LGAtiEqgPvT5T6NlZlNa+TF17gbgxHi0sG\",\"token\":\"dest-b61bc870-8ab8-4870-a209-6398b60269d5\",\"url\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5/pin?token=%2fYnZvwn9Q5TczQhubfjB8Sq1inIVtMGnKT9ywAcan60uavrMNeMAR1RGyuWj7N8XOiy7W2QrEXGzM%2f668UIJMzTFOlVqSrkQSn22ErWCb5BQTYXl04sF1nW73u8aykRHi1c4lGhu3kSrTKxqqN%2fGtEJTcDV%2bSfBj%2fhuWQZrdWTxdbnN2XX5jqNkGUHbfkFU0s9oxxwX6cYYreBbtmo0WFSLS0o2RT%2bLGAtiEqgPvT5T6NlZlNa%2bTF17gbgxHi0sG\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5/pin\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Set a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards), if supported by program.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateCardPIN()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.UpdateCardPin body = ApiHelper.JsonDeserialize<API.Models.UpdateCardPin>("{\"cardPinToken\":\"05OQkdzRkzjP+qlhTrsko00cb58gGERv+g1Nd7/xK+Ol2+vJaOJnjQgdFA0Jqf5TFdYZrjO7dw/2l1V9k8xNGVr3MyKHrQh/CZ+HMz2gdI3VkJVj0x50PStECnN0t1P4eXTZqmh93O24fXRyvLn8XvmfyV7nF94IEwzwVe6Xdvl6mHQyyyNwtSNKHtNGGpM88hoX5PAvbqgYrsy5tBYi3CcN+Ld5Ia8+nFq9pDAXs6dCLsidU9XJRzLLcWWdhzxR\",\"cardPin\":\"4444\"}");

            // Perform API call
            API.Models.OperationResult result = null;
            try
            {
                result = await this.controller.UpdateCardPINAsync(userToken, destinationToken, body);
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
                    "{\"result\":true,\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Reveal a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveCardPIN()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.RetrieveCardPin body = ApiHelper.JsonDeserialize<API.Models.RetrieveCardPin>("{\"cardPinToken\":\"IzPQ55SGbTumVRn7xscpjL9zgFV29503mQ+GJuKAzCYl8DhLkJKZSBqPLWx6rBf/ky9FRqZCptCCVmZ3ZT+sR6sVmBDT9vfK+8Bbv/6Kftz+Pu9DJOXTwd7Hcs9PuaU5qirAq9rp3P5pKL5Ilg+ZkU8b7TP2ZMBIchxYHZG5aJ3b96BdlMyEB4bu1UATKOjS2+vYFLUFprtwbnwp94QuaiFALG9NMClQ3CqWJqot/Z1DSbTnPqIq+BRzA8Xdbh1j\"}");

            // Perform API call
            API.Models.PrepaidCardPinResult result = null;
            try
            {
                result = await this.controller.RetrieveCardPINAsync(userToken, destinationToken, body);
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
                    "{\"cardPin\":\"4444\",\"token\":\"dest-b61bc870-8ab8-4870-a209-6398b60269d5\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5/pin\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Reveal a [PIN](#/rest/models/structures/prepaid-card-pin) for a [prepaid card](page:resources/prepaid-cards).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveCardPIN1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
            API.Models.RetrieveCardPin body = ApiHelper.JsonDeserialize<API.Models.RetrieveCardPin>("{\"cardPinToken\":\"IzPQ55SGbTumVRn7xscpjL9zgFV29503mQ+GJuKAzCYl8DhLkJKZSBqPLWx6rBf/ky9FRqZCptCCVmZ3ZT+sR6sVmBDT9vfK+8Bbv/6Kftz+Pu9DJOXTwd7Hcs9PuaU5qirAq9rp3P5pKL5Ilg+ZkU8b7TP2ZMBIchxYHZG5aJ3b96BdlMyEB4bu1UATKOjS2+vYFLUFprtwbnwp94QuaiFALG9NMClQ3CqWJqot/Z1DSbTnPqIq+BRzA8Xdbh1j\"}");

            // Perform API call
            API.Models.PrepaidCardPinResult result = null;
            try
            {
                result = await this.controller.RetrieveCardPINAsync(userToken, destinationToken, body);
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
                    "{\"cardPin\":\"4444\",\"token\":\"dest-b61bc870-8ab8-4870-a209-6398b60269d5\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2bbfc967-d12e-4647-a887-d905172fb4bc/prepaid-cards/dest-b61bc870-8ab8-4870-a209-6398b60269d5/pin\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}