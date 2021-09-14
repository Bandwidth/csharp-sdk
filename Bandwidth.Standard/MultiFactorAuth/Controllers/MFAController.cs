// <copyright file="MFAController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.MultiFactorAuth.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Bandwidth.Standard;
    using Bandwidth.Standard.Authentication;
    using Bandwidth.Standard.Http.Client;
    using Bandwidth.Standard.Http.Request;
    using Bandwidth.Standard.Http.Response;
    using Bandwidth.Standard.MultiFactorAuth.Exceptions;
    using Bandwidth.Standard.Utilities;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// MFAController.
    /// </summary>
    public class MFAController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MFAController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal MFAController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Multi-Factor authentication with Bandwidth Voice services. Allows for a user to send an MFA code via a phone call.
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Voice service enabled.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.TwoFactorVoiceResponse response from the API call.</returns>
        public ApiResponse<Models.TwoFactorVoiceResponse> CreateVoiceTwoFactor(
                string accountId,
                Models.TwoFactorCodeRequestSchema body)
        {
            Task<ApiResponse<Models.TwoFactorVoiceResponse>> t = this.CreateVoiceTwoFactorAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Multi-Factor authentication with Bandwidth Voice services. Allows for a user to send an MFA code via a phone call.
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Voice service enabled.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TwoFactorVoiceResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TwoFactorVoiceResponse>> CreateVoiceTwoFactorAsync(
                string accountId,
                Models.TwoFactorCodeRequestSchema body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MultiFactorAuthDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/code/voice");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["multiFactorAuth"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ErrorWithRequestException("If there is any issue with values passed in by the user", context);
            }

            if (response.StatusCode == 401)
            {
                throw new UnauthorizedRequestException("Authentication is either incorrect or not present", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ForbiddenRequestException("The user is not authorized to access this resource", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ErrorWithRequestException("An internal server error occurred", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.TwoFactorVoiceResponse>(response.Body);
            ApiResponse<Models.TwoFactorVoiceResponse> apiResponse = new ApiResponse<Models.TwoFactorVoiceResponse>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Multi-Factor authentication with Bandwidth Messaging services. Allows a user to send an MFA code via a text message (SMS).
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Messaging service enabled.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.TwoFactorMessagingResponse response from the API call.</returns>
        public ApiResponse<Models.TwoFactorMessagingResponse> CreateMessagingTwoFactor(
                string accountId,
                Models.TwoFactorCodeRequestSchema body)
        {
            Task<ApiResponse<Models.TwoFactorMessagingResponse>> t = this.CreateMessagingTwoFactorAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Multi-Factor authentication with Bandwidth Messaging services. Allows a user to send an MFA code via a text message (SMS).
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Messaging service enabled.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TwoFactorMessagingResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TwoFactorMessagingResponse>> CreateMessagingTwoFactorAsync(
                string accountId,
                Models.TwoFactorCodeRequestSchema body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MultiFactorAuthDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/code/messaging");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["multiFactorAuth"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ErrorWithRequestException("If there is any issue with values passed in by the user", context);
            }

            if (response.StatusCode == 401)
            {
                throw new UnauthorizedRequestException("Authentication is either incorrect or not present", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ForbiddenRequestException("The user is not authorized to access this resource", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ErrorWithRequestException("An internal server error occurred", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.TwoFactorMessagingResponse>(response.Body);
            ApiResponse<Models.TwoFactorMessagingResponse> apiResponse = new ApiResponse<Models.TwoFactorMessagingResponse>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Allows a user to verify an MFA code.
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Two-Factor enabled.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.TwoFactorVerifyCodeResponse response from the API call.</returns>
        public ApiResponse<Models.TwoFactorVerifyCodeResponse> CreateVerifyTwoFactor(
                string accountId,
                Models.TwoFactorVerifyRequestSchema body)
        {
            Task<ApiResponse<Models.TwoFactorVerifyCodeResponse>> t = this.CreateVerifyTwoFactorAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Allows a user to verify an MFA code.
        /// </summary>
        /// <param name="accountId">Required parameter: Bandwidth Account ID with Two-Factor enabled.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TwoFactorVerifyCodeResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TwoFactorVerifyCodeResponse>> CreateVerifyTwoFactorAsync(
                string accountId,
                Models.TwoFactorVerifyRequestSchema body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MultiFactorAuthDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/code/verify");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["multiFactorAuth"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ErrorWithRequestException("If there is any issue with values passed in by the user", context);
            }

            if (response.StatusCode == 401)
            {
                throw new UnauthorizedRequestException("Authentication is either incorrect or not present", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ForbiddenRequestException("The user is not authorized to access this resource", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ErrorWithRequestException("The user has made too many bad requests and is temporarily locked out", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ErrorWithRequestException("An internal server error occurred", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.TwoFactorVerifyCodeResponse>(response.Body);
            ApiResponse<Models.TwoFactorVerifyCodeResponse> apiResponse = new ApiResponse<Models.TwoFactorVerifyCodeResponse>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }
    }
}