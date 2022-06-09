using ClassLibraryTournaments.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public interface ITournamentRepository
    {
        public List<Tournament> GetAllTournaments();
        public void SaveTournament(Tournament tournament);
        public void UpdateTournament(Tournament tournament);
        public void DeleteTournament(int id);
        public Dictionary<int, int> GetAvailablePlaces();
        public Tournament GetTournamentById(int idTournament);
        public bool PlayerNotRegistered(int idTournament, int idPlayer);
        public void RegisterPlayer(int idTournament, int idPlayer);
        public Dictionary<User, int> GetRankingForTournament(int id);
        public Dictionary<int, User> GetNamesOfPlayersForTournament(int id);
        public List<Tournament> GetTournamentsForPlayer(int userId);
        public Dictionary<int, User> GetNamesOfOponents(int userId);
        public void DeleteRegisteredPlayersForTournament(int id);
        public List<Tournament> GetAllOpenOrCancelledTournaments();
        List<Tournament> GetAllTournamentsWithStatus(Status status);
    }
}
