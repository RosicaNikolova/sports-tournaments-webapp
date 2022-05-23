using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class TournamentManager
    {
        private ITournamentRepository tournamentRepository;
        public TournamentManager(ITournamentRepository repo)
        {
            this.tournamentRepository = repo;
        }
 
    }
}
