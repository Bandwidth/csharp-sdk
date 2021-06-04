// <copyright file="UnauthorizedRequestException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.TwoFactorAuth.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Bandwidth.Standard;
    using Bandwidth.Standard.Exceptions;
    using Bandwidth.Standard.Http.Client;
    using Bandwidth.Standard.TwoFactorAuth.Models;
    using Bandwidth.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// UnauthorizedRequestException.
    /// </summary>
    public class UnauthorizedRequestException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedRequestException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public UnauthorizedRequestException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// The message containing the reason behind the request being unauthorized
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public new string Message { get; set; }
    }
}