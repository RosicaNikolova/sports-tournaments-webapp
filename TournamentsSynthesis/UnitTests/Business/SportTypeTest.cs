using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class SportTypeTest
    {
        [TestMethod]
        public void CheckResultsSuccessfulTest()
        {
            ISportType sportType= new BadmintonSportType();
            Game game = new Game();
            game.Result1 = 21;
            game.Result2 = 19;
            bool result = sportType.CheckResults(game);
            Assert.AreEqual(true, result);         
        }

        [TestMethod]
        public void CheckResultsSuccessful1Test()
        {
            ISportType sportType = new BadmintonSportType();
            Game game = new Game();
            game.Result1 = 24;
            game.Result2 = 22;
            bool result = sportType.CheckResults(game);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckResultsFailsTest()
        {
            ISportType sportType = new BadmintonSportType();
            Game game = new Game();
            game.Result1 = 30;
            game.Result2 = 30;
            bool result = sportType.CheckResults(game);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckResultsFails2Test()
        {
            ISportType sportType = new BadmintonSportType();
            Game game = new Game();
            game.Result1 = 0;
            game.Result2 = 0;
            bool result = sportType.CheckResults(game);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckResultsFails3Test()
        {
            ISportType sportType = new BadmintonSportType();
            Game game = new Game();
            game.Result1 = 23;
            game.Result2 = 24;
            bool result = sportType.CheckResults(game);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckResultsFails4Test()
        {
            ISportType sportType = new BadmintonSportType();
            Game game = new Game();
            game.Result1 = 21;
            game.Result2 = 21;
            bool result = sportType.CheckResults(game);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckResultsFails5Test()
        {
            ISportType sportType = new BadmintonSportType();
            Game game = new Game();
            game.Result1 = 10;
            game.Result2 = 9;
            bool result = sportType.CheckResults(game);
            Assert.AreEqual(false, result);
        }

    }
}
