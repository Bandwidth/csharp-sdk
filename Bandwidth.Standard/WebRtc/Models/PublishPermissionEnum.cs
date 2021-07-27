// <copyright file="PublishPermissionEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.WebRtc.Models
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
    /// PublishPermissionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublishPermissionEnum
    {
        /// <summary>
        /// AUDIO.
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO,

        /// <summary>
        /// VIDEO.
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO,
    }
}