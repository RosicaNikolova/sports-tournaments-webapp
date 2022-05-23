using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class UserManager
    {
        private IUserRepository userRepository;

        public UserManager(IUserRepository repo)
        {
            this.userRepository = repo;
        }
    }
}
