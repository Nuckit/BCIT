using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DiplomaDataModel;
using Microsoft.AspNet.Identity;
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
            return View(new RoleViewModel { RoleName = roleName });
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

        public ActionResult AddUser(string roleName)
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

            var usersNotInRole = context.Users.Where(user => !user.Roles.Any(r => r.RoleId == role.Id));

            ViewBag.UserName = new SelectList(usersNotInRole, "UserName", "UserName");
            return View(new RoleViewModel { RoleName = roleName });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUser(RoleViewModel role)
        {
            IdentityRole identityRole = context.Roles.FirstOrDefault(r => r.Name == role.RoleName);

            if (identityRole == null)
            {
                ViewBag.ErrorMessage = string.Format("Role '{0}' no longer exists", role.RoleName);
                return View(new RoleViewModel { RoleName = role.RoleName });
            }

            if (ModelState.IsValid)
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                IdentityUser user = context.Users.FirstOrDefault(u => u.UserName == role.UserName);

                if (user == null)
                {
                    ViewBag.ErrorMessage = string.Format("User '{0}' no longer exists", role.UserName);
                }
                else if (userManager.IsInRole(user.Id, role.RoleName))
                {
                    ViewBag.ErrorMessage = string.Format("Role '{0}' already has user '{1}'", role.RoleName, role.UserName);
                }
                else
                {
                    IdentityResult result = userManager.AddToRole(user.Id, role.RoleName);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                    ViewBag.ErrorMessage = string.Format("Could not add user '{0}' to role '{1}'", role.UserName, role.RoleName);
                }
            }

            var usersNotInRole = context.Users.Where(user => user.Roles.All(r => r.RoleId != identityRole.Id));

            ViewBag.UserName = new SelectList(usersNotInRole, "UserName", "UserName");
            return View(new RoleViewModel { RoleName = role.RoleName });
        }

        public ActionResult RemoveUser(string roleName)
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

            var usersInRole = context.Users.Where(user => user.Roles.Any(r => r.RoleId == role.Id));

            ViewBag.UserName = new SelectList(usersInRole, "UserName", "UserName");
            return View(new RoleViewModel { RoleName = roleName });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveUser(RoleViewModel role)
        {
            IdentityRole identityRole = context.Roles.FirstOrDefault(r => r.Name == role.RoleName);

            if (identityRole == null)
            {
                ViewBag.ErrorMessage = string.Format("Role '{0}' no longer exists", role.RoleName);
                return View(new RoleViewModel { RoleName = role.RoleName });
            }

            if (ModelState.IsValid)
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                IdentityUser user = context.Users.FirstOrDefault(u => u.UserName == role.UserName);

                if (user == null)
                {
                    ViewBag.ErrorMessage = string.Format("User '{0}' no longer exists", role.UserName);
                }
                else if (!userManager.IsInRole(user.Id, role.RoleName))
                {
                    ViewBag.ErrorMessage = string.Format("User '{0}' is already not in role '{1}'", role.UserName, role.RoleName);
                }
                else
                {
                    IdentityResult result = userManager.RemoveFromRole(user.Id, role.RoleName);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                    ViewBag.ErrorMessage = string.Format("Could not remove user '{0}' from role '{1}'", role.UserName, role.RoleName);
                }
            }

            var usersNotInRole = context.Users.Where(user => user.Roles.All(r => r.RoleId != identityRole.Id));

            ViewBag.UserName = new SelectList(usersNotInRole, "UserName", "UserName");
            return View(new RoleViewModel { RoleName = role.RoleName });
        }
    }
}