// <copyright file="MessagingClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Messaging
{
    using System;
    using Bandwidth.Standard.Messaging.Controllers;

    /// <summary>
    /// MessagingClient Class.
    /// </summary>
    public sealed class MessagingClient
    {
        private readonly BandwidthClient bandwidthClient;
        private readonly Lazy<APIController> client;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingClient"/> class.
        /// </summary>
        /// <param name="bandwidthClient"> bandwidthClient.</param>
        public MessagingClient(BandwidthClient bandwidthClient)
        {
            this.bandwidthClient = bandwidthClient;
            this.client = new Lazy<APIController>(
                () => new APIController(this.bandwidthClient, this.bandwidthClient.HttpClient, this.bandwidthClient.AuthManagers, this.bandwidthClient.HttpCallBack));
        }

        /// <summary>
        /// Gets APIController controller.
        /// </summary>
        public APIController APIController => this.client.Value;
    }
}