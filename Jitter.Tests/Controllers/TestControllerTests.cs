using System;
using System.Web.Mvc;
using Jitter.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jitter.Tests.Controllers
{
    [TestClass]
    public class TestControllerTests
    {
        [TestMethod]
        public void TestControllerCanCallGetAction()
        {
            TestController my_controller = new TestController();
            string expected_output = "Hello, is it me for whom you are looking?";
            string actual_output = my_controller.Get();
            Assert.AreEqual(expected_output, actual_output);
        }
    }
}
