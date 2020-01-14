using System.Collections.Generic;

namespace Bandwidth.Standard.Http.Response
{
    public class ApiResponse<T>
    {
        /// <summary>
        /// HTTP Status code of the http response
        /// </summary>
        public int StatusCode { get; }
        
        /// <summary>
        /// Headers of the http response
        /// </summary>
        public Dictionary<string, string> Headers { get; }
        
        /// <summary>
        /// The deserialized body of the http response
        /// </summary>
        public T Data { get; }
    
        public ApiResponse(int statusCode, Dictionary<string, string> headers, T data) 
        {
            this.StatusCode = statusCode;
            this.Headers = headers;
            this.Data = data;
        }
    }
}