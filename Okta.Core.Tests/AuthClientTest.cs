using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Okta.Core.Clients;

namespace Okta.Core.Tests
{
    [TestClass]
    public class AuthClientTest : BaseTest
    {
        [TestMethod]
        [ExpectedException(typeof(OktaAuthenticationException))]
        public void AuthExceptionTest()
        {
            var client = new AuthClient(testSettings);

            client.Authenticate("fakeusername", "fakepassword");
        }
    }
}
