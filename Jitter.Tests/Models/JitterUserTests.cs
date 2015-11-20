using System;
using Jitter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JitterUserTests
    {
        [TestMethod]
        public void JitterUserCanCreateInstance()
        {
            JitterUser test1 = new JitterUser();
            Assert.IsNotNull(test1);
        }

        [TestMethod]
        public void JitterUserHasAllTheStuff()
        {
            JitterUser test1 = new JitterUser();
            test1.JitterUserID = 1;
            test1.Handle = "Bob1";
            test1.FirstName = "Bob";
            test1.LastName = "Smith";
            test1.PicURL = "http://pic.com";
            test1.Description = "I'm Bob.";
            Assert.AreEqual("Bob1", test1.Handle);
            Assert.AreEqual("Bob", test1.FirstName);
            Assert.AreEqual("Smith", test1.LastName);
            Assert.AreEqual("http://pic.com", test1.PicURL);
            Assert.AreEqual("I'm Bob.", test1.Description);
        }
    }
}
