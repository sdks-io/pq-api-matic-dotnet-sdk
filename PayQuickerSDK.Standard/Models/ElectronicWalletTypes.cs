// <copyright file="ElectronicWalletTypes.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ElectronicWalletTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectronicWalletTypes
    {
        /// <summary>
        /// AirtelMoney.
        /// </summary>
        [EnumMember(Value = "AIRTEL_MONEY")]
        AirtelMoney,

        /// <summary>
        /// AirtelTigoMoney.
        /// </summary>
        [EnumMember(Value = "AIRTEL_TIGO_MONEY")]
        AirtelTigoMoney,

        /// <summary>
        /// Alipay.
        /// </summary>
        [EnumMember(Value = "ALIPAY")]
        Alipay,

        /// <summary>
        /// Amole.
        /// </summary>
        [EnumMember(Value = "AMOLE")]
        Amole,

        /// <summary>
        /// Astrapay.
        /// </summary>
        [EnumMember(Value = "ASTRAPAY")]
        Astrapay,

        /// <summary>
        /// AwashBirr.
        /// </summary>
        [EnumMember(Value = "AWASH_BIRR")]
        AwashBirr,

        /// <summary>
        /// AyaPayWallet.
        /// </summary>
        [EnumMember(Value = "AYA_PAY_WALLET")]
        AyaPayWallet,

        /// <summary>
        /// Bankily.
        /// </summary>
        [EnumMember(Value = "BANKILY")]
        Bankily,

        /// <summary>
        /// Bigpay.
        /// </summary>
        [EnumMember(Value = "BIGPAY")]
        Bigpay,

        /// <summary>
        /// BilletBhdWallet.
        /// </summary>
        [EnumMember(Value = "BILLET_BHD_WALLET")]
        BilletBhdWallet,

        /// <summary>
        /// BilleteraMovilBanpro.
        /// </summary>
        [EnumMember(Value = "BILLETERA_MOVIL_BANPRO")]
        BilleteraMovilBanpro,

        /// <summary>
        /// Bkash.
        /// </summary>
        [EnumMember(Value = "BKASH")]
        Bkash,

        /// <summary>
        /// CbeBirr.
        /// </summary>
        [EnumMember(Value = "CBE_BIRR")]
        CbeBirr,

        /// <summary>
        /// Cellpay.
        /// </summary>
        [EnumMember(Value = "CELLPAY")]
        Cellpay,

        /// <summary>
        /// Coins.
        /// </summary>
        [EnumMember(Value = "COINS")]
        Coins,

        /// <summary>
        /// Dana.
        /// </summary>
        [EnumMember(Value = "DANA")]
        Dana,

        /// <summary>
        /// Daviplata.
        /// </summary>
        [EnumMember(Value = "DAVIPLATA")]
        Daviplata,

        /// <summary>
        /// DigicelMycash.
        /// </summary>
        [EnumMember(Value = "DIGICEL_MYCASH")]
        DigicelMycash,

        /// <summary>
        /// Dinarak.
        /// </summary>
        [EnumMember(Value = "DINARAK")]
        Dinarak,

        /// <summary>
        /// EasyPaisaWallet.
        /// </summary>
        [EnumMember(Value = "EASY_PAISA_WALLET")]
        EasyPaisaWallet,

        /// <summary>
        /// Ecocash.
        /// </summary>
        [EnumMember(Value = "ECOCASH")]
        Ecocash,

        /// <summary>
        /// EquitelMoney.
        /// </summary>
        [EnumMember(Value = "EQUITEL_MONEY")]
        EquitelMoney,

        /// <summary>
        /// Esewa.
        /// </summary>
        [EnumMember(Value = "ESEWA")]
        Esewa,

        /// <summary>
        /// ExpressUnion.
        /// </summary>
        [EnumMember(Value = "EXPRESS_UNION")]
        ExpressUnion,

        /// <summary>
        /// EzCash.
        /// </summary>
        [EnumMember(Value = "EZ_CASH")]
        EzCash,

        /// <summary>
        /// FdhBankWallets.
        /// </summary>
        [EnumMember(Value = "FDH_BANK_WALLETS")]
        FdhBankWallets,

        /// <summary>
        /// FinjaWallet.
        /// </summary>
        [EnumMember(Value = "FINJA_WALLET")]
        FinjaWallet,

        /// <summary>
        /// Gadha.
        /// </summary>
        [EnumMember(Value = "GADHA")]
        Gadha,

        /// <summary>
        /// Gcash.
        /// </summary>
        [EnumMember(Value = "GCASH")]
        Gcash,

        /// <summary>
        /// Gopay.
        /// </summary>
        [EnumMember(Value = "GOPAY")]
        Gopay,

        /// <summary>
        /// Grabpay.
        /// </summary>
        [EnumMember(Value = "GRABPAY")]
        Grabpay,

        /// <summary>
        /// Hellocash.
        /// </summary>
        [EnumMember(Value = "HELLOCASH")]
        Hellocash,

        /// <summary>
        /// HormuudEvc.
        /// </summary>
        [EnumMember(Value = "HORMUUD_EVC")]
        HormuudEvc,

        /// <summary>
        /// Icash.
        /// </summary>
        [EnumMember(Value = "ICASH")]
        Icash,

        /// <summary>
        /// Illicocash.
        /// </summary>
        [EnumMember(Value = "ILLICOCASH")]
        Illicocash,

        /// <summary>
        /// ImePay.
        /// </summary>
        [EnumMember(Value = "IME_PAY")]
        ImePay,

        /// <summary>
        /// Imkas.
        /// </summary>
        [EnumMember(Value = "IMKAS")]
        Imkas,

        /// <summary>
        /// JazzCashWallet.
        /// </summary>
        [EnumMember(Value = "JAZZ_CASH_WALLET")]
        JazzCashWallet,

        /// <summary>
        /// KhaltiWallet.
        /// </summary>
        [EnumMember(Value = "KHALTI_WALLET")]
        KhaltiWallet,

        /// <summary>
        /// Lendmn.
        /// </summary>
        [EnumMember(Value = "LENDMN")]
        Lendmn,

        /// <summary>
        /// Linkaja.
        /// </summary>
        [EnumMember(Value = "LINKAJA")]
        Linkaja,

        /// <summary>
        /// MPaisa.
        /// </summary>
        [EnumMember(Value = "M_PAISA")]
        MPaisa,

        /// <summary>
        /// MPesa.
        /// </summary>
        [EnumMember(Value = "M_PESA")]
        MPesa,

        /// <summary>
        /// Mcash.
        /// </summary>
        [EnumMember(Value = "MCASH")]
        Mcash,

        /// <summary>
        /// MgurushMobileMoney.
        /// </summary>
        [EnumMember(Value = "MGURUSH_MOBILE_MONEY")]
        MgurushMobileMoney,

        /// <summary>
        /// Momo.
        /// </summary>
        [EnumMember(Value = "MOMO")]
        Momo,

        /// <summary>
        /// Moncash.
        /// </summary>
        [EnumMember(Value = "MONCASH")]
        Moncash,

        /// <summary>
        /// MoovMoney.
        /// </summary>
        [EnumMember(Value = "MOOV_MONEY")]
        MoovMoney,

        /// <summary>
        /// Moru.
        /// </summary>
        [EnumMember(Value = "MORU")]
        Moru,

        /// <summary>
        /// Movii.
        /// </summary>
        [EnumMember(Value = "MOVII")]
        Movii,

        /// <summary>
        /// MtnGuineaConakry.
        /// </summary>
        [EnumMember(Value = "MTN_GUINEA_CONAKRY")]
        MtnGuineaConakry,

        /// <summary>
        /// MtnMobileMoney.
        /// </summary>
        [EnumMember(Value = "MTN_MOBILE_MONEY")]
        MtnMobileMoney,

        /// <summary>
        /// Namastepay.
        /// </summary>
        [EnumMember(Value = "NAMASTEPAY")]
        Namastepay,

        /// <summary>
        /// Nayapay.
        /// </summary>
        [EnumMember(Value = "NAYAPAY")]
        Nayapay,

        /// <summary>
        /// Nequi.
        /// </summary>
        [EnumMember(Value = "NEQUI")]
        Nequi,

        /// <summary>
        /// OrangeMoney.
        /// </summary>
        [EnumMember(Value = "ORANGE_MONEY")]
        OrangeMoney,

        /// <summary>
        /// Ovo.
        /// </summary>
        [EnumMember(Value = "OVO")]
        Ovo,

        /// <summary>
        /// Paymaya.
        /// </summary>
        [EnumMember(Value = "PAYMAYA")]
        Paymaya,

        /// <summary>
        /// Paytren.
        /// </summary>
        [EnumMember(Value = "PAYTREN")]
        Paytren,

        /// <summary>
        /// PrabhuPay.
        /// </summary>
        [EnumMember(Value = "PRABHU_PAY")]
        PrabhuPay,

        /// <summary>
        /// PremierWallet.
        /// </summary>
        [EnumMember(Value = "PREMIER_WALLET")]
        PremierWallet,

        /// <summary>
        /// Qiwi.
        /// </summary>
        [EnumMember(Value = "QIWI")]
        Qiwi,

        /// <summary>
        /// Qpay.
        /// </summary>
        [EnumMember(Value = "QPAY")]
        Qpay,

        /// <summary>
        /// Sadapay.
        /// </summary>
        [EnumMember(Value = "SADAPAY")]
        Sadapay,

        /// <summary>
        /// Sajilopay.
        /// </summary>
        [EnumMember(Value = "SAJILOPAY")]
        Sajilopay,

        /// <summary>
        /// Shopeepay.
        /// </summary>
        [EnumMember(Value = "SHOPEEPAY")]
        Shopeepay,

        /// <summary>
        /// SmartcashAirtel.
        /// </summary>
        [EnumMember(Value = "SMARTCASH_AIRTEL")]
        SmartcashAirtel,

        /// <summary>
        /// Telebirr.
        /// </summary>
        [EnumMember(Value = "TELEBIRR")]
        Telebirr,

        /// <summary>
        /// TigoMoney.
        /// </summary>
        [EnumMember(Value = "TIGO_MONEY")]
        TigoMoney,

        /// <summary>
        /// TigoPesa.
        /// </summary>
        [EnumMember(Value = "TIGO_PESA")]
        TigoPesa,

        /// <summary>
        /// TngDigital.
        /// </summary>
        [EnumMember(Value = "TNG_DIGITAL")]
        TngDigital,

        /// <summary>
        /// TnmWallets.
        /// </summary>
        [EnumMember(Value = "TNM_WALLETS")]
        TnmWallets,

        /// <summary>
        /// TruemoneyWallet.
        /// </summary>
        [EnumMember(Value = "TRUEMONEY_WALLET")]
        TruemoneyWallet,

        /// <summary>
        /// Unipago.
        /// </summary>
        [EnumMember(Value = "UNIPAGO")]
        Unipago,

        /// <summary>
        /// Uwallet.
        /// </summary>
        [EnumMember(Value = "UWALLET")]
        Uwallet,

        /// <summary>
        /// Vnpay.
        /// </summary>
        [EnumMember(Value = "VNPAY")]
        Vnpay,

        /// <summary>
        /// VnptPay.
        /// </summary>
        [EnumMember(Value = "VNPT_PAY")]
        VnptPay,

        /// <summary>
        /// VodafoneMoney.
        /// </summary>
        [EnumMember(Value = "VODAFONE_MONEY")]
        VodafoneMoney,

        /// <summary>
        /// Wechatpay.
        /// </summary>
        [EnumMember(Value = "WECHATPAY")]
        Wechatpay,

        /// <summary>
        /// WingMoney.
        /// </summary>
        [EnumMember(Value = "WING_MONEY")]
        WingMoney,

        /// <summary>
        /// Yoapp.
        /// </summary>
        [EnumMember(Value = "YOAPP")]
        Yoapp,

        /// <summary>
        /// ZainCash.
        /// </summary>
        [EnumMember(Value = "ZAIN_CASH")]
        ZainCash,

        /// <summary>
        /// Zalopay.
        /// </summary>
        [EnumMember(Value = "ZALOPAY")]
        Zalopay,

        /// <summary>
        /// ZamtelMobileMoney.
        /// </summary>
        [EnumMember(Value = "ZAMTEL_MOBILE_MONEY")]
        ZamtelMobileMoney,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}