using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Okta.Core.Clients;

namespace Okta.Core.Tests
{
    public class BaseTest
    {
        protected OktaSettings testSettings = new OktaSettings();

        public BaseTest()
        {
            testSettings.ApiToken = "00UeGvRv5SKYzuWgqIg1ycd4uqk2dfgyZq0eAtSMHA";
            testSettings.BaseUri = new Uri("http://rain.okta1.com:1802");
        }
    }
}
