/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
// uncomment below to import models
//using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Api
{
    /// <summary>
    ///  Class for testing MFAApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MFAApiTests : IDisposable
    {
        private MFAApi instance;

        public MFAApiTests()
        {
            instance = new MFAApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MFAApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MFAApi
            //Assert.IsType<MFAApi>(instance);
        }

        /// <summary>
        /// Test GenerateMessagingCode
        /// </summary>
        [Fact]
        public void GenerateMessagingCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //CodeRequest codeRequest = null;
            //var response = instance.GenerateMessagingCode(accountId, codeRequest);
            //Assert.IsType<MessagingCodeResponse>(response);
        }

        /// <summary>
        /// Test GenerateVoiceCode
        /// </summary>
        [Fact]
        public void GenerateVoiceCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //CodeRequest codeRequest = null;
            //var response = instance.GenerateVoiceCode(accountId, codeRequest);
            //Assert.IsType<VoiceCodeResponse>(response);
        }

        /// <summary>
        /// Test VerifyCode
        /// </summary>
        [Fact]
        public void VerifyCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //VerifyCodeRequest verifyCodeRequest = null;
            //var response = instance.VerifyCode(accountId, verifyCodeRequest);
            //Assert.IsType<VerifyCodeResponse>(response);
        }
    }
}
