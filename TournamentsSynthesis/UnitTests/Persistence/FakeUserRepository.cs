using ClassLibraryTournaments;
using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Persistence
{
    public class FakeUserRepository : IUserRepository
    {
        List<User> users;

        public FakeUserRepository(List<User> users)
        {
            this.users = users;       
        }
        public bool CheckIfUserExists(string email)
        {
            foreach (User user in users)
            {
                if(user.Email == email)
                {
                    return false;
                }
            }
            return true;
        }

        public User FindUser(string email, string password)
        {
            foreach (User user in users)
            {
                if(user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public User GetPlayerById(int userId)
        {
            foreach (User user in users)
            {
                if(user.Id == userId)
                {
                    return user;
                }
            }
            return null;
        }

        public void RegisterUser(User user)
        {
            users.Add(user);
        }
    }
}
