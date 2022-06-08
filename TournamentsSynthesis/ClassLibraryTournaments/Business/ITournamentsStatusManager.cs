using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface ITournamentsStatusManager
    {
        public void ChangeTournamentStatus(int id, Status status);
        public void CheckStatusesOfTournaments(List<Tournament> tournamentsToCheck);

    }
}
