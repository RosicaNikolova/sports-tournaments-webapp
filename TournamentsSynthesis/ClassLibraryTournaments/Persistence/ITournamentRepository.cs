using ClassLibraryTournaments.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public interface ITournamentRepository
    {
        public List<Tournament> GetAllTournaments();
        public void SaveTournament(Tournament tournament);
        public void UpdateTournament(Tournament tournament);
        public void DeleteTournament(int id);
        public List<Tournament> GetAllPendingTournaments();
        public List<Tournament> GetAllOngoingTournaments();
        public List<Tournament> GetAllOpenTournaments();
        public void SetStatusToOngoing(int id);
        public void SetStatusToFinished(int id);
        public void SetStatusToCancelled(int id);
        public void SetStatusToPending(int id);
        public int GetNumberOfRegisteredPlayersForTournament(int id);
        Dictionary<int, int> GetAvailablePlaces();
    }
}
