# Transfers

# Transfers

---


The *Transfers* resource describes a transfer quote from or to a user's account via a specified transfer method.

Depending on the program, the transfer of funds can be made to a prepaid card, bank account, or paper check belonging to the user. By default, transfers are queued for immediate processing; however, a future processing date can be specified in the request.

With this resource, you can perform the following requests:

* `POST`: Create a new transfer quote
* `GET`: Retrieve a transfer quote or list of transfer quotes
* `DELETE`: Delete a transfer quote

For more information, see [Transfers](page:resources/transfers).

```csharp
ITransfersController transfersController = client.TransfersController;
```

## Class Name

`TransfersController`

## Methods

* [Accept Transfer Quote](../../doc/controllers/transfers.md#accept-transfer-quote)
* [Cancel Transfer Quote](../../doc/controllers/transfers.md#cancel-transfer-quote)
* [Create Transfer Quote](../../doc/controllers/transfers.md#create-transfer-quote)
* [List Transfers](../../doc/controllers/transfers.md#list-transfers)
* [List User Transfers](../../doc/controllers/transfers.md#list-user-transfers)
* [Retrieve Transfer](../../doc/controllers/transfers.md#retrieve-transfer)
* [Retrieve User Transfer](../../doc/controllers/transfers.md#retrieve-user-transfer)


# Accept Transfer Quote

Accept a [transfer](page:resources/transfers) quote.

```csharp
AcceptTransferQuoteAsync(
    string transferToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transferToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`.<br><br>**Constraints**: *Pattern*: `^xfer-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.TransferResult>`](../../doc/models/transfer-result.md)

## Example Usage

```csharp
string transferToken = "xfer-0fac4aa8-43ac-447e-95f9-827f908a82ff";
try
{
    TransferResult result = await transfersController.AcceptTransferQuoteAsync(transferToken);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "token": "xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2",
  "clientTransferId": "af1d26c4-07d8-4bba-bdf6-104fda46e896",
  "created": "2025-06-24T12:40:53Z",
  "destinationAmount": 14,
  "destinationCurrency": "USD",
  "destinationToken": "dest-80611686-e311-4acd-aeeb-224609a3b12b",
  "fee": {
    "category": "USER",
    "destinationCountry": "USA",
    "destinationCurrency": "USD",
    "distribution": [
      {
        "amount": 1.5,
        "currency": "USD",
        "description": [
          {
            "language": "en-US",
            "translation": "Transfer to a Bank Fee"
          },
          {
            "language": "en-US",
            "translation": "Poplatek za převod do banky"
          },
          {
            "language": "de-DE",
            "translation": "Transfer zu einer Bankgebühr"
          },
          {
            "language": "es-ES",
            "translation": "Coste de la transferencia a un banco"
          },
          {
            "language": "en-US",
            "translation": "Pankkiin siirto -maksu"
          },
          {
            "language": "fr-FR",
            "translation": "Frais de virement vers une banque"
          },
          {
            "language": "it-IT",
            "translation": "Tariffa Trasferimento Bancario"
          },
          {
            "language": "ja-JP",
            "translation": "銀行への送金の手数料"
          },
          {
            "language": "ko-KR",
            "translation": "은행으로 송금 수수료"
          },
          {
            "language": "nl-NL",
            "translation": "Kosten bankoverschrijving"
          },
          {
            "language": "pl-PL",
            "translation": "Opłata za przelew do banku"
          },
          {
            "language": "pt-BR",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "ru-RU",
            "translation": "Комиссия за перевод на банковский счет"
          },
          {
            "language": "en-US",
            "translation": "Avgift för överföring till en bank"
          },
          {
            "language": "zh-Hans",
            "translation": "转账到银行手续费"
          },
          {
            "language": "zh-Hant",
            "translation": "轉帳至銀行手續費"
          },
          {
            "language": "fr-CA",
            "translation": "Frais de transfert bancaire"
          },
          {
            "language": "pt-PT",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "es-MX",
            "translation": "Transferencia a una Tarifa Bancaria"
          },
          {
            "language": "en-GB",
            "translation": "Transfer to a Bank Fee"
          }
        ],
        "formattedAmount": "$1.50 USD",
        "percentage": 1,
        "responsibility": "USER",
        "responsibilitySource": "SCHEDULE",
        "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e"
      }
    ],
    "source": "TRANSACTION",
    "totalAmount": 15.5,
    "transactionAmount": 14,
    "type": "BANK_TRANSFER",
    "valueAmount": 1.5,
    "valueType": "STATIC"
  },
  "fxRate": {
    "destinationAmount": 14,
    "destinationCurrency": "USD",
    "rate": 1,
    "sourceAmount": 14,
    "sourceCurrency": "USD",
    "sourceFormattedAmount": "$14.00 USD",
    "destinationFormattedAmount": "$14.00 USD"
  },
  "memo": "Bank transfer - memo",
  "note": "Bank transfer - note",
  "sourceToken": "user-65ec33d0-4518-41bb-2822-ed58c69e678e",
  "status": "PENDING_ACCEPTANCE",
  "destinationFormattedAmount": "$14.00 USD",
  "amount": 14,
  "formattedAmount": "$14.00 USD",
  "transferLockSide": "SOURCE",
  "transferMethodType": "IACH",
  "deliveryDetails": {
    "minimumDeliveryMinutes": 4320,
    "maximumDeliveryMinutes": 10080
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# Cancel Transfer Quote

Optional [transfer](page:resources/transfers) quote cancellation that auto-cancels after a period organically expires or when account activity invalidates the quote.

```csharp
CancelTransferQuoteAsync(
    string transferToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transferToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`.<br><br>**Constraints**: *Pattern*: `^xfer-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.TransferResult>`](../../doc/models/transfer-result.md)

## Example Usage

```csharp
string transferToken = "xfer-0fac4aa8-43ac-447e-95f9-827f908a82ff";
try
{
    TransferResult result = await transfersController.CancelTransferQuoteAsync(transferToken);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "token": "xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2",
  "clientTransferId": "af1d26c4-07d8-4bba-bdf6-104fda46e896",
  "created": "2025-06-24T12:40:53Z",
  "destinationAmount": 14,
  "destinationCurrency": "USD",
  "destinationToken": "dest-80611686-e311-4acd-aeeb-224609a3b12b",
  "fee": {
    "category": "USER",
    "destinationCountry": "USA",
    "destinationCurrency": "USD",
    "distribution": [
      {
        "amount": 1.5,
        "currency": "USD",
        "description": [
          {
            "language": "en-US",
            "translation": "Transfer to a Bank Fee"
          },
          {
            "language": "en-US",
            "translation": "Poplatek za převod do banky"
          },
          {
            "language": "de-DE",
            "translation": "Transfer zu einer Bankgebühr"
          },
          {
            "language": "es-ES",
            "translation": "Coste de la transferencia a un banco"
          },
          {
            "language": "en-US",
            "translation": "Pankkiin siirto -maksu"
          },
          {
            "language": "fr-FR",
            "translation": "Frais de virement vers une banque"
          },
          {
            "language": "it-IT",
            "translation": "Tariffa Trasferimento Bancario"
          },
          {
            "language": "ja-JP",
            "translation": "銀行への送金の手数料"
          },
          {
            "language": "ko-KR",
            "translation": "은행으로 송금 수수료"
          },
          {
            "language": "nl-NL",
            "translation": "Kosten bankoverschrijving"
          },
          {
            "language": "pl-PL",
            "translation": "Opłata za przelew do banku"
          },
          {
            "language": "pt-BR",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "ru-RU",
            "translation": "Комиссия за перевод на банковский счет"
          },
          {
            "language": "en-US",
            "translation": "Avgift för överföring till en bank"
          },
          {
            "language": "zh-Hans",
            "translation": "转账到银行手续费"
          },
          {
            "language": "zh-Hant",
            "translation": "轉帳至銀行手續費"
          },
          {
            "language": "fr-CA",
            "translation": "Frais de transfert bancaire"
          },
          {
            "language": "pt-PT",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "es-MX",
            "translation": "Transferencia a una Tarifa Bancaria"
          },
          {
            "language": "en-GB",
            "translation": "Transfer to a Bank Fee"
          }
        ],
        "formattedAmount": "$1.50 USD",
        "percentage": 1,
        "responsibility": "USER",
        "responsibilitySource": "SCHEDULE",
        "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e"
      }
    ],
    "source": "TRANSACTION",
    "totalAmount": 15.5,
    "transactionAmount": 14,
    "type": "BANK_TRANSFER",
    "valueAmount": 1.5,
    "valueType": "STATIC"
  },
  "fxRate": {
    "destinationAmount": 14,
    "destinationCurrency": "USD",
    "rate": 1,
    "sourceAmount": 14,
    "sourceCurrency": "USD",
    "sourceFormattedAmount": "$14.00 USD",
    "destinationFormattedAmount": "$14.00 USD"
  },
  "memo": "Bank transfer - memo",
  "note": "Bank transfer - note",
  "sourceToken": "user-65ec33d0-4518-41bb-2822-ed58c69e678e",
  "status": "PENDING_ACCEPTANCE",
  "destinationFormattedAmount": "$14.00 USD",
  "amount": 14,
  "formattedAmount": "$14.00 USD",
  "transferLockSide": "SOURCE",
  "transferMethodType": "IACH",
  "deliveryDetails": {
    "minimumDeliveryMinutes": 4320,
    "maximumDeliveryMinutes": 10080
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# Create Transfer Quote

Create a new [transfer](page:resources/transfers) quote.

```csharp
CreateTransferQuoteAsync(
    TransferQuote body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`TransferQuote`](../../doc/models/containers/transfer-quote.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.TransferResult>`](../../doc/models/transfer-result.md)

## Example Usage

```csharp
TransferQuote body = TransferQuote.FromGatewayTransferQuote(
    new GatewayTransferQuote
    {
        SourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
        DestinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
        Note = "string",
        Memo = "string",
        AutoAcceptQuote = true,
        ClientTransferId = "string",
        DestinationAmount = 50,
        DestinationCurrency = Currencies.Usd,
        TransferLockSide = LockSideTypes.Source,
        TransferMethodType = TransferMethodTypes.Iach,
    }
);

try
{
    TransferResult result = await transfersController.CreateTransferQuoteAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "token": "xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2",
  "clientTransferId": "af1d26c4-07d8-4bba-bdf6-104fda46e896",
  "created": "2025-06-24T12:40:53Z",
  "destinationAmount": 14,
  "destinationCurrency": "USD",
  "destinationToken": "dest-80611686-e311-4acd-aeeb-224609a3b12b",
  "fee": {
    "category": "USER",
    "destinationCountry": "USA",
    "destinationCurrency": "USD",
    "distribution": [
      {
        "amount": 1.5,
        "currency": "USD",
        "description": [
          {
            "language": "en-US",
            "translation": "Transfer to a Bank Fee"
          },
          {
            "language": "en-US",
            "translation": "Poplatek za převod do banky"
          },
          {
            "language": "de-DE",
            "translation": "Transfer zu einer Bankgebühr"
          },
          {
            "language": "es-ES",
            "translation": "Coste de la transferencia a un banco"
          },
          {
            "language": "en-US",
            "translation": "Pankkiin siirto -maksu"
          },
          {
            "language": "fr-FR",
            "translation": "Frais de virement vers une banque"
          },
          {
            "language": "it-IT",
            "translation": "Tariffa Trasferimento Bancario"
          },
          {
            "language": "ja-JP",
            "translation": "銀行への送金の手数料"
          },
          {
            "language": "ko-KR",
            "translation": "은행으로 송금 수수료"
          },
          {
            "language": "nl-NL",
            "translation": "Kosten bankoverschrijving"
          },
          {
            "language": "pl-PL",
            "translation": "Opłata za przelew do banku"
          },
          {
            "language": "pt-BR",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "ru-RU",
            "translation": "Комиссия за перевод на банковский счет"
          },
          {
            "language": "en-US",
            "translation": "Avgift för överföring till en bank"
          },
          {
            "language": "zh-Hans",
            "translation": "转账到银行手续费"
          },
          {
            "language": "zh-Hant",
            "translation": "轉帳至銀行手續費"
          },
          {
            "language": "fr-CA",
            "translation": "Frais de transfert bancaire"
          },
          {
            "language": "pt-PT",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "es-MX",
            "translation": "Transferencia a una Tarifa Bancaria"
          },
          {
            "language": "en-GB",
            "translation": "Transfer to a Bank Fee"
          }
        ],
        "formattedAmount": "$1.50 USD",
        "percentage": 1,
        "responsibility": "USER",
        "responsibilitySource": "SCHEDULE",
        "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e"
      }
    ],
    "source": "TRANSACTION",
    "totalAmount": 15.5,
    "transactionAmount": 14,
    "type": "BANK_TRANSFER",
    "valueAmount": 1.5,
    "valueType": "STATIC"
  },
  "fxRate": {
    "destinationAmount": 14,
    "destinationCurrency": "USD",
    "rate": 1,
    "sourceAmount": 14,
    "sourceCurrency": "USD",
    "sourceFormattedAmount": "$14.00 USD",
    "destinationFormattedAmount": "$14.00 USD"
  },
  "memo": "Bank transfer - memo",
  "note": "Bank transfer - note",
  "sourceToken": "user-65ec33d0-4518-41bb-2822-ed58c69e678e",
  "status": "PENDING_ACCEPTANCE",
  "destinationFormattedAmount": "$14.00 USD",
  "amount": 14,
  "formattedAmount": "$14.00 USD",
  "transferLockSide": "SOURCE",
  "transferMethodType": "IACH",
  "deliveryDetails": {
    "minimumDeliveryMinutes": 4320,
    "maximumDeliveryMinutes": 10080
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# List Transfers

Retrieve a list of [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListTransfersAsync(
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.TransferListResult>`](../../doc/models/transfer-list-result.md)

## Example Usage

```csharp
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    TransferListResult result = await transfersController.ListTransfersAsync(
        page,
        pageSize,
        filter,
        sort,
        language
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "payload": [
    {
      "token": "xfer-337b4c59-821d-4bac-a1dd-c9d7c15e41e8",
      "clientTransferId": "1066ab05-84d0-453f-a827-1bd3b2ad9e3d",
      "created": "2025-06-23T19:17:22Z",
      "destinationAmount": -14,
      "destinationCurrency": "USD",
      "destinationToken": "dest-80611686-e311-4acd-aeeb-244609a3b12b",
      "fee": {
        "category": "USER",
        "destinationCountry": "USA",
        "destinationCurrency": "USD",
        "distribution": [
          {
            "amount": 1.5,
            "currency": "USD",
            "description": [
              {
                "language": "en-US",
                "translation": "Transfer to a Bank Fee"
              },
              {
                "language": "en-US",
                "translation": "Poplatek za převod do banky"
              },
              {
                "language": "de-DE",
                "translation": "Transfer zu einer Bankgebühr"
              },
              {
                "language": "es-ES",
                "translation": "Coste de la transferencia a un banco"
              },
              {
                "language": "en-US",
                "translation": "Pankkiin siirto -maksu"
              },
              {
                "language": "fr-FR",
                "translation": "Frais de virement vers une banque"
              },
              {
                "language": "it-IT",
                "translation": "Tariffa Trasferimento Bancario"
              },
              {
                "language": "ja-JP",
                "translation": "銀行への送金の手数料"
              },
              {
                "language": "ko-KR",
                "translation": "은행으로 송금 수수료"
              },
              {
                "language": "nl-NL",
                "translation": "Kosten bankoverschrijving"
              },
              {
                "language": "pl-PL",
                "translation": "Opłata za przelew do banku"
              },
              {
                "language": "pt-BR",
                "translation": "Taxa de Transferência para um Banco"
              },
              {
                "language": "ru-RU",
                "translation": "Комиссия за перевод на банковский счет"
              },
              {
                "language": "en-US",
                "translation": "Avgift för överföring till en bank"
              },
              {
                "language": "zh-Hans",
                "translation": "转账到银行手续费"
              },
              {
                "language": "zh-Hant",
                "translation": "轉帳至銀行手續費"
              },
              {
                "language": "fr-CA",
                "translation": "Frais de transfert bancaire"
              },
              {
                "language": "pt-PT",
                "translation": "Taxa de Transferência para um Banco"
              },
              {
                "language": "es-MX",
                "translation": "Transferencia a una Tarifa Bancaria"
              },
              {
                "language": "en-GB",
                "translation": "Transfer to a Bank Fee"
              }
            ],
            "formattedAmount": "$1.50 USD",
            "percentage": 1,
            "responsibility": "USER",
            "responsibilitySource": "SCHEDULE",
            "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e"
          }
        ],
        "source": "TRANSACTION",
        "totalAmount": -12.5,
        "transactionAmount": -14,
        "type": "BANK_TRANSFER",
        "valueAmount": 1.5,
        "valueType": "STATIC"
      },
      "fxRate": {
        "destinationAmount": -14,
        "destinationCurrency": "USD",
        "rate": 1,
        "sourceAmount": -14,
        "sourceCurrency": "USD",
        "sourceFormattedAmount": "($14.00) USD",
        "destinationFormattedAmount": "($14.00) USD"
      },
      "memo": "Bank transfer - memo",
      "note": "Bank transfer - note",
      "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e",
      "status": "ACCEPTED",
      "receiptToken": "rcpt-337b4c59-821d-4bac-a1dd-c9d7c15e41e8",
      "destinationFormattedAmount": "($14.00) USD",
      "amount": -14,
      "formattedAmount": "($14.00) USD",
      "transferLockSide": "SOURCE",
      "transferMethodType": "IACH",
      "deliveryDetails": {
        "minimumDeliveryMinutes": 4320,
        "maximumDeliveryMinutes": 10080
      },
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-65ec33d0-4518-41bb-8822-ed58c69e678e/transfers/xfer-337b4c59-821d-4bac-a1dd-c9d7c15e41e8",
          "params": {
            "rel": "self"
          }
        }
      ]
    }
  ],
  "meta": {
    "pageNo": "1",
    "pageSize": "2",
    "pageCount": "1",
    "recordCount": "1",
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-65ec33d0-4518-41bb-8822-ed58c69e678e/transfers?page=1&language=en-US&filter=%27transfertype%27=%27BANK_TRANSFER%27&pageSize=2",
      "params": {
        "rel": "self"
      }
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# List User Transfers

Retrieve a list of user [transfers](page:resources/transfers) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListUserTransfersAsync(
    string userToken,
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.TransferListResult>`](../../doc/models/transfer-list-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    TransferListResult result = await transfersController.ListUserTransfersAsync(
        userToken,
        page,
        pageSize,
        filter,
        sort,
        language
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "payload": [
    {
      "token": "xfer-337b4c59-821d-4bac-a1dd-c9d7c15e41e8",
      "clientTransferId": "1066ab05-84d0-453f-a827-1bd3b2ad9e3d",
      "created": "2025-06-23T19:17:22Z",
      "destinationAmount": -14,
      "destinationCurrency": "USD",
      "destinationToken": "dest-80611686-e311-4acd-aeeb-244609a3b12b",
      "fee": {
        "category": "USER",
        "destinationCountry": "USA",
        "destinationCurrency": "USD",
        "distribution": [
          {
            "amount": 1.5,
            "currency": "USD",
            "description": [
              {
                "language": "en-US",
                "translation": "Transfer to a Bank Fee"
              },
              {
                "language": "en-US",
                "translation": "Poplatek za převod do banky"
              },
              {
                "language": "de-DE",
                "translation": "Transfer zu einer Bankgebühr"
              },
              {
                "language": "es-ES",
                "translation": "Coste de la transferencia a un banco"
              },
              {
                "language": "en-US",
                "translation": "Pankkiin siirto -maksu"
              },
              {
                "language": "fr-FR",
                "translation": "Frais de virement vers une banque"
              },
              {
                "language": "it-IT",
                "translation": "Tariffa Trasferimento Bancario"
              },
              {
                "language": "ja-JP",
                "translation": "銀行への送金の手数料"
              },
              {
                "language": "ko-KR",
                "translation": "은행으로 송금 수수료"
              },
              {
                "language": "nl-NL",
                "translation": "Kosten bankoverschrijving"
              },
              {
                "language": "pl-PL",
                "translation": "Opłata za przelew do banku"
              },
              {
                "language": "pt-BR",
                "translation": "Taxa de Transferência para um Banco"
              },
              {
                "language": "ru-RU",
                "translation": "Комиссия за перевод на банковский счет"
              },
              {
                "language": "en-US",
                "translation": "Avgift för överföring till en bank"
              },
              {
                "language": "zh-Hans",
                "translation": "转账到银行手续费"
              },
              {
                "language": "zh-Hant",
                "translation": "轉帳至銀行手續費"
              },
              {
                "language": "fr-CA",
                "translation": "Frais de transfert bancaire"
              },
              {
                "language": "pt-PT",
                "translation": "Taxa de Transferência para um Banco"
              },
              {
                "language": "es-MX",
                "translation": "Transferencia a una Tarifa Bancaria"
              },
              {
                "language": "en-GB",
                "translation": "Transfer to a Bank Fee"
              }
            ],
            "formattedAmount": "$1.50 USD",
            "percentage": 1,
            "responsibility": "USER",
            "responsibilitySource": "SCHEDULE",
            "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e"
          }
        ],
        "source": "TRANSACTION",
        "totalAmount": -12.5,
        "transactionAmount": -14,
        "type": "BANK_TRANSFER",
        "valueAmount": 1.5,
        "valueType": "STATIC"
      },
      "fxRate": {
        "destinationAmount": -14,
        "destinationCurrency": "USD",
        "rate": 1,
        "sourceAmount": -14,
        "sourceCurrency": "USD",
        "sourceFormattedAmount": "($14.00) USD",
        "destinationFormattedAmount": "($14.00) USD"
      },
      "memo": "Bank transfer - memo",
      "note": "Bank transfer - note",
      "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e",
      "status": "ACCEPTED",
      "receiptToken": "rcpt-337b4c59-821d-4bac-a1dd-c9d7c15e41e8",
      "destinationFormattedAmount": "($14.00) USD",
      "amount": -14,
      "formattedAmount": "($14.00) USD",
      "transferLockSide": "SOURCE",
      "transferMethodType": "IACH",
      "deliveryDetails": {
        "minimumDeliveryMinutes": 4320,
        "maximumDeliveryMinutes": 10080
      },
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-65ec33d0-4518-41bb-8822-ed58c69e678e/transfers/xfer-337b4c59-821d-4bac-a1dd-c9d7c15e41e8",
          "params": {
            "rel": "self"
          }
        }
      ]
    }
  ],
  "meta": {
    "pageNo": "1",
    "pageSize": "2",
    "pageCount": "1",
    "recordCount": "1",
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-65ec33d0-4518-41bb-8822-ed58c69e678e/transfers?page=1&language=en-US&filter=%27transfertype%27=%27BANK_TRANSFER%27&pageSize=2",
      "params": {
        "rel": "self"
      }
    }
  ]
}
```


# Retrieve Transfer

Retrieve details of a specific [transfer](page:resources/transfers) represented by a transfer token.

```csharp
RetrieveTransferAsync(
    string transferToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transferToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual transfer transaction, prefixed with `xfer-`.<br><br>**Constraints**: *Pattern*: `^xfer-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.TransferResult>`](../../doc/models/transfer-result.md)

## Example Usage

```csharp
string transferToken = "xfer-0fac4aa8-43ac-447e-95f9-827f908a82ff";
try
{
    TransferResult result = await transfersController.RetrieveTransferAsync(transferToken);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "token": "xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2",
  "clientTransferId": "af1d26c4-07d8-4bba-bdf6-104fda46e896",
  "created": "2025-06-24T12:40:53Z",
  "destinationAmount": 14,
  "destinationCurrency": "USD",
  "destinationToken": "dest-80611686-e311-4acd-aeeb-224609a3b12b",
  "fee": {
    "category": "USER",
    "destinationCountry": "USA",
    "destinationCurrency": "USD",
    "distribution": [
      {
        "amount": 1.5,
        "currency": "USD",
        "description": [
          {
            "language": "en-US",
            "translation": "Transfer to a Bank Fee"
          },
          {
            "language": "en-US",
            "translation": "Poplatek za převod do banky"
          },
          {
            "language": "de-DE",
            "translation": "Transfer zu einer Bankgebühr"
          },
          {
            "language": "es-ES",
            "translation": "Coste de la transferencia a un banco"
          },
          {
            "language": "en-US",
            "translation": "Pankkiin siirto -maksu"
          },
          {
            "language": "fr-FR",
            "translation": "Frais de virement vers une banque"
          },
          {
            "language": "it-IT",
            "translation": "Tariffa Trasferimento Bancario"
          },
          {
            "language": "ja-JP",
            "translation": "銀行への送金の手数料"
          },
          {
            "language": "ko-KR",
            "translation": "은행으로 송금 수수료"
          },
          {
            "language": "nl-NL",
            "translation": "Kosten bankoverschrijving"
          },
          {
            "language": "pl-PL",
            "translation": "Opłata za przelew do banku"
          },
          {
            "language": "pt-BR",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "ru-RU",
            "translation": "Комиссия за перевод на банковский счет"
          },
          {
            "language": "en-US",
            "translation": "Avgift för överföring till en bank"
          },
          {
            "language": "zh-Hans",
            "translation": "转账到银行手续费"
          },
          {
            "language": "zh-Hant",
            "translation": "轉帳至銀行手續費"
          },
          {
            "language": "fr-CA",
            "translation": "Frais de transfert bancaire"
          },
          {
            "language": "pt-PT",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "es-MX",
            "translation": "Transferencia a una Tarifa Bancaria"
          },
          {
            "language": "en-GB",
            "translation": "Transfer to a Bank Fee"
          }
        ],
        "formattedAmount": "$1.50 USD",
        "percentage": 1,
        "responsibility": "USER",
        "responsibilitySource": "SCHEDULE",
        "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e"
      }
    ],
    "source": "TRANSACTION",
    "totalAmount": 15.5,
    "transactionAmount": 14,
    "type": "BANK_TRANSFER",
    "valueAmount": 1.5,
    "valueType": "STATIC"
  },
  "fxRate": {
    "destinationAmount": 14,
    "destinationCurrency": "USD",
    "rate": 1,
    "sourceAmount": 14,
    "sourceCurrency": "USD",
    "sourceFormattedAmount": "$14.00 USD",
    "destinationFormattedAmount": "$14.00 USD"
  },
  "memo": "Bank transfer - memo",
  "note": "Bank transfer - note",
  "sourceToken": "user-65ec33d0-4518-41bb-2822-ed58c69e678e",
  "status": "PENDING_ACCEPTANCE",
  "destinationFormattedAmount": "$14.00 USD",
  "amount": 14,
  "formattedAmount": "$14.00 USD",
  "transferLockSide": "SOURCE",
  "transferMethodType": "IACH",
  "deliveryDetails": {
    "minimumDeliveryMinutes": 4320,
    "maximumDeliveryMinutes": 10080
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# Retrieve User Transfer

Retrieve a specific user bank [transfer](page:resources/transfers).

```csharp
RetrieveUserTransferAsync(
    string userToken,
    string transferToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `transferToken` | `string` | Template, Required | Auto-generated unique identifier representing a transfer, prefixed with `xfer-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^xfer-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.TransferResult>`](../../doc/models/transfer-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
string transferToken = "xfer-bf34989d-0b13-47ee-bd51-b96b0ecbe866";
try
{
    TransferResult result = await transfersController.RetrieveUserTransferAsync(
        userToken,
        transferToken
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "token": "xfer-0722428d-7929-4bb5-a7eb-8526e8fe49e2",
  "clientTransferId": "af1d26c4-07d8-4bba-bdf6-104fda46e896",
  "created": "2025-06-24T12:40:53Z",
  "destinationAmount": 14,
  "destinationCurrency": "USD",
  "destinationToken": "dest-80611686-e311-4acd-aeeb-224609a3b12b",
  "fee": {
    "category": "USER",
    "destinationCountry": "USA",
    "destinationCurrency": "USD",
    "distribution": [
      {
        "amount": 1.5,
        "currency": "USD",
        "description": [
          {
            "language": "en-US",
            "translation": "Transfer to a Bank Fee"
          },
          {
            "language": "en-US",
            "translation": "Poplatek za převod do banky"
          },
          {
            "language": "de-DE",
            "translation": "Transfer zu einer Bankgebühr"
          },
          {
            "language": "es-ES",
            "translation": "Coste de la transferencia a un banco"
          },
          {
            "language": "en-US",
            "translation": "Pankkiin siirto -maksu"
          },
          {
            "language": "fr-FR",
            "translation": "Frais de virement vers une banque"
          },
          {
            "language": "it-IT",
            "translation": "Tariffa Trasferimento Bancario"
          },
          {
            "language": "ja-JP",
            "translation": "銀行への送金の手数料"
          },
          {
            "language": "ko-KR",
            "translation": "은행으로 송금 수수료"
          },
          {
            "language": "nl-NL",
            "translation": "Kosten bankoverschrijving"
          },
          {
            "language": "pl-PL",
            "translation": "Opłata za przelew do banku"
          },
          {
            "language": "pt-BR",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "ru-RU",
            "translation": "Комиссия за перевод на банковский счет"
          },
          {
            "language": "en-US",
            "translation": "Avgift för överföring till en bank"
          },
          {
            "language": "zh-Hans",
            "translation": "转账到银行手续费"
          },
          {
            "language": "zh-Hant",
            "translation": "轉帳至銀行手續費"
          },
          {
            "language": "fr-CA",
            "translation": "Frais de transfert bancaire"
          },
          {
            "language": "pt-PT",
            "translation": "Taxa de Transferência para um Banco"
          },
          {
            "language": "es-MX",
            "translation": "Transferencia a una Tarifa Bancaria"
          },
          {
            "language": "en-GB",
            "translation": "Transfer to a Bank Fee"
          }
        ],
        "formattedAmount": "$1.50 USD",
        "percentage": 1,
        "responsibility": "USER",
        "responsibilitySource": "SCHEDULE",
        "sourceToken": "user-65ec33d0-4518-41bb-8822-ed58c69e678e"
      }
    ],
    "source": "TRANSACTION",
    "totalAmount": 15.5,
    "transactionAmount": 14,
    "type": "BANK_TRANSFER",
    "valueAmount": 1.5,
    "valueType": "STATIC"
  },
  "fxRate": {
    "destinationAmount": 14,
    "destinationCurrency": "USD",
    "rate": 1,
    "sourceAmount": 14,
    "sourceCurrency": "USD",
    "sourceFormattedAmount": "$14.00 USD",
    "destinationFormattedAmount": "$14.00 USD"
  },
  "memo": "Bank transfer - memo",
  "note": "Bank transfer - note",
  "sourceToken": "user-65ec33d0-4518-41bb-2822-ed58c69e678e",
  "status": "PENDING_ACCEPTANCE",
  "destinationFormattedAmount": "$14.00 USD",
  "amount": 14,
  "formattedAmount": "$14.00 USD",
  "transferLockSide": "SOURCE",
  "transferMethodType": "IACH",
  "deliveryDetails": {
    "minimumDeliveryMinutes": 4320,
    "maximumDeliveryMinutes": 10080
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/transfers/xfer-0722448d-7929-4bb5-a7eb-8526e8fe49e2",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |

