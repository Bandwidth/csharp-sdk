// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Voice.Controllers
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
    using Bandwidth.Standard.Exceptions;
    using Bandwidth.Standard.Http.Client;
    using Bandwidth.Standard.Http.Request;
    using Bandwidth.Standard.Http.Response;
    using Bandwidth.Standard.Utilities;
    using Bandwidth.Standard.Voice.Exceptions;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal APIController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Creates an outbound phone call.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.CreateCallResponse response from the API call.</returns>
        public ApiResponse<Models.CreateCallResponse> CreateCall(
                string accountId,
                Models.CreateCallRequest body)
        {
            Task<ApiResponse<Models.CreateCallResponse>> t = this.CreateCallAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates an outbound phone call.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CreateCallResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.CreateCallResponse>> CreateCallAsync(
                string accountId,
                Models.CreateCallRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls");

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

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.CreateCallResponse>(response.Body);
            ApiResponse<Models.CreateCallResponse> apiResponse = new ApiResponse<Models.CreateCallResponse>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Returns near-realtime metadata about the specified call.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.CallState response from the API call.</returns>
        public ApiResponse<Models.CallState> GetCall(
                string accountId,
                string callId)
        {
            Task<ApiResponse<Models.CallState>> t = this.GetCallAsync(accountId, callId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns near-realtime metadata about the specified call.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CallState response from the API call.</returns>
        public async Task<ApiResponse<Models.CallState>> GetCallAsync(
                string accountId,
                string callId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.CallState>(response.Body);
            ApiResponse<Models.CallState> apiResponse = new ApiResponse<Models.CallState>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Interrupts and replaces an active call's BXML document.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        public void ModifyCall(
                string accountId,
                string callId,
                Models.ModifyCallRequest body)
        {
            Task t = this.ModifyCallAsync(accountId, callId, body);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Interrupts and replaces an active call's BXML document.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ModifyCallAsync(
                string accountId,
                string callId,
                Models.ModifyCallRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
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

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Pauses or resumes a recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        public void ModifyCallRecordingState(
                string accountId,
                string callId,
                Models.ModifyCallRecordingRequest body)
        {
            Task t = this.ModifyCallRecordingStateAsync(accountId, callId, body);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Pauses or resumes a recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ModifyCallRecordingStateAsync(
                string accountId,
                string callId,
                Models.ModifyCallRecordingRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recording");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Returns a (potentially empty) list of metadata for the recordings that took place during the specified call.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of List<Models.CallRecordingMetadata> response from the API call.</returns>
        public ApiResponse<List<Models.CallRecordingMetadata>> GetCallRecordings(
                string accountId,
                string callId)
        {
            Task<ApiResponse<List<Models.CallRecordingMetadata>>> t = this.GetCallRecordingsAsync(accountId, callId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns a (potentially empty) list of metadata for the recordings that took place during the specified call.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.CallRecordingMetadata> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.CallRecordingMetadata>>> GetCallRecordingsAsync(
                string accountId,
                string callId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recordings");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<List<Models.CallRecordingMetadata>>(response.Body);
            ApiResponse<List<Models.CallRecordingMetadata>> apiResponse = new ApiResponse<List<Models.CallRecordingMetadata>>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Returns metadata for the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.CallRecordingMetadata response from the API call.</returns>
        public ApiResponse<Models.CallRecordingMetadata> GetCallRecording(
                string accountId,
                string callId,
                string recordingId)
        {
            Task<ApiResponse<Models.CallRecordingMetadata>> t = this.GetCallRecordingAsync(accountId, callId, recordingId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns metadata for the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CallRecordingMetadata response from the API call.</returns>
        public async Task<ApiResponse<Models.CallRecordingMetadata>> GetCallRecordingAsync(
                string accountId,
                string callId,
                string recordingId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recordings/{recordingId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.CallRecordingMetadata>(response.Body);
            ApiResponse<Models.CallRecordingMetadata> apiResponse = new ApiResponse<Models.CallRecordingMetadata>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Deletes the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        public void DeleteRecording(
                string accountId,
                string callId,
                string recordingId)
        {
            Task t = this.DeleteRecordingAsync(accountId, callId, recordingId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Deletes the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteRecordingAsync(
                string accountId,
                string callId,
                string recordingId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recordings/{recordingId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Delete(queryBuilder.ToString(), headers, null);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Downloads the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of dynamic response from the API call.</returns>
        public ApiResponse<dynamic> GetDownloadCallRecording(
                string accountId,
                string callId,
                string recordingId)
        {
            Task<ApiResponse<dynamic>> t = this.GetDownloadCallRecordingAsync(accountId, callId, recordingId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Downloads the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of dynamic response from the API call.</returns>
        public async Task<ApiResponse<dynamic>> GetDownloadCallRecordingAsync(
                string accountId,
                string callId,
                string recordingId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recordings/{recordingId}/media");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = response.RawBody;
            ApiResponse<dynamic> apiResponse = new ApiResponse<dynamic>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Deletes the specified recording's media.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        public void DeleteRecordingMedia(
                string accountId,
                string callId,
                string recordingId)
        {
            Task t = this.DeleteRecordingMediaAsync(accountId, callId, recordingId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Deletes the specified recording's media.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteRecordingMediaAsync(
                string accountId,
                string callId,
                string recordingId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recordings/{recordingId}/media");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Delete(queryBuilder.ToString(), headers, null);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Downloads the specified transcription.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.TranscriptionResponse response from the API call.</returns>
        public ApiResponse<Models.TranscriptionResponse> GetCallTranscription(
                string accountId,
                string callId,
                string recordingId)
        {
            Task<ApiResponse<Models.TranscriptionResponse>> t = this.GetCallTranscriptionAsync(accountId, callId, recordingId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Downloads the specified transcription.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TranscriptionResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TranscriptionResponse>> GetCallTranscriptionAsync(
                string accountId,
                string callId,
                string recordingId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.TranscriptionResponse>(response.Body);
            ApiResponse<Models.TranscriptionResponse> apiResponse = new ApiResponse<Models.TranscriptionResponse>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Requests that the specified recording be transcribed.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        public void CreateTranscribeCallRecording(
                string accountId,
                string callId,
                string recordingId,
                Models.TranscribeRecordingRequest body)
        {
            Task t = this.CreateTranscribeCallRecordingAsync(accountId, callId, recordingId, body);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Requests that the specified recording be transcribed.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CreateTranscribeCallRecordingAsync(
                string accountId,
                string callId,
                string recordingId,
                Models.TranscribeRecordingRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
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

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 410)
            {
                throw new ApiErrorException("The media for this recording has been deleted, so we can't transcribe it", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Deletes the specified recording's transcription.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        public void DeleteCallTranscription(
                string accountId,
                string callId,
                string recordingId)
        {
            Task t = this.DeleteCallTranscriptionAsync(accountId, callId, recordingId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Deletes the specified recording's transcription.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteCallTranscriptionAsync(
                string accountId,
                string callId,
                string recordingId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "callId", callId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Delete(queryBuilder.ToString(), headers, null);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Returns information about the conferences in the account.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="name">Optional parameter: Example: .</param>
        /// <param name="minCreatedTime">Optional parameter: Example: .</param>
        /// <param name="maxCreatedTime">Optional parameter: Example: .</param>
        /// <param name="pageSize">Optional parameter: Example: 1000.</param>
        /// <param name="pageToken">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of List<Models.ConferenceState> response from the API call.</returns>
        public ApiResponse<List<Models.ConferenceState>> GetConferences(
                string accountId,
                string name = null,
                string minCreatedTime = null,
                string maxCreatedTime = null,
                int? pageSize = 1000,
                string pageToken = null)
        {
            Task<ApiResponse<List<Models.ConferenceState>>> t = this.GetConferencesAsync(accountId, name, minCreatedTime, maxCreatedTime, pageSize, pageToken);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns information about the conferences in the account.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="name">Optional parameter: Example: .</param>
        /// <param name="minCreatedTime">Optional parameter: Example: .</param>
        /// <param name="maxCreatedTime">Optional parameter: Example: .</param>
        /// <param name="pageSize">Optional parameter: Example: 1000.</param>
        /// <param name="pageToken">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.ConferenceState> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ConferenceState>>> GetConferencesAsync(
                string accountId,
                string name = null,
                string minCreatedTime = null,
                string maxCreatedTime = null,
                int? pageSize = 1000,
                string pageToken = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/conferences");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "name", name },
                { "minCreatedTime", minCreatedTime },
                { "maxCreatedTime", maxCreatedTime },
                { "pageSize", (pageSize != null) ? pageSize : 1000 },
                { "pageToken", pageToken },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<List<Models.ConferenceState>>(response.Body);
            ApiResponse<List<Models.ConferenceState>> apiResponse = new ApiResponse<List<Models.ConferenceState>>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Returns information about the specified conference.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ConferenceState response from the API call.</returns>
        public ApiResponse<Models.ConferenceState> GetConference(
                string accountId,
                string conferenceId)
        {
            Task<ApiResponse<Models.ConferenceState>> t = this.GetConferenceAsync(accountId, conferenceId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns information about the specified conference.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConferenceState response from the API call.</returns>
        public async Task<ApiResponse<Models.ConferenceState>> GetConferenceAsync(
                string accountId,
                string conferenceId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/conferences/{conferenceId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "conferenceId", conferenceId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.ConferenceState>(response.Body);
            ApiResponse<Models.ConferenceState> apiResponse = new ApiResponse<Models.ConferenceState>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Modify the conference state.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        public void ModifyConference(
                string accountId,
                string conferenceId,
                Models.ModifyConferenceRequest body)
        {
            Task t = this.ModifyConferenceAsync(accountId, conferenceId, body);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Modify the conference state.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ModifyConferenceAsync(
                string accountId,
                string conferenceId,
                Models.ModifyConferenceRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/conferences/{conferenceId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "conferenceId", conferenceId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
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

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Updates settings for a particular conference member.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        public void ModifyConferenceMember(
                string accountId,
                string conferenceId,
                string callId,
                Models.ConferenceMemberState body)
        {
            Task t = this.ModifyConferenceMemberAsync(accountId, conferenceId, callId, body);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Updates settings for a particular conference member.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="callId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ModifyConferenceMemberAsync(
                string accountId,
                string conferenceId,
                string callId,
                Models.ConferenceMemberState body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/conferences/{conferenceId}/members/{callId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "conferenceId", conferenceId },
                { "callId", callId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Returns information about the specified conference member.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="memberId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ConferenceMemberState response from the API call.</returns>
        public ApiResponse<Models.ConferenceMemberState> GetConferenceMember(
                string accountId,
                string conferenceId,
                string memberId)
        {
            Task<ApiResponse<Models.ConferenceMemberState>> t = this.GetConferenceMemberAsync(accountId, conferenceId, memberId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns information about the specified conference member.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="memberId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConferenceMemberState response from the API call.</returns>
        public async Task<ApiResponse<Models.ConferenceMemberState>> GetConferenceMemberAsync(
                string accountId,
                string conferenceId,
                string memberId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/conferences/{conferenceId}/members/{memberId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "conferenceId", conferenceId },
                { "memberId", memberId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.ConferenceMemberState>(response.Body);
            ApiResponse<Models.ConferenceMemberState> apiResponse = new ApiResponse<Models.ConferenceMemberState>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Returns a (potentially empty) list of metadata for the recordings that took place during the specified conference.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of List<Models.ConferenceRecordingMetadata> response from the API call.</returns>
        public ApiResponse<List<Models.ConferenceRecordingMetadata>> GetConferenceRecordings(
                string accountId,
                string conferenceId)
        {
            Task<ApiResponse<List<Models.ConferenceRecordingMetadata>>> t = this.GetConferenceRecordingsAsync(accountId, conferenceId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns a (potentially empty) list of metadata for the recordings that took place during the specified conference.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.ConferenceRecordingMetadata> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ConferenceRecordingMetadata>>> GetConferenceRecordingsAsync(
                string accountId,
                string conferenceId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/conferences/{conferenceId}/recordings");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "conferenceId", conferenceId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<List<Models.ConferenceRecordingMetadata>>(response.Body);
            ApiResponse<List<Models.ConferenceRecordingMetadata>> apiResponse = new ApiResponse<List<Models.ConferenceRecordingMetadata>>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Returns metadata for the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.CallRecordingMetadata response from the API call.</returns>
        public ApiResponse<Models.CallRecordingMetadata> GetConferenceRecording(
                string accountId,
                string conferenceId,
                string recordingId)
        {
            Task<ApiResponse<Models.CallRecordingMetadata>> t = this.GetConferenceRecordingAsync(accountId, conferenceId, recordingId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns metadata for the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CallRecordingMetadata response from the API call.</returns>
        public async Task<ApiResponse<Models.CallRecordingMetadata>> GetConferenceRecordingAsync(
                string accountId,
                string conferenceId,
                string recordingId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/conferences/{conferenceId}/recordings/{recordingId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "conferenceId", conferenceId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.CallRecordingMetadata>(response.Body);
            ApiResponse<Models.CallRecordingMetadata> apiResponse = new ApiResponse<Models.CallRecordingMetadata>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Downloads the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of dynamic response from the API call.</returns>
        public ApiResponse<dynamic> GetDownloadConferenceRecording(
                string accountId,
                string conferenceId,
                string recordingId)
        {
            Task<ApiResponse<dynamic>> t = this.GetDownloadConferenceRecordingAsync(accountId, conferenceId, recordingId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Downloads the specified recording.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="conferenceId">Required parameter: Example: .</param>
        /// <param name="recordingId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of dynamic response from the API call.</returns>
        public async Task<ApiResponse<dynamic>> GetDownloadConferenceRecordingAsync(
                string accountId,
                string conferenceId,
                string recordingId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/conferences/{conferenceId}/recordings/{recordingId}/media");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "conferenceId", conferenceId },
                { "recordingId", recordingId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<dynamic>(response.Body);
            ApiResponse<dynamic> apiResponse = new ApiResponse<dynamic>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Returns a list of metadata for the recordings associated with the specified account. The list can be filtered by the optional from, to, minStartTime, and maxStartTime arguments. The list is capped at 1000 entries and may be empty if no recordings match the specified criteria.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="from">Optional parameter: Example: .</param>
        /// <param name="to">Optional parameter: Example: .</param>
        /// <param name="minStartTime">Optional parameter: Example: .</param>
        /// <param name="maxStartTime">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of List<Models.CallRecordingMetadata> response from the API call.</returns>
        public ApiResponse<List<Models.CallRecordingMetadata>> GetQueryCallRecordings(
                string accountId,
                string from = null,
                string to = null,
                string minStartTime = null,
                string maxStartTime = null)
        {
            Task<ApiResponse<List<Models.CallRecordingMetadata>>> t = this.GetQueryCallRecordingsAsync(accountId, from, to, minStartTime, maxStartTime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns a list of metadata for the recordings associated with the specified account. The list can be filtered by the optional from, to, minStartTime, and maxStartTime arguments. The list is capped at 1000 entries and may be empty if no recordings match the specified criteria.
        /// </summary>
        /// <param name="accountId">Required parameter: Example: .</param>
        /// <param name="from">Optional parameter: Example: .</param>
        /// <param name="to">Optional parameter: Example: .</param>
        /// <param name="minStartTime">Optional parameter: Example: .</param>
        /// <param name="maxStartTime">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.CallRecordingMetadata> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.CallRecordingMetadata>>> GetQueryCallRecordingsAsync(
                string accountId,
                string from = null,
                string to = null,
                string minStartTime = null,
                string maxStartTime = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.VoiceDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountId}/recordings");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "from", from },
                { "to", to },
                { "minStartTime", minStartTime },
                { "maxStartTime", maxStartTime },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["voice"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiErrorException("Something's not quite right... Your request is invalid. Please fix it before trying again.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API.", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiErrorException("User unauthorized to perform this action.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiErrorException("The resource specified cannot be found or does not belong to you.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiErrorException("We don't support that media type. If a request body is required, please send it to us as `application/json`.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiErrorException("You're sending requests to this endpoint too frequently. Please slow your request rate down and try again.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiErrorException("Something unexpected happened. Please try again.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<List<Models.CallRecordingMetadata>>(response.Body);
            ApiResponse<List<Models.CallRecordingMetadata>> apiResponse = new ApiResponse<List<Models.CallRecordingMetadata>>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }
    }
}
