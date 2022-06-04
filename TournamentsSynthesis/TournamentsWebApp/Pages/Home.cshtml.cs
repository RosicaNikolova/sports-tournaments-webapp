using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace TournamentsWebApp.Pages
{
    public class HomeModel : PageModel
    {
        public List<Tournament> tournaments;

        public IActionResult OnGet()
        {
            try
            {
                TournamentManager tournamentManager  = new TournamentManager(new TournamentRepository());
                tournaments = tournamentManager.GetAllTournaments();
                return Page();
            }
            catch (DataBaseException)
            {
                ViewData["Error_message"] = "An error occured while adding the content of this page. Please, try again.";
                return new RedirectToPageResult("Error");

            }
            catch (Exception)
            {
                ViewData["Error_message"] = "An error occured while adding the content of this page. Please, try again.";
                return new RedirectToPageResult("Error");
            }
        }
    }
}
