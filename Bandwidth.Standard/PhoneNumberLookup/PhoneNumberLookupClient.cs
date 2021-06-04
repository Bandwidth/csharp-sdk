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
        private readonly Lazy<NumberLookupController> numberLookup;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberLookupClient"/> class.
        /// </summary>
        /// <param name="bandwidthClient"> bandwidthClient.</param>
        public PhoneNumberLookupClient(BandwidthClient bandwidthClient)
        {
            this.bandwidthClient = bandwidthClient;
            this.numberLookup = new Lazy<NumberLookupController>(
                () => new NumberLookupController(this.bandwidthClient, this.bandwidthClient.HttpClient, this.bandwidthClient.AuthManagers, this.bandwidthClient.HttpCallBack));
        }

        /// <summary>
        /// Gets NumberLookupController controller.
        /// </summary>
        public NumberLookupController NumberLookupController => this.numberLookup.Value;
    }
}