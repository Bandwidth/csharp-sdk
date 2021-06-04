// <copyright file="DeviceApiVersionEnum.cs" company="APIMatic">
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
    /// DeviceApiVersionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceApiVersionEnum
    {
        /// <summary>
        /// V3.
        /// </summary>
        [EnumMember(Value = "V3")]
        V3,

        /// <summary>
        /// V2.
        /// </summary>
        [EnumMember(Value = "V2")]
        V2,
    }
}