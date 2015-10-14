using System.Collections.Generic;
using Week5Lib;

namespace Week5.Migrations.LocationMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Week5.DataContext.LocationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\LocationMigrations";
        }

        protected override void Seed(Week5.DataContext.LocationContext context)
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
            var province1 = new Province
            {
                Code = "BC",
                Name = "British Columbia"
            };

            var province2 = new Province
            {
                Code = "AB",
                Name = "Alberta"
            };
            var province3 = new Province
            {
                Code = "NS",
                Name = "Nova Scotia"
            };

            context.Provinces.AddOrUpdate(p => p.Code,
                province1,
                province2,
                province3);

            context.SaveChanges();
            var city1 = new City
            {
                Name = "Vancouver",
                Population = 100000,
                Province = province1
            };

            var city2 = new City
            {                
                Name = "Surrey",
                Population = 5000,
                Province = province1
            };

            var city3 = new City
            {                
                Name = "Calgary",
                Population = 2000,
                Province = province2
            };

            var city4 = new City
            {                
                Name = "testtest",
                Population = 2000,
                Province = province3
            };

            context.Cities.AddOrUpdate(c => c.CityId,
                city1,
                city2,
                city3, 
                city4);

            context.SaveChanges();         
        }
    }
}
