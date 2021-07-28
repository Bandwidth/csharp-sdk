// <copyright file="WebRtcClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.WebRtc
{
    using System;
    using Bandwidth.Standard.WebRtc.Controllers;

    /// <summary>
    /// WebRtcClient Class.
    /// </summary>
    public sealed class WebRtcClient
    {
        private readonly BandwidthClient bandwidthClient;
        private readonly Lazy<APIController> client;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRtcClient"/> class.
        /// </summary>
        /// <param name="bandwidthClient"> bandwidthClient.</param>
        public WebRtcClient(BandwidthClient bandwidthClient)
        {
            this.bandwidthClient = bandwidthClient;
            this.client = new Lazy<APIController>(
                () => new APIController(this.bandwidthClient, this.bandwidthClient.HttpClient, this.bandwidthClient.AuthManagers));
        }

        /// <summary>
        /// Gets APIController controller.
        /// </summary>
        public APIController APIController => this.client.Value;
    }
}