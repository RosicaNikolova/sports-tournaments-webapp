using ClassLibraryTournaments.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class GameManager : IGameManager
    {

        private IGameRepository gameRepository;
        public GameManager(IGameRepository repo)
        {
            this.gameRepository = repo;
        }

        public List<Game> GenerateGames(Tournament tournament)
        {
            List<User> playersForTournament = GetPlayersForTournament(tournament.Id);
            List <Game> games = tournament.TournamentSystem.GenerateSchedule(playersForTournament);
            gameRepository.SaveGames(games, tournament.Id);
            return games;
        }

        public List<User> GetPlayersForTournament(int idTournament)
        {
            List<User> playersForTournament = new List<User>();
            playersForTournament = gameRepository.GetPlayersForTournament(idTournament);
            return playersForTournament;
        }

        public List<Game> GetGamesForTournament(int id)
        {
            List<Game> games = gameRepository.GetGamesForTournament(id);
            return games;

        }

        public void SaveResults(List<Game> games)
        {
            foreach (Game game in games)
            {
                if (game.Result1 > game.Result2)
                {
                    game.WinnerId = game.Player1Id;
                }
                else
                {
                    game.WinnerId = game.Player2Id;
                }
            }
            gameRepository.SaveResults(games);
        }

        public Dictionary<int, List<Game>> GetGamesForPlayer(int userId)
        {
            return gameRepository.GetGamesForPlayer(userId);
        }

        public bool CheckIfAllResultsAreEntered(int id)
        {
            return gameRepository.CheckIfAllResultsAreEntered(id);
        }
    }
}
