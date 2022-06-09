using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class UserManagerTest
    {

        [TestMethod]
        public void GetPlayerByIdTest()
        {
            User user = new User();
            user.Id = 1;
            User user1 = new User();
            user1.Id = 2;
            List<User> users = new List<User>();
            users.Add(user);
            users.Add(user1);

            FakeUserRepository fakeRepo = new FakeUserRepository(users);

            UserManager userManager = new UserManager(fakeRepo);
            User userActual = userManager.GetPlayerById(user.Id);
            Assert.AreEqual(user, userActual);
        }

        [TestMethod]
        public void GetPlayerByIdReturnsNullTest()
        {
            User user = new User();
            user.Id = 1;
            User user1 = new User();
            user.Id = 2;

            List<User> users = new List<User>();
            users.Add(user);
            users.Add(user1);

            FakeUserRepository fakeRepo = new FakeUserRepository(users);

            UserManager userManager = new UserManager(fakeRepo);
            User userActual = userManager.GetPlayerById(3);
            Assert.AreEqual(null, userActual);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            User user = new User();
            user.Id = 1;
            user.Email = "rositsa@mail.com";
            user.FirstName = "Rositsa";
            user.LastName = "Nikolova";
            user.Password = "123";
          
            List<User> users = new List<User>();
            users.Add(user);
           
            FakeUserRepository fakeRepo = new FakeUserRepository(users);

            UserManager userManager = new UserManager(fakeRepo);
            bool result = userManager.UpdateUser("rositsa@mail.com", "123", "Rositsa", "Plamenova", 1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void UpdateUserFailsTest()
        {
            User user = new User();
            user.Id = 1;
            user.Email = "rositsa@mail.com";
            user.FirstName = "Rositsa";
            user.LastName = "Nikolova";
            user.Password = "123";

            User user1 = new User();
            user1.Id = 2;
            user1.Email = "Daniil@mail.com";
            user1.FirstName = "Daniil";
            user1.LastName = "Blagoev";
            user1.Password = "123";

            List<User> users = new List<User>();
            users.Add(user);
            users.Add(user1);

            FakeUserRepository fakeRepo = new FakeUserRepository(users);

            UserManager userManager = new UserManager(fakeRepo);
            bool result = userManager.UpdateUser("Daniil@mail.com", "1234", "Rositsa", "Plamenova", 1);
            Assert.AreEqual(false, result);
        }
    }
}
