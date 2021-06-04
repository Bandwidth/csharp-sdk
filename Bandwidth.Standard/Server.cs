// <copyright file="Server.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard
{
    /// <summary>
    /// Available servers.
    /// </summary>
    public enum Server
    {
        /// <summary>
        /// Default.
        /// </summary>
        Default,

        /// <summary>
        /// MessagingDefault.
        /// </summary>
        MessagingDefault,

        /// <summary>
        /// TwoFactorAuthDefault.
        /// </summary>
        TwoFactorAuthDefault,

        /// <summary>
        /// PhoneNumberLookupDefault.
        /// </summary>
        PhoneNumberLookupDefault,

        /// <summary>
        /// VoiceDefault.
        /// </summary>
        VoiceDefault,

        /// <summary>
        /// WebRtcDefault.
        /// </summary>
        WebRtcDefault,
    }
}
