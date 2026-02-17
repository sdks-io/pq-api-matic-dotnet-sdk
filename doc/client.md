
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| XMyPayQuickerVersion | `string` | Date-based API Version specified in the header *required* on all calls.<br>*Default*: `"2026.02.01"` |
| SandboxInstance | `Models.SandboxInstance` | Sandbox Environments<br>*Default*: `SandboxInstance.sandbox` |
| UatInstance | `Models.UatInstance` | UAT Environments<br>*Default*: `UatInstance.uat1` |
| Environment | [`Environment`](../README.md#environments) | The API environment. <br> **Default: `Environment.Sandbox`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](../doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ServerCredentials | [`ServerCredentials`](auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |
| ClientsideCredentials | [`ClientsideCredentials`](auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

The API client can be initialized as follows:

## Code-Based Initialization

```csharp
using Microsoft.Extensions.Logging;
using PayQuickerSDK.Standard;
using PayQuickerSDK.Standard.Authentication;
using PayQuickerSDK.Standard.Models;
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
    .Environment(PayQuickerSDK.Standard.Environment.Sandbox)
    .SandboxInstance(SandboxInstance.Sandbox)
    .UatInstance(UatInstance.Uat1)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

## Configuration-Based Initialization

```csharp
using PayQuickerSDK.Standard;
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

See the [Configuration-Based Initialization](../doc/configuration-based-initialization.md) section for details.

## PQ API v2Client Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| AgreementsController | Gets AgreementsController controller. |
| BalancesController | Gets BalancesController controller. |
| BankAccountsController | Gets BankAccountsController controller. |
| ClientSideController | Gets ClientSideController controller. |
| ComplianceController | Gets ComplianceController controller. |
| DocumentsController | Gets DocumentsController controller. |
| ElectronicWalletsController | Gets ElectronicWalletsController controller. |
| EventsController | Gets EventsController controller. |
| PaymentsController | Gets PaymentsController controller. |
| PrepaidCardsController | Gets PrepaidCardsController controller. |
| ProgramController | Gets ProgramController controller. |
| ReceiptsController | Gets ReceiptsController controller. |
| SpendbackController | Gets SpendbackController controller. |
| SpendbackRefundsController | Gets SpendbackRefundsController controller. |
| StatementsController | Gets StatementsController controller. |
| TransfersController | Gets TransfersController controller. |
| UsersController | Gets UsersController controller. |
| WebhooksController | Gets WebhooksController controller. |
| JobsController | Gets JobsController controller. |
| InvitationsController | Gets InvitationsController controller. |
| OAuthAuthorizationController | Gets OAuthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| XMyPayQuickerVersion | Date-based API Version specified in the header *required* on all calls. | `string` |
| Environment | Current API environment. | `Environment` |
| SandboxInstance | Sandbox Environments | `Models.SandboxInstance` |
| UatInstance | UAT Environments | `Models.UatInstance` |
| ServerCredentials | Gets the credentials to use with Server. | [`IServerCredentials`](auth/oauth-2-client-credentials-grant.md) |
| ClientsideCredentials | Gets the credentials to use with Clientside. | [`IClientsideCredentials`](auth/oauth-2-bearer-token.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Api)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the PQ API v2Client using the values provided for the builder. | `Builder` |

## PQ API v2Client Builder Class

Class to build instances of PQ API v2Client.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `XMyPayQuickerVersion(string xMyPayQuickerVersion)` | Date-based API Version specified in the header *required* on all calls. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `SandboxInstance(Models.SandboxInstance sandboxInstance)` | Sandbox Environments | `Builder` |
| `UatInstance(Models.UatInstance uatInstance)` | UAT Environments | `Builder` |
| `ServerCredentials(Action<ServerModel.Builder> action)` | Sets credentials for Server. | `Builder` |
| `ClientsideCredentials(Action<ClientsideModel.Builder> action)` | Sets credentials for Clientside. | `Builder` |

