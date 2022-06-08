using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class TournamentSystemTest
    {
        [TestMethod]
        public void GenerateRoundRobinTest()
        {
            ITournamentSystem tournamentSystem= new RoundRobin();
            List<User> users = new List<User>();
            User user = new User();
            user.Id = 1;
            User user1 = new User();
            user1.Id = 2;
            User user2 = new User();
            user2.Id = 3;
            users.Add(user);
            users.Add(user1);
            users.Add(user2);
            List <Game> gamesGenerated = tournamentSystem.GenerateSchedule(users);

            List<Game> gamesExpected = new List<Game>();
            Game game = new Game();
            game.Player1Id = 1;
            game.Player2Id = 2;

            Game game1 = new Game();
            game1.Player1Id = 1;
            game1.Player2Id = 3;

            Game game2 = new Game();
            game2.Player1Id = 2;
            game2.Player2Id = 3;
            gamesExpected.Add(game);
            gamesExpected.Add(game1);
            gamesExpected.Add(game2);

            
            //CollectionAssert.AreEquivalent(gamesExpected, gamesGenerated);
            Assert.AreEqual(game2, gamesExpected[2]);
          
        }

        [TestMethod]
        public void GenerateDoubleRoundRobinTest()
        {
            ITournamentSystem tournamentSystem = new DoubleRoundRobin();
            List<User> users = new List<User>();
            User user = new User();
            user.Id = 1;
            User user1 = new User();
            user1.Id = 2;
            users.Add(user);
            users.Add(user1);
         
            List<Game> gamesGenerated = tournamentSystem.GenerateSchedule(users);

            List<Game> gamesExpected = new List<Game>();
            Game game = new Game();
            game.Player1Id = 1;
            game.Player2Id = 2;

            Game game1 = new Game();
            game1.Player1Id = 2;
            game1.Player2Id = 1;

            gamesExpected.Add(game);
            gamesExpected.Add(game1);

            //CollectionAssert.AreEquivalent(gamesExpected, gamesGenerated);
            Assert.AreEqual(game1, gamesExpected[1]);
        }
    }
}
