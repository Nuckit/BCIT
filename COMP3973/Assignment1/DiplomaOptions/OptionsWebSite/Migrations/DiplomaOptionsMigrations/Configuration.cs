using DiplomaDataModel;

namespace OptionsWebSite.Migrations.DiplomaOptionsMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OptionsWebSite.Models.DiplomaOptionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\DiplomaOptionsMigrations";
        }

        protected override void Seed(OptionsWebSite.Models.DiplomaOptionsContext context)
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

            var yearTerm1 = new YearTerm
            {
                Year = 2015,
                Term = 10,
                IsDefault = false
            };
            var yearTerm2 = new YearTerm
            {
                Year = 2015,
                Term = 20,
                IsDefault = false
            };
            var yearTerm3 = new YearTerm
            {
                Year = 2015,
                Term = 30,
                IsDefault = false
            };
            var yearTerm4 = new YearTerm
            {
                Year = 2016,
                Term = 10,
                IsDefault = true
            };

            context.YearTerms.AddOrUpdate(y => y.YearTermId, yearTerm1, yearTerm2, yearTerm3, yearTerm4);
            context.SaveChanges();

            var option1 = new Option
            {
                Title = "Data Communications",
                IsActive = true
            };

            var option2 = new Option
            {
                Title = "Client Server",
                IsActive = true
            };

            var option3 = new Option
            {
                Title = "Digital Processing",
                IsActive = true
            };

            var option4 = new Option
            {
                Title = "Information Systems",
                IsActive = true
            };

            var option5 = new Option
            {
                Title = "Database",
                IsActive = false
            };

            var option6 = new Option
            {
                Title = "Web & Mobile",
                IsActive = true
            };

            var option7 = new Option
            {
                Title = "Tech Pro",
                IsActive = false
            };

            context.Options.AddOrUpdate(o => o.OptionId, option1, option2, option3, option4, option5, option6, option7);
            context.SaveChanges();
        }
    }
}
