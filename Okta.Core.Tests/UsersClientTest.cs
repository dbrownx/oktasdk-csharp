using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Okta.Core.Clients;

namespace Okta.Core.Tests
{
    [TestClass]
    public class UsersClientTest : BaseTest
    {
        [TestMethod]
        public void GetSingleUserTest()
        {
            var client = new UsersClient(testSettings);

            // Get a user by their short name
            var shortUser = client.Get("administrator1");
            Assert.IsNotNull(shortUser.Id);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            var client = new UsersClient(testSettings);

            // Get a user by their short name
            var shortUser = client.Get("administrator1");
            shortUser.Profile.MobilePhone = "changed";

            var updatedUser = client.Update(shortUser);

            Assert.AreEqual(shortUser.Profile.MobilePhone, updatedUser.Profile.MobilePhone);
            Assert.IsTrue(shortUser.LastUpdated < updatedUser.LastUpdated);
        }
    }
}
