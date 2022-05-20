using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryTournaments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TournamentsWebApp.Pages
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public User Login { get; set; }
        public void OnGet()
        {
        }
    }
}
