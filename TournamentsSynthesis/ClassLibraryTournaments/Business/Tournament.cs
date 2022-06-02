using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class Tournament
    {
        public int Id { get; set; }
        public ISportType SportType { get; set; }
        public ITournamentSystem TournamentSystem { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime RegistrationCloses { get; set; }
        public DateTime EndDate { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public string Location { get; set; }
        public Status Status { get; set; }


        public override string ToString()
        {
            return $"{TournamentSystem.ToString()} Location: {Location}";
        }

        public Tournament()
        {
            RegistrationCloses = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day);
        }
    }

    

}
