using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface ITournamentSystem
    {
        public List<Game> GenerateSchedule(List<User>players);
    }
}
