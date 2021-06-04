// <copyright file="TwoFactorAuthClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.TwoFactorAuth
{
    using System;
    using Bandwidth.Standard.TwoFactorAuth.Controllers;

    /// <summary>
    /// TwoFactorAuthClient Class.
    /// </summary>
    public sealed class TwoFactorAuthClient
    {
        private readonly BandwidthClient bandwidthClient;
        private readonly Lazy<MFAController> mFA;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorAuthClient"/> class.
        /// </summary>
        /// <param name="bandwidthClient"> bandwidthClient.</param>
        public TwoFactorAuthClient(BandwidthClient bandwidthClient)
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