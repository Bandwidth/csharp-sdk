// <copyright file="ForbiddenRequestException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.MultiFactorAuth.Exceptions
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
    using Bandwidth.Standard.MultiFactorAuth.Models;
    using Bandwidth.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ForbiddenRequestException.
    /// </summary>
    public class ForbiddenRequestException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenRequestException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ForbiddenRequestException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// The message containing the reason behind the request being forbidden
        /// </summary>
        [JsonProperty("Message", NullValueHandling = NullValueHandling.Ignore)]
        public new string Message { get; set; }
    }
}