using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    class BadmintonSportType : ISportType
    {
        public bool CheckResults(Game game)
        {
            
        }

        public override string ToString()
        {
            return "Badminton";
        }
    }
}
