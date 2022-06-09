using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Persistence
{
    public class FakeTournamentStatusRepository : ITournamentStatusRepository
    {

        Dictionary<int, int> placesavailable;

        public List<Tournament> tournaments;

        public FakeTournamentStatusRepository(List<Tournament> tournaments)
        {
            this.tournaments = tournaments;
        }

        public FakeTournamentStatusRepository(Dictionary<int, int> placesAvailable)
        {
            this.placesavailable = placesAvailable;
        }

        public void ChangeTournamentStatus(int id, Status status)
        {
            foreach (Tournament tournament in tournaments)
            {
                if (tournament.Id == id)
                {
                    tournament.Status = status;
                }
            }
        }

        public int GetNumberOfRegisteredPlayersForTournament(int id)
        {
            tournaments = new List<Tournament>();
            tournaments.Add(new Tournament() { Id = id });
            return placesavailable[id];
        }
    }
}
