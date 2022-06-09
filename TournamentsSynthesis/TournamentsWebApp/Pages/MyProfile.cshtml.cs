using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TournamentsWebApp.Pages
{
    [Authorize]
    public class MyProfileModel : PageModel
    {

        public User user = null;
        public List<Tournament> tournaments = null;

        //tournamne id, ranking
        public Dictionary<int, int> ranking = null;

        //tournament id, games
        public Dictionary<int, List<Game>> games = null;

        //user id, User
        public Dictionary<int, User> names = null;

        public IActionResult OnGet()
        {
            UserManager userManager = new UserManager(new UserRepository());
            TournamentManager tournamentManager = new TournamentManager(new TournamentRepository());
            GameManager gameManager = new GameManager(new GameRepository());
            try
            {
                int userId = Convert.ToInt32(User.FindFirst("id").Value);

                //I query the user because I have to show personal information on the page
                user = userManager.GetPlayerById(userId);
                tournaments = tournamentManager.GetTournamentsForPlayer(userId);
                if (tournaments.Count != 0)
                {
                    games = gameManager.GetGamesForPlayer(userId);
                    ranking = tournamentManager.GetRankingForPlayer(userId, tournaments);
                    names = tournamentManager.GetNamesOfOtherPlayers(userId);
                }

                return Page();

            }
            catch (DataBaseException)
            {
                return new RedirectToPageResult("Error");
            }
            catch (Exception)
            {
                return new RedirectToPageResult("Error");
            }
        }
    }
}
