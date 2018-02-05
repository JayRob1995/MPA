using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectBusinessLayer;

namespace BusinessLayerTest
{
    [TestClass]
    public class UserManagementTest
    {
        [TestMethod]
        public void TestLoginUser()
        {
            UserManagement User = new UserManagement();
            Assert.AreEqual(false, User.LoginUser("admin", "PASSWORD"), "Password not same captitalisation");
            Assert.AreEqual(true, User.LoginUser("admin", "password"), "Acceptable Input not allowed - admin lowercase?");
            Assert.AreEqual(true, User.LoginUser("Admin", "password"), "Acceptable Input not allowed - admin capital letter?");
            Assert.AreEqual(true, User.LoginUser("ADMIN", "password"), "Acceptable Input not allowed - admin capitals?");
        }
    }
}
