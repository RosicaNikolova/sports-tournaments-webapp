using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class DoubleRoundRobin : ITournamentSystem
    {
        public List<Game> GenerateSchedule()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Double Round Robin";
        }
    }
}
