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

        public User GetPlayerById(int userId)
        {
            return userRepository.GetPlayerById(userId);
        }

        public bool UpdateUser(string email, string password, string firstName, string lastName, int userId)
        {
            if (userRepository.CheckIfAnotherUsesWithSameEmail(email, userId))
            {
                User user = new User();
                user.Email = email;
                user.Password = password;
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Id = userId;
                userRepository.UpdateUser(user);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
