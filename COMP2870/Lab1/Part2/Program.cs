using System;
using System.Collections.Generic;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                Make = "Ford",
                Model = "Mustang"
            };

            Car car2 = new Car()
            {
                Make = "Mazda",
                Model = "Speed"
            };

            Goose goose1 = new Goose()
            {
                Name = "Barney"
            };

            Goose goose2 = new Goose()
            {
                Name = "Ducky"
            };

            List<IHonkable> honkables = new List<IHonkable>()
            {
                car1,
                car2,
                goose1,
                goose2
            };

            foreach (IHonkable honkable in honkables)
            {
                Console.WriteLine(honkable);
                honkable.Honk();                
            }

            Console.ReadKey();
        }
    }
}
