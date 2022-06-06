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
        public Dictionary<int, int> GetAvailablePlaces();
        public Tournament GetTournamentById(int idTournament);
        public bool PlayerNotRegistered(int idTournament, int idPlayer);
        public void RegisterPlayer(int idTournament, int idPlayer);
        Dictionary<User, int> GetRankingForTournament(int id);
    }
}
