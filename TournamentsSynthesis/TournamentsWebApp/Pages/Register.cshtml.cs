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
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User Register { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            RegisterManager registerManager = new RegisterManager(new UserRepository());

            if (ModelState.IsValid)
            {
                try
                {
                    bool registrationSucessful = registerManager.Register(Register.Email, Register.Password, Register.FirstName, Register.LastName);
                    if (registrationSucessful)
                    {
                        return new RedirectToPageResult("Login");
                    }
                    else
                    {
                        ViewData["Message_register"] = "User with these credentials already exists.";
                        return Page();
                    }
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
            else
            {
                return Page();
            }
        }
    }
}
