using System.Data.Entity;
using Week5Lib;

namespace Week5Home.DataContext
{
    public class LocationsContext : DbContext
    {
        public LocationsContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<LocationsContext>());
        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}