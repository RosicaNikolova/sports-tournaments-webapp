using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class TournamentManagerTest
    {
        [TestMethod]
        public void GetAllTournamentsTest()
        {
            List<Tournament> tournamentsExpected = new List<Tournament>() { new Tournament { Id = 1}, new Tournament { Id = 2 } };
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsExpected);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            List<Tournament> tournamentsActual = tournamentManager.GetAllTournaments();
            CollectionAssert.AreEqual(tournamentsExpected, tournamentsActual);
        }

        //when there are not tournaments
        [TestMethod]
        public void GetAllTournamentsTest2()
        {
            List<Tournament> tournamentsExpected = new List<Tournament>();
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsExpected);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            List<Tournament> tournamentsActual = tournamentManager.GetAllTournaments();
            CollectionAssert.AreEqual(tournamentsExpected, tournamentsActual);
        }

        [TestMethod]
        public void GetTournamentByIdTest()
        {
            Tournament tournamentExpected = new Tournament();
            tournamentExpected.Id = 1;
            Tournament tournamentSecond = new Tournament();
            tournamentSecond.Id = 2;

            List<Tournament> tournaments = new List<Tournament>() { tournamentExpected, tournamentSecond};
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournaments);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            Tournament tournamentActual = tournamentManager.GetTournamentById(1);
            Assert.AreEqual(tournamentExpected.Id, tournamentActual.Id);
        }

        [TestMethod]
        public void GetTournamentByIdReturnsNullTest()
        {
            Tournament tournament = new Tournament();
            tournament.Id = 2;

            List<Tournament> tournaments = new List<Tournament>() { tournament };
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournaments);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            Tournament tournamentActual = tournamentManager.GetTournamentById(1);
            Assert.AreEqual(null, tournamentActual);
        }


        [TestMethod]
        public void GetAllOpenOrCacelledTournamentsTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            tournament1.Status = Status.cancelled;
            Tournament tournament2 = new Tournament();
            tournament2.Id = 2;
            tournament2.Status = Status.open;
            Tournament tournament3 = new Tournament();
            tournament3.Id = 3;
            tournament3.Status = Status.finished;

            List<Tournament> tournamentsExcpected = new List<Tournament>() { tournament1, tournament2 };

            List<Tournament> tournamentsPassed = new List<Tournament>() { tournament1, tournament2, tournament3 };
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsPassed);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            List<Tournament> tournamentsActual = tournamentManager.GetAllOpenOrCancelledTournaments();
            CollectionAssert.AreEqual(tournamentsExcpected, tournamentsActual);
        }


        [TestMethod]
        public void GetAllOpenOrCacelledTournamentsReturns0Test()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            tournament1.Status = Status.ongoing;

            List<Tournament> tournamentsExcpected = new List<Tournament>() {};

            List<Tournament> tournamentsPassed = new List<Tournament>() { tournament1};
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsPassed);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            List<Tournament> tournamentsActual = tournamentManager.GetAllOpenOrCancelledTournaments();
            CollectionAssert.AreEqual(tournamentsExcpected, tournamentsActual);
        }


        [TestMethod]
        public void GetTournamentsForPlayerTest()
        {
            Dictionary<Tournament, List<int>> tournamentsPlayers = new Dictionary<Tournament, List<int>>();

            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            Tournament tournament2 = new Tournament();
            tournament2.Id = 2;
        
            int player1Id = 1;
            int player2Id = 2;

            tournamentsPlayers.Add(tournament1, new List<int>() { player1Id, player2Id});
            tournamentsPlayers.Add(tournament2, new List<int>() { player1Id, player2Id});

            List<Tournament> tournamentsExpected = new List<Tournament>() { tournament1, tournament2 };
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsPlayers);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            List<Tournament> tournamentsActual = tournamentManager.GetTournamentsForPlayer(player1Id);
            CollectionAssert.AreEqual(tournamentsExpected, tournamentsActual);
        }

        [TestMethod]
        public void GetTournamentsForPlayerReturns0Test()
        {
            Dictionary<Tournament, List<int>> tournamentsPlayers = new Dictionary<Tournament, List<int>>();

            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            Tournament tournament2 = new Tournament();
            tournament2.Id = 2;

            int player1Id = 1;
            int player2Id = 2;

            tournamentsPlayers.Add(tournament1, new List<int>() { player2Id });
            tournamentsPlayers.Add(tournament2, new List<int>() { player2Id });

            List<Tournament> tournamentsExpected = new List<Tournament>() { };
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsPlayers);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            List<Tournament> tournamentsActual = tournamentManager.GetTournamentsForPlayer(player1Id);
            CollectionAssert.AreEqual(tournamentsExpected, tournamentsActual);
        }



        [TestMethod]
        public void GetNamesOfPlayersForTournamentTest()
        {
            Dictionary<Tournament, List<int>> tournamentsPlayers = new Dictionary<Tournament, List<int>>();
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;

            int player1Id = 1;
            int player2Id = 2;

            tournamentsPlayers.Add(tournament1, new List<int>() { player1Id, player2Id });

            List<int> playersIdsExpected = new List<int>() { player1Id, player2Id};
          
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsPlayers);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            Dictionary<int, User> playersActual = tournamentManager.GetNamesOfPlayersForTournament(tournament1.Id);

            //I am getting the ids here because if I compare the dictionaries directrly they will never be equal becuse the objects(User) are not equal because of the references
            List<int> playersIdsActual = new List<int>();
            foreach (var keyValuePair in playersActual)
            {
                playersIdsActual.Add(keyValuePair.Key);
            }

            CollectionAssert.AreEqual(playersIdsExpected, playersIdsActual);
        }

        [TestMethod]
        public void GetNamesOfPlayersForTournamentReturns0Test()
        {
            Dictionary<Tournament, List<int>> tournamentsPlayers = new Dictionary<Tournament, List<int>>();
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;

            Tournament tournament2 = new Tournament();
            tournament1.Id = 2;

            int player1Id = 1;
            int player2Id = 2;

            tournamentsPlayers.Add(tournament2, new List<int>() {player1Id, player2Id});

            List<int> playersIdsExpected = new List<int>() {};

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsPlayers);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            Dictionary<int, User> playersActual = tournamentManager.GetNamesOfPlayersForTournament(tournament1.Id);

            //I am getting the ids here because if I compare the dictionaries directrly they will never be equal becuse the objects(User) are not equal because of the references
            List<int> playersIdsActual = new List<int>();
            foreach (var keyValuePair in playersActual)
            {
                playersIdsActual.Add(keyValuePair.Key);
            }

            CollectionAssert.AreEqual(playersIdsExpected, playersIdsActual);
        }


        [TestMethod]
        public void DeleteTournamentTest()
        {

            List<Tournament> tournamentsExpected = new List<Tournament>();
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            Tournament tournament2 = new Tournament();
            tournament1.Id = 2;

            tournamentsExpected.Add(tournament1);
            tournamentsExpected.Add(tournament2);
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentsExpected);
            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            tournamentsExpected.Remove(tournament1);
            tournamentManager.DeleteTournament(1);

            CollectionAssert.AreEqual(tournamentsExpected, fakeRepo.tournaments);
        }


        [TestMethod]
        public void CreateTournamentTest()
        {
            Tournament tournament = new Tournament();
            tournament.Id = 1;
            DateTime startDate = new DateTime(2022, 06, 22);
            DateTime endDate = new DateTime(2022, 06, 29);
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(new List<Tournament>());
            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            tournamentManager.CreateTournament("Badminton", "Round-Robin", "test", startDate, endDate, 2, 4, "Eindhoven");
            Assert.AreEqual(tournament.Id,fakeRepo.tournaments[0].Id);
        }

        [TestMethod]
        public void UpdateTournamentTest()
        {
            List<Tournament> tournaments = new List<Tournament>();
            Tournament tournament = new Tournament();
            tournament.Id = 1;
            tournament.Location = "Eindhoven";
            DateTime startDate = new DateTime(2022, 06, 22);
            DateTime endDate = new DateTime(2022, 06, 29);
            tournaments.Add(tournament);
            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournaments);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            tournamentManager.UpdateTournament(1, "Badminton", "Round-Robin", "test", startDate, endDate, 2, 4, "Breda");
            Assert.AreEqual("Breda", fakeRepo.tournaments[0].Location);
        }

        [TestMethod]
        public void GetRankingForTournamentTest()
        {
            //Key - user, Value - points
            Dictionary<User, int> rankingExpected = new Dictionary<User, int>();
            rankingExpected.Add(new User() { Id = 1 }, 3);
            rankingExpected.Add(new User() { Id = 2 }, 4);

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(rankingExpected);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);
            Dictionary<User, int>rankingActual = tournamentManager.GetRankingForTournament(1);

            Assert.AreEqual(rankingExpected, rankingActual);
        }


        [TestMethod]
        public void GetRankingForPlayerTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
          
            int userId = 1;
            List<Tournament> tournaments = new List<Tournament>();
            tournaments.Add(tournament1);

            //Key - tournamentId, Value - Rank
            Dictionary<int, int> rankingExpected = new Dictionary<int, int>();
            rankingExpected.Add(tournament1.Id, 1);

            //Passing the dictionary with ranking of players for this tournament
            Dictionary<User, int> rankingForTournament = new Dictionary<User, int>();
            rankingForTournament.Add(new User() { Id = userId }, 1);

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(rankingForTournament);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            //Key - tournamentId, Value - Rank
            Dictionary<int, int> rankingActual = tournamentManager.GetRankingForPlayer(1, tournaments);

            Assert.AreEqual(rankingExpected[1], rankingActual[1]);
        }


        [TestMethod]
        public void GetAvailablePlacesTest()
        {
            //Key - tournamentId, Value-Places Available
            Dictionary<int, int> placesAvailable = new Dictionary<int, int>();
            placesAvailable.Add(1, 3);
            placesAvailable.Add(2, 10);

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(placesAvailable);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            //Key - tournamentId, Value-Places Available
            Dictionary<int, int> placesActual = tournamentManager.GetAvailablePlaces();

            CollectionAssert.AreEqual(placesAvailable, placesActual);
        }

        [TestMethod]
        public void GetNamesOfOtherPlayersTest()
        {
            //Key - user id, Value - User
            Dictionary<int, User> namesOfOponents= new Dictionary<int, User>();
            namesOfOponents.Add(1, new User());
            namesOfOponents.Add(2, new User());

            int userId = 1;

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(namesOfOponents);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            Dictionary<int, User> namesOfOponentsActual = tournamentManager.GetNamesOfOtherPlayers(userId);

            CollectionAssert.AreEqual(namesOfOponents, namesOfOponentsActual);
        }

        [TestMethod]
        public void RegisterPlayerTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 3;
            int userId = 1;
            Dictionary<Tournament, List<int>> tournamentPlayers = new Dictionary<Tournament, List<int>>();
            tournamentPlayers.Add(tournament1, new List<int>());

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentPlayers);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            bool registerSuccessful = tournamentManager.RegisterPlayerForTournament(tournament1.Id ,userId);

            Assert.AreEqual(true, registerSuccessful);
        }

        [TestMethod]
        public void RegisterPlayerFailsTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 3;
            int userId = 1;
            Dictionary<Tournament, List<int>> tournamentPlayers = new Dictionary<Tournament, List<int>>();
            tournamentPlayers.Add(tournament1, new List<int>() { userId});

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournamentPlayers);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            bool registerSuccessful = tournamentManager.RegisterPlayerForTournament(tournament1.Id, userId);

            Assert.AreEqual(false, registerSuccessful);
        }

        [TestMethod]
        public void GetAllTournamentsWithStatusOpenTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 3;
            tournament1.Status = Status.open;
            Tournament tournament2 = new Tournament();
            tournament2.Id = 1;
            tournament2.Status = Status.cancelled;

            List<Tournament> tournamentsExpected = new List<Tournament>();
            tournamentsExpected.Add(tournament1);

            List<Tournament> tournaments = new List<Tournament>();
            tournaments.Add(tournament1);
            tournaments.Add(tournament2);

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournaments);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            List<Tournament> tournamentsActual = tournamentManager.GetAllTournamentsWithStatus(Status.open);

            CollectionAssert.AreEqual(tournamentsExpected, tournamentsActual);
        }

        [TestMethod]
        public void GetAllTournamentsWithStatusOngoingTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 3;
            tournament1.Status = Status.ongoing;
            Tournament tournament2 = new Tournament();
            tournament2.Id = 1;
            tournament2.Status = Status.pending;
            Tournament tournament3 = new Tournament();
            tournament3.Id = 1;
            tournament3.Status = Status.open;

            List<Tournament> tournamentsExpected = new List<Tournament>();
            tournamentsExpected.Add(tournament1);

            List<Tournament> tournaments = new List<Tournament>();
            tournaments.Add(tournament1);
            tournaments.Add(tournament2);
            tournaments.Add(tournament3);

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournaments);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            List<Tournament> tournamentsActual = tournamentManager.GetAllTournamentsWithStatus(Status.ongoing);

            CollectionAssert.AreEqual(tournamentsExpected, tournamentsActual);
        }

        [TestMethod]
        public void GetAllTournamentsWithStatusPendingTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 3;
            tournament1.Status = Status.pending;
            Tournament tournament2 = new Tournament();
            tournament2.Id = 1;
            tournament2.Status = Status.pending;
            Tournament tournament3 = new Tournament();
            tournament3.Id = 1;
            tournament3.Status = Status.open;

            List<Tournament> tournamentsExpected = new List<Tournament>();
            tournamentsExpected.Add(tournament1);
            tournamentsExpected.Add(tournament2);

            List<Tournament> tournaments = new List<Tournament>();
            tournaments.Add(tournament1);
            tournaments.Add(tournament2);
            tournaments.Add(tournament3);

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournaments);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            List<Tournament> tournamentsActual = tournamentManager.GetAllTournamentsWithStatus(Status.pending);

            CollectionAssert.AreEqual(tournamentsExpected, tournamentsActual);
        }

        [TestMethod]
        public void GetAllTournamentsWithStatusReturns0Test()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 3;
            tournament1.Status = Status.pending;
            Tournament tournament2 = new Tournament();
            tournament2.Id = 1;
            tournament2.Status = Status.finished;
            Tournament tournament3 = new Tournament();
            tournament3.Id = 1;
            tournament3.Status = Status.cancelled;

            List<Tournament> tournamentsExpected = new List<Tournament>();

            List<Tournament> tournaments = new List<Tournament>();
            tournaments.Add(tournament1);
            tournaments.Add(tournament2);
            tournaments.Add(tournament3);

            FakeTournamentRepository fakeRepo = new FakeTournamentRepository(tournaments);

            TournamentManager tournamentManager = new TournamentManager(fakeRepo);

            List<Tournament> tournamentsActual = tournamentManager.GetAllTournamentsWithStatus(Status.open);

            CollectionAssert.AreEqual(tournamentsExpected, tournamentsActual);
        }
    }
}
