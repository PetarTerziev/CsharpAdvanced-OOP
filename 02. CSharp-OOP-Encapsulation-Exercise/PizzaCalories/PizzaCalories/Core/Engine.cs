using System;

using PizzaCalories.Models;

namespace PizzaCalories.Core
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run() 
        {
            string[] pizzaInput = Console.ReadLine().Split();
            string[] dough = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Pizza pizza = new Pizza(pizzaInput[1], new Dough(dough[1], dough[2], int.Parse(dough[3])));
     
                while (true)
                {
                    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    if (input[0] == "END")
                    {
                        break;
                    }

                    pizza.AddTopping(new Topping(input[1], int.Parse(input[2])));
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
