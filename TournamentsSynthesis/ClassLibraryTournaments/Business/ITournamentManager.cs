using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface ITournamentManager
    {
        public List<Tournament> GetAllTournaments();

        public void CreateTournament(string sportType, string tournamentSystem, string description, DateTime startDate, DateTime endDate, int minimumPlayers, int maximumPlayers, string location);


        public Dictionary<int, User> GetNamesOfOtherPlayers(int userId);


        public Tournament GetTournamentById(int idTournament);


        public void UpdateTournament(int id, string sportType, string tournamentSystem, string description, DateTime startDate, DateTime endDate, int minimumPlayers, int maximumPlayers, string location);


        public List<Tournament> GetAllOpenOrCancelledTournaments();


        public bool RegisterPlayerForTournament(int idTournament, int idPlayer);

        public List<Tournament> GetAllTournamentsWithStatus(Status status);

        public void DeleteTournament(int id);

        public Dictionary<int, int> GetAvailablePlaces();


        public Dictionary<int, User> GetNamesOfPlayersForTournament(int id);

        public Dictionary<User, int> GetRankingForTournament(int id);

        public Dictionary<int, int> GetRankingForPlayer(int userId, List<Tournament> tournaments);

        public List<Tournament> GetTournamentsForPlayer(int userId);

    }
}
