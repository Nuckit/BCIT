using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DiplomaDataModel;
using Microsoft.AspNet.Identity.EntityFramework;
using OptionsWebSite.Models;
using WebGrease.Css.Extensions;

namespace OptionsWebSite.Controllers
{
    public class ManageRolesController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        // GET: ManageRoles
        public ActionResult Index()
        {
            List<RoleViewModel> models = new List<RoleViewModel>();
            context.Roles.ForEach(role => models.Add(new RoleViewModel
            {
                RoleName = role.Name
            }));
            return View(models);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoleViewModel role)
        {
            if (ModelState.IsValid && IsRoleValid(role))
            {
                context.Roles.Add(new IdentityRole(role.RoleName));
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(role);
        }

        private bool IsRoleValid(RoleViewModel role)
        {
            if (context.Roles.Any(r => r.Name == role.RoleName))
            {
                ViewBag.ErrorMessage = string.Format("Role with name '{0}' exists already", role.RoleName);
                return false;
            }
            return true;
        }

        public ActionResult Delete(string roleName)
        {
            if (roleName == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdentityRole role = context.Roles.FirstOrDefault(r => r.Name == roleName);
            if (role == null)
            {
                return new HttpNotFoundResult();
            }
            return View(new RoleViewModel{RoleName = role.Name});
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string roleName)
        {
            IdentityRole role = context.Roles.First(r => r.Name == roleName);
            context.Roles.Remove(role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}