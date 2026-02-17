// <copyright file="PayQuickerSDKClient.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Authentication;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Logger.Configuration;
using Microsoft.Extensions.Configuration;
using PayQuickerSDK.Standard.Authentication;
using PayQuickerSDK.Standard.Controllers;
using PayQuickerSDK.Standard.Http.Client;
using PayQuickerSDK.Standard.Logging;
using System;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class PayQuickerSDKClient : IPayQuickerSDKClient
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Api, "https://api.payquicker.io/api/v2" },
                }
            },
            {
                Environment.Sandbox, new Dictionary<Enum, string>
                {
                    { Server.Api, "https://api.{sandbox_instance}.payquicker.io/api/v2" },
                }
            },
            {
                Environment.Uat, new Dictionary<Enum, string>
                {
                    { Server.Api, "https://api.{uat_instance}.payquicker.io/api/v2" },
                }
            },
            {
                Environment.Development, new Dictionary<Enum, string>
                {
                    { Server.Api, "https://api.local.payquicker.io/api/v2" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private SdkLoggingConfiguration sdkLoggingConfiguration;
        private const string userAgent = "PayQuicker SDK 2026.02.01";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<IAgreementsController> agreements;
        private readonly Lazy<IBalancesController> balances;
        private readonly Lazy<IBankAccountsController> bankAccounts;
        private readonly Lazy<IClientSideController> clientSide;
        private readonly Lazy<IComplianceController> compliance;
        private readonly Lazy<IDocumentsController> documents;
        private readonly Lazy<IElectronicWalletsController> electronicWallets;
        private readonly Lazy<IEventsController> events;
        private readonly Lazy<IPaymentsController> payments;
        private readonly Lazy<IPrepaidCardsController> prepaidCards;
        private readonly Lazy<IProgramController> program;
        private readonly Lazy<IReceiptsController> receipts;
        private readonly Lazy<ISpendbackController> spendback;
        private readonly Lazy<ISpendbackRefundsController> spendbackRefunds;
        private readonly Lazy<IStatementsController> statements;
        private readonly Lazy<ITransfersController> transfers;
        private readonly Lazy<IUsersController> users;
        private readonly Lazy<IWebhooksController> webhooks;
        private readonly Lazy<IJobsController> jobs;
        private readonly Lazy<IInvitationsController> invitations;
        private readonly Lazy<IOAuthAuthorizationController> oAuthAuthorization;

        private PayQuickerSDKClient(
            string xMyPayQuickerVersion,
            Environment environment,
            Models.SandboxInstance sandboxInstance,
            Models.UatInstance uatInstance,
            ServerModel serverModel,
            ClientsideModel clientsideModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration,
            SdkLoggingConfiguration sdkLoggingConfiguration)
        {
            this.XMyPayQuickerVersion = xMyPayQuickerVersion;
            this.Environment = environment;
            this.SandboxInstance = sandboxInstance;
            this.UatInstance = uatInstance;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            this.sdkLoggingConfiguration = sdkLoggingConfiguration;
            ServerModel = serverModel;
            var serverManager = new ServerManager(serverModel,
                () => OAuthAuthorizationController);
            ClientsideModel = clientsideModel;
            var clientsideManager = new ClientsideManager(clientsideModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"server", serverManager},
                    {"clientside", clientsideManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Api)
                .LoggingConfig(sdkLoggingConfiguration)
                .Parameters(globalParameter => globalParameter
                    .Header(headerParameter => headerParameter.Setup("X-MyPayQuicker-Version", this.XMyPayQuickerVersion))
                    .Template(templateParameter => templateParameter.Setup("sandbox_instance", CoreHelper.JsonSerialize(this.SandboxInstance).Trim('\"')))
                    .Template(templateParameter => templateParameter.Setup("uat_instance", CoreHelper.JsonSerialize(this.UatInstance).Trim('\"')))
                )
                .UserAgent(userAgent)
                .Build();
            ServerCredentials = serverManager;
            ClientsideCredentials = clientsideManager;

            this.agreements = new Lazy<IAgreementsController>(
                () => new AgreementsController(globalConfiguration));
            this.balances = new Lazy<IBalancesController>(
                () => new BalancesController(globalConfiguration));
            this.bankAccounts = new Lazy<IBankAccountsController>(
                () => new BankAccountsController(globalConfiguration));
            this.clientSide = new Lazy<IClientSideController>(
                () => new ClientSideController(globalConfiguration));
            this.compliance = new Lazy<IComplianceController>(
                () => new ComplianceController(globalConfiguration));
            this.documents = new Lazy<IDocumentsController>(
                () => new DocumentsController(globalConfiguration));
            this.electronicWallets = new Lazy<IElectronicWalletsController>(
                () => new ElectronicWalletsController(globalConfiguration));
            this.events = new Lazy<IEventsController>(
                () => new EventsController(globalConfiguration));
            this.payments = new Lazy<IPaymentsController>(
                () => new PaymentsController(globalConfiguration));
            this.prepaidCards = new Lazy<IPrepaidCardsController>(
                () => new PrepaidCardsController(globalConfiguration));
            this.program = new Lazy<IProgramController>(
                () => new ProgramController(globalConfiguration));
            this.receipts = new Lazy<IReceiptsController>(
                () => new ReceiptsController(globalConfiguration));
            this.spendback = new Lazy<ISpendbackController>(
                () => new SpendbackController(globalConfiguration));
            this.spendbackRefunds = new Lazy<ISpendbackRefundsController>(
                () => new SpendbackRefundsController(globalConfiguration));
            this.statements = new Lazy<IStatementsController>(
                () => new StatementsController(globalConfiguration));
            this.transfers = new Lazy<ITransfersController>(
                () => new TransfersController(globalConfiguration));
            this.users = new Lazy<IUsersController>(
                () => new UsersController(globalConfiguration));
            this.webhooks = new Lazy<IWebhooksController>(
                () => new WebhooksController(globalConfiguration));
            this.jobs = new Lazy<IJobsController>(
                () => new JobsController(globalConfiguration));
            this.invitations = new Lazy<IInvitationsController>(
                () => new InvitationsController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<IOAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets AgreementsController controller.
        /// </summary>
        public IAgreementsController AgreementsController => this.agreements.Value;

        /// <summary>
        /// Gets BalancesController controller.
        /// </summary>
        public IBalancesController BalancesController => this.balances.Value;

        /// <summary>
        /// Gets BankAccountsController controller.
        /// </summary>
        public IBankAccountsController BankAccountsController => this.bankAccounts.Value;

        /// <summary>
        /// Gets ClientSideController controller.
        /// </summary>
        public IClientSideController ClientSideController => this.clientSide.Value;

        /// <summary>
        /// Gets ComplianceController controller.
        /// </summary>
        public IComplianceController ComplianceController => this.compliance.Value;

        /// <summary>
        /// Gets DocumentsController controller.
        /// </summary>
        public IDocumentsController DocumentsController => this.documents.Value;

        /// <summary>
        /// Gets ElectronicWalletsController controller.
        /// </summary>
        public IElectronicWalletsController ElectronicWalletsController => this.electronicWallets.Value;

        /// <summary>
        /// Gets EventsController controller.
        /// </summary>
        public IEventsController EventsController => this.events.Value;

        /// <summary>
        /// Gets PaymentsController controller.
        /// </summary>
        public IPaymentsController PaymentsController => this.payments.Value;

        /// <summary>
        /// Gets PrepaidCardsController controller.
        /// </summary>
        public IPrepaidCardsController PrepaidCardsController => this.prepaidCards.Value;

        /// <summary>
        /// Gets ProgramController controller.
        /// </summary>
        public IProgramController ProgramController => this.program.Value;

        /// <summary>
        /// Gets ReceiptsController controller.
        /// </summary>
        public IReceiptsController ReceiptsController => this.receipts.Value;

        /// <summary>
        /// Gets SpendbackController controller.
        /// </summary>
        public ISpendbackController SpendbackController => this.spendback.Value;

        /// <summary>
        /// Gets SpendbackRefundsController controller.
        /// </summary>
        public ISpendbackRefundsController SpendbackRefundsController => this.spendbackRefunds.Value;

        /// <summary>
        /// Gets StatementsController controller.
        /// </summary>
        public IStatementsController StatementsController => this.statements.Value;

        /// <summary>
        /// Gets TransfersController controller.
        /// </summary>
        public ITransfersController TransfersController => this.transfers.Value;

        /// <summary>
        /// Gets UsersController controller.
        /// </summary>
        public IUsersController UsersController => this.users.Value;

        /// <summary>
        /// Gets WebhooksController controller.
        /// </summary>
        public IWebhooksController WebhooksController => this.webhooks.Value;

        /// <summary>
        /// Gets JobsController controller.
        /// </summary>
        public IJobsController JobsController => this.jobs.Value;

        /// <summary>
        /// Gets InvitationsController controller.
        /// </summary>
        public IInvitationsController InvitationsController => this.invitations.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public IOAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets XMyPayQuickerVersion.
        /// Date-based API Version specified in the header *required* on all calls.
        /// </summary>
        public string XMyPayQuickerVersion { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets SandboxInstance.
        /// Sandbox Environments.
        /// </summary>
        public Models.SandboxInstance SandboxInstance { get; }

        /// <summary>
        /// Gets UatInstance.
        /// UAT Environments.
        /// </summary>
        public Models.UatInstance UatInstance { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with Server.
        /// </summary>
        public IServerCredentials ServerCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with Server.
        /// </summary>
        public ServerModel ServerModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with Clientside.
        /// </summary>
        public IClientsideCredentials ClientsideCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with Clientside.
        /// </summary>
        public ClientsideModel ClientsideModel { get; private set; }

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.ClientsideCredentials.AccessToken;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:API.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Api)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the PayQuickerSDKClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .XMyPayQuickerVersion(this.XMyPayQuickerVersion)
                .Environment(this.Environment)
                .SandboxInstance(this.SandboxInstance)
                .UatInstance(this.UatInstance)
                .HttpCallback(httpCallback)
                .LoggingConfig(sdkLoggingConfiguration)
                .HttpClientConfig(config => config.Build());

            if (ServerModel != null)
            {
                builder.ServerCredentials(ServerModel.ToBuilder().Build());
            }

            if (ClientsideModel != null)
            {
                builder.ClientsideCredentials(ClientsideModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"XMyPayQuickerVersion = {this.XMyPayQuickerVersion}, " +
                $"Environment = {this.Environment}, " +
                $"SandboxInstance = {this.SandboxInstance}, " +
                $"UatInstance = {this.UatInstance}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> PayQuickerSDKClient.</returns>
        internal static PayQuickerSDKClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string xMyPayQuickerVersion = System.Environment.GetEnvironmentVariable("PAY_QUICKER_SDK_STANDARD_X_MY_PAY_QUICKER_VERSION");
            string environment = System.Environment.GetEnvironmentVariable("PAY_QUICKER_SDK_STANDARD_ENVIRONMENT");
            string sandboxInstance = System.Environment.GetEnvironmentVariable("PAY_QUICKER_SDK_STANDARD_SANDBOX_INSTANCE");
            string uatInstance = System.Environment.GetEnvironmentVariable("PAY_QUICKER_SDK_STANDARD_UAT_INSTANCE");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("PAY_QUICKER_SDK_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("PAY_QUICKER_SDK_STANDARD_O_AUTH_CLIENT_SECRET");
            string accessToken = System.Environment.GetEnvironmentVariable("PAY_QUICKER_SDK_STANDARD_ACCESS_TOKEN");

            if (xMyPayQuickerVersion != null)
            {
                builder.XMyPayQuickerVersion(xMyPayQuickerVersion);
            }

            if (environment != null)
            {
                builder.Environment(CoreHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (sandboxInstance != null)
            {
                builder.SandboxInstance(CoreHelper.JsonDeserialize<Models.SandboxInstance>($"\"{sandboxInstance}\""));
            }

            if (uatInstance != null)
            {
                builder.UatInstance(CoreHelper.JsonDeserialize<Models.UatInstance>($"\"{uatInstance}\""));
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.ServerCredentials(new ServerModel
                .Builder(oAuthClientId, oAuthClientSecret)
                .Build());
            }

            if (accessToken != null)
            {
                builder.ClientsideCredentials(new ClientsideModel
                .Builder(accessToken)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Creates the client from configuration.
        /// </summary>
        /// <returns> PayQuickerSDKClient.</returns>
        public static PayQuickerSDKClient FromConfiguration(IConfigurationSection configuration) =>
            Builder.FromConfiguration(configuration).Build();

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string _xMyPayQuickerVersion = "2026.02.01";
            private Environment _environment = PayQuickerSDK.Standard.Environment.Sandbox;
            private Models.SandboxInstance _sandboxInstance = Models.SandboxInstance.Sandbox;
            private Models.UatInstance _uatInstance = Models.UatInstance.Uat1;
            private ServerModel _serverModel = new ServerModel();
            private ClientsideModel _clientsideModel = new ClientsideModel();
            private HttpClientConfiguration.Builder _httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback _httpCallback;
            private SdkLoggingConfiguration _sdkLoggingConfiguration;

            /// <summary>
            /// Sets credentials for Server.
            /// </summary>
            /// <param name="serverModel">ServerModel.</param>
            /// <returns>Builder.</returns>
            public Builder ServerCredentials(ServerModel serverModel)
            {
                _serverModel = serverModel ??
                    throw new ArgumentNullException(nameof(serverModel));
                return this;
            }

            /// <summary>
            /// Sets credentials for Clientside.
            /// </summary>
            /// <param name="clientsideModel">ClientsideModel.</param>
            /// <returns>Builder.</returns>
            public Builder ClientsideCredentials(ClientsideModel clientsideModel)
            {
                _clientsideModel = clientsideModel ??
                    throw new ArgumentNullException(nameof(clientsideModel));
                return this;
            }

            /// <summary>
            /// Sets XMyPayQuickerVersion.
            /// </summary>
            /// <param name="xMyPayQuickerVersion"> XMyPayQuickerVersion. </param>
            /// <returns> Builder. </returns>
            public Builder XMyPayQuickerVersion(string xMyPayQuickerVersion)
            {
                _xMyPayQuickerVersion = xMyPayQuickerVersion ?? throw new ArgumentNullException(nameof(xMyPayQuickerVersion));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                _environment = environment;
                return this;
            }

            /// <summary>
            /// Sets SandboxInstance.
            /// </summary>
            /// <param name="sandboxInstance"> SandboxInstance. </param>
            /// <returns> Builder. </returns>
            public Builder SandboxInstance(Models.SandboxInstance sandboxInstance)
            {
                _sandboxInstance = sandboxInstance;
                return this;
            }

            /// <summary>
            /// Sets UatInstance.
            /// </summary>
            /// <param name="uatInstance"> UatInstance. </param>
            /// <returns> Builder. </returns>
            public Builder UatInstance(Models.UatInstance uatInstance)
            {
                _uatInstance = uatInstance;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(_httpClientConfig);
                return this;
            }

            private Builder HttpClientConfig(HttpClientConfiguration.Builder httpClientConfigurationBuilder)
            {
                if (httpClientConfigurationBuilder != null)
                {
                    _httpClientConfig = httpClientConfigurationBuilder;
                }

                return this;
            }

            /// <summary>
            /// Sets the default logging configuration, using the Console logger.
            /// </summary>
            /// <returns>Builder.</returns>
            public Builder LoggingConfig()
            {
                _sdkLoggingConfiguration = SdkLoggingConfiguration.Console();
                return this;
            }

            /// <summary>
            /// Sets the logging configuration using the provided <paramref name="action"/>.
            /// </summary>
            /// <param name="action">The action to perform on the logging configuration builder.</param>
            /// <returns>Builder.</returns>
            /// <exception cref="ArgumentNullException">Thrown when <paramref name="action"/> is null.</exception>
            public Builder LoggingConfig(Action<LogBuilder> action)
            {
                if (action is null) throw new ArgumentNullException(nameof(action));
                var logBuilder =
                    LogBuilder.CreateFromConfig(_sdkLoggingConfiguration ?? SdkLoggingConfiguration.Console());
                action(logBuilder);
                _sdkLoggingConfiguration = logBuilder.Build();
                return this;
            }

            internal Builder LoggingConfig(SdkLoggingConfiguration configuration)
            {
                _sdkLoggingConfiguration = configuration;
                return this;
            }

            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                _httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the PayQuickerSDKClient using the values provided for the builder.
            /// </summary>
            /// <returns>PayQuickerSDKClient.</returns>
            public PayQuickerSDKClient Build()
            {
                if (_serverModel.OAuthClientId == null || _serverModel.OAuthClientSecret == null)
                {
                    _serverModel = null;
                }
                if (_clientsideModel.AccessToken == null)
                {
                    _clientsideModel = null;
                }
                return new PayQuickerSDKClient(
                    _xMyPayQuickerVersion,
                    _environment,
                    _sandboxInstance,
                    _uatInstance,
                    _serverModel,
                    _clientsideModel,
                    _httpCallback,
                    _httpClientConfig.Build(),
                    _sdkLoggingConfiguration);
            }

            /// <summary>
            /// Creates the client builder from configuration.
            /// </summary>
            /// <returns> Builder.</returns>
            public static Builder FromConfiguration(IConfigurationSection config)
            {
                var builder = new Builder();
                var options = config.Get<PayQuickerSDKClientOptions>();
                if (options == null) return builder;
                if (options.XMyPayQuickerVersion != null)
                    builder.XMyPayQuickerVersion(options.XMyPayQuickerVersion);
                if (options.Environment != null)
                    builder.Environment(options.Environment.Value);
                if (options.SandboxInstance != null)
                    builder.SandboxInstance(options.SandboxInstance.Value);
                if (options.UatInstance != null)
                    builder.UatInstance(options.UatInstance.Value);
                if (options.ServerCredentials != null)
                    builder.ServerCredentials(ServerModel.FromOptions(options.ServerCredentials));
                if (options.ClientsideCredentials != null)
                    builder.ClientsideCredentials(ClientsideModel.FromOptions(options.ClientsideCredentials));
                if (options.HttpClientConfig != null)
                    builder.HttpClientConfig(Http.Client.HttpClientConfiguration.FromOptions(options.HttpClientConfig));
                if (options.LoggingConfig != null)
                    builder.LoggingConfig(LogBuilder.FromOptions(options.LoggingConfig));
                return builder;
            }
        }

        public class PayQuickerSDKClientOptions
        {
            public string XMyPayQuickerVersion { get; set; }
            public Environment? Environment { get; set; }
            public Models.SandboxInstance? SandboxInstance { get; set; }
            public Models.UatInstance? UatInstance { get; set; }
            public ServerModelOptions ServerCredentials { get; set; }
            public ClientsideModelOptions ClientsideCredentials { get; set; }
            public HttpClientConfigurationOptions HttpClientConfig { get; set; }
            public LoggingConfigOptions LoggingConfig { get; set; }
        }
    }
}
