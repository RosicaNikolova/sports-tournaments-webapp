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
    public class AvailableTournamentsModel : PageModel
    {
        public List<Tournament> tournaments;
        public Dictionary<int, int> availablePlaces = new Dictionary<int, int>();


        public IActionResult OnGet()
        {
            try
            {
                TournamentManager tournamentManager = new TournamentManager(new TournamentRepository());
                tournaments = tournamentManager.GetAllOpenTournaments();
                if (tournaments.Count != 0)
                {
                    availablePlaces = tournamentManager.GetAvailablePlaces();
                }
                foreach (Tournament tournament in tournaments)
                {
                    if (!availablePlaces.ContainsKey(tournament.Id))
                    {
                        availablePlaces.Add(tournament.Id, tournament.MaxPlayers);
                    }
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
