using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatchAutomation;

namespace MatchTests
{
    [TestClass]
    public class SignUpNewUserTests
    {
        [TestInitialize]
        public void Init()
       { 
            Driver.Initialize();
        }



        [TestMethod]
        public void New_User_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAsNewUser("ganeshosho@gmail.com").WithPassword("password").SignUp();

          Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
      
}
