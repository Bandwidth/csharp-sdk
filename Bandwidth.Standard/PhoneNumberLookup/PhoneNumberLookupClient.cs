// <copyright file="PhoneNumberLookupClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.PhoneNumberLookup
{
    using System;
    using Bandwidth.Standard.PhoneNumberLookup.Controllers;

    /// <summary>
    /// PhoneNumberLookupClient Class.
    /// </summary>
    public sealed class PhoneNumberLookupClient
    {
        private readonly BandwidthClient bandwidthClient;
        private readonly Lazy<APIController> client;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberLookupClient"/> class.
        /// </summary>
        /// <param name="bandwidthClient"> bandwidthClient.</param>
        public PhoneNumberLookupClient(BandwidthClient bandwidthClient)
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