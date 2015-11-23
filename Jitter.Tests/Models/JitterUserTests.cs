using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jitter.Models;
using System.Collections.Generic;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JitterUserTests
    {
        [TestMethod]
        public void JitterUserEnsureICanCreateInstance()
        {
            JitterUser a_user = new JitterUser();
            Assert.IsNotNull(a_user);
        }

        [TestMethod]
        public void JitterUserEnsureJitterUserHasAllTheThings()
        {
            // Arrange
            JitterUser a_user = new JitterUser();
            a_user.Handle = "adam1";
            a_user.FirstName = "Adam";
            a_user.LastName = "Sandler";
            a_user.Picture = "https://google.com";
            a_user.Description = "I am Awesome!";

            // Assert 
            Assert.AreEqual("I am Awesome!", a_user.Description);
            Assert.AreEqual("adam1", a_user.Handle);
            Assert.AreEqual("Adam", a_user.FirstName);
            Assert.AreEqual("Sandler", a_user.LastName);
            Assert.AreEqual("https://google.com", a_user.Picture);

        }

        [TestMethod]
        public void JitterUserHasJots()
        {
            List<Jot> ListOfJots = new List<Jot>
            {
                new Jot { Content = "blah" },
                new Jot { Content = "blah2" }
            };
            JitterUser a_user = new JitterUser { Handle = "Bobbert", Jots = ListOfJots};
            List<Jot> actual_jots = a_user.Jots;
            CollectionAssert.AreEqual(ListOfJots, actual_jots);
        }

        [TestMethod]
        public void JitterUserFollowsOtherUsers()
        {
            List<JitterUser> ListOfUsers = new List<JitterUser>
            {
                new JitterUser { Handle = "sara1" },
                new JitterUser {Handle = "john1" }
            };
            JitterUser a_user = new JitterUser { Handle = "bobbert", Following = ListOfUsers };
            List<JitterUser> actual_users = a_user.Following;
            CollectionAssert.AreEqual(ListOfUsers, actual_users);
        }


    }
}
