/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using Bandwidth.Standard.TwoFactorAuth.Controllers;

namespace Bandwidth.Standard.TwoFactorAuth
{
    public sealed class TwoFactorAuthClient
    {
        private readonly BandwidthClient bandwidthClient;
        private readonly Lazy<MFAController> mFA;

        /// <summary>
        /// Provides access to MFAController controller
        /// </summary>
        public MFAController MFAController => mFA.Value;

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public TwoFactorAuthClient(BandwidthClient bandwidthClient)
        {
            this.bandwidthClient = bandwidthClient;
            mFA = new Lazy<MFAController>(
                () => new MFAController(this.bandwidthClient, this.bandwidthClient.httpClient, this.bandwidthClient.authManagers));

        }
        #endregion
    }
}