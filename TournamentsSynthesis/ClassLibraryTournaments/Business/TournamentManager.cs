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
            tournament.SportType = sportType;
            tournament.Description = description;
            tournament.StartDate = startDate;
            tournament.EndDate = endDate;
            tournament.MinPlayers = minimumPlayers;
            tournament.MaxPlayers = maximumPlayers;
            tournament.Location = location;
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
            tournament.SportType = sportType;
            tournament.Description = description;
            tournament.StartDate = startDate;
            tournament.EndDate = endDate;
            tournament.MinPlayers = minimumPlayers;
            tournament.MaxPlayers = maximumPlayers;
            tournament.Location = location;
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
    }
}
