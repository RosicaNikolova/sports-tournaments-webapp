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
        UserManager userManager = new UserManager(new UserRepository());

        User loggedUser;
        public IActionResult OnGet()
        {
            try
            {
                if(User.FindFirst("id").Value != null)
                {
                    return Page();
                }
                else
                {
                    return new RedirectToPageResult("Login");
                }
            }
            catch (DataBaseException)
            {
                ViewData["Error_message"] = "An error occured while loading the page. Please contact the support.";
                return new RedirectToPageResult("Error");
            }
            catch (Exception)
            {
                ViewData["Error_message"] = "An error occured while loading the page. Please contact the support.";
                return new RedirectToPageResult("Error");
            }
        }
    }
}
