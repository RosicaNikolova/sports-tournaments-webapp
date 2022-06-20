using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface IGameManager
    {
        public List<Game> GenerateGames(Tournament tournament);

        public List<User> GetPlayersForTournament(int idTournament);

        public List<Game> GetGamesForTournament(int id);

        public void SaveResults(List<Game> games);

        public Dictionary<int, List<Game>> GetGamesForPlayer(int userId);

        public bool CheckIfAllResultsAreEntered(int id);


    }
}
