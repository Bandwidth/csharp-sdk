// <copyright file="ApiResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Http.Response
{
    using System.Collections.Generic;

    /// <summary>
    /// ApiResponse Class.
    /// </summary>
    /// <typeparam name="T"> Generic type.</typeparam>
    public class ApiResponse<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="statusCode">Status code.</param>
        /// <param name="headers">Headers.</param>
        /// <param name="data">Data.</param>
        public ApiResponse(int statusCode, Dictionary<string, string> headers, T data)
        {
            this.StatusCode = statusCode;
            this.Headers = headers;
            this.Data = data;
        }

        /// <summary>
        /// Gets the HTTP Status code of the http response.
        /// </summary>
        public int StatusCode { get; }

        /// <summary>
        /// Gets the headers of the http response.
        /// </summary>
        public Dictionary<string, string> Headers { get; }

        /// <summary>
        /// Gets the deserialized body of the http response.
        /// </summary>
        public T Data { get; }
    }
}