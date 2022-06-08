using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class GameManagerTest
    {

        [TestMethod]
        public void GenerateGamesTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.TournamentSystem = new RoundRobin();
            tournament1.Id = 1;

            Game game = new Game();
            game.Player1Id = 1;
            game.Player2Id = 2;
            game.TournamentId = 1;

            FakeGameRepository fakeRepo = new FakeGameRepository();

            GameManager gameManager = new GameManager(fakeRepo);
            List<Game> gamesActual = gameManager.GenerateGames(tournament1);
            Assert.AreEqual(game.Player1Id, gamesActual[0].Player1Id);
        }


        [TestMethod]
        public void GetPlayersForTournamentTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;

            User user = new User();
            user.Id = 1;
            User user1 = new User();
            user1.Id = 2;
            List<User> users = new List<User>() { user, user1 };
           
            FakeGameRepository fakeRepo = new FakeGameRepository();

            GameManager gameManager = new GameManager(fakeRepo);
            List<User> playersActual = gameManager.GetPlayersForTournament(tournament1.Id);
            Assert.AreEqual(users[1].Id, playersActual[1].Id);
        }

        [TestMethod]
        public void GetGamesForTournamentTest()
        {
            Game game = new Game();
            game.GameId = 1;
            game.TournamentId = 1;

            Game game2 = new Game();
            game2.GameId = 2;
            game2.TournamentId = 1;

            List<Game> games = new List<Game>();
            games.Add(game);
            games.Add(game2);

            FakeGameRepository fakeRepo = new FakeGameRepository(games);
            GameManager gameManager = new GameManager(fakeRepo);
            List<Game> gamesActual = gameManager.GetGamesForTournament(1);
            Assert.AreEqual(games[1].GameId, gamesActual[1].GameId);
        }


        [TestMethod]
        public void SaveResultsTest()
        {
            Game game = new Game();
            game.GameId = 1;
            game.TournamentId = 1;
     
            Game game1 = new Game();
            game1.GameId = 2;
            game1.TournamentId = 1;
        
            List<Game> games = new List<Game>();
            games.Add(game);
            games.Add(game1);

            FakeGameRepository fakeRepo = new FakeGameRepository(games);
            List<Game> gamesExpected = new List<Game>();

            game.Result1 = 21;
            game.Result2 = 19;
            game1.Result1 = 16;
            game1.Result2 = 21;
            gamesExpected.Add(game);
            gamesExpected.Add(game1);

            GameManager gameManager = new GameManager(fakeRepo);
            gameManager.SaveResults(gamesExpected);
            CollectionAssert.AreEqual(gamesExpected, fakeRepo.games);
        }


        [TestMethod]
        public void CheckIfAllResultsAreEnteredTest()
        {
            Game game = new Game();
            game.GameId = 1;
            game.TournamentId = 1;
            game.Result1 = 21;
            game.Result2 = 19;

            Game game1 = new Game();
            game1.GameId = 2;
            game1.TournamentId = 1;
            game1.Result1 = 16;
            game1.Result2 = 21;
            List<Game> games = new List<Game>();
            games.Add(game);
            games.Add(game1);

            FakeGameRepository fakeRepo = new FakeGameRepository(games);
            GameManager gameManager = new GameManager(fakeRepo);
            bool result = gameManager.CheckIfAllResultsAreEntered(1);

            Assert.AreEqual(true,result);
        }


        [TestMethod]
        public void CheckIfAllResultsAreEnteredReturnsFalseTest()
        {
            Game game = new Game();
            game.GameId = 1;
            game.TournamentId = 1;
            game.Result1 = 0;
            game.Result2 = 0;

            Game game1 = new Game();
            game1.GameId = 2;
            game1.TournamentId = 1;
            game1.Result1 = 16;
            game1.Result2 = 21;
            List<Game> games = new List<Game>();
            games.Add(game);
            games.Add(game1);

            FakeGameRepository fakeRepo = new FakeGameRepository(games);
            GameManager gameManager = new GameManager(fakeRepo);
            bool result = gameManager.CheckIfAllResultsAreEntered(1);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetGamesForPlayerTest()
        {
            //Key - tournamentId , Value - List of games
            Dictionary<int, List<Game>> tournamentGames = new Dictionary<int, List<Game>>();

            tournamentGames.Add(1, new List<Game>() { new Game() { GameId = 1 } });
            tournamentGames.Add(2, new List<Game>() { new Game() { GameId = 2 } });

           
            FakeGameRepository fakeRepo = new FakeGameRepository(tournamentGames);
            GameManager gameManager = new GameManager(fakeRepo);
            Dictionary<int, List<Game>> tournamentGamesActual = gameManager.GetGamesForPlayer(1);

            CollectionAssert.AreEqual(tournamentGames, tournamentGamesActual);
        }

        [TestMethod]
        public void GetGamesForPlayerReturns0Test()
        {
            //Key - tournamentId , Value - List of games
            Dictionary<int, List<Game>> tournamentGames = new Dictionary<int, List<Game>>();

            tournamentGames.Add(1, new List<Game>() { new Game() { GameId = 1 } });
            tournamentGames.Add(2, new List<Game>() { new Game() { GameId = 2 } });

            Dictionary<int, List<Game>> tournamentGamesExpected = new Dictionary<int, List<Game>>();


            FakeGameRepository fakeRepo = new FakeGameRepository(tournamentGames);
            GameManager gameManager = new GameManager(fakeRepo);
            Dictionary<int, List<Game>> tournamentGamesActual = gameManager.GetGamesForPlayer(1);

            CollectionAssert.AreEqual(tournamentGames, tournamentGamesActual);
        }
    }
}
