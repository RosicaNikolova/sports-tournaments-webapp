using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class DoubleRoundRobin : ITournamentSystem
    {
        public List<Game> GenerateSchedule(List<User>players)
        {
            List<Game> games = new List<Game>();
            for (int i = 0; i < players.Count - 1; i++)
            {
                for (int k = i + 1; k < players.Count; k++)
                {
                    Game gameHome = new Game();
                    gameHome.Player1Id = players[i].Id;
                    gameHome.Player2Id = players[k].Id;

                    Game gameAway = new Game();
                    gameAway.Player1Id = players[k].Id;
                    gameAway.Player2Id = players[i].Id;

                    games.Add(gameHome);
                    games.Add(gameAway);
                }

            }
            return games;
        }

        public override string ToString()
        {
            return "Double Round-Robin";
        }
    }
}
