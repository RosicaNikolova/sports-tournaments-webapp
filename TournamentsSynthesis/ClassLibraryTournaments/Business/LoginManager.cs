using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class LoginManager : ILoginManager
    {
        private IUserRepository userRepository;

        public LoginManager(IUserRepository repo)
        {
            this.userRepository = repo;
        }

        public User Login(string email, string password)
        {
            User user = userRepository.FindUser(email, password);
            return user;
        }
    }


}
