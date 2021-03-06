﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OA.Web.Models;

namespace OA.Web.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public Account account { get; set; }
        private DatabaseContext db;
        public SignUpModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            account = new Account();
        }
        public IActionResult OnPost()
        {
            account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            db.Accounts.Add(account);
            db.SaveChanges();
            return RedirectToPage("login");
        }
    }
}