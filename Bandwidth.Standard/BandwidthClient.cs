/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Text;
using System.Linq;
using System.Net;
using System.Collections.Generic;
using Bandwidth.Standard.Authentication;
using Bandwidth.Standard.Http.Client;
using Bandwidth.Standard.Messaging;
using Bandwidth.Standard.TwoFactorAuth;
using Bandwidth.Standard.Voice;
using Bandwidth.Standard.WebRtc;

using Bandwidth.Standard.Utilities;

namespace Bandwidth.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and 
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class BandwidthClient: IConfiguration
    {
        internal readonly IDictionary<string, IAuthManager> authManagers;
        internal readonly IHttpClient httpClient;
        internal readonly HttpCallBack httpCallBack;
        private readonly MessagingBasicAuthManager messagingBasicAuthManager;
        private readonly TwoFactorAuthBasicAuthManager twoFactorAuthBasicAuthManager;
        private readonly VoiceBasicAuthManager voiceBasicAuthManager;
        private readonly WebRtcBasicAuthManager webRtcBasicAuthManager;
        private readonly Lazy<MessagingClient> messaging;
        private readonly Lazy<TwoFactorAuthClient> twoFactorAuth;
        private readonly Lazy<VoiceClient> voice;
        private readonly Lazy<WebRtcClient> webRtc;

        /// <summary>
        /// Provides access to MessagingClient controller.
        /// </summary>
        public MessagingClient Messaging => messaging.Value;

        /// <summary>
        /// Provides access to TwoFactorAuthClient controller.
        /// </summary>
        public TwoFactorAuthClient TwoFactorAuth => twoFactorAuth.Value;

        /// <summary>
        /// Provides access to VoiceClient controller.
        /// </summary>
        public VoiceClient Voice => voice.Value;

        /// <summary>
        /// Provides access to WebRtcClient controller.
        /// </summary>
        public WebRtcClient WebRtc => webRtc.Value;

        internal static BandwidthClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string timeout = System.Environment.GetEnvironmentVariable("BANDWIDTH_STANDARD_TIMEOUT");
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

            if (timeout != null)
            {
                builder.Timeout(TimeSpan.Parse(timeout));
            }

            if (environment != null)
            {
                builder.Environment(EnvironmentHelper.ParseString(environment));
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

        private BandwidthClient(TimeSpan timeout, Environment environment, string baseUrl,
                string messagingBasicAuthUserName, string messagingBasicAuthPassword,
                string twoFactorAuthBasicAuthUserName, string twoFactorAuthBasicAuthPassword,
                string voiceBasicAuthUserName, string voiceBasicAuthPassword,
                string webRtcBasicAuthUserName, string webRtcBasicAuthPassword,
                IDictionary<string, IAuthManager> authManagers, IHttpClient httpClient,
                HttpCallBack httpCallBack, IHttpClientConfiguration httpClientConfiguration)
        {
            Timeout = timeout;
            Environment = environment;
            BaseUrl = baseUrl;
            this.httpCallBack = httpCallBack;
            this.httpClient = httpClient;
            this.authManagers = (authManagers == null) ? new Dictionary<string, IAuthManager>() : new Dictionary<string, IAuthManager>(authManagers);
            HttpClientConfiguration = httpClientConfiguration;

            if (this.authManagers.ContainsKey("messaging"))
            {
                messagingBasicAuthManager = (MessagingBasicAuthManager) this.authManagers["messaging"];
            }

            if (!this.authManagers.ContainsKey("messaging")
                || !MessagingBasicAuthCredentials.Equals(messagingBasicAuthUserName, messagingBasicAuthPassword))
            {
                messagingBasicAuthManager = new MessagingBasicAuthManager(messagingBasicAuthUserName, messagingBasicAuthPassword);
                this.authManagers["messaging"] = messagingBasicAuthManager;
            }

            if (this.authManagers.ContainsKey("twoFactorAuth"))
            {
                twoFactorAuthBasicAuthManager = (TwoFactorAuthBasicAuthManager) this.authManagers["twoFactorAuth"];
            }

            if (!this.authManagers.ContainsKey("twoFactorAuth")
                || !TwoFactorAuthBasicAuthCredentials.Equals(twoFactorAuthBasicAuthUserName, twoFactorAuthBasicAuthPassword))
            {
                twoFactorAuthBasicAuthManager = new TwoFactorAuthBasicAuthManager(twoFactorAuthBasicAuthUserName, twoFactorAuthBasicAuthPassword);
                this.authManagers["twoFactorAuth"] = twoFactorAuthBasicAuthManager;
            }

            if (this.authManagers.ContainsKey("voice"))
            {
                voiceBasicAuthManager = (VoiceBasicAuthManager) this.authManagers["voice"];
            }

            if (!this.authManagers.ContainsKey("voice")
                || !VoiceBasicAuthCredentials.Equals(voiceBasicAuthUserName, voiceBasicAuthPassword))
            {
                voiceBasicAuthManager = new VoiceBasicAuthManager(voiceBasicAuthUserName, voiceBasicAuthPassword);
                this.authManagers["voice"] = voiceBasicAuthManager;
            }

            if (this.authManagers.ContainsKey("webRtc"))
            {
                webRtcBasicAuthManager = (WebRtcBasicAuthManager) this.authManagers["webRtc"];
            }

            if (!this.authManagers.ContainsKey("webRtc")
                || !WebRtcBasicAuthCredentials.Equals(webRtcBasicAuthUserName, webRtcBasicAuthPassword))
            {
                webRtcBasicAuthManager = new WebRtcBasicAuthManager(webRtcBasicAuthUserName, webRtcBasicAuthPassword);
                this.authManagers["webRtc"] = webRtcBasicAuthManager;
            }

            messaging = new Lazy<MessagingClient>(() => new MessagingClient(this));
            twoFactorAuth = new Lazy<TwoFactorAuthClient>(() => new TwoFactorAuthClient(this));
            voice = new Lazy<VoiceClient>(() => new VoiceClient(this));
            webRtc = new Lazy<WebRtcClient>(() => new WebRtcClient(this));
        }

        /// <summary>
        /// The configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// The credentials to use with MessagingBasicAuth
        /// </summary>
        public IMessagingBasicAuthCredentials MessagingBasicAuthCredentials { get => messagingBasicAuthManager; }

        /// <summary>
        /// The credentials to use with TwoFactorAuthBasicAuth
        /// </summary>
        public ITwoFactorAuthBasicAuthCredentials TwoFactorAuthBasicAuthCredentials { get => twoFactorAuthBasicAuthManager; }

        /// <summary>
        /// The credentials to use with VoiceBasicAuth
        /// </summary>
        public IVoiceBasicAuthCredentials VoiceBasicAuthCredentials { get => voiceBasicAuthManager; }

        /// <summary>
        /// The credentials to use with WebRtcBasicAuth
        /// </summary>
        public IWebRtcBasicAuthCredentials WebRtcBasicAuthCredentials { get => webRtcBasicAuthManager; }

        /// <summary>
        /// Http client timeout
        /// </summary>
        public TimeSpan Timeout { get; }

        /// <summary>
        /// Current API environment
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// BaseUrl value
        /// </summary>
        public string BaseUrl { get; }

        //A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Server, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Server, string>>
        {
            {
                Environment.Production, new Dictionary<Server, string>
                {
                    { Server.Default, "api.bandwidth.com" },
                    { Server.MessagingDefault, "https://messaging.bandwidth.com/api/v2" },
                    { Server.TwoFactorAuthDefault, "https://mfa.bandwidth.com/api/v1/" },
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

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        private List<KeyValuePair<string, object>> GetBaseUriParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("base_url", BaseUrl),
            };
            return kvpList;
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends 
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        public string GetBaseUri(Server alias = Server.Default)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            ApiHelper.AppendUrlWithTemplateParameters(Url, GetBaseUriParameters());
            return Url.ToString();
        }

        /// <summary>
        /// Creates an object of the BandwidthClient using the values provided for the builder.
        /// </summary>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Timeout(Timeout)
                .Environment(Environment)
                .BaseUrl(BaseUrl)
                .MessagingBasicAuthCredentials(messagingBasicAuthManager.BasicAuthUserName, messagingBasicAuthManager.BasicAuthPassword)
                .TwoFactorAuthBasicAuthCredentials(twoFactorAuthBasicAuthManager.BasicAuthUserName, twoFactorAuthBasicAuthManager.BasicAuthPassword)
                .VoiceBasicAuthCredentials(voiceBasicAuthManager.BasicAuthUserName, voiceBasicAuthManager.BasicAuthPassword)
                .WebRtcBasicAuthCredentials(webRtcBasicAuthManager.BasicAuthUserName, webRtcBasicAuthManager.BasicAuthPassword)
                .HttpCallBack(httpCallBack)
                .HttpClient(httpClient)
                .AuthManagers(authManagers);

            return builder;
        }

        public class Builder
        {
            private TimeSpan timeout = TimeSpan.FromSeconds(100);
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
            private HttpClientConfiguration httpClientConfig = new HttpClientConfiguration();
            private IHttpClient httpClient;
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Credentials setter for MessagingBasicAuth
            /// </summary>
            public Builder MessagingBasicAuthCredentials(string messagingBasicAuthUserName, string messagingBasicAuthPassword)
            {
                this.messagingBasicAuthUserName = messagingBasicAuthUserName ?? throw new ArgumentNullException(nameof(messagingBasicAuthUserName));
                this.messagingBasicAuthPassword = messagingBasicAuthPassword ?? throw new ArgumentNullException(nameof(messagingBasicAuthPassword));
                return this;
            }

            /// <summary>
            /// Credentials setter for TwoFactorAuthBasicAuth
            /// </summary>
            public Builder TwoFactorAuthBasicAuthCredentials(string twoFactorAuthBasicAuthUserName, string twoFactorAuthBasicAuthPassword)
            {
                this.twoFactorAuthBasicAuthUserName = twoFactorAuthBasicAuthUserName ?? throw new ArgumentNullException(nameof(twoFactorAuthBasicAuthUserName));
                this.twoFactorAuthBasicAuthPassword = twoFactorAuthBasicAuthPassword ?? throw new ArgumentNullException(nameof(twoFactorAuthBasicAuthPassword));
                return this;
            }

            /// <summary>
            /// Credentials setter for VoiceBasicAuth
            /// </summary>
            public Builder VoiceBasicAuthCredentials(string voiceBasicAuthUserName, string voiceBasicAuthPassword)
            {
                this.voiceBasicAuthUserName = voiceBasicAuthUserName ?? throw new ArgumentNullException(nameof(voiceBasicAuthUserName));
                this.voiceBasicAuthPassword = voiceBasicAuthPassword ?? throw new ArgumentNullException(nameof(voiceBasicAuthPassword));
                return this;
            }

            /// <summary>
            /// Credentials setter for WebRtcBasicAuth
            /// </summary>
            public Builder WebRtcBasicAuthCredentials(string webRtcBasicAuthUserName, string webRtcBasicAuthPassword)
            {
                this.webRtcBasicAuthUserName = webRtcBasicAuthUserName ?? throw new ArgumentNullException(nameof(webRtcBasicAuthUserName));
                this.webRtcBasicAuthPassword = webRtcBasicAuthPassword ?? throw new ArgumentNullException(nameof(webRtcBasicAuthPassword));
                return this;
            }

            /// <summary>
            /// Setter for Environment.
            /// </summary>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Setter for BaseUrl.
            /// </summary>
            public Builder BaseUrl(string baseUrl)
            {
                this.baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
                return this;
            }

            /// <summary>
            /// Setter for Timeout.
            /// </summary>
            public Builder Timeout(TimeSpan timeout)
            {
                httpClientConfig.Timeout = timeout.TotalSeconds <= 0 ? TimeSpan.FromSeconds(100) : timeout;
                this.createCustomHttpClient = true;
                return this;
            }

            /// <summary>
            /// Sets the IHttpClient for the Builder.
            /// </summary>
            internal Builder HttpClient(IHttpClient httpClient)
            {
                this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                return this;
            }

            /// <summary>
            /// Sets the authentication managers for the Builder.
            /// </summary>
            internal Builder AuthManagers(IDictionary<string, IAuthManager> authManagers)
            {
                this.authManagers = authManagers ?? throw new ArgumentNullException(nameof(authManagers));
                return this;
            }

            /// <summary>
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the BandwidthClient using the values provided for the builder.
            /// </summary>
            public BandwidthClient Build()
            {
                if (createCustomHttpClient) 
                {
                    httpClient = new HttpClientWrapper(httpClientConfig);
                } 
                else 
                {
                    httpClient = new HttpClientWrapper();
                }

                return new BandwidthClient(timeout, environment, baseUrl, messagingBasicAuthUserName, messagingBasicAuthPassword,
                        twoFactorAuthBasicAuthUserName, twoFactorAuthBasicAuthPassword, voiceBasicAuthUserName,
                        voiceBasicAuthPassword, webRtcBasicAuthUserName, webRtcBasicAuthPassword, authManagers, httpClient,
                        httpCallBack, httpClientConfig);
            }
        }

    }
}
