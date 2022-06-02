using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface ISportType
    {
        public bool CheckResults(Game game);
    }
}
