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

        private List<User> GetPlayersForTournament(int idTournament)
        {
            List<User> playersForTournament = new List<User>();
            playersForTournament = gameRepository.GetPlayersForTournament(idTournament);
            return playersForTournament;
        }
    }
}
