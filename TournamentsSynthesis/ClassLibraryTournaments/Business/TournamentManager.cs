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

        public Dictionary<int, User> GetNamesOfOtherPlayers(int userId)
        {
           
            return tournamentRepository.GetNamesOfOponents(userId);
        }

        public Tournament GetTournamentById(int idTournament)
        {
            return tournamentRepository.GetTournamentById(idTournament);
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

        public bool RegisterPlayerForTournament(int idTournament, int idPlayer)
        {
            if(tournamentRepository.PlayerNotRegistered(idTournament, idPlayer))
            {
                tournamentRepository.RegisterPlayer(idTournament, idPlayer);         

                if (tournamentRepository.GetAvailablePlaces()[idTournament] == 0)
                {
                    tournamentRepository.SetStatusToPending(idTournament);
                }
                return true;
            }
            else
            {
                return false;
            }
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

        public Dictionary<int, int> GetAvailablePlaces()
        {
            return tournamentRepository.GetAvailablePlaces();
        }

        public Dictionary<int, User> GetNamesOfPlayersForTournament(int id)
        {
            return tournamentRepository.GetNamesOfPlayersForTournament(id);
        }


        public Dictionary<User, int> GetRankingForTournament(int id)
        {
            return tournamentRepository.GetRankingForTournament(id);
        }

        public Dictionary<int, int> GetRankingForPlayer(int userId, List<Tournament> tournaments)
        {
            Dictionary<int, int> ranking = new Dictionary<int, int>();
            foreach (Tournament tournament in tournaments)
            {
                Dictionary<User, int> rankingForTournament =  tournamentRepository.GetRankingForTournament(tournament.Id);
                int counter = 1;
                foreach (var user in rankingForTournament)
                {
                    if(user.Key.Id == userId)
                    {
                        ranking.Add(tournament.Id, counter);
                    }
                    counter++;
                }
            }
            return ranking;
        }

        public List<Tournament> GetTournamentsForPlayer(int userId)
        {
            return tournamentRepository.GetTournamentsForPlayer(userId);
        }
    }
}
