using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnterpriseProject;
using EnterpriseProject.Controllers;

namespace EnterpriseProject.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void LogOn()
        {
            AccountController controller = new AccountController();
            ViewResult result = controller.LogOn() as ViewResult;
            Assert.IsNotNull(result);
        }

        /*[TestMethod]
        public void Register()
        {
            AccountController controller = new AccountController();
            ViewResult result = controller.Register() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ChangePassword()
        {
            AccountController controller = new AccountController();
            ViewResult result = controller.ChangePassword() as ViewResult;
            Assert.IsNotNull(result);
        }
         */
    }
}
