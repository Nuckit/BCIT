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
            var city1 = new City
            {
                CityId = 1,
                Name = "Vancouver",
                Population = 100000
            };

            var city2 = new City
            {
                CityId = 2,
                Name = "Surrey",
                Population = 5000
            };

            var city3 = new City
            {
                CityId = 3,
                Name = "Calgary",
                Population = 2000
            };

            var city4 = new City
            {
                CityId = 3,
                Name = "testtest",
                Population = 2000
            };

            context.Cities.AddOrUpdate(c => c.CityId,
                city1,
                city2,
                city3, 
                city4);

            context.SaveChanges();

            context.Provinces.AddOrUpdate(p => p.Code,
                new Province
                {
                    Code = "BC",
                    Name = "British Columbia",
                    Cities = new List<City>
                    {
                        city1,
                        city2,
                    }
                },
                new Province
                {
                    Code = "AB",
                    Name = "Alberta",
                    Cities = new List<City>
                    {
                        city3,                        
                    }
                },
                new Province
                {
                    Code = "NS",
                    Name = "Nova Scotia",
                    Cities = new List<City>
                    {
                        city4,                        
                    }
                });
        }
    }
}
