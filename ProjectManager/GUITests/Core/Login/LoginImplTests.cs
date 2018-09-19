using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManager.Core.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Core.Login.Tests
{
    [TestClass()]
    public class LoginImplTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            var username = "admin";
            var password = "admin";
            var login = new LoginImpl();
            var user = login.Login(username, password);
            Assert.IsNotNull(user);
        }

    }
}