using System;

namespace Part2
{
    public class Goose : IHonkable
    {
        public string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("I'm Flying!");
        }

        public void Eat()
        {
            Console.WriteLine("I'm Eating!");
        }

        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public override string ToString()
        {
            return String.Format("Name: {0}", Name);
        }
    }
}