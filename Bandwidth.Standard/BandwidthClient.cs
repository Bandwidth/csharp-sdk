// <copyright file="BandwidthClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using Bandwidth.Standard.Authentication;
    using Bandwidth.Standard.Http.Client;
    using Bandwidth.Standard.Messaging;
    using Bandwidth.Standard.PhoneNumberLookup;
    using Bandwidth.Standard.TwoFactorAuth;
    using Bandwidth.Standard.Utilities;
    using Bandwidth.Standard.Voice;
    using Bandwidth.Standard.WebRtc;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class BandwidthClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Server, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Server, string>>
        {
            {
                Environment.Production, new Dictionary<Server, string>
                {
                    { Server.Default, "api.bandwidth.com" },
                    { Server.MessagingDefault, "https://messaging.bandwidth.com/api/v2" },
                    { Server.TwoFactorAuthDefault, "https://mfa.bandwidth.com/api/v1" },
                    { Server.PhoneNumberLookupDefault, "https://uat.numbers.bandwidth.com/api/v1" },
                    { Server.VoiceDefault, "https://voice.bandwidth.com" },
                    { Server.WebRtcDefault, "https://api.webrtc.bandwidth.com/v1" },
                }
            },
            {
                Environment.Custom, new Dictionary<Server, string>
                {
                    { Server.Default, "{base_url}" },
                    { Server.MessagingDefault, "{base_url}" },
                    { Server.TwoFactorAuthDefault, "{base_url}" },
                    { Server.VoiceDefault, "{base_url}" },
                    { Server.WebRtcDefault, "{base_url}" },
                }
            },
        };

        private readonly IDictionary<string, IAuthManager> authManagers;
        private readonly IHttpClient httpClient;
        private readonly HttpCallBack httpCallBack;
        private readonly MessagingBasicAuthManager messagingBasicAuthManager;
        private readonly TwoFactorAuthBasicAuthManager twoFactorAuthBasicAuthManager;
        private readonly VoiceBasicAuthManager voiceBasicAuthManager;
        private readonly WebRtcBasicAuthManager webRtcBasicAuthManager;

        private readonly Lazy<MessagingClient> messaging;
        private readonly Lazy<TwoFactorAuthClient> twoFactorAuth;
        private readonly Lazy<PhoneNumberLookupClient> phoneNumberLookup;
        private readonly Lazy<VoiceClient> voice;
        private readonly Lazy<WebRtcClient> webRtc;

        /// <summary>
        /// Gets MessagingClient controller.
        /// </summary>
        public MessagingClient Messaging => this.messaging.Value;

        /// <summary>
        /// Gets TwoFactorAuthClient controller.
        /// </summary>
        public TwoFactorAuthClient TwoFactorAuth => this.twoFactorAuth.Value;

        /// <summary>
        /// Gets PhoneNumberLookupClient controller.
        /// </summary>
        public PhoneNumberLookupClient PhoneNumberLookup => this.phoneNumberLookup.Value;

        /// <summary>
        /// Gets VoiceClient controller.
        /// </summary>
        public VoiceClient Voice => this.voice.Value;

        /// <summary>
        /// Gets WebRtcClient controller.
        /// </summary>
        public WebRtcClient WebRtc => this.webRtc.Value;

        private BandwidthClient(
            Environment environment,
            string baseUrl,
            string messagingBasicAuthUserName,
            string messagingBasicAuthPassword,
            string twoFactorAuthBasicAuthUserName,
            string twoFactorAuthBasicAuthPassword,
            string voiceBasicAuthUserName,
            string voiceBasicAuthPassword,
            string webRtcBasicAuthUserName,
            string webRtcBasicAuthPassword,
            IDictionary<string, IAuthManager> authManagers,
            IHttpClient httpClient,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.BaseUrl = baseUrl;
            this.httpCallBack = httpCallBack;
            this.httpClient = httpClient;
            this.authManagers = (authManagers == null) ? new Dictionary<string, IAuthManager>() : new Dictionary<string, IAuthManager>(authManagers);
            this.HttpClientConfiguration = httpClientConfiguration;

            if (this.authManagers.ContainsKey("messaging"))
            {
                this.messagingBasicAuthManager = (MessagingBasicAuthManager)this.authManagers["messaging"];
            }

            if (!this.authManagers.ContainsKey("messaging")
                || !this.MessagingBasicAuthCredentials.Equals(messagingBasicAuthUserName, messagingBasicAuthPassword))
            {
                this.messagingBasicAuthManager = new MessagingBasicAuthManager(messagingBasicAuthUserName, messagingBasicAuthPassword);
                this.authManagers["messaging"] = this.messagingBasicAuthManager;
            }

            if (this.authManagers.ContainsKey("twoFactorAuth"))
            {
                this.twoFactorAuthBasicAuthManager = (TwoFactorAuthBasicAuthManager)this.authManagers["twoFactorAuth"];
            }

            if (!this.authManagers.ContainsKey("twoFactorAuth")
                || !this.TwoFactorAuthBasicAuthCredentials.Equals(twoFactorAuthBasicAuthUserName, twoFactorAuthBasicAuthPassword))
            {
                this.twoFactorAuthBasicAuthManager = new TwoFactorAuthBasicAuthManager(twoFactorAuthBasicAuthUserName, twoFactorAuthBasicAuthPassword);
                this.authManagers["twoFactorAuth"] = this.twoFactorAuthBasicAuthManager;
            }

            if (this.authManagers.ContainsKey("voice"))
            {
                this.voiceBasicAuthManager = (VoiceBasicAuthManager)this.authManagers["voice"];
            }

            if (!this.authManagers.ContainsKey("voice")
                || !this.VoiceBasicAuthCredentials.Equals(voiceBasicAuthUserName, voiceBasicAuthPassword))
            {
                this.voiceBasicAuthManager = new VoiceBasicAuthManager(voiceBasicAuthUserName, voiceBasicAuthPassword);
                this.authManagers["voice"] = this.voiceBasicAuthManager;
            }

            if (this.authManagers.ContainsKey("webRtc"))
            {
                this.webRtcBasicAuthManager = (WebRtcBasicAuthManager)this.authManagers["webRtc"];
            }

            if (!this.authManagers.ContainsKey("webRtc")
                || !this.WebRtcBasicAuthCredentials.Equals(webRtcBasicAuthUserName, webRtcBasicAuthPassword))
            {
                this.webRtcBasicAuthManager = new WebRtcBasicAuthManager(webRtcBasicAuthUserName, webRtcBasicAuthPassword);
                this.authManagers["webRtc"] = this.webRtcBasicAuthManager;
            }

            this.messaging = new Lazy<MessagingClient>(() => new MessagingClient(this));
            this.twoFactorAuth = new Lazy<TwoFactorAuthClient>(() => new TwoFactorAuthClient(this));
            this.phoneNumberLookup = new Lazy<PhoneNumberLookupClient>(() => new PhoneNumberLookupClient(this));
            this.voice = new Lazy<VoiceClient>(() => new VoiceClient(this));
            this.webRtc = new Lazy<WebRtcClient>(() => new WebRtcClient(this));
        }

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets BaseUrl.
        /// BaseUrl value.
        /// </summary>
        public string BaseUrl { get; }

        /// <summary>
        /// Gets auth managers.
        /// </summary>
        internal IDictionary<string, IAuthManager> AuthManagers => this.authManagers;

        /// <summary>
        /// Gets http client.
        /// </summary>
        internal IHttpClient HttpClient => this.httpClient;

        /// <summary>
        /// Gets http callback.
        /// </summary>
        internal HttpCallBack HttpCallBack => this.httpCallBack;

        /// <summary>
        /// Gets the credentials to use with MessagingBasicAuth.
        /// </summary>
        public IMessagingBasicAuthCredentials MessagingBasicAuthCredentials => this.messagingBasicAuthManager;

        /// <summary>
        /// Gets the credentials to use with TwoFactorAuthBasicAuth.
        /// </summary>
        public ITwoFactorAuthBasicAuthCredentials TwoFactorAuthBasicAuthCredentials => this.twoFactorAuthBasicAuthManager;

        /// <summary>
        /// Gets the credentials to use with VoiceBasicAuth.
        /// </summary>
        public IVoiceBasicAuthCredentials VoiceBasicAuthCredentials => this.voiceBasicAuthManager;

        /// <summary>
        /// Gets the credentials to use with WebRtcBasicAuth.
        /// </summary>
        public IWebRtcBasicAuthCredentials WebRtcBasicAuthCredentials => this.webRtcBasicAuthManager;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            StringBuilder url = new StringBuilder(EnvironmentsMap[this.Environment][alias]);
            ApiHelper.AppendUrlWithTemplateParameters(url, this.GetBaseUriParameters());

            return url.ToString();
        }

        /// <summary>
        /// Creates an object of the BandwidthClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .BaseUrl(this.BaseUrl)
                .MessagingBasicAuthCredentials(this.messagingBasicAuthManager.BasicAuthUserName, this.messagingBasicAuthManager.BasicAuthPassword)
                .TwoFactorAuthBasicAuthCredentials(this.twoFactorAuthBasicAuthManager.BasicAuthUserName, this.twoFactorAuthBasicAuthManager.BasicAuthPassword)
                .VoiceBasicAuthCredentials(this.voiceBasicAuthManager.BasicAuthUserName, this.voiceBasicAuthManager.BasicAuthPassword)
                .WebRtcBasicAuthCredentials(this.webRtcBasicAuthManager.BasicAuthUserName, this.webRtcBasicAuthManager.BasicAuthPassword)
                .HttpCallBack(this.httpCallBack)
                .HttpClient(this.httpClient)
                .AuthManagers(this.authManagers)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"BaseUrl = {this.BaseUrl}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> BandwidthClient.</returns>
        internal static BandwidthClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_ENVIRONMENT");
            string baseUrl = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_BASE_URL");
            string messagingBasicAuthUserName = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_MESSAGING_BASIC_AUTH_USER_NAME");
            string messagingBasicAuthPassword = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_MESSAGING_BASIC_AUTH_PASSWORD");
            string twoFactorAuthBasicAuthUserName = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_TWO_FACTOR_AUTH_BASIC_AUTH_USER_NAME");
            string twoFactorAuthBasicAuthPassword = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_TWO_FACTOR_AUTH_BASIC_AUTH_PASSWORD");
            string voiceBasicAuthUserName = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_VOICE_BASIC_AUTH_USER_NAME");
            string voiceBasicAuthPassword = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_VOICE_BASIC_AUTH_PASSWORD");
            string webRtcBasicAuthUserName = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_WEB_RTC_BASIC_AUTH_USER_NAME");
            string webRtcBasicAuthPassword = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_WEB_RTC_BASIC_AUTH_PASSWORD");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (baseUrl != null)
            {
                builder.BaseUrl(baseUrl);
            }

            if (messagingBasicAuthUserName != null && messagingBasicAuthPassword != null)
            {
                builder.MessagingBasicAuthCredentials(messagingBasicAuthUserName, messagingBasicAuthPassword);
            }

            if (twoFactorAuthBasicAuthUserName != null && twoFactorAuthBasicAuthPassword != null)
            {
                builder.TwoFactorAuthBasicAuthCredentials(twoFactorAuthBasicAuthUserName, twoFactorAuthBasicAuthPassword);
            }

            if (voiceBasicAuthUserName != null && voiceBasicAuthPassword != null)
            {
                builder.VoiceBasicAuthCredentials(voiceBasicAuthUserName, voiceBasicAuthPassword);
            }

            if (webRtcBasicAuthUserName != null && webRtcBasicAuthPassword != null)
            {
                builder.WebRtcBasicAuthCredentials(webRtcBasicAuthUserName, webRtcBasicAuthPassword);
            }

            return builder.Build();
        }

        /// <summary>
        /// Makes a list of the BaseURL parameters.
        /// </summary>
        /// <returns>Returns the parameters list.</returns>
        private List<KeyValuePair<string, object>> GetBaseUriParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("base_url", this.BaseUrl),
            };
            return kvpList;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = Bandwidth.Standard.Environment.Production;
            private string baseUrl = "https://www.example.com";
            private string messagingBasicAuthUserName = "TODO: Replace";
            private string messagingBasicAuthPassword = "TODO: Replace";
            private string twoFactorAuthBasicAuthUserName = "TODO: Replace";
            private string twoFactorAuthBasicAuthPassword = "TODO: Replace";
            private string voiceBasicAuthUserName = "TODO: Replace";
            private string voiceBasicAuthPassword = "TODO: Replace";
            private string webRtcBasicAuthUserName = "TODO: Replace";
            private string webRtcBasicAuthPassword = "TODO: Replace";
            private IDictionary<string, IAuthManager> authManagers = new Dictionary<string, IAuthManager>();
            private bool createCustomHttpClient = false;
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private IHttpClient httpClient;
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for MessagingBasicAuth.
            /// </summary>
            /// <param name="messagingBasicAuthUserName">MessagingBasicAuthUserName.</param>
            /// <param name="messagingBasicAuthPassword">MessagingBasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            public Builder MessagingBasicAuthCredentials(string messagingBasicAuthUserName, string messagingBasicAuthPassword)
            {
                this.messagingBasicAuthUserName = messagingBasicAuthUserName ?? throw new ArgumentNullException(nameof(messagingBasicAuthUserName));
                this.messagingBasicAuthPassword = messagingBasicAuthPassword ?? throw new ArgumentNullException(nameof(messagingBasicAuthPassword));
                return this;
            }

            /// <summary>
            /// Sets credentials for TwoFactorAuthBasicAuth.
            /// </summary>
            /// <param name="twoFactorAuthBasicAuthUserName">TwoFactorAuthBasicAuthUserName.</param>
            /// <param name="twoFactorAuthBasicAuthPassword">TwoFactorAuthBasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            public Builder TwoFactorAuthBasicAuthCredentials(string twoFactorAuthBasicAuthUserName, string twoFactorAuthBasicAuthPassword)
            {
                this.twoFactorAuthBasicAuthUserName = twoFactorAuthBasicAuthUserName ?? throw new ArgumentNullException(nameof(twoFactorAuthBasicAuthUserName));
                this.twoFactorAuthBasicAuthPassword = twoFactorAuthBasicAuthPassword ?? throw new ArgumentNullException(nameof(twoFactorAuthBasicAuthPassword));
                return this;
            }

            /// <summary>
            /// Sets credentials for VoiceBasicAuth.
            /// </summary>
            /// <param name="voiceBasicAuthUserName">VoiceBasicAuthUserName.</param>
            /// <param name="voiceBasicAuthPassword">VoiceBasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            public Builder VoiceBasicAuthCredentials(string voiceBasicAuthUserName, string voiceBasicAuthPassword)
            {
                this.voiceBasicAuthUserName = voiceBasicAuthUserName ?? throw new ArgumentNullException(nameof(voiceBasicAuthUserName));
                this.voiceBasicAuthPassword = voiceBasicAuthPassword ?? throw new ArgumentNullException(nameof(voiceBasicAuthPassword));
                return this;
            }

            /// <summary>
            /// Sets credentials for WebRtcBasicAuth.
            /// </summary>
            /// <param name="webRtcBasicAuthUserName">WebRtcBasicAuthUserName.</param>
            /// <param name="webRtcBasicAuthPassword">WebRtcBasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            public Builder WebRtcBasicAuthCredentials(string webRtcBasicAuthUserName, string webRtcBasicAuthPassword)
            {
                this.webRtcBasicAuthUserName = webRtcBasicAuthUserName ?? throw new ArgumentNullException(nameof(webRtcBasicAuthUserName));
                this.webRtcBasicAuthPassword = webRtcBasicAuthPassword ?? throw new ArgumentNullException(nameof(webRtcBasicAuthPassword));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets BaseUrl.
            /// </summary>
            /// <param name="baseUrl"> BaseUrl. </param>
            /// <returns> Builder. </returns>
            public Builder BaseUrl(string baseUrl)
            {
                this.baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                this.createCustomHttpClient = true;
                return this;
            }

            /// <summary>
            /// Sets the IHttpClient for the Builder.
            /// </summary>
            /// <param name="httpClient"> http client. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpClient(IHttpClient httpClient)
            {
                this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                return this;
            }

            /// <summary>
            /// Sets the authentication managers for the Builder.
            /// </summary>
            /// <param name="authManagers"> auth managers. </param>
            /// <returns>Builder.</returns>
            internal Builder AuthManagers(IDictionary<string, IAuthManager> authManagers)
            {
                this.authManagers = authManagers ?? throw new ArgumentNullException(nameof(authManagers));
                return this;
            }

            /// <summary>
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the BandwidthClient using the values provided for the builder.
            /// </summary>
            /// <returns>BandwidthClient.</returns>
            public BandwidthClient Build()
            {
                if (this.createCustomHttpClient)
                {
                    this.httpClient = new HttpClientWrapper(this.httpClientConfig.Build());
                }
                else
                {
                    this.httpClient = new HttpClientWrapper();
                }

                return new BandwidthClient(
                    this.environment,
                    this.baseUrl,
                    this.messagingBasicAuthUserName,
                    this.messagingBasicAuthPassword,
                    this.twoFactorAuthBasicAuthUserName,
                    this.twoFactorAuthBasicAuthPassword,
                    this.voiceBasicAuthUserName,
                    this.voiceBasicAuthPassword,
                    this.webRtcBasicAuthUserName,
                    this.webRtcBasicAuthPassword,
                    this.authManagers,
                    this.httpClient,
                    this.httpCallBack,
                    this.httpClientConfig.Build());
            }
        }
    }
}
