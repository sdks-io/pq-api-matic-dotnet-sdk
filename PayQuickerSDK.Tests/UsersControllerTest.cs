// <copyright file="UsersControllerTest.cs" company="APIMatic">
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
    /// UsersControllerTest.
    /// </summary>
    [TestFixture]
    public class UsersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IUsersController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.UsersController;
        }

        /// <summary>
        /// Retrieve a list of [users](page:resources/user) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListUsers()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.UserListResult result = null;
            try
            {
                result = await this.controller.ListUsersAsync(page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"user-19c60cc6-71c3-4db0-9092-4d422410c87e\",\"addressLine1\":\"400 Linden Oaks\",\"addressLine2\":\"Rochester, NY 14625-2818\",\"city\":\"Rochester\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-07T21:23:41Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Caden_Aufderhar@GMAIL.COM\",\"firstName\":\"Susie\",\"gender\":\"MALE\",\"language\":\"en-US\",\"lastName\":\"Fadel\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14625\",\"premiseNumber\":\"400\",\"programUserId\":\"Haley_Ryan\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-19c60cc6-71c3-4db0-9092-4d422410c87e\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"user-2d926d31-a609-40e1-b28a-a32e0aeb6a79\",\"addressLine1\":\"400 Linden Oaks\",\"addressLine2\":\"Rochester, NY 14625-2818\",\"city\":\"Rochester\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-08T16:04:54Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Milton_Cronin9@GMAIL.COM\",\"firstName\":\"Alycia\",\"gender\":\"MALE\",\"language\":\"en-US\",\"lastName\":\"McLaughlin\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14625\",\"premiseNumber\":\"400\",\"programUserId\":\"Elliot.Sawayn\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2d926d31-a609-40e1-b28a-a32e0aeb6a79\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"user-80df50a2-3cc8-462d-87c8-cf3e266994c8\",\"addressLine1\":\"400 Linden Oaks\",\"addressLine2\":\"Rochester, NY 14625-2818\",\"city\":\"Rochester\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-08T16:13:53Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Meta50@GMAIL.COM\",\"firstName\":\"Trisha\",\"gender\":\"MALE\",\"governmentId\":\"000000000\",\"language\":\"en-US\",\"lastName\":\"Leffler\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14625\",\"premiseNumber\":\"400\",\"programUserId\":\"Nona49\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-80df50a2-3cc8-462d-87c8-cf3e266994c8\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"user-b26db8d1-ebb1-4367-aad4-3ffb6f0f17cf\",\"addressLine1\":\"400 Linden Oaks\",\"addressLine2\":\"Rochester, NY 14625-2818\",\"city\":\"Rochester\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-08T16:21:54Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Frankie_Stoltenberg@GMAIL.COM\",\"firstName\":\"Kevon\",\"gender\":\"MALE\",\"governmentId\":\"000000000\",\"language\":\"en-US\",\"lastName\":\"Waelchi\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14625\",\"premiseNumber\":\"400\",\"programUserId\":\"Lydia_Jacobi13\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-b26db8d1-ebb1-4367-aad4-3ffb6f0f17cf\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"user-61b12c1f-7cff-42e3-9c56-09ba2b08d2ed\",\"addressLine1\":\"4179 BUFFALO ROAD\",\"businessAddressLine1\":\"400 Linden Oaks\",\"businessAddressType\":\"BUSINESS\",\"businessCity\":\"Rochester\",\"businessCountry\":\"US\",\"businessName\":\"Api V2 Company LLC\",\"businessOperatingName\":\"Api V2 Company LLC\",\"businessPostalCode\":\"14625\",\"businessRegion\":\"NY\",\"businessRegistrationCountry\":\"US\",\"businessRegistrationRegion\":\"NY\",\"city\":\"NORTH CHILI\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-08T16:36:05Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Helena.Skiles24@GMAIL.COM\",\"firstName\":\"Westley\",\"gender\":\"MALE\",\"governmentId\":\"000000000\",\"language\":\"en-US\",\"lastName\":\"Westley\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14514\",\"premiseNumber\":\"400\",\"programUserId\":\"Nicholas94\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"BUSINESS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-61b12c1f-7cff-42e3-9c56-09ba2b08d2ed\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"5\",\"pageCount\":\"124\",\"recordCount\":\"618\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users?pageSize=5&page=1\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a list of [users](page:resources/user) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListUsers1()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.UserListResult result = null;
            try
            {
                result = await this.controller.ListUsersAsync(page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"user-19c60cc6-71c3-4db0-9092-4d422410c87e\",\"addressLine1\":\"400 Linden Oaks\",\"addressLine2\":\"Rochester, NY 14625-2818\",\"city\":\"Rochester\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-07T21:23:41Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Caden_Aufderhar@GMAIL.COM\",\"firstName\":\"Susie\",\"gender\":\"MALE\",\"language\":\"en-US\",\"lastName\":\"Fadel\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14625\",\"premiseNumber\":\"400\",\"programUserId\":\"Haley_Ryan\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-19c60cc6-71c3-4db0-9092-4d422410c87e\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"user-2d926d31-a609-40e1-b28a-a32e0aeb6a79\",\"addressLine1\":\"400 Linden Oaks\",\"addressLine2\":\"Rochester, NY 14625-2818\",\"city\":\"Rochester\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-08T16:04:54Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Milton_Cronin9@GMAIL.COM\",\"firstName\":\"Alycia\",\"gender\":\"MALE\",\"language\":\"en-US\",\"lastName\":\"McLaughlin\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14625\",\"premiseNumber\":\"400\",\"programUserId\":\"Elliot.Sawayn\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-2d926d31-a609-40e1-b28a-a32e0aeb6a79\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"user-80df50a2-3cc8-462d-87c8-cf3e266994c8\",\"addressLine1\":\"400 Linden Oaks\",\"addressLine2\":\"Rochester, NY 14625-2818\",\"city\":\"Rochester\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-08T16:13:53Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Meta50@GMAIL.COM\",\"firstName\":\"Trisha\",\"gender\":\"MALE\",\"governmentId\":\"000000000\",\"language\":\"en-US\",\"lastName\":\"Leffler\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14625\",\"premiseNumber\":\"400\",\"programUserId\":\"Nona49\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-80df50a2-3cc8-462d-87c8-cf3e266994c8\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"user-b26db8d1-ebb1-4367-aad4-3ffb6f0f17cf\",\"addressLine1\":\"400 Linden Oaks\",\"addressLine2\":\"Rochester, NY 14625-2818\",\"city\":\"Rochester\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-08T16:21:54Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Frankie_Stoltenberg@GMAIL.COM\",\"firstName\":\"Kevon\",\"gender\":\"MALE\",\"governmentId\":\"000000000\",\"language\":\"en-US\",\"lastName\":\"Waelchi\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14625\",\"premiseNumber\":\"400\",\"programUserId\":\"Lydia_Jacobi13\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-b26db8d1-ebb1-4367-aad4-3ffb6f0f17cf\",\"params\":{\"rel\":\"self\"}}]},{\"token\":\"user-61b12c1f-7cff-42e3-9c56-09ba2b08d2ed\",\"addressLine1\":\"4179 BUFFALO ROAD\",\"businessAddressLine1\":\"400 Linden Oaks\",\"businessAddressType\":\"BUSINESS\",\"businessCity\":\"Rochester\",\"businessCountry\":\"US\",\"businessName\":\"Api V2 Company LLC\",\"businessOperatingName\":\"Api V2 Company LLC\",\"businessPostalCode\":\"14625\",\"businessRegion\":\"NY\",\"businessRegistrationCountry\":\"US\",\"businessRegistrationRegion\":\"NY\",\"city\":\"NORTH CHILI\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2021-06-08T16:36:05Z\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Helena.Skiles24@GMAIL.COM\",\"firstName\":\"Westley\",\"gender\":\"MALE\",\"governmentId\":\"000000000\",\"language\":\"en-US\",\"lastName\":\"Westley\",\"mobileNumber\":\"+1 585-987-6543\",\"mobileNumberCountry\":\"US\",\"phoneNumber\":\"+1 585-987-6543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14514\",\"premiseNumber\":\"400\",\"programUserId\":\"Nicholas94\",\"region\":\"NY\",\"status\":\"ACTIVE\",\"userType\":\"BUSINESS\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-61b12c1f-7cff-42e3-9c56-09ba2b08d2ed\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"5\",\"pageCount\":\"124\",\"recordCount\":\"618\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users?pageSize=5&page=1\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a new [user](page:resources/user).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateUser()
        {
            // Parameters for the API call
            API.Models.CreateOrUpdateUser body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateUser>("{\"CURRENCY\":\"USD\",\"PROGRAMUSERID\":\"Jarrell_Sauer\",\"EMAIL\":\"PQTESTEMAIL+Viviane.Legros20@GMAIL.COM\",\"FIRSTNAME\":\"Amari\",\"LASTNAME\":\"Rippin\",\"DATEOFBIRTH\":\"1991-04-13\",\"BUSINESSCONTACTROLE\":\"SW ENGINEER\",\"GOVERNMENTIDTYPE\":\"SSN\",\"GOVERNMENTID\":\"000000000\",\"OCCUPATIONTITLE\":\"TESTER\",\"OCCUPATIONTYPE\":\"GOVERNMENT\",\"TAXRESIDENTSTATUS\":\"PREFER_NOT_TO_ANSWER\",\"PHONENUMBER\":\"+15859876543\",\"MOBILENUMBER\":\"+15859876543\",\"PHONENUMBERCOUNTRY\":\"US\",\"MOBILENUMBERCOUNTRY\":\"US\",\"ADDRESSLINE1\":\"400 Linden Oaks\",\"ADDRESSLINE2\":\"\",\"MAILINGADDRESSLINE1\":\"123 Emory Lane\",\"MAILINGCOUNTRY\":\"US\",\"MAILINGCITY\":\"Rochester\",\"MAILINGREGION\":\"NY\",\"MAILINGPOSTALCODE\":14625,\"BUSINESSADDRESSLINE1\":\"99 Office Park\",\"BUSINESSADDRESSLINE2\":\"Suite 293\",\"BUSINESSCOUNTRY\":\"US\",\"BUSINESSCITY\":\"Modesto\",\"BUSINESSREGION\":\"CA\",\"BUSINESSPOSTALCODE\":99785,\"CITY\":\"Rochester\",\"REGION\":\"NY\",\"COUNTRY\":\"US\",\"POSTALCODE\":\"14625\",\"PREMISENUMBER\":\"\",\"ADDRESSTYPE\":\"RESIDENTIAL\",\"EMPLOYERID\":\"1\",\"GENDER\":\"MALE\",\"USERTYPE\":\"INDIVIDUAL\",\"LANGUAGE\":\"EN-US\",\"COUNTRYOFBIRTH\":\"US\",\"COUNTRYOFNATIONALITY\":\"US\",\"PROGRAMTOKEN\":\"prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb\",\"PrimaryUserToken\":\"user-35372005-a9a3-41ae-ba46-a39cf944726d\"}");

            // Perform API call
            API.Models.UserResult result = null;
            try
            {
                result = await this.controller.CreateUserAsync(body);
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
                    "{\"token\":\"user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"addressLine1\":\"4179 BUFFALO ROAD\",\"businessAddressLine1\":\"99 Office Park\",\"businessAddressLine2\":\"Suite 293\",\"businessAddressType\":\"BUSINESS\",\"businessCity\":\"Modesto\",\"businessContactRole\":\"OTHER\",\"businessCountry\":\"US\",\"businessName\":\"Api V2 Company LLC\",\"businessPostalCode\":\"99700\",\"businessRegion\":\"CA\",\"city\":\"NORTH CHILI\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2022-04-08T19:44:16Z\",\"currency\":\"USD\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Emanuel_Carroll@GMAIL.COM\",\"employerId\":\"1\",\"firstName\":\"Timothy\",\"gender\":\"MALE\",\"governmentId\":\"111111111\",\"governmentIdType\":\"SSN\",\"language\":\"en-US\",\"lastName\":\"Mueller\",\"mailingAddressLine1\":\"128 Maple Lane\",\"mailingCity\":\"Rochester\",\"mailingCountry\":\"US\",\"mailingPostalCode\":\"14625\",\"mailingRegion\":\"NY\",\"mobileNumber\":\"+15859876543\",\"mobileNumberCountry\":\"US\",\"occupationTitle\":\"TESTER\",\"occupationType\":\"GOVERNMENT\",\"phoneNumber\":\"+15859876543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14514\",\"programUserId\":\"Kaylee.Howe8\",\"region\":\"NY\",\"taxResidentStatus\":\"YES\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a new [user](page:resources/user).
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateUser1()
        {
            // Parameters for the API call
            API.Models.CreateOrUpdateUser body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateUser>("{\"CURRENCY\":\"USD\",\"PROGRAMUSERID\":\"Jarrell_Sauer\",\"EMAIL\":\"PQTESTEMAIL+Viviane.Legros20@GMAIL.COM\",\"FIRSTNAME\":\"Amari\",\"LASTNAME\":\"Rippin\",\"DATEOFBIRTH\":\"1991-04-13\",\"BUSINESSCONTACTROLE\":\"SW ENGINEER\",\"GOVERNMENTIDTYPE\":\"SSN\",\"GOVERNMENTID\":\"000000000\",\"OCCUPATIONTITLE\":\"TESTER\",\"OCCUPATIONTYPE\":\"GOVERNMENT\",\"TAXRESIDENTSTATUS\":\"PREFER_NOT_TO_ANSWER\",\"PHONENUMBER\":\"+15859876543\",\"MOBILENUMBER\":\"+15859876543\",\"PHONENUMBERCOUNTRY\":\"US\",\"MOBILENUMBERCOUNTRY\":\"US\",\"ADDRESSLINE1\":\"400 Linden Oaks\",\"ADDRESSLINE2\":\"\",\"MAILINGADDRESSLINE1\":\"123 Emory Lane\",\"MAILINGCOUNTRY\":\"US\",\"MAILINGCITY\":\"Rochester\",\"MAILINGREGION\":\"NY\",\"MAILINGPOSTALCODE\":14625,\"BUSINESSADDRESSLINE1\":\"99 Office Park\",\"BUSINESSADDRESSLINE2\":\"Suite 293\",\"BUSINESSCOUNTRY\":\"US\",\"BUSINESSCITY\":\"Modesto\",\"BUSINESSREGION\":\"CA\",\"BUSINESSPOSTALCODE\":99785,\"CITY\":\"Rochester\",\"REGION\":\"NY\",\"COUNTRY\":\"US\",\"POSTALCODE\":\"14625\",\"PREMISENUMBER\":\"\",\"ADDRESSTYPE\":\"RESIDENTIAL\",\"EMPLOYERID\":\"1\",\"GENDER\":\"MALE\",\"USERTYPE\":\"INDIVIDUAL\",\"LANGUAGE\":\"EN-US\",\"COUNTRYOFBIRTH\":\"US\",\"COUNTRYOFNATIONALITY\":\"US\",\"PROGRAMTOKEN\":\"prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb\",\"PrimaryUserToken\":\"user-35372005-a9a3-41ae-ba46-a39cf944726d\"}");

            // Perform API call
            API.Models.UserResult result = null;
            try
            {
                result = await this.controller.CreateUserAsync(body);
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
                    "{\"token\":\"user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"addressLine1\":\"4179 BUFFALO ROAD\",\"businessAddressLine1\":\"99 Office Park\",\"businessAddressLine2\":\"Suite 293\",\"businessAddressType\":\"BUSINESS\",\"businessCity\":\"Modesto\",\"businessContactRole\":\"OTHER\",\"businessCountry\":\"US\",\"businessName\":\"Api V2 Company LLC\",\"businessPostalCode\":\"99700\",\"businessRegion\":\"CA\",\"city\":\"NORTH CHILI\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2022-04-08T19:44:16Z\",\"currency\":\"USD\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Emanuel_Carroll@GMAIL.COM\",\"employerId\":\"1\",\"firstName\":\"Timothy\",\"gender\":\"MALE\",\"governmentId\":\"111111111\",\"governmentIdType\":\"SSN\",\"language\":\"en-US\",\"lastName\":\"Mueller\",\"mailingAddressLine1\":\"128 Maple Lane\",\"mailingCity\":\"Rochester\",\"mailingCountry\":\"US\",\"mailingPostalCode\":\"14625\",\"mailingRegion\":\"NY\",\"mobileNumber\":\"+15859876543\",\"mobileNumberCountry\":\"US\",\"occupationTitle\":\"TESTER\",\"occupationType\":\"GOVERNMENT\",\"phoneNumber\":\"+15859876543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14514\",\"programUserId\":\"Kaylee.Howe8\",\"region\":\"NY\",\"taxResidentStatus\":\"YES\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Update a [user](page:resources/user) object (change [email](#/rest/models/structures/email-address)], [address](#/rest/models/structures/address) change, etc.) using a user token.'
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateUser()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            API.Models.CreateOrUpdateUser body = ApiHelper.JsonDeserialize<API.Models.CreateOrUpdateUser>("{\"CURRENCY\":\"USD\",\"PROGRAMUSERID\":\"Jarrell_Sauer\",\"EMAIL\":\"PQTESTEMAIL+Viviane.Legros20@GMAIL.COM\",\"FIRSTNAME\":\"Amari\",\"LASTNAME\":\"Rippin\",\"DATEOFBIRTH\":\"1991-04-13\",\"BUSINESSCONTACTROLE\":\"SW ENGINEER\",\"GOVERNMENTIDTYPE\":\"SSN\",\"GOVERNMENTID\":\"000000000\",\"OCCUPATIONTITLE\":\"TESTER\",\"OCCUPATIONTYPE\":\"GOVERNMENT\",\"TAXRESIDENTSTATUS\":\"PREFER_NOT_TO_ANSWER\",\"PHONENUMBER\":\"+15859876543\",\"MOBILENUMBER\":\"+15859876543\",\"PHONENUMBERCOUNTRY\":\"US\",\"MOBILENUMBERCOUNTRY\":\"US\",\"ADDRESSLINE1\":\"400 Linden Oaks\",\"ADDRESSLINE2\":\"\",\"MAILINGADDRESSLINE1\":\"123 Emory Lane\",\"MAILINGCOUNTRY\":\"US\",\"MAILINGCITY\":\"Rochester\",\"MAILINGREGION\":\"NY\",\"MAILINGPOSTALCODE\":14625,\"BUSINESSADDRESSLINE1\":\"99 Office Park\",\"BUSINESSADDRESSLINE2\":\"Suite 293\",\"BUSINESSCOUNTRY\":\"US\",\"BUSINESSCITY\":\"Modesto\",\"BUSINESSREGION\":\"CA\",\"BUSINESSPOSTALCODE\":99785,\"CITY\":\"Rochester\",\"REGION\":\"NY\",\"COUNTRY\":\"US\",\"POSTALCODE\":\"14625\",\"PREMISENUMBER\":\"\",\"ADDRESSTYPE\":\"RESIDENTIAL\",\"EMPLOYERID\":\"1\",\"GENDER\":\"MALE\",\"USERTYPE\":\"INDIVIDUAL\",\"LANGUAGE\":\"EN-US\",\"COUNTRYOFBIRTH\":\"US\",\"COUNTRYOFNATIONALITY\":\"US\",\"PROGRAMTOKEN\":\"prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb\",\"PrimaryUserToken\":\"user-35372005-a9a3-41ae-ba46-a39cf944726d\"}");

            // Perform API call
            API.Models.UserResult result = null;
            try
            {
                result = await this.controller.UpdateUserAsync(userToken, body);
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
                    "{\"token\":\"user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"addressLine1\":\"4179 BUFFALO ROAD\",\"businessAddressLine1\":\"99 Office Park\",\"businessAddressLine2\":\"Suite 293\",\"businessAddressType\":\"BUSINESS\",\"businessCity\":\"Modesto\",\"businessContactRole\":\"OTHER\",\"businessCountry\":\"US\",\"businessName\":\"Api V2 Company LLC\",\"businessPostalCode\":\"99700\",\"businessRegion\":\"CA\",\"city\":\"NORTH CHILI\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2022-04-08T19:44:16Z\",\"currency\":\"USD\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Emanuel_Carroll@GMAIL.COM\",\"employerId\":\"1\",\"firstName\":\"Timothy\",\"gender\":\"MALE\",\"governmentId\":\"111111111\",\"governmentIdType\":\"SSN\",\"language\":\"en-US\",\"lastName\":\"Mueller\",\"mailingAddressLine1\":\"128 Maple Lane\",\"mailingCity\":\"Rochester\",\"mailingCountry\":\"US\",\"mailingPostalCode\":\"14625\",\"mailingRegion\":\"NY\",\"mobileNumber\":\"+15859876543\",\"mobileNumberCountry\":\"US\",\"occupationTitle\":\"TESTER\",\"occupationType\":\"GOVERNMENT\",\"phoneNumber\":\"+15859876543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14514\",\"programUserId\":\"Kaylee.Howe8\",\"region\":\"NY\",\"taxResidentStatus\":\"YES\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [user](page:resources/user) record by user token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveUser()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.UserResult result = null;
            try
            {
                result = await this.controller.RetrieveUserAsync(userToken);
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
                    "{\"token\":\"user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"addressLine1\":\"4179 BUFFALO ROAD\",\"businessAddressLine1\":\"99 Office Park\",\"businessAddressLine2\":\"Suite 293\",\"businessAddressType\":\"BUSINESS\",\"businessCity\":\"Modesto\",\"businessContactRole\":\"OTHER\",\"businessCountry\":\"US\",\"businessName\":\"Api V2 Company LLC\",\"businessPostalCode\":\"99700\",\"businessRegion\":\"CA\",\"city\":\"NORTH CHILI\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2022-04-08T19:44:16Z\",\"currency\":\"USD\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Emanuel_Carroll@GMAIL.COM\",\"employerId\":\"1\",\"firstName\":\"Timothy\",\"gender\":\"MALE\",\"governmentId\":\"111111111\",\"governmentIdType\":\"SSN\",\"language\":\"en-US\",\"lastName\":\"Mueller\",\"mailingAddressLine1\":\"128 Maple Lane\",\"mailingCity\":\"Rochester\",\"mailingCountry\":\"US\",\"mailingPostalCode\":\"14625\",\"mailingRegion\":\"NY\",\"mobileNumber\":\"+15859876543\",\"mobileNumberCountry\":\"US\",\"occupationTitle\":\"TESTER\",\"occupationType\":\"GOVERNMENT\",\"phoneNumber\":\"+15859876543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14514\",\"programUserId\":\"Kaylee.Howe8\",\"region\":\"NY\",\"taxResidentStatus\":\"YES\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a single [user](page:resources/user) record by user token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveUser1()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";

            // Perform API call
            API.Models.UserResult result = null;
            try
            {
                result = await this.controller.RetrieveUserAsync(userToken);
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
                    "{\"token\":\"user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"addressLine1\":\"4179 BUFFALO ROAD\",\"businessAddressLine1\":\"99 Office Park\",\"businessAddressLine2\":\"Suite 293\",\"businessAddressType\":\"BUSINESS\",\"businessCity\":\"Modesto\",\"businessContactRole\":\"OTHER\",\"businessCountry\":\"US\",\"businessName\":\"Api V2 Company LLC\",\"businessPostalCode\":\"99700\",\"businessRegion\":\"CA\",\"city\":\"NORTH CHILI\",\"country\":\"US\",\"countryOfBirth\":\"US\",\"countryOfNationality\":\"US\",\"createdOn\":\"2022-04-08T19:44:16Z\",\"currency\":\"USD\",\"dateOfBirth\":\"1991-04-13T00:00:00Z\",\"email\":\"PQTESTEMAIL+Emanuel_Carroll@GMAIL.COM\",\"employerId\":\"1\",\"firstName\":\"Timothy\",\"gender\":\"MALE\",\"governmentId\":\"111111111\",\"governmentIdType\":\"SSN\",\"language\":\"en-US\",\"lastName\":\"Mueller\",\"mailingAddressLine1\":\"128 Maple Lane\",\"mailingCity\":\"Rochester\",\"mailingCountry\":\"US\",\"mailingPostalCode\":\"14625\",\"mailingRegion\":\"NY\",\"mobileNumber\":\"+15859876543\",\"mobileNumberCountry\":\"US\",\"occupationTitle\":\"TESTER\",\"occupationType\":\"GOVERNMENT\",\"phoneNumber\":\"+15859876543\",\"phoneNumberCountry\":\"US\",\"postalCode\":\"14514\",\"programUserId\":\"Kaylee.Howe8\",\"region\":\"NY\",\"taxResidentStatus\":\"YES\",\"userType\":\"INDIVIDUAL\",\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-91acd009-36d5-40d9-b8b1-39a3704b577e\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}