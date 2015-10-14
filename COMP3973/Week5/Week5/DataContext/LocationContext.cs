using System.Data.Entity;
using Week5Lib;

namespace Week5.DataContext
{
    public class LocationContext : DbContext
    {
        public LocationContext() : base("DefaultConnection")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<LocationContext>());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}