using System;
using Moq;
using System.Data.Entity;
using Jitter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JitterRepositoryTests
    {
        [TestMethod]
        public void JitterContextCanCreateInstance()
        {
            JitterContext context = new JitterContext();
            Assert.IsNotNull(context);
        }

        [TestMethod]
        public void JitterRepositoryCanCreateInstance()
        {
            JitterRepository repository = new JitterRepository();
            Assert.IsNotNull(repository);
        }

        [TestMethod]
        public void JitterRepositoryCanGetAllUsers()
        {
            var expected = new List<JitterUser>
            {
                new JitterUser { Handle = "Bobbert"},
                new JitterUser { Handle = "Sara1"}
            };
            Mock<JitterContext> mock_context = new Mock<JitterContext>();
            Mock<DbSet<JitterUser>> mock_set = new Mock<DbSet<JitterUser>>();
            JitterRepository repository = new JitterRepository(mock_context.Object);
            mock_set.Object.AddRange(expected);

            //This is stubbing the JitterUsers property getter
            mock_context.Setup(a => a.JitterUsers).Returns(mock_set.Object);
            var actual = repository.GetAllUsers();
            //Assert.AreEqual("Bobbert", actual.First().Handle);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JitterRepositoryCanGetContext()
        {
            JitterRepository repository = new JitterRepository();
            var actual = repository.Context;
            Assert.IsInstanceOfType(actual, typeof(JitterContext));
        }

    }
}
