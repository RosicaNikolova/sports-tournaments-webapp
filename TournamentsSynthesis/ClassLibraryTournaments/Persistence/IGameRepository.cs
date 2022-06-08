using ClassLibraryTournaments.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public interface IGameRepository
    {
        public List<User> GetPlayersForTournament(int id);
        public void SaveGames(List<Game> games, int tournamentId);
        public List<Game> GetGamesForTournament(int id);
        public void SaveResults(List<Game> games);
        public bool CheckIfAllResultsAreEntered(int id);
        public Dictionary<int, List<Game>> GetGamesForPlayer(int userId);
    }
}
