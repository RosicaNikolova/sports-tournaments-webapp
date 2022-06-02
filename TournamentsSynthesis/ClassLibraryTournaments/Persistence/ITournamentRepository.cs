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
        public void SetStatusToOngoing(int id);
        public List<Tournament> GetAllOngoingTournaments();
        public void SetStatusToFinished(int id);
    }
}
