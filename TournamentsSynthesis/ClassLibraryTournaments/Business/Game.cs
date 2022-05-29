using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class Game
    {
        public int GameId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int TournamentId { get; set; }
        public int Result1 { get; set; }
        public int Result2 { get; set; }
        public int WinnerId { get; set; }

        public override string ToString()
        {
            return $"Player:{Player1Id} - Player:{Player2Id}";
        }
    }
}
