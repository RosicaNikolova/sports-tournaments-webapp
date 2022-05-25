using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface ITournamentManager
    {
        public List<Tournament> GetAllTournaments();

        public void CreateTournament(string sportType, string tournamentSystem, string description, DateTime startDate, DateTime endDate, int minimumPlayers, int maximumPlayers, string location);

        public void UpdateTournament(int id, string sportType, string tournamentSystem, string description, DateTime startDate, DateTime endDate, int minimumPlayers, int maximumPlayers, string location);

        public void DeleteTournament(int id);


    }
}
