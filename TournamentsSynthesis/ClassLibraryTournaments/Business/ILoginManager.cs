using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface ILoginManager
    {
        public User Login(string email, string password);
    }
}
