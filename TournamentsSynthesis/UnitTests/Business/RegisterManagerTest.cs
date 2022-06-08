using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class RegisterManagerTest
    {

        [TestMethod]
        public void RegisterTest()
        {
            User user = new User();
            user.Email = "Dannil@mail.com";
            user.Password = "12345678";

            List<User> users = new List<User>();
            users.Add(user);

            FakeUserRepository fakeRepo = new FakeUserRepository(users);

            RegisterManager registerManager = new RegisterManager(fakeRepo);
            bool registerSuccessful = registerManager.Register("rositsa@mail.com", "12345678", "Rositsa", "Nikolova");
            Assert.AreEqual(true, registerSuccessful);
        }

        [TestMethod]
        public void RegisterFailsTest()
        {
            User user = new User();
            user.Email = "rositsa@mail.com";
            user.Password = "12345678";

            List<User> users = new List<User>();
            users.Add(user);

            FakeUserRepository fakeRepo = new FakeUserRepository(users);

            RegisterManager registerManager = new RegisterManager(fakeRepo);
            bool registerSuccessful = registerManager.Register("rositsa@mail.com", "12345678", "Rositsa", "Nikolova");
            Assert.AreEqual(false, registerSuccessful);
        }
    }
}
