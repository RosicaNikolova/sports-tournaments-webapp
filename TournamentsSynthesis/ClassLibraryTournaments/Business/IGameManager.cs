using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public interface IGameManager
    {
        public List<Game> GenerateGames(Tournament tournament);

    }
}
