// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.WebRtc.Controllers
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
    using Bandwidth.Standard.WebRtc.Exceptions;
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
        /// Create a new participant under this account..
        /// Participants are idempotent, so relevant parameters must be set in this function if desired..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="body">Optional parameter: Participant parameters.</param>
        /// <returns>Returns the ApiResponse of Models.AccountsParticipantsResponse response from the API call.</returns>
        public ApiResponse<Models.AccountsParticipantsResponse> CreateParticipant(
                string accountId,
                Models.Participant body = null)
        {
            Task<ApiResponse<Models.AccountsParticipantsResponse>> t = this.CreateParticipantAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new participant under this account..
        /// Participants are idempotent, so relevant parameters must be set in this function if desired..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="body">Optional parameter: Participant parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AccountsParticipantsResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.AccountsParticipantsResponse>> CreateParticipantAsync(
                string accountId,
                Models.Participant body = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/participants");

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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiException("Bad Request", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.AccountsParticipantsResponse>(response.Body);
            ApiResponse<Models.AccountsParticipantsResponse> apiResponse = new ApiResponse<Models.AccountsParticipantsResponse>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Get participant by ID..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <returns>Returns the ApiResponse of Models.Participant response from the API call.</returns>
        public ApiResponse<Models.Participant> GetParticipant(
                string accountId,
                string participantId)
        {
            Task<ApiResponse<Models.Participant>> t = this.GetParticipantAsync(accountId, participantId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get participant by ID..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Participant response from the API call.</returns>
        public async Task<ApiResponse<Models.Participant>> GetParticipantAsync(
                string accountId,
                string participantId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/participants/{participantId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "participantId", participantId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.Participant>(response.Body);
            ApiResponse<Models.Participant> apiResponse = new ApiResponse<Models.Participant>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Delete participant by ID..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="participantId">Required parameter: Example: .</param>
        public void DeleteParticipant(
                string accountId,
                string participantId)
        {
            Task t = this.DeleteParticipantAsync(accountId, participantId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete participant by ID..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="participantId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteParticipantAsync(
                string accountId,
                string participantId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/participants/{participantId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "participantId", participantId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Create a new session..
        /// Sessions are idempotent, so relevant parameters must be set in this function if desired..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="body">Optional parameter: Session parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Session response from the API call.</returns>
        public ApiResponse<Models.Session> CreateSession(
                string accountId,
                Models.Session body = null)
        {
            Task<ApiResponse<Models.Session>> t = this.CreateSessionAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new session..
        /// Sessions are idempotent, so relevant parameters must be set in this function if desired..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="body">Optional parameter: Session parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Session response from the API call.</returns>
        public async Task<ApiResponse<Models.Session>> CreateSessionAsync(
                string accountId,
                Models.Session body = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/sessions");

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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiException("Bad Request", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.Session>(response.Body);
            ApiResponse<Models.Session> apiResponse = new ApiResponse<Models.Session>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Get session by ID..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <returns>Returns the ApiResponse of Models.Session response from the API call.</returns>
        public ApiResponse<Models.Session> GetSession(
                string accountId,
                string sessionId)
        {
            Task<ApiResponse<Models.Session>> t = this.GetSessionAsync(accountId, sessionId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get session by ID..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Session response from the API call.</returns>
        public async Task<ApiResponse<Models.Session>> GetSessionAsync(
                string accountId,
                string sessionId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/sessions/{sessionId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "sessionId", sessionId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.Session>(response.Body);
            ApiResponse<Models.Session> apiResponse = new ApiResponse<Models.Session>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Delete session by ID..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        public void DeleteSession(
                string accountId,
                string sessionId)
        {
            Task t = this.DeleteSessionAsync(accountId, sessionId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete session by ID..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteSessionAsync(
                string accountId,
                string sessionId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/sessions/{sessionId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "sessionId", sessionId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// List participants in a session..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <returns>Returns the ApiResponse of List<Models.Participant> response from the API call.</returns>
        public ApiResponse<List<Models.Participant>> ListSessionParticipants(
                string accountId,
                string sessionId)
        {
            Task<ApiResponse<List<Models.Participant>>> t = this.ListSessionParticipantsAsync(accountId, sessionId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List participants in a session..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.Participant> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Participant>>> ListSessionParticipantsAsync(
                string accountId,
                string sessionId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/sessions/{sessionId}/participants");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "sessionId", sessionId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<List<Models.Participant>>(response.Body);
            ApiResponse<List<Models.Participant>> apiResponse = new ApiResponse<List<Models.Participant>>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Add a participant to a session..
        /// Subscriptions can optionally be provided as part of this call..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <param name="body">Optional parameter: Subscriptions the participant should be created with.</param>
        public void AddParticipantToSession(
                string accountId,
                string sessionId,
                string participantId,
                Models.Subscriptions body = null)
        {
            Task t = this.AddParticipantToSessionAsync(accountId, sessionId, participantId, body);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Add a participant to a session..
        /// Subscriptions can optionally be provided as part of this call..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <param name="body">Optional parameter: Subscriptions the participant should be created with.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task AddParticipantToSessionAsync(
                string accountId,
                string sessionId,
                string participantId,
                Models.Subscriptions body = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/sessions/{sessionId}/participants/{participantId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "sessionId", sessionId },
                { "participantId", participantId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Remove a participant from a session..
        /// This will automatically remove any subscriptions the participant has associated with this session..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        public void RemoveParticipantFromSession(
                string accountId,
                string sessionId,
                string participantId)
        {
            Task t = this.RemoveParticipantFromSessionAsync(accountId, sessionId, participantId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Remove a participant from a session..
        /// This will automatically remove any subscriptions the participant has associated with this session..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task RemoveParticipantFromSessionAsync(
                string accountId,
                string sessionId,
                string participantId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/sessions/{sessionId}/participants/{participantId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "sessionId", sessionId },
                { "participantId", participantId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Get a participant's subscriptions..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <returns>Returns the ApiResponse of Models.Subscriptions response from the API call.</returns>
        public ApiResponse<Models.Subscriptions> GetParticipantSubscriptions(
                string accountId,
                string sessionId,
                string participantId)
        {
            Task<ApiResponse<Models.Subscriptions>> t = this.GetParticipantSubscriptionsAsync(accountId, sessionId, participantId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a participant's subscriptions..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Subscriptions response from the API call.</returns>
        public async Task<ApiResponse<Models.Subscriptions>> GetParticipantSubscriptionsAsync(
                string accountId,
                string sessionId,
                string participantId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/sessions/{sessionId}/participants/{participantId}/subscriptions");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "sessionId", sessionId },
                { "participantId", participantId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.Subscriptions>(response.Body);
            ApiResponse<Models.Subscriptions> apiResponse = new ApiResponse<Models.Subscriptions>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Update a participant's subscriptions..
        /// This is a full update that will replace the participant's subscriptions. First call `getParticipantSubscriptions` if you need the current subscriptions. Call this function with no `Subscriptions` object to remove all subscriptions..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <param name="body">Optional parameter: Initial state.</param>
        public void UpdateParticipantSubscriptions(
                string accountId,
                string sessionId,
                string participantId,
                Models.Subscriptions body = null)
        {
            Task t = this.UpdateParticipantSubscriptionsAsync(accountId, sessionId, participantId, body);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update a participant's subscriptions..
        /// This is a full update that will replace the participant's subscriptions. First call `getParticipantSubscriptions` if you need the current subscriptions. Call this function with no `Subscriptions` object to remove all subscriptions..
        /// </summary>
        /// <param name="accountId">Required parameter: Account ID.</param>
        /// <param name="sessionId">Required parameter: Session ID.</param>
        /// <param name="participantId">Required parameter: Participant ID.</param>
        /// <param name="body">Optional parameter: Initial state.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UpdateParticipantSubscriptionsAsync(
                string accountId,
                string sessionId,
                string participantId,
                Models.Subscriptions body = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.WebRtcDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/sessions/{sessionId}/participants/{participantId}/subscriptions");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "sessionId", sessionId },
                { "participantId", participantId },
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

            httpRequest = await this.AuthManagers["webRtc"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiException("Bad Request", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("Access Denied", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("Not Found", context);
            }

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new ErrorException("Unexpected Error", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }
    }
}