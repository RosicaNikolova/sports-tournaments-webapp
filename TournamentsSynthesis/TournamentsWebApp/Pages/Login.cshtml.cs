using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClassLibraryTournaments;
using ClassLibraryTournaments.Business;
using ClassLibraryTournaments.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TournamentsWebApp.Pages
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public User Login { get; set; }

        public IActionResult OnPost(string? returnUrl)
        {
            LoginManager loginManager = new LoginManager(new UserRepository());

            if (ModelState.IsValid)
            {
                try
                {
                    User user = loginManager.Login(Login.Email, Login.Password);
                    if (user != null)
                    {
                        if (user.Role == Role.Staff)
                        {
                            ViewData["Message"] = "Wellcome Staff! You can login to the desktop application";
                            return Page();
                        }
                        else
                        {
                            string id = user.Id.ToString();
                            List<Claim> claims = new List<Claim>();

                            claims.Add(new Claim("id", id));
                            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                            HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                            

                            if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                            {
                                return Redirect(returnUrl);
                            }
                            else
                            {
                                return RedirectToPage("Home");
                            }
                        }
                    }
                    else
                    {
                        ViewData["Message"] = "Invalid credentials";
                        return Page();
                    }
                }
                catch (DataBaseException)
                {
                    ViewData["Error_message"] = "An error occured while logging in. Please, try again.";
                    return new RedirectToPageResult("Error");
                }
                catch (Exception)
                {
                    ViewData["Error_message"] = "An error occured while logging in. Please, try again.";
                    return new RedirectToPageResult("Error");
                }
            }
            else
            {
                ViewData["Message"] = "Please enter all data fields!";
                return Page();
            }

        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Home");
        }

    }

   
}

