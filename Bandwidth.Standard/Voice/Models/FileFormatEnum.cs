// <copyright file="FileFormatEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Voice.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Bandwidth.Standard;
    using Bandwidth.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// FileFormatEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileFormatEnum
    {
        /// <summary>
        /// Mp3.
        /// </summary>
        [EnumMember(Value = "mp3")]
        Mp3,

        /// <summary>
        /// Wav.
        /// </summary>
        [EnumMember(Value = "wav")]
        Wav,
    }
}