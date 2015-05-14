using System;

namespace Part2
{
    public class Car : IHonkable
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vroom!");
        }

        public void Break()
        {
            Console.WriteLine("Skreetch!");
        }

        public void Honk()
        {
            Console.WriteLine("Honk Honk, Get out of my way!");
        }

        public override string ToString()
        {
            return String.Format("Make: {0}, Model: {1}", Make, Model);
        }
    }
}