// <copyright file="MultiFactorAuthClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.MultiFactorAuth
{
    using System;
    using Bandwidth.Standard.MultiFactorAuth.Controllers;

    /// <summary>
    /// MultiFactorAuthClient Class.
    /// </summary>
    public sealed class MultiFactorAuthClient
    {
        private readonly BandwidthClient bandwidthClient;
        private readonly Lazy<MFAController> mFA;

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiFactorAuthClient"/> class.
        /// </summary>
        /// <param name="bandwidthClient"> bandwidthClient.</param>
        public MultiFactorAuthClient(BandwidthClient bandwidthClient)
        {
            this.bandwidthClient = bandwidthClient;
            this.mFA = new Lazy<MFAController>(
                () => new MFAController(this.bandwidthClient, this.bandwidthClient.HttpClient, this.bandwidthClient.AuthManagers));
        }

        /// <summary>
        /// Gets MFAController controller.
        /// </summary>
        public MFAController MFAController => this.mFA.Value;
    }
}