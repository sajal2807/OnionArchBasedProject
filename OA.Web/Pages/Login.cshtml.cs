using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OA.Web.Models;

namespace OA.Web.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Account account { get; set; }
        public void OnGet()
        {
            account = new Account();
        }
    }
}