// <copyright file="ModeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Voice.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ModeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisplayNameEnum
    {
        /// <summary>
        /// Restricted.
        /// </summary>
        [EnumMember(Value = "Restricted")]
        Restricted,

        /// <summary>
        /// Anonymous.
        /// </summary>
        [EnumMember(Value = "Anonymous")]
        Anonymous,

        /// <summary>
        /// Private.
        /// </summary>
        [EnumMember(Value = "Private")]
        Private,

        /// <summary>
        /// Unavailable.
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,
    }
}
