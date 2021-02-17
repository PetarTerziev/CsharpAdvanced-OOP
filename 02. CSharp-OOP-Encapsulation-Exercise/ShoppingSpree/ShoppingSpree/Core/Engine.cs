using System;
using System.Collections.Generic;
using System.Linq;

using ShoppingSpree.Models;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run() 
        {
            List<Tuple<string, decimal>> personsInfo = ReadData();
            List<Person> persons = new List<Person>();

            foreach (var pers in personsInfo)
            {
                try
                {
                    persons.Add(new Person(pers.Item1, pers.Item2));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            List<Tuple<string, decimal>> productsInfo = ReadData();
            List<Product> products = new List<Product>();

            foreach (var product in productsInfo)
            {
                try
                {
                    products.Add(new Product(product.Item1, product.Item2));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            while (true)
            {
                string[] buyOrder = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (buyOrder[0] == "END")
                {
                    break;
                }

                Person buyer = persons.FirstOrDefault(p => p.Name == buyOrder[0]);
                Product product = products.FirstOrDefault(p => p.Name == buyOrder[1]);

                if (buyer.CanBuyProduct(product))
                {
                    Console.WriteLine($"{buyer.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{buyer.Name} can't afford {product.Name}");
                }
            }

            foreach (var pers in persons)
            {
                Console.WriteLine(pers);
            }

        }

        public static List<Tuple<string, decimal>> ReadData()
        {
            string[] input = Console.ReadLine().Split(";",
                StringSplitOptions.RemoveEmptyEntries);
            List<Tuple<string, decimal>> result = new List<Tuple<string, decimal>>();

            foreach (var position in input)
            {
                string[] splited = position.Split("=");
                result.Add(new Tuple<string, decimal>(splited[0], decimal.Parse(splited[1])));
            }

            return result;
        }

    }
}
