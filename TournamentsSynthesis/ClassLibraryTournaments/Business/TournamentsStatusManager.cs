using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class TournamentsStatusManager : ITournamentsStatusManager
    {
        private ITournamentStatusRepository statusRepository;
        public TournamentsStatusManager(ITournamentStatusRepository repo)
        {
            this.statusRepository = repo;
        }

        public void ChangeTournamentStatus(int id, Status status)
        {
            statusRepository.ChangeTournamentStatus(id, status);
        }

        public void CheckStatusesOfTournaments(List<Tournament> tournamentsToCheck)
        {
            DateTime today = DateTime.Today;
            foreach (Tournament tournament in tournamentsToCheck)
            {
                if (tournament.RegistrationCloses == today)
                {
                    if (statusRepository.GetNumberOfRegisteredPlayersForTournament(tournament.Id) < tournament.MinPlayers)
                    {
                        statusRepository.ChangeTournamentStatus(tournament.Id, Status.cancelled);
                    }
                    else
                    {
                        statusRepository.ChangeTournamentStatus(tournament.Id, Status.pending);
                    }
                }
            }
        }

    }
}
