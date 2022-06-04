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

        public void CreateTournament(string sportType, string tournamentSystem, string description, DateTime startDate, DateTime endDate, int minimumPlayers, int maximumPlayers, string location)
        {
            Tournament tournament = new Tournament();
            tournament.SportType = new BadmintonSportType();
            tournament.Description = description;
            tournament.StartDate = startDate;
            tournament.EndDate = endDate;
            tournament.MinPlayers = minimumPlayers;
            tournament.MaxPlayers = maximumPlayers;
            tournament.Location = location;
            tournament.RegistrationCloses = tournament.SetRegistrationClosesDate();

            if (tournamentSystem == "Round Robin")
            {
                tournament.TournamentSystem = new RoundRobin();
            }
            else
            {
                tournament.TournamentSystem = new DoubleRoundRobin();
            }

            tournamentRepository.SaveTournament(tournament);
        }

        public void UpdateTournament(int id, string sportType, string tournamentSystem, string description, DateTime startDate, DateTime endDate, int minimumPlayers, int maximumPlayers, string location)
        {
            Tournament tournament = new Tournament();
            tournament.Id = id;
            tournament.SportType = new BadmintonSportType();
            tournament.Description = description;
            tournament.StartDate = startDate;
            tournament.EndDate = endDate;
            tournament.MinPlayers = minimumPlayers;
            tournament.MaxPlayers = maximumPlayers;
            tournament.Location = location;
            tournament.RegistrationCloses = tournament.SetRegistrationClosesDate();
            if (tournamentSystem == "Round Robin")
            {
                tournament.TournamentSystem = new RoundRobin();
            }
            else
            {
                tournament.TournamentSystem = new DoubleRoundRobin();
            }
            tournamentRepository.UpdateTournament(tournament);
        }

        public List<Tournament> GetAllOpenTournaments()
        {
            return tournamentRepository.GetAllOpenTournaments();
        }

        public void DeleteTournament(int id)
        {
            tournamentRepository.DeleteTournament(id);
        }

        public List<Tournament> GetAllPendingTournaments()
        {
            List<Tournament> tournaments = tournamentRepository.GetAllPendingTournaments();
            return tournaments;
        }

        public void SetStatusToOngoing(int id)
        {
            tournamentRepository.SetStatusToOngoing(id);
        }

        public List<Tournament> GetAllOngoingTournaments()
        {
            List<Tournament> tournaments = tournamentRepository.GetAllOngoingTournaments();
            return tournaments;

        }

        public void SetStatusToFinished(int id)
        {
            tournamentRepository.SetStatusToFinished(id);
        }

        public void CheckStatusesOfTournaments()
        {
            List<Tournament> tournaments = tournamentRepository.GetAllTournaments();
            DateTime today = DateTime.Today;
            foreach (Tournament tournament in tournaments)
            {
                if (tournament.RegistrationCloses == today)
                    if (tournamentRepository.GetNumberOfRegisteredPlayersForTournament(tournament.Id) < tournament.MinPlayers)
                    {
                        tournamentRepository.SetStatusToCancelled(tournament.Id);
                    }
                    else
                    {
                        tournamentRepository.SetStatusToPending(tournament.Id);
                    }
            }
        }
    }
}
