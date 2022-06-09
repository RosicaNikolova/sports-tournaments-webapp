using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Persistence
{
    public class FakeTournamentRepository : ITournamentRepository
    {
        public List<Tournament> tournaments;
        Dictionary<Tournament, List<int>> tournamentsPlayers = new Dictionary<Tournament, List<int>>();
        public Dictionary<User, int> rankingForTournament;
        Dictionary<int, int> placesavailable = new Dictionary<int, int>();
        Dictionary<int, User> namesOfOponents;

        public FakeTournamentRepository(List<Tournament> tournaments)
        {
            this.tournaments = tournaments;
        }

        //Key- Tournamnet, value - List of player's ids
        public FakeTournamentRepository(Dictionary<Tournament, List<int>> tournamentsPlayers)
        {
            this.tournamentsPlayers = tournamentsPlayers;
        }

        //Key - User, Value - points
        public FakeTournamentRepository(Dictionary<User, int> rankingForTournament)
        {
            this.rankingForTournament = rankingForTournament;
        }

        //Key - Tournament Id, Value - places available
        public FakeTournamentRepository(Dictionary<int, int> placesAvailable)
        {
            this.placesavailable = placesAvailable;
        }

        //Key - User Id, Value-List of users
        public FakeTournamentRepository(Dictionary<int, User> namesOfOponents)
        {
            this.namesOfOponents = namesOfOponents;
        }

        //Key - tournamentId, Value - registeredPlayers
        //public FakeTournamentRepository(Dictionary<int, int> tournamentRegisteredPlayers)
        //{
        //    this.placesavailable = tournamentRegisteredPlayers;
        //}

        public List<Tournament> GetAllTournaments()
        {
            return tournaments;
        }

        public Tournament GetTournamentById(int idTournament)
        {
            foreach (Tournament tournament in tournaments)
            {
                if (tournament.Id == idTournament)
                {
                    return tournament;
                }
            }
            return null;
        }

        public void DeleteRegisteredPlayersForTournament(int id)
        {
            foreach (var keyValuePair in tournamentsPlayers)
            {
                if (keyValuePair.Key.Id == id)
                {
                    keyValuePair.Value.Clear();
                }
            }
        }

        public void DeleteTournament(int id)
        {
            foreach (var tournament in tournaments)
            {
                if (tournament.Id == id)
                {
                    tournaments.Remove(tournament);
                }
            }
        }


        public List<Tournament> GetAllOpenOrCancelledTournaments()
        {
            List<Tournament> tournamentsResult = new List<Tournament>();
            foreach (Tournament tournament in tournaments)
            {
                if (tournament.Status == Status.open || tournament.Status == Status.cancelled)
                {
                    tournamentsResult.Add(tournament);
                }
            }
            return tournamentsResult;
        }

        public Dictionary<int, int> GetAvailablePlaces()
        {
            return placesavailable;
        }

        //Key - id User , User
        public Dictionary<int, User> GetNamesOfOponents(int userId)
        {
            return namesOfOponents;
        }

        public Dictionary<int, User> GetNamesOfPlayersForTournament(int id)
        {
            Dictionary<int, User> result = new Dictionary<int, User>();

            foreach (var tournament in tournamentsPlayers)
            {
                if (tournament.Key.Id == id)
                {
                    foreach (int player in tournament.Value)
                    {
                        result.Add(player, new User());
                    }

                }
            }
            return result;
        }

        public Dictionary<User, int> GetRankingForTournament(int id)
        {
            return rankingForTournament;
        }
        public List<Tournament> GetTournamentsForPlayer(int userId)
        {
            List<Tournament> tournamentsResult = new List<Tournament>();


            foreach (var keyValuePair in tournamentsPlayers)
            {
                if (keyValuePair.Value.Contains(userId))
                {
                    tournamentsResult.Add(keyValuePair.Key);
                }
            }
            return tournamentsResult;
        }

        public bool PlayerNotRegistered(int idTournament, int idPlayer)
        {
            foreach (var keyValuePair in tournamentsPlayers)
            {
                if(keyValuePair.Key.Id == idTournament)
                {
                    if (keyValuePair.Value.Contains(idPlayer))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void RegisterPlayer(int idTournament, int idPlayer)
        {
            tournamentsPlayers.Add(new Tournament() { Id = idTournament }, new List<int>() { idPlayer });
        }

        public void SaveTournament(Tournament tournament)
        {
            tournament.Id = 1;
            tournaments.Add(tournament);
        }

        public void UpdateTournament(Tournament tournament)
        {
            for (int i = 0; i < tournaments.Count; i++)
            {
                if (tournaments[i].Id == tournament.Id)
                {
                    tournaments[i] = tournament;
                }
            }
        }

        public List<Tournament> GetAllTournamentsWithStatus(Status status)
        {
            List<Tournament> tournamentsResult = new List<Tournament>();
            foreach (Tournament tournament in tournaments)
            {
                if(tournament.Status == status)
                {
                    tournamentsResult.Add(tournament);
                }
            }
            return tournamentsResult;
        }
    }

}
