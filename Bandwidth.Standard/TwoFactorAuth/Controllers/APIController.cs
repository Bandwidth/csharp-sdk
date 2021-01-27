/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Bandwidth.Standard;
using Bandwidth.Standard.Utilities;
using Bandwidth.Standard.Http.Request;
using Bandwidth.Standard.Http.Response;
using Bandwidth.Standard.Http.Client;
using Bandwidth.Standard.Authentication;
using Bandwidth.Standard.TwoFactorAuth.Exceptions;

namespace Bandwidth.Standard.TwoFactorAuth.Controllers
{
    public class APIController : BaseController
    {
        internal APIController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null) :
            base(config, httpClient, authManagers, httpCallBack)
        { }

        /// <summary>
        /// Two-Factor authentication with Bandwidth Voice services
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Voice service enabled</param>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the ApiResponse<Models.TwoFactorVoiceResponse> response from the API call</return>
        public ApiResponse<Models.TwoFactorVoiceResponse> CreateVoiceTwoFactor(string accountId, Models.TwoFactorCodeRequestSchema body)
        {
            Task<ApiResponse<Models.TwoFactorVoiceResponse>> t = CreateVoiceTwoFactorAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Two-Factor authentication with Bandwidth Voice services
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Voice service enabled</param>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the ApiResponse<Models.TwoFactorVoiceResponse> response from the API call</return>
        public async Task<ApiResponse<Models.TwoFactorVoiceResponse>> CreateVoiceTwoFactorAsync(string accountId, Models.TwoFactorCodeRequestSchema body, CancellationToken cancellationToken = default)
        {
            //the base uri for api requests
            string _baseUri = config.GetBaseUri(Server.TwoFactorAuthDefault);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/code/voice");

            //process optional template parameters
            ApiHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string, string>()
            {
                { "user-agent", userAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = ApiHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = GetClientInstance().PostBody(_queryBuilder.ToString(), _headers, _body);
            if (HttpCallBack != null)
            {
                HttpCallBack.OnBeforeHttpRequestEventHandler(GetClientInstance(), _request);
            }

            _request = await authManagers["twoFactorAuth"].ApplyAsync(_request).ConfigureAwait(false);

            //invoke request and get response
            HttpStringResponse _response = await GetClientInstance().ExecuteAsStringAsync(_request, cancellationToken).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request, _response);
            if (HttpCallBack != null)
            {
                HttpCallBack.OnAfterHttpResponseEventHandler(GetClientInstance(), _response);
            }


            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
            {
                throw new InvalidRequestException("client request error", _context);
            }

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            var _result = ApiHelper.JsonDeserialize<Models.TwoFactorVoiceResponse>(_response.Body);
            ApiResponse<Models.TwoFactorVoiceResponse> apiResponse = new ApiResponse<Models.TwoFactorVoiceResponse>(_response.StatusCode, _response.Headers, _result);
            return apiResponse;
        }

        /// <summary>
        /// Two-Factor authentication with Bandwidth messaging services
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Messaging service enabled</param>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the ApiResponse<Models.TwoFactorMessagingResponse> response from the API call</return>
        public ApiResponse<Models.TwoFactorMessagingResponse> CreateMessagingTwoFactor(string accountId, Models.TwoFactorCodeRequestSchema body)
        {
            Task<ApiResponse<Models.TwoFactorMessagingResponse>> t = CreateMessagingTwoFactorAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Two-Factor authentication with Bandwidth messaging services
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Messaging service enabled</param>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the ApiResponse<Models.TwoFactorMessagingResponse> response from the API call</return>
        public async Task<ApiResponse<Models.TwoFactorMessagingResponse>> CreateMessagingTwoFactorAsync(string accountId, Models.TwoFactorCodeRequestSchema body, CancellationToken cancellationToken = default)
        {
            //the base uri for api requests
            string _baseUri = config.GetBaseUri(Server.TwoFactorAuthDefault);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/code/messaging");

            //process optional template parameters
            ApiHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string, string>()
            {
                { "user-agent", userAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = ApiHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = GetClientInstance().PostBody(_queryBuilder.ToString(), _headers, _body);
            if (HttpCallBack != null)
            {
                HttpCallBack.OnBeforeHttpRequestEventHandler(GetClientInstance(), _request);
            }

            _request = await authManagers["twoFactorAuth"].ApplyAsync(_request).ConfigureAwait(false);

            //invoke request and get response
            HttpStringResponse _response = await GetClientInstance().ExecuteAsStringAsync(_request, cancellationToken).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request, _response);
            if (HttpCallBack != null)
            {
                HttpCallBack.OnAfterHttpResponseEventHandler(GetClientInstance(), _response);
            }


            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
            {
                throw new InvalidRequestException("client request error", _context);
            }

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            var _result = ApiHelper.JsonDeserialize<Models.TwoFactorMessagingResponse>(_response.Body);
            ApiResponse<Models.TwoFactorMessagingResponse> apiResponse = new ApiResponse<Models.TwoFactorMessagingResponse>(_response.StatusCode, _response.Headers, _result);
            return apiResponse;
        }

        /// <summary>
        /// Verify a previously sent two-factor authentication code
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Two-Factor enabled</param>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the ApiResponse<Models.TwoFactorVerifyCodeResponse> response from the API call</return>
        public ApiResponse<Models.TwoFactorVerifyCodeResponse> CreateVerifyTwoFactor(string accountId, Models.TwoFactorVerifyRequestSchema body)
        {
            Task<ApiResponse<Models.TwoFactorVerifyCodeResponse>> t = CreateVerifyTwoFactorAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Verify a previously sent two-factor authentication code
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Two-Factor enabled</param>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the ApiResponse<Models.TwoFactorVerifyCodeResponse> response from the API call</return>
        public async Task<ApiResponse<Models.TwoFactorVerifyCodeResponse>> CreateVerifyTwoFactorAsync(string accountId, Models.TwoFactorVerifyRequestSchema body, CancellationToken cancellationToken = default)
        {
            //the base uri for api requests
            string _baseUri = config.GetBaseUri(Server.TwoFactorAuthDefault);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountId}/code/verify");

            //process optional template parameters
            ApiHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId }
            });

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string, string>()
            {
                { "user-agent", userAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = ApiHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = GetClientInstance().PostBody(_queryBuilder.ToString(), _headers, _body);
            if (HttpCallBack != null)
            {
                HttpCallBack.OnBeforeHttpRequestEventHandler(GetClientInstance(), _request);
            }

            _request = await authManagers["twoFactorAuth"].ApplyAsync(_request).ConfigureAwait(false);

            //invoke request and get response
            HttpStringResponse _response = await GetClientInstance().ExecuteAsStringAsync(_request, cancellationToken).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request, _response);
            if (HttpCallBack != null)
            {
                HttpCallBack.OnAfterHttpResponseEventHandler(GetClientInstance(), _response);
            }


            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
            {
                throw new InvalidRequestException("client request error", _context);
            }

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            var _result = ApiHelper.JsonDeserialize<Models.TwoFactorVerifyCodeResponse>(_response.Body);
            ApiResponse<Models.TwoFactorVerifyCodeResponse> apiResponse = new ApiResponse<Models.TwoFactorVerifyCodeResponse>(_response.StatusCode, _response.Headers, _result);
            return apiResponse;
        }

    }
}