// <copyright file="IPayQuickerSDKClient.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using PayQuickerSDK.Standard.Controllers;

namespace PayQuickerSDK.Standard
{
    /// <summary>
    /// IPayQuickerSDKClient.
    /// </summary>
    public interface IPayQuickerSDKClient : IConfiguration
    {
        /// <summary>
        /// Gets instance for IAgreementsController.
        /// </summary>
        IAgreementsController AgreementsController { get; }

        /// <summary>
        /// Gets instance for IBalancesController.
        /// </summary>
        IBalancesController BalancesController { get; }

        /// <summary>
        /// Gets instance for IBankAccountsController.
        /// </summary>
        IBankAccountsController BankAccountsController { get; }

        /// <summary>
        /// Gets instance for IClientSideController.
        /// </summary>
        IClientSideController ClientSideController { get; }

        /// <summary>
        /// Gets instance for IComplianceController.
        /// </summary>
        IComplianceController ComplianceController { get; }

        /// <summary>
        /// Gets instance for IDocumentsController.
        /// </summary>
        IDocumentsController DocumentsController { get; }

        /// <summary>
        /// Gets instance for IElectronicWalletsController.
        /// </summary>
        IElectronicWalletsController ElectronicWalletsController { get; }

        /// <summary>
        /// Gets instance for IEventsController.
        /// </summary>
        IEventsController EventsController { get; }

        /// <summary>
        /// Gets instance for IPaymentsController.
        /// </summary>
        IPaymentsController PaymentsController { get; }

        /// <summary>
        /// Gets instance for IPrepaidCardsController.
        /// </summary>
        IPrepaidCardsController PrepaidCardsController { get; }

        /// <summary>
        /// Gets instance for IProgramController.
        /// </summary>
        IProgramController ProgramController { get; }

        /// <summary>
        /// Gets instance for IReceiptsController.
        /// </summary>
        IReceiptsController ReceiptsController { get; }

        /// <summary>
        /// Gets instance for ISpendbackController.
        /// </summary>
        ISpendbackController SpendbackController { get; }

        /// <summary>
        /// Gets instance for ISpendbackRefundsController.
        /// </summary>
        ISpendbackRefundsController SpendbackRefundsController { get; }

        /// <summary>
        /// Gets instance for IStatementsController.
        /// </summary>
        IStatementsController StatementsController { get; }

        /// <summary>
        /// Gets instance for ITransfersController.
        /// </summary>
        ITransfersController TransfersController { get; }

        /// <summary>
        /// Gets instance for IUsersController.
        /// </summary>
        IUsersController UsersController { get; }

        /// <summary>
        /// Gets instance for IWebhooksController.
        /// </summary>
        IWebhooksController WebhooksController { get; }

        /// <summary>
        /// Gets instance for IJobsController.
        /// </summary>
        IJobsController JobsController { get; }

        /// <summary>
        /// Gets instance for IInvitationsController.
        /// </summary>
        IInvitationsController InvitationsController { get; }

        /// <summary>
        /// Gets instance for IOAuthAuthorizationController.
        /// </summary>
        IOAuthAuthorizationController OAuthAuthorizationController { get; }
    }
}