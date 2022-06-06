using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class RegisterManager : IRegisterManager
    {

        private IUserRepository userRepository;
        public RegisterManager(IUserRepository repo)
        {
            this.userRepository = repo;
        }

        public bool Register(string email, string password, string firstName, string lastName)
        {
            if(userRepository.CheckIfUserExists(email))
            {
                User user = new User();
                user.Email = email;
                user.Password = password;
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Role = Role.Player;
                userRepository.RegisterUser(user);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
