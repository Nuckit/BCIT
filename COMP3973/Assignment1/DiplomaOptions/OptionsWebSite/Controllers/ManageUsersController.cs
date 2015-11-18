using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DiplomaDataModel;
using OptionsWebSite.Models;
using WebGrease.Css.Extensions;

namespace OptionsWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ManageUsersController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        // GET: ManageUsers
        public ActionResult Index()
        {
            List<UserViewModel> models = new List<UserViewModel>();
            context.Users.ForEach(user => models.Add(new UserViewModel
            {
                UserName = user.UserName,
                LockoutEnabled = user.LockoutEnabled                
            }));
            return View(models);
        }

        public ActionResult Edit(string userName)
        {
            if (userName == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ApplicationUser applicationUser = context.Users.FirstOrDefault(u => u.UserName == userName);
            if (applicationUser == null)
            {
                return new HttpNotFoundResult();
            }
            UserViewModel model = new UserViewModel
            {
                UserName = applicationUser.UserName,
                LockoutEnabled = applicationUser.LockoutEnabled
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = context.Users.FirstOrDefault(u => u.UserName == user.UserName);
                if (applicationUser == null)
                {
                    return new HttpNotFoundResult();
                }
                applicationUser.LockoutEnabled = user.LockoutEnabled;
                applicationUser.LockoutEndDateUtc = user.LockoutEnabled ? DateTime.MaxValue : (DateTime?) null;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}