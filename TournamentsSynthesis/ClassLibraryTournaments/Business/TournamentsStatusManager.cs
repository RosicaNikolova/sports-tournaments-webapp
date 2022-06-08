using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class TournamentsStatusManager : ITournamentsStatusManager
    {
        private ITournamentRepository tournamentRepository;
        public TournamentsStatusManager(ITournamentRepository repo)
        {
            this.tournamentRepository = repo;
        }

        public void ChangeTournamentStatus(int id, Status status)
        {
            tournamentRepository.ChangeTournamentStatus(id, status);
        }

        public void CheckStatusesOfTournaments(List<Tournament> tournamentsToCheck)
        {
            DateTime today = DateTime.Today;
            foreach (Tournament tournament in tournamentsToCheck)
            {
                if (tournament.RegistrationCloses == today)
                {
                    if (tournamentRepository.GetNumberOfRegisteredPlayersForTournament(tournament.Id) < tournament.MinPlayers)
                    {
                        tournamentRepository.ChangeTournamentStatus(tournament.Id, Status.cancelled);
                    }
                    else
                    {
                        tournamentRepository.ChangeTournamentStatus(tournament.Id, Status.pending);
                    }
                }
            }
        }

    }
}
