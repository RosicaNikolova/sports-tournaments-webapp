using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public interface IUserRepository
    {
        public User FindUser(string email, string password);
        public User GetPlayerById(int userId);
        public bool CheckIfUserExists(string email);
        public void RegisterUser(User user);
    }
}
