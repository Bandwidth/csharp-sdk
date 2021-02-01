/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using Bandwidth.Standard.Messaging.Controllers;

namespace Bandwidth.Standard.Messaging
{
    public sealed class MessagingClient
    {
        private readonly BandwidthClient bandwidthClient;
        private readonly Lazy<APIController> client;

        /// <summary>
        /// Provides access to APIController controller
        /// </summary>
        public APIController APIController => client.Value;

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public MessagingClient(BandwidthClient bandwidthClient)
        {
            this.bandwidthClient = bandwidthClient;
            client = new Lazy<APIController>(
                () => new APIController(this.bandwidthClient, this.bandwidthClient.httpClient, this.bandwidthClient.authManagers, this.bandwidthClient.httpCallBack));

        }
        #endregion
    }
}