// <copyright file="RedirectFallbackMethodEnum.cs" company="APIMatic">
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
    /// RedirectFallbackMethodEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RedirectFallbackMethodEnum
    {
        /// <summary>
        /// POST.
        /// </summary>
        [EnumMember(Value = "POST")]
        POST,

        /// <summary>
        /// GET.
        /// </summary>
        [EnumMember(Value = "GET")]
        GET,
    }
}