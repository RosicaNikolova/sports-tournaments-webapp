using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class RoundRobin : ITournamentSystem
    {
        public List<Game> GenerateSchedule(List<User>players)
        {
            List<Game> games = new List<Game>();
            for (int i = 0; i < players.Count-1 ; i++)
            {
                for (int k = i+1; k < players.Count; k++)
                {
                    Game game = new Game();
                    game.Player1Id = players[i].Id;
                    game.Player2Id = players[k].Id;
                    games.Add(game);
                }

            }
            return games;
        }
        public override string ToString()
        {
            return "Round Robin";
        }
    }
}
