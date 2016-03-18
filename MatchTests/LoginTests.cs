using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatchAutomation;

namespace MatchTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }



        [TestMethod]
        public void LoginTest()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("nagaraju.yarru@gmail.com").WithPassword("abcd").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
