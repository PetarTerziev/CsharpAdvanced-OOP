using System;

namespace PizzaCalories.Models
{
    public class Topping
    {
        private const int defaultCaloriesPerGram = 2;
        private string type;
        private int weight;

        internal Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        private string Type
        {
            get => type;

            set
            {
                if (!isCorrectType(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }
        public int Weight
        {
            get => weight;

            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double CaloriesPerGram => defaultCaloriesPerGram * Modifier(Type);

        private bool isCorrectType(string type)
        {
            switch (type.ToLower())
            {
                case "meat":
                case "veggies":
                case "cheese":
                case "sauce":
                    return true;
                default:
                    return false;

            }
        }

        private double Modifier(string type)
        {
            switch (type.ToLower())
            {
                case "meat":
                    return 1.2;
                case "veggies":
                    return 0.8;
                case "cheese":
                    return 1.1;
                case "sauce":
                    return 0.9;
                default:
                    return 1.0;
            }
        }
    }
}
