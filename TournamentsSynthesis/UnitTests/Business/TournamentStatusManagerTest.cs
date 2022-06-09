using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Persistence;

namespace UnitTests
{
    [TestClass]
    public class TournamentStatusManagerTest
    {

        [TestMethod]
        public void ChangeTournamentStatusToFinishedTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            tournament1.Status = Status.ongoing;

            List<Tournament> tournamentsPassed = new List<Tournament>() { tournament1 };
            FakeTournamentStatusRepository fakeRepo = new FakeTournamentStatusRepository(tournamentsPassed);

            TournamentsStatusManager tournamentStatusManager = new TournamentsStatusManager(fakeRepo);
            tournamentStatusManager.ChangeTournamentStatus(1, Status.finished);
            Assert.AreEqual(Status.finished, fakeRepo.tournaments[0].Status);
        }

        [TestMethod]
        public void ChangeTournamentStatusToPendingTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            tournament1.Status = Status.open;

            List<Tournament> tournamentsPassed = new List<Tournament>() { tournament1 };
            FakeTournamentStatusRepository fakeRepo = new FakeTournamentStatusRepository(tournamentsPassed);

            TournamentsStatusManager tournamentStatusManager = new TournamentsStatusManager(fakeRepo);
            tournamentStatusManager.ChangeTournamentStatus(1, Status.pending);
            Assert.AreEqual(Status.pending, fakeRepo.tournaments[0].Status);
        }

        [TestMethod]
        public void ChangeTournamentStatusToCacelledTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            tournament1.Status = Status.open;

            List<Tournament> tournamentsPassed = new List<Tournament>() { tournament1 };
            FakeTournamentStatusRepository fakeRepo = new FakeTournamentStatusRepository(tournamentsPassed);

            TournamentsStatusManager tournamentStatusManager = new TournamentsStatusManager(fakeRepo);
            tournamentStatusManager.ChangeTournamentStatus(1, Status.cancelled);
            Assert.AreEqual(Status.cancelled, fakeRepo.tournaments[0].Status);
        }

        [TestMethod]
        public void ChangeTournamentStatusTournamentNotFoundTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            tournament1.Status = Status.ongoing;

            List<Tournament> tournamentsPassed = new List<Tournament>() { tournament1 };
            FakeTournamentStatusRepository fakeRepo = new FakeTournamentStatusRepository(tournamentsPassed);

            TournamentsStatusManager tournamentStatusManager = new TournamentsStatusManager(fakeRepo);
            tournamentStatusManager.ChangeTournamentStatus(2, Status.finished);

            Assert.AreEqual(Status.ongoing, fakeRepo.tournaments[0].Status);
        }

        [TestMethod]
        public void CheckStatusesOfTournamentsSetToCancelTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            tournament1.Status = Status.open;
            tournament1.MinPlayers = 2;
            tournament1.RegistrationCloses = DateTime.Today;

            List<Tournament> tournamentsPassed = new List<Tournament>() { tournament1};

            Dictionary<int, int> tournamentAvaialblePlaces = new Dictionary<int, int>();
            tournamentAvaialblePlaces.Add(1, 1);
            tournamentAvaialblePlaces.Add(2, 6);
            

            FakeTournamentStatusRepository fakeRepo = new FakeTournamentStatusRepository(tournamentAvaialblePlaces);
            TournamentsStatusManager tournamentStatusManager = new TournamentsStatusManager(fakeRepo);
            tournamentStatusManager.CheckStatusesOfTournaments(tournamentsPassed);

            Assert.AreEqual(Status.cancelled, fakeRepo.tournaments[0].Status);
        }


        [TestMethod]
        public void CheckStatusesOfTournamentsSetToPendingTest()
        {
            Tournament tournament1 = new Tournament();
            tournament1.Id = 1;
            tournament1.Status = Status.open;
            tournament1.MinPlayers = 3;
            tournament1.RegistrationCloses = DateTime.Today;

            List<Tournament> tournamentsPassed = new List<Tournament>() { tournament1 };

            Dictionary<int, int> tournamentAvaialblePlaces = new Dictionary<int, int>();
            tournamentAvaialblePlaces.Add(1, 3);
            tournamentAvaialblePlaces.Add(2, 6);

            FakeTournamentStatusRepository fakeRepo = new FakeTournamentStatusRepository(tournamentAvaialblePlaces);
            TournamentsStatusManager tournamentStatusManager = new TournamentsStatusManager(fakeRepo);
            tournamentStatusManager.CheckStatusesOfTournaments(tournamentsPassed);

            Assert.AreEqual(Status.pending, fakeRepo.tournaments[0].Status);
        }

    }
}
