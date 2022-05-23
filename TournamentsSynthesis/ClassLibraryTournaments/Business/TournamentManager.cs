using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class TournamentManager : ITournamentManager
    {
        private ITournamentRepository tournamentRepository;
        public TournamentManager(ITournamentRepository repo)
        {
            this.tournamentRepository = repo;
        }

        public List<Tournament> GetAllTournaments()
        {
            List<Tournament> tournaments = tournamentRepository.GetAllTournaments();
            return tournaments;
        }
    }
}
