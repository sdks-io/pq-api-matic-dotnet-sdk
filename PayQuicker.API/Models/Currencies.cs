// <copyright file="Currencies.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// Currencies.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Currencies
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// Aed.
        /// </summary>
        [EnumMember(Value = "AED")]
        Aed,

        /// <summary>
        /// Afn.
        /// </summary>
        [EnumMember(Value = "AFN")]
        Afn,

        /// <summary>
        /// All.
        /// </summary>
        [EnumMember(Value = "ALL")]
        All,

        /// <summary>
        /// Amd.
        /// </summary>
        [EnumMember(Value = "AMD")]
        Amd,

        /// <summary>
        /// Ang.
        /// </summary>
        [EnumMember(Value = "ANG")]
        Ang,

        /// <summary>
        /// Aoa.
        /// </summary>
        [EnumMember(Value = "AOA")]
        Aoa,

        /// <summary>
        /// Ars.
        /// </summary>
        [EnumMember(Value = "ARS")]
        Ars,

        /// <summary>
        /// Aud.
        /// </summary>
        [EnumMember(Value = "AUD")]
        Aud,

        /// <summary>
        /// Awg.
        /// </summary>
        [EnumMember(Value = "AWG")]
        Awg,

        /// <summary>
        /// Azn.
        /// </summary>
        [EnumMember(Value = "AZN")]
        Azn,

        /// <summary>
        /// Bam.
        /// </summary>
        [EnumMember(Value = "BAM")]
        Bam,

        /// <summary>
        /// Bbd.
        /// </summary>
        [EnumMember(Value = "BBD")]
        Bbd,

        /// <summary>
        /// Bdt.
        /// </summary>
        [EnumMember(Value = "BDT")]
        Bdt,

        /// <summary>
        /// Bgn.
        /// </summary>
        [EnumMember(Value = "BGN")]
        Bgn,

        /// <summary>
        /// Bhd.
        /// </summary>
        [EnumMember(Value = "BHD")]
        Bhd,

        /// <summary>
        /// Bif.
        /// </summary>
        [EnumMember(Value = "BIF")]
        Bif,

        /// <summary>
        /// Bmd.
        /// </summary>
        [EnumMember(Value = "BMD")]
        Bmd,

        /// <summary>
        /// Bnd.
        /// </summary>
        [EnumMember(Value = "BND")]
        Bnd,

        /// <summary>
        /// Bob.
        /// </summary>
        [EnumMember(Value = "BOB")]
        Bob,

        /// <summary>
        /// Brl.
        /// </summary>
        [EnumMember(Value = "BRL")]
        Brl,

        /// <summary>
        /// Bsd.
        /// </summary>
        [EnumMember(Value = "BSD")]
        Bsd,

        /// <summary>
        /// Btn.
        /// </summary>
        [EnumMember(Value = "BTN")]
        Btn,

        /// <summary>
        /// Bwp.
        /// </summary>
        [EnumMember(Value = "BWP")]
        Bwp,

        /// <summary>
        /// Byr.
        /// </summary>
        [EnumMember(Value = "BYR")]
        Byr,

        /// <summary>
        /// Bzd.
        /// </summary>
        [EnumMember(Value = "BZD")]
        Bzd,

        /// <summary>
        /// Cad.
        /// </summary>
        [EnumMember(Value = "CAD")]
        Cad,

        /// <summary>
        /// Cdf.
        /// </summary>
        [EnumMember(Value = "CDF")]
        Cdf,

        /// <summary>
        /// Chf.
        /// </summary>
        [EnumMember(Value = "CHF")]
        Chf,

        /// <summary>
        /// Clp.
        /// </summary>
        [EnumMember(Value = "CLP")]
        Clp,

        /// <summary>
        /// Cny.
        /// </summary>
        [EnumMember(Value = "CNY")]
        Cny,

        /// <summary>
        /// Cop.
        /// </summary>
        [EnumMember(Value = "COP")]
        Cop,

        /// <summary>
        /// Crc.
        /// </summary>
        [EnumMember(Value = "CRC")]
        Crc,

        /// <summary>
        /// Cuc.
        /// </summary>
        [EnumMember(Value = "CUC")]
        Cuc,

        /// <summary>
        /// Cup.
        /// </summary>
        [EnumMember(Value = "CUP")]
        Cup,

        /// <summary>
        /// Cve.
        /// </summary>
        [EnumMember(Value = "CVE")]
        Cve,

        /// <summary>
        /// Czk.
        /// </summary>
        [EnumMember(Value = "CZK")]
        Czk,

        /// <summary>
        /// Djf.
        /// </summary>
        [EnumMember(Value = "DJF")]
        Djf,

        /// <summary>
        /// Dkk.
        /// </summary>
        [EnumMember(Value = "DKK")]
        Dkk,

        /// <summary>
        /// Dop.
        /// </summary>
        [EnumMember(Value = "DOP")]
        Dop,

        /// <summary>
        /// Dzd.
        /// </summary>
        [EnumMember(Value = "DZD")]
        Dzd,

        /// <summary>
        /// Egp.
        /// </summary>
        [EnumMember(Value = "EGP")]
        Egp,

        /// <summary>
        /// Ern.
        /// </summary>
        [EnumMember(Value = "ERN")]
        Ern,

        /// <summary>
        /// Etb.
        /// </summary>
        [EnumMember(Value = "ETB")]
        Etb,

        /// <summary>
        /// Eur.
        /// </summary>
        [EnumMember(Value = "EUR")]
        Eur,

        /// <summary>
        /// Fjd.
        /// </summary>
        [EnumMember(Value = "FJD")]
        Fjd,

        /// <summary>
        /// Fkp.
        /// </summary>
        [EnumMember(Value = "FKP")]
        Fkp,

        /// <summary>
        /// Gbp.
        /// </summary>
        [EnumMember(Value = "GBP")]
        Gbp,

        /// <summary>
        /// Gel.
        /// </summary>
        [EnumMember(Value = "GEL")]
        Gel,

        /// <summary>
        /// Ggp.
        /// </summary>
        [EnumMember(Value = "GGP")]
        Ggp,

        /// <summary>
        /// Ghs.
        /// </summary>
        [EnumMember(Value = "GHS")]
        Ghs,

        /// <summary>
        /// Gip.
        /// </summary>
        [EnumMember(Value = "GIP")]
        Gip,

        /// <summary>
        /// Gmd.
        /// </summary>
        [EnumMember(Value = "GMD")]
        Gmd,

        /// <summary>
        /// Gnf.
        /// </summary>
        [EnumMember(Value = "GNF")]
        Gnf,

        /// <summary>
        /// Gtq.
        /// </summary>
        [EnumMember(Value = "GTQ")]
        Gtq,

        /// <summary>
        /// Gyd.
        /// </summary>
        [EnumMember(Value = "GYD")]
        Gyd,

        /// <summary>
        /// Hkd.
        /// </summary>
        [EnumMember(Value = "HKD")]
        Hkd,

        /// <summary>
        /// Hnl.
        /// </summary>
        [EnumMember(Value = "HNL")]
        Hnl,

        /// <summary>
        /// Hrk.
        /// </summary>
        [EnumMember(Value = "HRK")]
        Hrk,

        /// <summary>
        /// Htg.
        /// </summary>
        [EnumMember(Value = "HTG")]
        Htg,

        /// <summary>
        /// Huf.
        /// </summary>
        [EnumMember(Value = "HUF")]
        Huf,

        /// <summary>
        /// Idr.
        /// </summary>
        [EnumMember(Value = "IDR")]
        Idr,

        /// <summary>
        /// Ils.
        /// </summary>
        [EnumMember(Value = "ILS")]
        Ils,

        /// <summary>
        /// Imp.
        /// </summary>
        [EnumMember(Value = "IMP")]
        Imp,

        /// <summary>
        /// Inr.
        /// </summary>
        [EnumMember(Value = "INR")]
        Inr,

        /// <summary>
        /// Iqd.
        /// </summary>
        [EnumMember(Value = "IQD")]
        Iqd,

        /// <summary>
        /// Irr.
        /// </summary>
        [EnumMember(Value = "IRR")]
        Irr,

        /// <summary>
        /// Isk.
        /// </summary>
        [EnumMember(Value = "ISK")]
        Isk,

        /// <summary>
        /// Jep.
        /// </summary>
        [EnumMember(Value = "JEP")]
        Jep,

        /// <summary>
        /// Jmd.
        /// </summary>
        [EnumMember(Value = "JMD")]
        Jmd,

        /// <summary>
        /// Jod.
        /// </summary>
        [EnumMember(Value = "JOD")]
        Jod,

        /// <summary>
        /// Jpy.
        /// </summary>
        [EnumMember(Value = "JPY")]
        Jpy,

        /// <summary>
        /// Kes.
        /// </summary>
        [EnumMember(Value = "KES")]
        Kes,

        /// <summary>
        /// Kgs.
        /// </summary>
        [EnumMember(Value = "KGS")]
        Kgs,

        /// <summary>
        /// Khr.
        /// </summary>
        [EnumMember(Value = "KHR")]
        Khr,

        /// <summary>
        /// Kmf.
        /// </summary>
        [EnumMember(Value = "KMF")]
        Kmf,

        /// <summary>
        /// Kpw.
        /// </summary>
        [EnumMember(Value = "KPW")]
        Kpw,

        /// <summary>
        /// Krw.
        /// </summary>
        [EnumMember(Value = "KRW")]
        Krw,

        /// <summary>
        /// Kwd.
        /// </summary>
        [EnumMember(Value = "KWD")]
        Kwd,

        /// <summary>
        /// Kyd.
        /// </summary>
        [EnumMember(Value = "KYD")]
        Kyd,

        /// <summary>
        /// Kzt.
        /// </summary>
        [EnumMember(Value = "KZT")]
        Kzt,

        /// <summary>
        /// Lak.
        /// </summary>
        [EnumMember(Value = "LAK")]
        Lak,

        /// <summary>
        /// Lbp.
        /// </summary>
        [EnumMember(Value = "LBP")]
        Lbp,

        /// <summary>
        /// Lkr.
        /// </summary>
        [EnumMember(Value = "LKR")]
        Lkr,

        /// <summary>
        /// Lrd.
        /// </summary>
        [EnumMember(Value = "LRD")]
        Lrd,

        /// <summary>
        /// Lsl.
        /// </summary>
        [EnumMember(Value = "LSL")]
        Lsl,

        /// <summary>
        /// Lyd.
        /// </summary>
        [EnumMember(Value = "LYD")]
        Lyd,

        /// <summary>
        /// Mad.
        /// </summary>
        [EnumMember(Value = "MAD")]
        Mad,

        /// <summary>
        /// Mdl.
        /// </summary>
        [EnumMember(Value = "MDL")]
        Mdl,

        /// <summary>
        /// Mga.
        /// </summary>
        [EnumMember(Value = "MGA")]
        Mga,

        /// <summary>
        /// Mkd.
        /// </summary>
        [EnumMember(Value = "MKD")]
        Mkd,

        /// <summary>
        /// Mmk.
        /// </summary>
        [EnumMember(Value = "MMK")]
        Mmk,

        /// <summary>
        /// Mnt.
        /// </summary>
        [EnumMember(Value = "MNT")]
        Mnt,

        /// <summary>
        /// Mop.
        /// </summary>
        [EnumMember(Value = "MOP")]
        Mop,

        /// <summary>
        /// Mro.
        /// </summary>
        [EnumMember(Value = "MRO")]
        Mro,

        /// <summary>
        /// Mur.
        /// </summary>
        [EnumMember(Value = "MUR")]
        Mur,

        /// <summary>
        /// Mvr.
        /// </summary>
        [EnumMember(Value = "MVR")]
        Mvr,

        /// <summary>
        /// Mwk.
        /// </summary>
        [EnumMember(Value = "MWK")]
        Mwk,

        /// <summary>
        /// Mxn.
        /// </summary>
        [EnumMember(Value = "MXN")]
        Mxn,

        /// <summary>
        /// Myr.
        /// </summary>
        [EnumMember(Value = "MYR")]
        Myr,

        /// <summary>
        /// Mzn.
        /// </summary>
        [EnumMember(Value = "MZN")]
        Mzn,

        /// <summary>
        /// Nad.
        /// </summary>
        [EnumMember(Value = "NAD")]
        Nad,

        /// <summary>
        /// Ngn.
        /// </summary>
        [EnumMember(Value = "NGN")]
        Ngn,

        /// <summary>
        /// Nio.
        /// </summary>
        [EnumMember(Value = "NIO")]
        Nio,

        /// <summary>
        /// Nok.
        /// </summary>
        [EnumMember(Value = "NOK")]
        Nok,

        /// <summary>
        /// Npr.
        /// </summary>
        [EnumMember(Value = "NPR")]
        Npr,

        /// <summary>
        /// Nzd.
        /// </summary>
        [EnumMember(Value = "NZD")]
        Nzd,

        /// <summary>
        /// Omr.
        /// </summary>
        [EnumMember(Value = "OMR")]
        Omr,

        /// <summary>
        /// Pab.
        /// </summary>
        [EnumMember(Value = "PAB")]
        Pab,

        /// <summary>
        /// Pen.
        /// </summary>
        [EnumMember(Value = "PEN")]
        Pen,

        /// <summary>
        /// Pgk.
        /// </summary>
        [EnumMember(Value = "PGK")]
        Pgk,

        /// <summary>
        /// Php.
        /// </summary>
        [EnumMember(Value = "PHP")]
        Php,

        /// <summary>
        /// Pkr.
        /// </summary>
        [EnumMember(Value = "PKR")]
        Pkr,

        /// <summary>
        /// Pln.
        /// </summary>
        [EnumMember(Value = "PLN")]
        Pln,

        /// <summary>
        /// Pyg.
        /// </summary>
        [EnumMember(Value = "PYG")]
        Pyg,

        /// <summary>
        /// Qar.
        /// </summary>
        [EnumMember(Value = "QAR")]
        Qar,

        /// <summary>
        /// Ron.
        /// </summary>
        [EnumMember(Value = "RON")]
        Ron,

        /// <summary>
        /// Rsd.
        /// </summary>
        [EnumMember(Value = "RSD")]
        Rsd,

        /// <summary>
        /// Rub.
        /// </summary>
        [EnumMember(Value = "RUB")]
        Rub,

        /// <summary>
        /// Rwf.
        /// </summary>
        [EnumMember(Value = "RWF")]
        Rwf,

        /// <summary>
        /// Sar.
        /// </summary>
        [EnumMember(Value = "SAR")]
        Sar,

        /// <summary>
        /// Sbd.
        /// </summary>
        [EnumMember(Value = "SBD")]
        Sbd,

        /// <summary>
        /// Scr.
        /// </summary>
        [EnumMember(Value = "SCR")]
        Scr,

        /// <summary>
        /// Sdg.
        /// </summary>
        [EnumMember(Value = "SDG")]
        Sdg,

        /// <summary>
        /// Sek.
        /// </summary>
        [EnumMember(Value = "SEK")]
        Sek,

        /// <summary>
        /// Sgd.
        /// </summary>
        [EnumMember(Value = "SGD")]
        Sgd,

        /// <summary>
        /// Shp.
        /// </summary>
        [EnumMember(Value = "SHP")]
        Shp,

        /// <summary>
        /// Sll.
        /// </summary>
        [EnumMember(Value = "SLL")]
        Sll,

        /// <summary>
        /// Sos.
        /// </summary>
        [EnumMember(Value = "SOS")]
        Sos,

        /// <summary>
        /// Spl.
        /// </summary>
        [EnumMember(Value = "SPL")]
        Spl,

        /// <summary>
        /// Srd.
        /// </summary>
        [EnumMember(Value = "SRD")]
        Srd,

        /// <summary>
        /// Std.
        /// </summary>
        [EnumMember(Value = "STD")]
        Std,

        /// <summary>
        /// Svc.
        /// </summary>
        [EnumMember(Value = "SVC")]
        Svc,

        /// <summary>
        /// Syp.
        /// </summary>
        [EnumMember(Value = "SYP")]
        Syp,

        /// <summary>
        /// Szl.
        /// </summary>
        [EnumMember(Value = "SZL")]
        Szl,

        /// <summary>
        /// Thb.
        /// </summary>
        [EnumMember(Value = "THB")]
        Thb,

        /// <summary>
        /// Tjs.
        /// </summary>
        [EnumMember(Value = "TJS")]
        Tjs,

        /// <summary>
        /// Tmt.
        /// </summary>
        [EnumMember(Value = "TMT")]
        Tmt,

        /// <summary>
        /// Tnd.
        /// </summary>
        [EnumMember(Value = "TND")]
        Tnd,

        /// <summary>
        /// Top.
        /// </summary>
        [EnumMember(Value = "TOP")]
        Top,

        /// <summary>
        /// Try.
        /// </summary>
        [EnumMember(Value = "TRY")]
        Try,

        /// <summary>
        /// Ttd.
        /// </summary>
        [EnumMember(Value = "TTD")]
        Ttd,

        /// <summary>
        /// Tvd.
        /// </summary>
        [EnumMember(Value = "TVD")]
        Tvd,

        /// <summary>
        /// Twd.
        /// </summary>
        [EnumMember(Value = "TWD")]
        Twd,

        /// <summary>
        /// Tzs.
        /// </summary>
        [EnumMember(Value = "TZS")]
        Tzs,

        /// <summary>
        /// Uah.
        /// </summary>
        [EnumMember(Value = "UAH")]
        Uah,

        /// <summary>
        /// Ugx.
        /// </summary>
        [EnumMember(Value = "UGX")]
        Ugx,

        /// <summary>
        /// Usd.
        /// </summary>
        [EnumMember(Value = "USD")]
        Usd,

        /// <summary>
        /// Uyu.
        /// </summary>
        [EnumMember(Value = "UYU")]
        Uyu,

        /// <summary>
        /// Uzs.
        /// </summary>
        [EnumMember(Value = "UZS")]
        Uzs,

        /// <summary>
        /// Vef.
        /// </summary>
        [EnumMember(Value = "VEF")]
        Vef,

        /// <summary>
        /// Vnd.
        /// </summary>
        [EnumMember(Value = "VND")]
        Vnd,

        /// <summary>
        /// Vuv.
        /// </summary>
        [EnumMember(Value = "VUV")]
        Vuv,

        /// <summary>
        /// Wst.
        /// </summary>
        [EnumMember(Value = "WST")]
        Wst,

        /// <summary>
        /// Xaf.
        /// </summary>
        [EnumMember(Value = "XAF")]
        Xaf,

        /// <summary>
        /// Xcd.
        /// </summary>
        [EnumMember(Value = "XCD")]
        Xcd,

        /// <summary>
        /// Xdr.
        /// </summary>
        [EnumMember(Value = "XDR")]
        Xdr,

        /// <summary>
        /// Xof.
        /// </summary>
        [EnumMember(Value = "XOF")]
        Xof,

        /// <summary>
        /// Xpf.
        /// </summary>
        [EnumMember(Value = "XPF")]
        Xpf,

        /// <summary>
        /// Yer.
        /// </summary>
        [EnumMember(Value = "YER")]
        Yer,

        /// <summary>
        /// Zar.
        /// </summary>
        [EnumMember(Value = "ZAR")]
        Zar,

        /// <summary>
        /// Zmw.
        /// </summary>
        [EnumMember(Value = "ZMW")]
        Zmw,

        /// <summary>
        /// Zwd.
        /// </summary>
        [EnumMember(Value = "ZWD")]
        Zwd,

        /// <summary>
        /// Cnh.
        /// </summary>
        [EnumMember(Value = "CNH")]
        Cnh,

        /// <summary>
        /// Cxx.
        /// </summary>
        [EnumMember(Value = "CXX")]
        Cxx,

        /// <summary>
        /// Mru.
        /// </summary>
        [EnumMember(Value = "MRU")]
        Mru,

        /// <summary>
        /// Sle.
        /// </summary>
        [EnumMember(Value = "SLE")]
        Sle,

        /// <summary>
        /// Ssp.
        /// </summary>
        [EnumMember(Value = "SSP")]
        Ssp
    }
}