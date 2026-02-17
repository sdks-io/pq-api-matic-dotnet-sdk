// <copyright file="Languages.cs" company="APIMatic">
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
    /// Languages.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Languages
    {
        /// <summary>
        ///Czech
        /// CsCz.
        /// </summary>
        [EnumMember(Value = "cs-CZ")]
        CsCz,

        /// <summary>
        ///German
        /// DeDe.
        /// </summary>
        [EnumMember(Value = "de-DE")]
        DeDe,

        /// <summary>
        ///English (UK)
        /// EnGb.
        /// </summary>
        [EnumMember(Value = "en-GB")]
        EnGb,

        /// <summary>
        ///English (US)
        /// EnUs.
        /// </summary>
        [EnumMember(Value = "en-US")]
        EnUs,

        /// <summary>
        ///Spanish (Spain)
        /// EsEs.
        /// </summary>
        [EnumMember(Value = "es-ES")]
        EsEs,

        /// <summary>
        ///Spanish (Mexico)
        /// EsMx.
        /// </summary>
        [EnumMember(Value = "es-MX")]
        EsMx,

        /// <summary>
        ///French (Canadian)
        /// FrCa.
        /// </summary>
        [EnumMember(Value = "fr-CA")]
        FrCa,

        /// <summary>
        ///French (France)
        /// FrFr.
        /// </summary>
        [EnumMember(Value = "fr-FR")]
        FrFr,

        /// <summary>
        ///Italian
        /// ItIt.
        /// </summary>
        [EnumMember(Value = "it-IT")]
        ItIt,

        /// <summary>
        ///I bet you already know
        /// JaJp.
        /// </summary>
        [EnumMember(Value = "ja-JP")]
        JaJp,

        /// <summary>
        ///Korea
        /// KoKr.
        /// </summary>
        [EnumMember(Value = "ko-KR")]
        KoKr,

        /// <summary>
        ///Dutch
        /// NlNl.
        /// </summary>
        [EnumMember(Value = "nl-NL")]
        NlNl,

        /// <summary>
        ///Polish
        /// PlPl.
        /// </summary>
        [EnumMember(Value = "pl-PL")]
        PlPl,

        /// <summary>
        ///Portuguese (Brazil)
        /// PtBr.
        /// </summary>
        [EnumMember(Value = "pt-BR")]
        PtBr,

        /// <summary>
        ///Portuguese (Portugal)
        /// PtPt.
        /// </summary>
        [EnumMember(Value = "pt-PT")]
        PtPt,

        /// <summary>
        ///Russian
        /// RuRu.
        /// </summary>
        [EnumMember(Value = "ru-RU")]
        RuRu,

        /// <summary>
        ///Chinese (Simplified)
        /// ZhHans.
        /// </summary>
        [EnumMember(Value = "zh-Hans")]
        ZhHans,

        /// <summary>
        ///Chinese (Traditional)
        /// ZhHant.
        /// </summary>
        [EnumMember(Value = "zh-Hant")]
        ZhHant
    }
}