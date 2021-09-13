// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.PhoneNumberLookup.Controllers
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
    using Bandwidth.Standard.PhoneNumberLookup.Exceptions;
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
        /// Create a TN Lookup Order.
        /// </summary>
        /// <param name="accountId">Required parameter: The ID of the Bandwidth account that the user belongs to.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.OrderResponse response from the API call.</returns>
        public ApiResponse<Models.OrderResponse> CreateLookupRequest(
                string accountId,
                Models.OrderRequest body)
        {
            Task<ApiResponse<Models.OrderResponse>> t = this.CreateLookupRequestAsync(accountId, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a TN Lookup Order.
        /// </summary>
        /// <param name="accountId">Required parameter: The ID of the Bandwidth account that the user belongs to.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.OrderResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.OrderResponse>> CreateLookupRequestAsync(
                string accountId,
                Models.OrderRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.PhoneNumberLookupDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/tnlookup");

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

            httpRequest = await this.AuthManagers["phoneNumberLookup"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new AccountsTnlookup400ErrorException("Bad Request. Ensure that your request payload is properly formatted and that the telephone numbers used are valid.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized. Ensure that you are using the proper credentials for the environment you are accessing, your user has the proper role assigned to it, and that your Bandwidth account is enabled for TN Lookup access.", context);
            }

            if (response.StatusCode == 415)
            {
                throw new ApiException("Invalid content-type. Ensure that your content-type header is set to application/json.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiException("Too Many Requests. Reduce the amount of requests that you are sending in order to avoid receiving this status code.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 501)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 502)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 503)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 504)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 505)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 506)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 507)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 508)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 509)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 510)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 511)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 512)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 513)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 514)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 515)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 516)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 517)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 518)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 519)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 520)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 521)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 522)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 523)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 524)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 525)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 526)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 527)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 528)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 529)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 530)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 531)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 532)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 533)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 534)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 535)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 536)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 537)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 538)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 539)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 540)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 541)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 542)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 543)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 544)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 545)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 546)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 547)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 548)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 549)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 550)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 551)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 552)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 553)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 554)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 555)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 556)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 557)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 558)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 559)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 560)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 561)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 562)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 563)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 564)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 565)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 566)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 567)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 568)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 569)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 570)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 571)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 572)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 573)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 574)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 575)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 576)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 577)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 578)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 579)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 580)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 581)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 582)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 583)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 584)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 585)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 586)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 587)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 588)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 589)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 590)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 591)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 592)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 593)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 594)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 595)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 596)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 597)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 598)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 599)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.OrderResponse>(response.Body);
            ApiResponse<Models.OrderResponse> apiResponse = new ApiResponse<Models.OrderResponse>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }

        /// <summary>
        /// Query an existing TN Lookup Order.
        /// </summary>
        /// <param name="accountId">Required parameter: The ID of the Bandwidth account that the user belongs to.</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.OrderStatus response from the API call.</returns>
        public ApiResponse<Models.OrderStatus> GetLookupRequestStatus(
                string accountId,
                string requestId)
        {
            Task<ApiResponse<Models.OrderStatus>> t = this.GetLookupRequestStatusAsync(accountId, requestId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Query an existing TN Lookup Order.
        /// </summary>
        /// <param name="accountId">Required parameter: The ID of the Bandwidth account that the user belongs to.</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.OrderStatus response from the API call.</returns>
        public async Task<ApiResponse<Models.OrderStatus>> GetLookupRequestStatusAsync(
                string accountId,
                string requestId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.PhoneNumberLookupDefault);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts/{accountId}/tnlookup/{requestId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "accountId", accountId },
                { "requestId", requestId },
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

            httpRequest = await this.AuthManagers["phoneNumberLookup"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 400)
            {
                throw new ApiException("Bad Request. Ensure that you have set the requestId as a URL path parameter.", context);
            }

            if (response.StatusCode == 401)
            {
                throw new ApiException("Unauthorized. Ensure that you are using the proper credentials for the environment you are accessing, your user has the proper role assigned to it, and that your Bandwidth account is enabled for TN Lookup access.", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("RequestId not found. Ensure that the requestId used in the URL path is valid and maps to a previous request that was submitted.", context);
            }

            if (response.StatusCode == 429)
            {
                throw new ApiException("Too Many Requests. Reduce the amount of requests that you are sending in order to avoid receiving this status code.", context);
            }

            if (response.StatusCode == 500)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 501)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 502)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 503)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 504)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 505)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 506)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 507)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 508)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 509)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 510)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 511)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 512)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 513)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 514)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 515)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 516)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 517)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 518)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 519)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 520)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 521)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 522)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 523)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 524)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 525)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 526)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 527)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 528)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 529)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 530)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 531)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 532)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 533)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 534)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 535)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 536)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 537)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 538)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 539)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 540)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 541)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 542)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 543)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 544)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 545)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 546)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 547)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 548)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 549)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 550)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 551)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 552)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 553)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 554)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 555)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 556)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 557)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 558)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 559)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 560)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 561)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 562)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 563)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 564)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 565)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 566)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 567)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 568)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 569)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 570)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 571)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 572)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 573)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 574)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 575)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 576)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 577)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 578)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 579)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 580)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 581)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 582)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 583)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 584)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 585)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 586)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 587)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 588)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 589)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 590)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 591)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 592)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 593)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 594)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 595)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 596)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 597)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 598)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            if (response.StatusCode == 599)
            {
                throw new ApiException("Unexpected error. Please contact Bandwidth Support if your requests are receiving this status code for an extended period of time.", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            var result = ApiHelper.JsonDeserialize<Models.OrderStatus>(response.Body);
            ApiResponse<Models.OrderStatus> apiResponse = new ApiResponse<Models.OrderStatus>(response.StatusCode, response.Headers, result);
            return apiResponse;
        }
    }
}