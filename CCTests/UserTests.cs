using System;
using System.Collections.Generic;
using System.Linq;
using CCDomain;
using CCExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserTests;

namespace PWTests
{
    [TestClass]
    public class UserTests
    {
        private readonly IEnumerable<User> users;
        public UserTests()
        {
            users = TestUsers.CreateMockUsers();
        }
        [TestMethod]
        public void TestUserCCChanged()
        {
            var ret = users.SaveOrUpdate(2,"0000111122223333");
            Assert.IsTrue(users.Where(user => user.Id == 2).FirstOrDefault().CC == "0000111122223333");
            Assert.IsTrue(ret == 1);
        }
        [TestMethod]
        public void TestInvalidUser()
        {
            var ret = users.SaveOrUpdate(1, "0000111122223333");
            Assert.IsTrue(ret == 0);
        }
        [TestMethod]
        public void Test()
        {
            var ret = users.SaveOrUpdate(1, "0000111122223333");
            Assert.IsTrue(ret == 0);
        }
    }
}
