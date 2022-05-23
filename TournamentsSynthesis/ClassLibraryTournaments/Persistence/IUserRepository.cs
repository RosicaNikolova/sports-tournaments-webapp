using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public interface IUserRepository
    {
        User FindUser(string email, string password);
    }
}
