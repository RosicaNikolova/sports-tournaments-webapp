using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Persistence
{
    public class FakeGameRepository : IGameRepository
    {
        public List<Game> games;
        Dictionary<int, List<Game>> gamesForPlayer;
        public FakeGameRepository(List<Game>games)
        {
            this.games = games;
        }
        public FakeGameRepository()
        {
            games = new List<Game>();
        }
        public FakeGameRepository(Dictionary<int, List<Game>> gamesForPlayer)
        {
            this.gamesForPlayer = gamesForPlayer;
        }
        public bool CheckIfAllResultsAreEntered(int id)
        {
            foreach (Game game in games)
            {
                if (game.TournamentId == id)
                {
                    if (game.Result1 == 0 && game.Result2 == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Dictionary<int, List<Game>> GetGamesForPlayer(int userId)
        {
            return gamesForPlayer;
        }

        public List<Game> GetGamesForTournament(int id)
        {
            List<Game> gamesResult = new List<Game>();
            foreach (Game game in games)
            {
                if(game.TournamentId == id)
                {
                    gamesResult.Add(game);
                }
            }
            return gamesResult;

        }

        public List<User> GetPlayersForTournament(int id)
        {
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1 });
            users.Add(new User() { Id = 2 });
            return users;
        }

        public void SaveGames(List<Game> newGames, int tournamentId)
        {
            foreach (Game game in newGames)
            {
                game.TournamentId = tournamentId;
                games.Add(game);
            }
        }

        public void SaveResults(List<Game> results)
        {
            foreach (Game result in results)
            {
                for (int i = 0; i < games.Count; i++)
                {
                    if (result.GameId == games[i].GameId)
                    {
                        games[i].Result1 = result.Result1;
                        games[i].Result2 = result.Result2;
                    }
                } 
            }
        }
    }
}
