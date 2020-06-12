using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using OA.Data;
using OA.Services;
using OA.Web.Models;

namespace OA.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IUserProfileService userProfileService;

        public UserController(IUserService userService, IUserProfileService userProfileService)
        {
            this.userService = userService;
            this.userProfileService = userProfileService;
        }
        public IActionResult Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            this.userService.GetUsers().ToList().ForEach(u =>
            {
                UserProfile userProfile = this.userProfileService.GetUserProfile(u.Id);

                UserViewModel user = new UserViewModel
                {
                    Id = u.Id,
                    Name = $"{userProfile.FirstName} {userProfile.LastName}",
                    Email = u.Email,
                    Address = userProfile.Address
                };
                model.Add(user);
            });
            return View(model);
        }
        [HttpGet]
        public ActionResult AddorEdit()
        {
            UserViewModel userModal = new UserViewModel();
            return View(userModal);
        }

        [HttpPost]
        public ActionResult AddorEdit(UserViewModel userModal)
        {
            User userentity = new User
            {
                UserName = userModal.UserName,
                Email = userModal.Email,
                Password = userModal.Password,
                AddedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                UserProfile = new UserProfile
                {
                    FirstName = userModal.FirstName,
                    LastName = userModal.LastName,
                    Address = userModal.Address,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                }
            };
            this.userService.InsertUser(userentity);
            ModelState.Clear();
          /*  if (userentity.Id > 0)
            {
                return RedirectToAction("Index");
            }*/
            ViewBag.SuccessMessage = "Registration Successful";
            return View(userModal);
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("~/Login/login");
        }

        public ActionResult tabulator()
        {
            return View();
        }
        public ActionResult highcharts()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult EditUser(int id)
        {
            UserViewModel model = new UserViewModel();
            if(id != 0)
            {
                User userEntity = this.userService.GetUser(id);
                UserProfile userProfileEntity = this.userProfileService.GetUserProfile(id);
                model.FirstName = userProfileEntity.FirstName;
                model.LastName = userProfileEntity.LastName;
                model.Address = userProfileEntity.Address;
                model.Email = userEntity.Email;
            }
            return View("EditUser", model);
        }

        [HttpPost]
        public ActionResult EditUser(UserViewModel model)
        {
            User userEntity = this.userService.GetUser(model.Id);
            userEntity.Email = model.Email;
            userEntity.ModifiedDate = DateTime.Now;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            UserProfile userProfileEntity = this.userProfileService.GetUserProfile(model.Id);
            userProfileEntity.FirstName = model.FirstName;
            userProfileEntity.LastName = model.LastName;
            userProfileEntity.Address = model.Address;
            userProfileEntity.ModifiedDate = DateTime.Now;
            userProfileEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            userEntity.UserProfile = userProfileEntity;
            this.userService.UpdateUser(userEntity);

            if(userEntity.Id > 0)
            {
                return RedirectToAction("Index");
            }
            return View("EditUser", model);
        }

        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            UserViewModel model = new UserViewModel();
            if (id != 0)
            {
                UserProfile userProfileEntity = this.userProfileService.GetUserProfile(id);
                model.FirstName = userProfileEntity.FirstName;
                model.LastName = userProfileEntity.LastName;
            }
            return View("DeleteUser", model);
        }

        [HttpPost]
        public ActionResult DeleteUser(long id)
        {
            this.userService.DeleteUser(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DetailsUser(int id)
        {
            UserViewModel model = new UserViewModel();
            if (id != 0)
            {
                User userEntity = this.userService.GetUser(id);
                UserProfile userProfileEntity = this.userProfileService.GetUserProfile(id);
                model.Id = userEntity.Id;
                model.FirstName = userProfileEntity.FirstName;
                model.LastName = userProfileEntity.LastName;
                model.Address = userProfileEntity.Address;
                model.Email = userEntity.Email;
                model.UserName = userEntity.UserName;
            }
            return View(model);
        }
        public ActionResult ColumnBasic()
        {
            List<double> tokyoValues = new List<double> { 49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 };
            List<double> nyValues = new List<double> { 83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0, 104.3, 91.2, 83.5, 106.6, 92.3 };
            List<double> berlinValues = new List<double> { 42.4, 33.2, 34.5, 39.7, 52.6, 75.5, 57.4, 60.4, 47.6, 39.1, 46.8, 51.1 };
            List<double> londonValues = new List<double> { 48.9, 38.8, 39.3, 41.4, 47.0, 48.3, 59.0, 59.6, 52.4, 65.2, 59.3, 51.2 };
            List<ColumnSeriesData> tokyoData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> nyData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> berlinData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> londonData = new List<ColumnSeriesData>();

            tokyoValues.ForEach(p => tokyoData.Add(new ColumnSeriesData
            {
                Y = p
            }));
            nyValues.ForEach(p => nyData.Add(new ColumnSeriesData
            {
                Y = p
            }));
            berlinValues.ForEach(p => berlinData.Add(new ColumnSeriesData
            {
                Y = p
            }));
            londonValues.ForEach(p => londonData.Add(new ColumnSeriesData
            {
                Y = p
            }));

            ViewData["tokyoData"] = tokyoData;
            ViewData["nyData"] = nyData;
            ViewData["berlinData"] = berlinData;
            ViewData["londonData"] = londonData;

            return View();
        }

    }
}