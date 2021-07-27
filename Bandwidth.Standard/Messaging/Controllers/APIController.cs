// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Messaging.Controllers
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
    using Bandwidth.Standard.Messaging.Exceptions;
    using Bandwidth.Standard.Utilities;
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
        /// listMedia.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="continuationToken">Optional parameter: Continuation token used to retrieve subsequent media..</param>
        /// <returns>Returns the ApiResponse of List<Models.Media> response from the API call.</returns>
        public ApiResponse<List<Models.Media>> ListMedia(
                string accountId,
                string continuationToken = null)
        {
            Task<ApiResponse<List<Models.Media>>> t = this.ListMediaAsync(accountId, continuationToken);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// listMedia.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="continuationToken">Optional parameter: Continuation token used to retrieve subsequent media..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.Media> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Media>>> ListMediaAsync(
                string accountId,
                string continuationToken = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MessagingDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/users/{accountId}/media");

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
                { "Continuation-Token", continuationToken },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["messaging"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new MessagingException("400 Request is malformed or invalid", context);
            }

            if (response.StatusCode == 401)
            {
                throw new MessagingException("401 The specified user does not have access to the account", context);
            }

            if (response.StatusCode == 403)
            {
                throw new MessagingException("403 The user does not have access to this API", context);
            }

            if (response.StatusCode == 404)
            {
                throw new MessagingException("404 Path not found", context);
            }

            if (response.StatusCode == 415)
            {
                throw new MessagingException("415 The content-type of the request is incorrect", context);
            }

            if (response.StatusCode == 429)
            {
                throw new MessagingException("429 The rate limit has been reached", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<List<Models.Media>>(response.Body);
            ApiResponse<List<Models.Media>> apiResponse = new ApiResponse<List<Models.Media>>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// getMedia.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="mediaId">Required parameter: Media ID to retrieve.</param>
        /// <returns>Returns the ApiResponse of Stream response from the API call.</returns>
        public ApiResponse<Stream> GetMedia(
                string accountId,
                string mediaId)
        {
            Task<ApiResponse<Stream>> t = this.GetMediaAsync(accountId, mediaId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// getMedia.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="mediaId">Required parameter: Media ID to retrieve.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Stream response from the API call.</returns>
        public async Task<ApiResponse<Stream>> GetMediaAsync(
                string accountId,
                string mediaId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MessagingDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/users/{accountId}/media/{mediaId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "mediaId", mediaId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["messaging"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpResponse response = await this.GetClientInstance().ExecuteAsBinaryAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new MessagingException("400 Request is malformed or invalid", context);
            }

            if (response.StatusCode == 401)
            {
                throw new MessagingException("401 The specified user does not have access to the account", context);
            }

            if (response.StatusCode == 403)
            {
                throw new MessagingException("403 The user does not have access to this API", context);
            }

            if (response.StatusCode == 404)
            {
                throw new MessagingException("404 Path not found", context);
            }

            if (response.StatusCode == 415)
            {
                throw new MessagingException("415 The content-type of the request is incorrect", context);
            }

            if (response.StatusCode == 429)
            {
                throw new MessagingException("429 The rate limit has been reached", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = response.RawBody;
            ApiResponse<Stream> apiResponse = new ApiResponse<Stream>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// uploadMedia.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="mediaId">Required parameter: The user supplied custom media ID.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="contentType">Optional parameter: The media type of the entity-body.</param>
        /// <param name="cacheControl">Optional parameter: General-header field is used to specify directives that MUST be obeyed by all caching mechanisms along the request/response chain..</param>
        public void UploadMedia(
                string accountId,
                string mediaId,
                FileStreamInfo body,
                string contentType = "application/octet-stream",
                string cacheControl = null)
        {
            Task t = this.UploadMediaAsync(accountId, mediaId, body, contentType, cacheControl);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// uploadMedia.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="mediaId">Required parameter: The user supplied custom media ID.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="contentType">Optional parameter: The media type of the entity-body.</param>
        /// <param name="cacheControl">Optional parameter: General-header field is used to specify directives that MUST be obeyed by all caching mechanisms along the request/response chain..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UploadMediaAsync(
                string accountId,
                string mediaId,
                FileStreamInfo body,
                string contentType = "application/octet-stream",
                string cacheControl = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MessagingDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/users/{accountId}/media/{mediaId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "mediaId", mediaId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Content-Type", (contentType != null) ? contentType : "application/octet-stream" },
                { "Cache-Control", cacheControl },
            };

            // append body params.
            var bodyText = body;

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["messaging"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new MessagingException("400 Request is malformed or invalid", context);
            }

            if (response.StatusCode == 401)
            {
                throw new MessagingException("401 The specified user does not have access to the account", context);
            }

            if (response.StatusCode == 403)
            {
                throw new MessagingException("403 The user does not have access to this API", context);
            }

            if (response.StatusCode == 404)
            {
                throw new MessagingException("404 Path not found", context);
            }

            if (response.StatusCode == 415)
            {
                throw new MessagingException("415 The content-type of the request is incorrect", context);
            }

            if (response.StatusCode == 429)
            {
                throw new MessagingException("429 The rate limit has been reached", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// deleteMedia.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="mediaId">Required parameter: The media ID to delete.</param>
        public void DeleteMedia(
                string accountId,
                string mediaId)
        {
            Task t = this.DeleteMediaAsync(accountId, mediaId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// deleteMedia.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="mediaId">Required parameter: The media ID to delete.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteMediaAsync(
                string accountId,
                string mediaId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MessagingDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/users/{accountId}/media/{mediaId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "mediaId", mediaId },
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

            httpRequest = await this.AuthManagers["messaging"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new MessagingException("400 Request is malformed or invalid", context);
            }

            if (response.StatusCode == 401)
            {
                throw new MessagingException("401 The specified user does not have access to the account", context);
            }

            if (response.StatusCode == 403)
            {
                throw new MessagingException("403 The user does not have access to this API", context);
            }

            if (response.StatusCode == 404)
            {
                throw new MessagingException("404 Path not found", context);
            }

            if (response.StatusCode == 415)
            {
                throw new MessagingException("415 The content-type of the request is incorrect", context);
            }

            if (response.StatusCode == 429)
            {
                throw new MessagingException("429 The rate limit has been reached", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// getMessages.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="messageId">Optional parameter: The ID of the message to search for. Special characters need to be encoded using URL encoding.</param>
        /// <param name="sourceTn">Optional parameter: The phone number that sent the message.</param>
        /// <param name="destinationTn">Optional parameter: The phone number that received the message.</param>
        /// <param name="messageStatus">Optional parameter: The status of the message. One of RECEIVED, QUEUED, SENDING, SENT, FAILED, DELIVERED, ACCEPTED, UNDELIVERED.</param>
        /// <param name="errorCode">Optional parameter: The error code of the message.</param>
        /// <param name="fromDateTime">Optional parameter: The start of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days..</param>
        /// <param name="toDateTime">Optional parameter: The end of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days..</param>
        /// <param name="pageToken">Optional parameter: A base64 encoded value used for pagination of results.</param>
        /// <param name="limit">Optional parameter: The maximum records requested in search result. Default 100. The sum of limit and after cannot be more than 10000.</param>
        /// <returns>Returns the ApiResponse of Models.BandwidthMessagesList response from the API call.</returns>
        public ApiResponse<Models.BandwidthMessagesList> GetMessages(
                string accountId,
                string messageId = null,
                string sourceTn = null,
                string destinationTn = null,
                string messageStatus = null,
                int? errorCode = null,
                string fromDateTime = null,
                string toDateTime = null,
                string pageToken = null,
                int? limit = null)
        {
            Task<ApiResponse<Models.BandwidthMessagesList>> t = this.GetMessagesAsync(accountId, messageId, sourceTn, destinationTn, messageStatus, errorCode, fromDateTime, toDateTime, pageToken, limit);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// getMessages.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="messageId">Optional parameter: The ID of the message to search for. Special characters need to be encoded using URL encoding.</param>
        /// <param name="sourceTn">Optional parameter: The phone number that sent the message.</param>
        /// <param name="destinationTn">Optional parameter: The phone number that received the message.</param>
        /// <param name="messageStatus">Optional parameter: The status of the message. One of RECEIVED, QUEUED, SENDING, SENT, FAILED, DELIVERED, ACCEPTED, UNDELIVERED.</param>
        /// <param name="errorCode">Optional parameter: The error code of the message.</param>
        /// <param name="fromDateTime">Optional parameter: The start of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days..</param>
        /// <param name="toDateTime">Optional parameter: The end of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days..</param>
        /// <param name="pageToken">Optional parameter: A base64 encoded value used for pagination of results.</param>
        /// <param name="limit">Optional parameter: The maximum records requested in search result. Default 100. The sum of limit and after cannot be more than 10000.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.BandwidthMessagesList response from the API call.</returns>
        public async Task<ApiResponse<Models.BandwidthMessagesList>> GetMessagesAsync(
                string accountId,
                string messageId = null,
                string sourceTn = null,
                string destinationTn = null,
                string messageStatus = null,
                int? errorCode = null,
                string fromDateTime = null,
                string toDateTime = null,
                string pageToken = null,
                int? limit = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MessagingDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/users/{accountId}/messages");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "messageId", messageId },
                { "sourceTn", sourceTn },
                { "destinationTn", destinationTn },
                { "messageStatus", messageStatus },
                { "errorCode", errorCode },
                { "fromDateTime", fromDateTime },
                { "toDateTime", toDateTime },
                { "pageToken", pageToken },
                { "limit", limit },
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

            httpRequest = await this.AuthManagers["messaging"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new MessagingException("400 Request is malformed or invalid", context);
            }

            if (response.StatusCode == 401)
            {
                throw new MessagingException("401 The specified user does not have access to the account", context);
            }

            if (response.StatusCode == 403)
            {
                throw new MessagingException("403 The user does not have access to this API", context);
            }

            if (response.StatusCode == 404)
            {
                throw new MessagingException("404 Path not found", context);
            }

            if (response.StatusCode == 415)
            {
                throw new MessagingException("415 The content-type of the request is incorrect", context);
            }

            if (response.StatusCode == 429)
            {
                throw new MessagingException("429 The rate limit has been reached", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.BandwidthMessagesList>(response.Body);
            ApiResponse<Models.BandwidthMessagesList> apiResponse = new ApiResponse<Models.BandwidthMessagesList>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// createMessage.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.BandwidthMessage response from the API call.</returns>
        public ApiResponse<Models.BandwidthMessage> CreateMessage(
                string accountId,
                Models.MessageRequest body)
        {
            Task<ApiResponse<Models.BandwidthMessage>> t = this.CreateMessageAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// createMessage.
        /// </summary>
        /// <param name="accountId">Required parameter: User's account ID.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.BandwidthMessage response from the API call.</returns>
        public async Task<ApiResponse<Models.BandwidthMessage>> CreateMessageAsync(
                string accountId,
                Models.MessageRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.MessagingDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/users/{accountId}/messages");

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

            httpRequest = await this.AuthManagers["messaging"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new MessagingException("400 Request is malformed or invalid", context);
            }

            if (response.StatusCode == 401)
            {
                throw new MessagingException("401 The specified user does not have access to the account", context);
            }

            if (response.StatusCode == 403)
            {
                throw new MessagingException("403 The user does not have access to this API", context);
            }

            if (response.StatusCode == 404)
            {
                throw new MessagingException("404 Path not found", context);
            }

            if (response.StatusCode == 415)
            {
                throw new MessagingException("415 The content-type of the request is incorrect", context);
            }

            if (response.StatusCode == 429)
            {
                throw new MessagingException("429 The rate limit has been reached", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.BandwidthMessage>(response.Body);
            ApiResponse<Models.BandwidthMessage> apiResponse = new ApiResponse<Models.BandwidthMessage>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }
    }
}