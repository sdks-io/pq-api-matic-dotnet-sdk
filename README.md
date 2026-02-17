
# Getting Started with PQ API v2

## Introduction

PayQuicker offers a secure and instant payout platform that delivers payment to a payee-owned and insured bank account linked to a debit card, similar to a standard checking account.

As soon as the payment is made, funds are available in the insured account and available to spend instantly online through a virtual card, at retail with a plastic prepaid debit card, or by loading the card to a mobile wallet.

PayQuicker provides a RESTful API that allows authorized clients to send and receive payments, debit user's accounts for spendback, retrieve user account balance, retrieve user reports, and retrieve transaction reports.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package PqApimaticSDK --version 1.0.0
```

You can also view the package at:
https://www.nuget.org/packages/PqApimaticSDK/1.0.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| XMyPayQuickerVersion | `string` | Date-based API Version specified in the header *required* on all calls.<br>*Default*: `"2026.02.01"` |
| SandboxInstance | `Models.SandboxInstance` | Sandbox Environments<br>*Default*: `SandboxInstance.sandbox` |
| UatInstance | `Models.UatInstance` | UAT Environments<br>*Default*: `UatInstance.uat1` |
| Environment | [`Environment`](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/README.md#environments) | The API environment. <br> **Default: `Environment.Sandbox`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ServerCredentials | [`ServerCredentials`](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| ClientsideCredentials | [`ClientsideCredentials`](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using Microsoft.Extensions.Logging;
using PayQuicker.API;
using PayQuicker.API.Authentication;
using PayQuicker.API.Models;
using System.Collections.Generic;

namespace ConsoleApp;

PayQuickerSDKClient client = new PayQuickerSDKClient.Builder()
    .ServerCredentials(
        new ServerModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .OAuthScopes(
            new List<OAuthScopeServer>
            {
                OAuthScopeServer.Readonly,
                OAuthScopeServer.Modify,
            })
        .Build())
    .ClientsideCredentials(
        new ClientsideModel.Builder(
            "AccessToken"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .XMyPayQuickerVersion("2026.02.01")
    .Environment(PayQuicker.API.Environment.Sandbox)
    .SandboxInstance(SandboxInstance.Sandbox)
    .UatInstance(UatInstance.Uat1)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

### Configuration-Based Initialization

```csharp
using PayQuicker.API;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = PayQuickerSDKClient
    .FromConfiguration(configuration.GetSection("PayQuickerSDK"));
```

See the [Configuration-Based Initialization](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | Production |
| Sandbox | **Default** Sandbox is used for both sandbox testing and customer UAT. |
| Uat | UAT is used for both sandbox testing and customer UAT. |
| Development | Development is used for local development testing. |

## Authorization

This API uses the following authentication schemes.

* [`server (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/auth/oauth-2-client-credentials-grant.md)
* [`clientside (OAuth 2 Bearer token)`](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/auth/oauth-2-bearer-token.md)

## List of APIs

* [Agreements](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/agreements.md)
* [Balances](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/balances.md)
* [Bank Accounts](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/bank-accounts.md)
* [Client Side](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/client-side.md)
* [Compliance](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/compliance.md)
* [Documents](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/documents.md)
* [Electronic Wallets](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/electronic-wallets.md)
* [Events](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/events.md)
* [Invitations](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/invitations.md)
* [Jobs](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/jobs.md)
* [Payments](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/payments.md)
* [Prepaid Cards](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/prepaid-cards.md)
* [Program](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/program.md)
* [Receipts](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/receipts.md)
* [Spendback](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/spendback.md)
* [Spendback Refunds](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/spendback-refunds.md)
* [Statements](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/statements.md)
* [Transfers](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/transfers.md)
* [Users](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/users.md)
* [Webhooks](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/controllers/webhooks.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md)
* [LogBuilder](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/log-response-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/http-callback.md)
* [HttpContext](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/http-context.md)
* [HttpRequest](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/api-exception.md)
* [ApiHelper](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/unix-date-time-converter.md)
* [JsonObject](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/json-object.md)
* [JsonValue](https://www.github.com/sdks-io/pq-api-matic-dotnet-sdk/tree/1.0.0/doc/json-value.md)

