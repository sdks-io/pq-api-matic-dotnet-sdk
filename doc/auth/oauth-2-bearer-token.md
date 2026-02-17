
# OAuth 2 Bearer token



Documentation for accessing and setting credentials for clientside.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| AccessToken | `string` | The OAuth 2.0 Access Token to use for API requests. | `AccessToken` | `AccessToken` |



**Note:** Auth credentials can be set using `ClientsideCredentials` in the client builder and accessed through `ClientsideCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
using PayQuicker.API;
using PayQuicker.API.Authentication;

namespace ConsoleApp;

PayQuickerSDKClient client = new PayQuickerSDKClient.Builder()
    .ClientsideCredentials(
        new ClientsideModel.Builder(
            "AccessToken"
        )
        .Build())
    .Build();
```


