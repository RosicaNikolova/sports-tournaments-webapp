using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface ITournamentManager
    {
        public List<Tournament> GetAllTournaments();
    }
}
