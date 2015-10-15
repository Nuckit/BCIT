using Week5Lib;

namespace Week5Home.Migrations.LocationsMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Week5Home.DataContext.LocationsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\LocationsMigrations";
        }

        protected override void Seed(Week5Home.DataContext.LocationsContext context)
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
                ProvinceCode = "BC",
                ProvinceName = "British Columbia"
            };

            var province2 = new Province
            {
                ProvinceCode = "AB",
                ProvinceName = "Alberta"
            };
            var province3 = new Province
            {
                ProvinceCode = "NS",
                ProvinceName = "Nova Scotia"
            };

            context.Provinces.AddOrUpdate(p => p.ProvinceCode,
                province1,
                province2,
                province3);

            context.SaveChanges();
            var city1 = new City
            {
                CityName = "Vancouver",
                Population = 100000,
                Province = province1
            };

            var city2 = new City
            {
                CityName = "Surrey",
                Population = 5000,
                Province = province1
            };

            var city3 = new City
            {
                CityName = "Calgary",
                Population = 2000,
                Province = province2
            };

            var city4 = new City
            {
                CityName = "testtest",
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
