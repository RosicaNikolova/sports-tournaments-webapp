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
        List<Game> GetGamesForTournament(int id);
        void SaveResults(Game game);
    }
}
