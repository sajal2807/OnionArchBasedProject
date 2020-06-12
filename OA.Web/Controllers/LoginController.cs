using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using OA.Repo;
using OA.Web.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using OA.Data;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace OA.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationContext context;
        private DbSet<User> entities;
        public LoginController(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<User>();
        }
        
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(UserViewModel userModel)
        {
            var userDetails = entities.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
            if(userDetails == null)
            {
                userModel.LoginErrorMessage = "Username or Password is incorrect.";
                return View("login", userModel);
            }
            
                HttpContext.Session.SetString("Username", userDetails.UserName);
            HttpContext.Session.SetString("Password", userDetails.Password);
            return RedirectToAction("Index", "Home");
            
        }
    }
}