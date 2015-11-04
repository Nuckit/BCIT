using StudentAPI.Models;

namespace StudentAPI.Migrations.StudentsContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAPI.Models.StudentsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\StudentsContext";
        }

        protected override void Seed(StudentAPI.Models.StudentsContext context)
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

            var student1 = new Student
            {
                StudentId = "A00111111",
                FirstName = "John",
                LastName = "Archer",
                Program = "CIT"
            };
            var student2 = new Student
            {
                StudentId = "A00222222",
                FirstName = "Jane",
                LastName = "Baker",
                Program = "CST"
            };
            var student3 = new Student
            {
                StudentId = "A00333333",
                FirstName = "Bill",
                LastName = "Carter",
                Program = "BTECH"
            };
            var student4 = new Student
            {
                StudentId = "A00444444",
                FirstName = "Judy",
                LastName = "Fisher",
                Program = "Nursing"
            };

            context.Students.AddOrUpdate(s => s.StudentId, student1,student2, student3, student4);
            context.SaveChanges();
        }
    }
}
