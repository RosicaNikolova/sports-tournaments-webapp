using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TournamentsWebApp.Pages
{
    public class TournamentModel : PageModel
    {
        public Tournament tournament;
        public List<User> players;
        public List<Game> games = null;
        //User - user, int - point for the tournament
        public Dictionary<User, int> ranking = null;
        public Dictionary<int, User> namesOfPlayersForGames = null;
        public IActionResult OnGet(int id)
        {
            TournamentManager tournamentManager = new TournamentManager(new TournamentRepository());
            GameManager gameManager = new GameManager(new GameRepository());
            tournament = tournamentManager.GetTournamentById(id);
            if (tournament != null)
            {

                if (tournament.Status != Status.cancelled)
                {
                    players = gameManager.GetPlayersForTournament(id);
                }
                if (tournament.Status == Status.finished || tournament.Status == Status.ongoing)
                {
                    games = gameManager.GetGamesForTournament(id);
                    namesOfPlayersForGames = tournamentManager.GetNamesOfPlayersForTournament(id);
                    ranking = tournamentManager.GetRankingForTournament(id);
                }
            }
            return Page();

        }
    }
}
