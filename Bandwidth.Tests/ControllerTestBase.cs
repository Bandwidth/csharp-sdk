using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Bandwidth.Standard;
using Bandwidth.Standard.Http.Client;
using Bandwidth.Tests.Helpers;

namespace Bandwidth.Tests
{
    [TestFixture]
    public class ControllerTestBase
    {
        //Test setup
        public const int REQUEST_TIMEOUT = 60;
        protected const double ASSERT_PRECISION = 0.1;
        public TimeSpan globalTimeout = TimeSpan.FromSeconds(REQUEST_TIMEOUT);

        protected BandwidthClient client;

        internal HttpCallBack httpCallBackHandler;

        [OneTimeSetUp]
        public void SetUp()
        {
            httpCallBackHandler = new HttpCallBack();
            client = BandwidthClient.CreateFromEnvironment().ToBuilder()
                .HttpCallBack(httpCallBackHandler)
                .Build();
        }
    }
}