using System;
using Jitter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JotTests
    {
        [TestMethod]
        public void JotICanCreateInstance()
        {
            Jot a_jot = new Jot();
            Assert.IsNotNull(a_jot);
        }

        [TestMethod]
        public void JotHasAllTheThings()
        {
            Jot a_jot = new Jot();
            DateTime expected_time = DateTime.Now;
            a_jot.ID = 1;
            a_jot.Content = "My Content";
            a_jot.Date = expected_time;
            a_jot.Author = null; //Need to create a user to have an author.
            a_jot.Picture = "https://google.com";
            Assert.AreEqual(1, a_jot.ID);
            Assert.AreEqual("My Content", a_jot.Content);
            Assert.AreEqual(expected_time, a_jot.Date);
            Assert.AreEqual(null, a_jot.Author);
            Assert.AreEqual("https://google.com", a_jot.Picture);
        }

        [TestMethod]
        public void JotCanUseObjectInitializerSyntax()
        {
            DateTime expected_time = DateTime.Now;
            Jot a_jot = new Jot { ID = 1, Content = "My Content", Author = null, Picture = "https://google.com", Date = expected_time };
            Assert.AreEqual(1, a_jot.ID);
            Assert.AreEqual("My Content", a_jot.Content);
            Assert.AreEqual(expected_time, a_jot.Date);
            Assert.AreEqual(null, a_jot.Author);
            Assert.AreEqual("https://google.com", a_jot.Picture);
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }

    }
}
