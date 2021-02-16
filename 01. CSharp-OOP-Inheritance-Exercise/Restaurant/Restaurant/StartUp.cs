using System;

namespace Restaurant
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Beverage("Coffe", 2, 100);
            Coffee cofee = new Coffee("Nova Brasilia", 100);
            Console.WriteLine(cofee.Name);
            Console.WriteLine(cofee.Price);
            Console.WriteLine(cofee.Milliliters);
            Console.WriteLine(cofee.Caffeine);

            Cake cake = new Cake("Garash");
            Console.WriteLine(cake.Name);

            Console.WriteLine(cake.Calories);
            Console.WriteLine(cake.Grams);
            Console.WriteLine(cake.Price);

            Fish fish = new Fish("Salmon", 150);

            Console.WriteLine(fish.Name);
            Console.WriteLine(fish.Price);
            Console.WriteLine(fish.Grams);


        }
    }
}
