using System;
using System.Collections.Generic;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("John", "Doe")
            {
                Age = 25,
                Salary = new decimal(50000.00)
            };

            Employee employee2 = new Employee("Bill", "Gates")
            {
                Age = 50,
                Salary = new decimal(1000000)
            };

            Customer customer1 = new Customer("Connor", "McDavid")
            {
                PhoneNumber = "1-800-HOCKEY"
            };

            Customer customer2 = new Customer("Dexter", "Morgan")
            {
                PhoneNumber = "123-4567"
            };

            List<Person> people = new List<Person>()
            {
                employee1, 
                employee2,
                customer1,
                customer2
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
