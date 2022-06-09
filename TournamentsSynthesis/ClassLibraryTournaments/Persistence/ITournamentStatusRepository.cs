using ClassLibraryTournaments.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public interface ITournamentStatusRepository
    {
        public int GetNumberOfRegisteredPlayersForTournament(int id);
        public void ChangeTournamentStatus(int id, Status status);
    }
}
