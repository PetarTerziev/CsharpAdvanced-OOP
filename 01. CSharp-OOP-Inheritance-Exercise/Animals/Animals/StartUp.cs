using System;
using System.Collections.Generic;
using System.IO;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Beast!")
                {
                    break;
                }

                string[] animalInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    animals.Add(CreateAnimal(input, animalInfo));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        public static Animal CreateAnimal(string type, string [] animalInfo) 
        {
            string name = animalInfo[0];
            int age = int.Parse(animalInfo[1]);
            string gender = animalInfo[2];

            switch (type)
            {
                case "Dog":
                    return new Dog(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);              
                case "Cat":
                    return new Cat(name, age, gender);
                case "Kitten":
                    return new Kitten(name, age);
                case "Tomcat":
                    return new Tomcat(name, age);
                default:
                    return null;
            }
        }
    }
}
