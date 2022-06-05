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
    public class SignUpForTournamentModel : PageModel
    {
        public Tournament tournament;
        public User player;
        TournamentManager tournamentManager = new TournamentManager(new TournamentRepository());
        UserManager userManager = new UserManager(new UserRepository());


        public IActionResult OnGet(int id)
        {
            try
            {
                //if (User.Identity.IsAuthenticated)
                //{
                //I querry the user because I need to display player's personal infromation 
                int userId = Convert.ToInt32(User.FindFirst("id").Value);

                    player = userManager.GetPlayerById(userId);
                    int tournamnetId = id;
                    tournament = tournamentManager.GetTournamentById(tournamnetId);
                //}
                return Page();
            }
            catch (DataBaseException)
            {
                ViewData["Error_message"] = "There is a problem with our database at the moment. Please, contact the support.";
                return new RedirectToPageResult("Error");
            }
            catch (Exception)
            {
                ViewData["Error_message"] = "An error occured while loading the page. Please, try again.";
                return new RedirectToPageResult("Error");
            }
        }

        public void OnPost(int id)
        {
            //try
            //{
            int userId = Convert.ToInt32(User.FindFirst("id").Value);

            if (tournamentManager.RegisterPlayerForTournament(id, userId))
            {
                @ViewData["Message"] = "Registration completed successfully";
            }
            else
            {
                @ViewData["Message"] = "You are already registered for this tournament";
            }
                OnGet(id);
                //return Page();
            //}
            //catch (DataBaseException)
            //{
            //    ViewData["Error_message"] = "An error occured while loading the page. Please, try again.";
            //    return new RedirectToPageResult("Error");
            //}
            //catch (Exception)
            //{
            //    ViewData["Error_message"] = "An error occured while loading the page. Please, try again.";
            //    return new RedirectToPageResult("Error");
            //}
        }
    }
}
