using System.Data.Entity;

namespace DiplomaDataModel
{
    public class DiplomaOptionsContext : DbContext
    {
        public DiplomaOptionsContext()
            : base("DiplomaOptionsConnection")
        {            
        }

        public DbSet<Choice> Choices { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<YearTerm> YearTerms { get; set; }
    }
}