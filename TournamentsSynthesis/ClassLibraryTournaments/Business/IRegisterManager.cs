using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface IRegisterManager
    {
        public bool Register(string email, string password, string firstName, string lastName);

    }
}
