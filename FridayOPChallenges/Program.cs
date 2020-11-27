using System;

namespace FridayOPChallenges
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;

            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            } 

            public double Hunger
            {
                get { return hunger; }
            }

            public void Sleep()
            {
                Console.WriteLine("I sleep like a boss!");
                hunger += 0.2;
            }

            public void Meow()
            {
                Console.WriteLine("Meow meow im a king");
            }

            public void ShowCatDetails()
            {
                Console.WriteLine($"Name: {name};\n Color: {color}; \n Hunger: {hunger}; ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cat newCat = new Cat("Juku", "Brown");

            newCat.ShowCatDetails();

            newCat.Meow();
            

        }
    }
}
