using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class LoginManagerTest
    {

        [TestMethod]
        public void LoginTest()
        {
            User user = new User();
            user.Email = "rositsa@mail.com";
            user.Password = "12345678";

            List<User> users = new List<User>();
            users.Add(user);

            FakeUserRepository fakeRepo = new FakeUserRepository(users);

            LoginManager loginManager = new LoginManager(fakeRepo);
            User userActual = loginManager.Login("rositsa@mail.com", "12345678");
            Assert.AreEqual(user, userActual);
        }

        [TestMethod]
        public void LoginUserNotFoundTest()
        {
            User user = new User();
            user.Email = "rositsa@mail.com";
            user.Password = "12345678";

            List<User> users = new List<User>();
            users.Add(user);

            FakeUserRepository fakeRepo = new FakeUserRepository(users);

            LoginManager loginManager = new LoginManager(fakeRepo);
            User userActual = loginManager.Login("Daniil@mail.com", "123");
            Assert.AreEqual(null, userActual);
        }
    }
}
