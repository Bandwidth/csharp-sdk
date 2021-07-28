// <copyright file="VoiceClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Voice
{
    using System;
    using Bandwidth.Standard.Voice.Controllers;

    /// <summary>
    /// VoiceClient Class.
    /// </summary>
    public sealed class VoiceClient
    {
        private readonly BandwidthClient bandwidthClient;
        private readonly Lazy<APIController> client;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceClient"/> class.
        /// </summary>
        /// <param name="bandwidthClient"> bandwidthClient.</param>
        public VoiceClient(BandwidthClient bandwidthClient)
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