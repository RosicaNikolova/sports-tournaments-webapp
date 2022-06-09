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
    public class EditProfileModel : PageModel
    {
        [BindProperty]
        public User EditedUser { get; set; }
        public User loggedUser { get; set; }
        UserManager userManager = new UserManager(new UserRepository());
        public IActionResult OnGet()
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst("id").Value);
                loggedUser = userManager.GetPlayerById(userId);
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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                //try
                //{
                    int userId = Convert.ToInt32(User.FindFirst("id").Value);
                    bool result = userManager.UpdateUser(EditedUser.Email, EditedUser.Password, EditedUser.FirstName, EditedUser.LastName, userId);
                    loggedUser = EditedUser;

                    if (result)
                    {
                        ViewData["Success_Message"] = "Profile's information successfully updated";

                        return Page();
                    }
                    else
                    {
                        ViewData["Fail_Message"] = "User with this email already exists";
                        return Page();
                    }
                //}

                //catch (DataBaseException)
                //{
                //    return new RedirectToPageResult("Error");
                //}
                //catch (Exception)
                //{
                //    return new RedirectToPageResult("Error");
                //}
            }
            else
            {
                return Page();
            }
        }
    }
}
