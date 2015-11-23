using System;
using System.Data.Entity.Migrations;
using DiplomaDataModel;

namespace OptionsWebSite.Migrations.DiplomaOptionsMigrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DiplomaOptionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\DiplomaOptionsMigrations";
        }

        protected override void Seed(DiplomaOptionsContext context)
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
                YearTermId = 1,
                Year = 2015,
                Term = 10,
                IsDefault = false
            };
            var yearTerm2 = new YearTerm
            {
                YearTermId = 2,
                Year = 2015,
                Term = 20,
                IsDefault = false
            };
            var yearTerm3 = new YearTerm
            {
                YearTermId = 3,
                Year = 2015,
                Term = 30,
                IsDefault = false
            };
            var yearTerm4 = new YearTerm
            {
                YearTermId = 4,
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

            context.Options.AddOrUpdate(o => o.Title, option1, option2, option3, option4, option5, option6, option7);
            context.SaveChanges();

            context.Choices.AddOrUpdate(c => c.ChoiceId, new Choice
            {
                ChoiceId = 1,
                FirstChoiceOptionId = 1,
                SecondChoiceOptionId = 2,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 4,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A000",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 2,
                FirstChoiceOptionId = 1,
                SecondChoiceOptionId = 2,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 4,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A001",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 3,
                FirstChoiceOptionId = 6,
                SecondChoiceOptionId = 5,
                ThirdChoiceOptionId = 1,
                FourthChoiceOptionId = 2,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A002",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 4,
                FirstChoiceOptionId = 3,
                SecondChoiceOptionId = 7,
                ThirdChoiceOptionId = 2,
                FourthChoiceOptionId = 5,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A003",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 5,
                FirstChoiceOptionId = 3,
                SecondChoiceOptionId = 4,
                ThirdChoiceOptionId = 5,
                FourthChoiceOptionId = 6,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A004",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 6,
                FirstChoiceOptionId = 1,
                SecondChoiceOptionId = 7,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 5,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A005",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 7,
                FirstChoiceOptionId = 7,
                SecondChoiceOptionId = 5,
                ThirdChoiceOptionId = 6,
                FourthChoiceOptionId = 4,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A006",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 8,
                FirstChoiceOptionId = 7,
                SecondChoiceOptionId = 6,
                ThirdChoiceOptionId = 5,
                FourthChoiceOptionId = 4,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A007",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 9,
                FirstChoiceOptionId = 1,
                SecondChoiceOptionId = 2,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 4,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A008",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 10,
                FirstChoiceOptionId = 4,
                SecondChoiceOptionId = 1,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 6,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A009",
                YearTermId = 3,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 11,
                FirstChoiceOptionId = 2,
                SecondChoiceOptionId = 1,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 6,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0010",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 12,
                FirstChoiceOptionId = 2,
                SecondChoiceOptionId = 1,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 6,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0011",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 13,
                FirstChoiceOptionId = 4,
                SecondChoiceOptionId = 3,
                ThirdChoiceOptionId = 2,
                FourthChoiceOptionId = 1,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0012",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 14,
                FirstChoiceOptionId = 5,
                SecondChoiceOptionId = 4,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 6,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0013",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 15,
                FirstChoiceOptionId = 2,
                SecondChoiceOptionId = 3,
                ThirdChoiceOptionId = 7,
                FourthChoiceOptionId = 6,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0014",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 16,
                FirstChoiceOptionId = 7,
                SecondChoiceOptionId = 4,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 6,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0015",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 17,
                FirstChoiceOptionId = 7,
                SecondChoiceOptionId = 1,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 2,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0016",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 18,
                FirstChoiceOptionId = 1,
                SecondChoiceOptionId = 5,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 6,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0017",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 19,
                FirstChoiceOptionId = 4,
                SecondChoiceOptionId = 6,
                ThirdChoiceOptionId = 7,
                FourthChoiceOptionId = 5,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0018",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            }, new Choice
            {
                ChoiceId = 20,
                FirstChoiceOptionId = 2,
                SecondChoiceOptionId = 1,
                ThirdChoiceOptionId = 3,
                FourthChoiceOptionId = 4,
                StudentFirstName = "Test",
                StudentLastName = "Student",
                StudentId = "A0019",
                YearTermId = 4,
                SelectionDate = DateTime.Now
            });
            context.SaveChanges();
        }
    }
}
