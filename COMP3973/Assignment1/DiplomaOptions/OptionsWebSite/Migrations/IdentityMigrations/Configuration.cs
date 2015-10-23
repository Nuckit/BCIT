using System.Data.Entity.Migrations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OptionsWebSite.Models;

namespace OptionsWebSite.Migrations.IdentityMigrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\IdentityMigrations";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            const string adminRoleName = "Admin";
            if (!roleManager.RoleExists(adminRoleName))
            {
                roleManager.Create(new IdentityRole(adminRoleName));
            }

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            const string defaultAdminUserName = "A00111111";
            const string defaultAdminEmail = "a@a.a";
            const string defaultAdminPassword = "P@$$w0rd";

            const string defaultStudentUserName = "A00222222";
            const string defaultStudentEmail = "s@s.s";
            const string defaultStudentPassword = "P@$$w0rd";

            if (userManager.FindByName(defaultAdminUserName) == null)
            {
                var user = new ApplicationUser
                {
                    UserName = defaultAdminUserName,
                    Email = defaultAdminEmail,                    
                };

                IdentityResult result = userManager.Create(user, defaultAdminPassword);
                if (result.Succeeded)
                {
                    userManager.AddToRole(userManager.FindByName(defaultAdminUserName).Id, adminRoleName);
                }
            }

            if (userManager.FindByName(defaultStudentUserName) == null)
            {
                var user = new ApplicationUser
                {
                    UserName = defaultStudentUserName,
                    Email = defaultStudentEmail,
                };

                userManager.Create(user, defaultStudentPassword);
            }
        }
    }
}
