using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface IUserManager
    {
        public User GetPlayerById(int userId);
     
        public bool UpdateUser(string email, string password, string firstName, string lastName, int userId);
       
    }
}

