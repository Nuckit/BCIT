using System.Data.Entity;
using DiplomaDataModel;

namespace OptionsWebSite.Models
{
    public class DiplomaOptionsContext : DbContext
    {
        public DiplomaOptionsContext() : base("DefaultConnection")
        {            
        }

        public DbSet<Choice> Choices { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<YearTerm> YearTerms { get; set; }
    }
}