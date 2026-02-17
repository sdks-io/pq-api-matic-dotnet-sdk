// <copyright file="TransfersControllerTest.cs" company="APIMatic">
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
    /// TransfersControllerTest.
    /// </summary>
    [TestFixture]
    public class TransfersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ITransfersController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.TransfersController;
        }

        /// <summary>
        /// Retrieve a list of [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListTransfers()
        {
            // Parameters for the API call
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.TransferListResult result = null;
            try
            {
                result = await this.controller.ListTransfersAsync(page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"xfer-337b4c59-821d-4bac-a1dd-c9d7c15e41e8\",\"clientTransferId\":\"1066ab05-84d0-453f-a827-1bd3b2ad9e3d\",\"created\":\"2025-06-23T19:17:22Z\",\"destinationAmount\":-14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-244609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":-12.5,\"transactionAmount\":-14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":-14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":-14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"($14.00) USD\",\"destinationFormattedAmount\":\"($14.00) USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-337b4c59-821d-4bac-a1dd-c9d7c15e41e8\",\"destinationFormattedAmount\":\"($14.00) USD\",\"amount\":-14,\"formattedAmount\":\"($14.00) USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-65ec33d0-4518-41bb-8822-ed58c69e678e/transfers/xfer-337b4c59-821d-4bac-a1dd-c9d7c15e41e8\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"2\",\"pageCount\":\"1\",\"recordCount\":\"1\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-65ec33d0-4518-41bb-8822-ed58c69e678e/transfers?page=1&language=en-US&filter=%27transfertype%27=%27BANK_TRANSFER%27&pageSize=2\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a new [transfer](page:resources/transfers) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateTransferQuote()
        {
            // Parameters for the API call
            TransferQuote body = null;

            // Perform API call
            API.Models.TransferResult result = null;
            try
            {
                result = await this.controller.CreateTransferQuoteAsync(body);
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
                    "{\"token\":\"xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2\",\"clientTransferId\":\"af1d26c4-07d8-4bba-bdf6-104fda46e896\",\"created\":\"2025-06-24T12:40:53Z\",\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-224609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":15.5,\"transactionAmount\":14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"$14.00 USD\",\"destinationFormattedAmount\":\"$14.00 USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-2822-ed58c69e678e\",\"status\":\"PENDING_ACCEPTANCE\",\"destinationFormattedAmount\":\"$14.00 USD\",\"amount\":14,\"formattedAmount\":\"$14.00 USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create a new [transfer](page:resources/transfers) quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateTransferQuote1()
        {
            // Parameters for the API call
            TransferQuote body = null;

            // Perform API call
            API.Models.TransferResult result = null;
            try
            {
                result = await this.controller.CreateTransferQuoteAsync(body);
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
                    "{\"token\":\"xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2\",\"clientTransferId\":\"af1d26c4-07d8-4bba-bdf6-104fda46e896\",\"created\":\"2025-06-24T12:40:53Z\",\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-224609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":15.5,\"transactionAmount\":14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"$14.00 USD\",\"destinationFormattedAmount\":\"$14.00 USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-2822-ed58c69e678e\",\"status\":\"PENDING_ACCEPTANCE\",\"destinationFormattedAmount\":\"$14.00 USD\",\"amount\":14,\"formattedAmount\":\"$14.00 USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve details of a specific [transfer](page:resources/transfers) represented by a transfer token.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveTransfer()
        {
            // Parameters for the API call
            string transferToken = "xfer-0fac4aa8-43ac-447e-95f9-827f908a82ff";

            // Perform API call
            API.Models.TransferResult result = null;
            try
            {
                result = await this.controller.RetrieveTransferAsync(transferToken);
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
                    "{\"token\":\"xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2\",\"clientTransferId\":\"af1d26c4-07d8-4bba-bdf6-104fda46e896\",\"created\":\"2025-06-24T12:40:53Z\",\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-224609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":15.5,\"transactionAmount\":14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"$14.00 USD\",\"destinationFormattedAmount\":\"$14.00 USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-2822-ed58c69e678e\",\"status\":\"PENDING_ACCEPTANCE\",\"destinationFormattedAmount\":\"$14.00 USD\",\"amount\":14,\"formattedAmount\":\"$14.00 USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Accept a [transfer](page:resources/transfers) quote..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAcceptTransferQuote()
        {
            // Parameters for the API call
            string transferToken = "xfer-0fac4aa8-43ac-447e-95f9-827f908a82ff";

            // Perform API call
            API.Models.TransferResult result = null;
            try
            {
                result = await this.controller.AcceptTransferQuoteAsync(transferToken);
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
                    "{\"token\":\"xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2\",\"clientTransferId\":\"af1d26c4-07d8-4bba-bdf6-104fda46e896\",\"created\":\"2025-06-24T12:40:53Z\",\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-224609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":15.5,\"transactionAmount\":14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"$14.00 USD\",\"destinationFormattedAmount\":\"$14.00 USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-2822-ed58c69e678e\",\"status\":\"PENDING_ACCEPTANCE\",\"destinationFormattedAmount\":\"$14.00 USD\",\"amount\":14,\"formattedAmount\":\"$14.00 USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Accept a [transfer](page:resources/transfers) quote..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAcceptTransferQuote1()
        {
            // Parameters for the API call
            string transferToken = "xfer-0fac4aa8-43ac-447e-95f9-827f908a82ff";

            // Perform API call
            API.Models.TransferResult result = null;
            try
            {
                result = await this.controller.AcceptTransferQuoteAsync(transferToken);
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
                    "{\"token\":\"xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2\",\"clientTransferId\":\"af1d26c4-07d8-4bba-bdf6-104fda46e896\",\"created\":\"2025-06-24T12:40:53Z\",\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-224609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":15.5,\"transactionAmount\":14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"$14.00 USD\",\"destinationFormattedAmount\":\"$14.00 USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-2822-ed58c69e678e\",\"status\":\"PENDING_ACCEPTANCE\",\"destinationFormattedAmount\":\"$14.00 USD\",\"amount\":14,\"formattedAmount\":\"$14.00 USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Optional [transfer](page:resources/transfers) quote cancellation that auto-cancels after a period organically expires or when account activity invalidates the quote.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCancelTransferQuote()
        {
            // Parameters for the API call
            string transferToken = "xfer-0fac4aa8-43ac-447e-95f9-827f908a82ff";

            // Perform API call
            API.Models.TransferResult result = null;
            try
            {
                result = await this.controller.CancelTransferQuoteAsync(transferToken);
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
                    "{\"token\":\"xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2\",\"clientTransferId\":\"af1d26c4-07d8-4bba-bdf6-104fda46e896\",\"created\":\"2025-06-24T12:40:53Z\",\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-224609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":15.5,\"transactionAmount\":14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"$14.00 USD\",\"destinationFormattedAmount\":\"$14.00 USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-2822-ed58c69e678e\",\"status\":\"PENDING_ACCEPTANCE\",\"destinationFormattedAmount\":\"$14.00 USD\",\"amount\":14,\"formattedAmount\":\"$14.00 USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a list of user [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListUserTransfers()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            int page = 1;
            int pageSize = 20;
            string filter = "string";
            string sort = "string";
            API.Models.Languages language = ApiHelper.JsonDeserialize<API.Models.Languages>("\"en-US\"");

            // Perform API call
            API.Models.TransferListResult result = null;
            try
            {
                result = await this.controller.ListUserTransfersAsync(userToken, page, pageSize, filter, sort, language);
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
                    "{\"payload\":[{\"token\":\"xfer-337b4c59-821d-4bac-a1dd-c9d7c15e41e8\",\"clientTransferId\":\"1066ab05-84d0-453f-a827-1bd3b2ad9e3d\",\"created\":\"2025-06-23T19:17:22Z\",\"destinationAmount\":-14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-244609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":-12.5,\"transactionAmount\":-14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":-14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":-14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"($14.00) USD\",\"destinationFormattedAmount\":\"($14.00) USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\",\"status\":\"ACCEPTED\",\"receiptToken\":\"rcpt-337b4c59-821d-4bac-a1dd-c9d7c15e41e8\",\"destinationFormattedAmount\":\"($14.00) USD\",\"amount\":-14,\"formattedAmount\":\"($14.00) USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-65ec33d0-4518-41bb-8822-ed58c69e678e/transfers/xfer-337b4c59-821d-4bac-a1dd-c9d7c15e41e8\",\"params\":{\"rel\":\"self\"}}]}],\"meta\":{\"pageNo\":\"1\",\"pageSize\":\"2\",\"pageCount\":\"1\",\"recordCount\":\"1\",\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/users/user-65ec33d0-4518-41bb-8822-ed58c69e678e/transfers?page=1&language=en-US&filter=%27transfertype%27=%27BANK_TRANSFER%27&pageSize=2\",\"params\":{\"rel\":\"self\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieve a specific user bank [transfer](page:resources/transfers)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRetrieveUserTransfer()
        {
            // Parameters for the API call
            string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
            string transferToken = "xfer-bf34989d-0b13-47ee-bd51-b96b0ecbe866";

            // Perform API call
            API.Models.TransferResult result = null;
            try
            {
                result = await this.controller.RetrieveUserTransferAsync(userToken, transferToken);
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
                    "{\"token\":\"xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2\",\"clientTransferId\":\"af1d26c4-07d8-4bba-bdf6-104fda46e896\",\"created\":\"2025-06-24T12:40:53Z\",\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"destinationToken\":\"dest-80611686-e311-4acd-aeeb-224609a3b12b\",\"fee\":{\"category\":\"USER\",\"destinationCountry\":\"USA\",\"destinationCurrency\":\"USD\",\"distribution\":[{\"amount\":1.5,\"currency\":\"USD\",\"description\":[{\"language\":\"en-US\",\"translation\":\"Transfer to a Bank Fee\"},{\"language\":\"en-US\",\"translation\":\"Poplatek za převod do banky\"},{\"language\":\"de-DE\",\"translation\":\"Transfer zu einer Bankgebühr\"},{\"language\":\"es-ES\",\"translation\":\"Coste de la transferencia a un banco\"},{\"language\":\"en-US\",\"translation\":\"Pankkiin siirto -maksu\"},{\"language\":\"fr-FR\",\"translation\":\"Frais de virement vers une banque\"},{\"language\":\"it-IT\",\"translation\":\"Tariffa Trasferimento Bancario\"},{\"language\":\"ja-JP\",\"translation\":\"銀行への送金の手数料\"},{\"language\":\"ko-KR\",\"translation\":\"은행으로 송금 수수료\"},{\"language\":\"nl-NL\",\"translation\":\"Kosten bankoverschrijving\"},{\"language\":\"pl-PL\",\"translation\":\"Opłata za przelew do banku\"},{\"language\":\"pt-BR\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"ru-RU\",\"translation\":\"Комиссия за перевод на банковский счет\"},{\"language\":\"en-US\",\"translation\":\"Avgift för överföring till en bank\"},{\"language\":\"zh-Hans\",\"translation\":\"转账到银行手续费\"},{\"language\":\"zh-Hant\",\"translation\":\"轉帳至銀行手續費\"},{\"language\":\"fr-CA\",\"translation\":\"Frais de transfert bancaire\"},{\"language\":\"pt-PT\",\"translation\":\"Taxa de Transferência para um Banco\"},{\"language\":\"es-MX\",\"translation\":\"Transferencia a una Tarifa Bancaria\"},{\"language\":\"en-GB\",\"translation\":\"Transfer to a Bank Fee\"}],\"formattedAmount\":\"$1.50 USD\",\"percentage\":1,\"responsibility\":\"USER\",\"responsibilitySource\":\"SCHEDULE\",\"sourceToken\":\"user-65ec33d0-4518-41bb-8822-ed58c69e678e\"}],\"source\":\"TRANSACTION\",\"totalAmount\":15.5,\"transactionAmount\":14,\"type\":\"BANK_TRANSFER\",\"valueAmount\":1.5,\"valueType\":\"STATIC\"},\"fxRate\":{\"destinationAmount\":14,\"destinationCurrency\":\"USD\",\"rate\":1,\"sourceAmount\":14,\"sourceCurrency\":\"USD\",\"sourceFormattedAmount\":\"$14.00 USD\",\"destinationFormattedAmount\":\"$14.00 USD\"},\"memo\":\"Bank transfer - memo\",\"note\":\"Bank transfer - note\",\"sourceToken\":\"user-65ec33d0-4518-41bb-2822-ed58c69e678e\",\"status\":\"PENDING_ACCEPTANCE\",\"destinationFormattedAmount\":\"$14.00 USD\",\"amount\":14,\"formattedAmount\":\"$14.00 USD\",\"transferLockSide\":\"SOURCE\",\"transferMethodType\":\"IACH\",\"deliveryDetails\":{\"minimumDeliveryMinutes\":4320,\"maximumDeliveryMinutes\":10080},\"links\":[{\"href\":\"https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2\",\"params\":{\"rel\":\"self\"}}],\"meta\":{\"timezone\":\"GMT\",\"requestRef\":\"request-reference-value\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}